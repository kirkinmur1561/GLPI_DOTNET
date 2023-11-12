using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using CommonObj.Base;
using CommonObj.Client;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public class Document:Dashboard<Document>
    {
        private const string UPLOADMANIFEST = "uploadManifest";
        private const string FILENAMEZERO = "filename[0]";
        private const string ALT = "?alt=media";
        
        [JsonProperty(BaseJsonProperty.FILENAME)]
        public string FileName { get; set; }
        
        [JsonProperty(BaseJsonProperty.FILEPATH)]
        public string FilePath { get; set; }
        
        [JsonProperty(BaseJsonProperty.DOCUMENTCATEGORIES_ID)]
        public long? IdDocumentCategories { get; set; }
        
        [JsonProperty(BaseJsonProperty.MIME)]
        public string Mime { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINK)]
        public string Link { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETS_ID)]
        public long? IdTickets { get; set; }
        
        [JsonProperty(BaseJsonProperty.SHA1SUM)]
        public string Sha1 { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_BLACKLISTED)]
        public bool? IsBlockListed { get; set; }
        
        [JsonProperty(BaseJsonProperty.TAG)]
        public string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="idDocument"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static Task<Stream> Download(IClient clt, long idDocument, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault(BaseResource.MIMO_APPLICATION_OCTET_STREAM);

            var res =  clt.http.GetAsync(
                string.Join(string.Empty, nameof(Document), BaseResource.SEPARATOR_URI, idDocument, ALT),
                cancel).Result;
            if (!res.IsSuccessStatusCode)
                throw new ExceptionGLPI_ErrorCommon(res.Content.ReadAsStringAsync(cancel).Result, res.StatusCode);
            return res.Content.ReadAsStreamAsync(cancel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="manifestFile"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static async Task<ManifestFileUpload?> Upload(IClient clt, ManifestFile manifestFile, CancellationToken cancel = default)

        {
            clt.SetHeaderDefault();

            MultipartFormDataContent form = new MultipartFormDataContent();
            string[] filesname = {manifestFile.FileName};
            StringContent stringContent =
                new StringContent(JsonConvert.SerializeObject(new
                    {
                        input = new
                        {
                            name = manifestFile.DocumentName,
                            _filename = filesname
                        }
                    }),
                    Encoding.UTF8,
                    MediaTypeNames.Application.Json);

            StreamContent streamContent = new StreamContent(manifestFile.GetStream());
            streamContent.Headers.ContentType =
                new MediaTypeWithQualityHeaderValue(BaseResource.MIMO_MULTIPART_FORM_DATA);

            form.Add(streamContent, FILENAMEZERO, filesname[0]);
            form.Add(stringContent, UPLOADMANIFEST);
            HttpResponseMessage response = await clt.http.PostAsync(nameof(Document), form, cancel);
            string result = await response.Content.ReadAsStringAsync(cancel);
            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<ManifestFileUpload>(result)
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }
    }
}

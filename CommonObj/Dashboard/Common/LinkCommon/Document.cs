using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Common.LinkCommon
{
    public class Document : Dashboard<Document>
    {
        private const string DOCUMENT = nameof(Document);
        private const string UP_LOAD_MANIFEST = "uploadManifest";
        private const string FILE_NAME_0 = "filename[0]";

        /// <summary>
        /// Ответ на загрузку
        /// </summary>
        [JsonProperty(BaseJsonProperty.MESSAGE)]
        public string Msg { get; set; }

        /// <summary>
        /// Ответ на загрузку
        /// </summary>
        // [JsonProperty("upload_result")]
        // public UploadResult UploadResult { get; set; }
        //
        // [JsonProperty("filename")]
        // public string FileName { get; set; }

        [JsonProperty(BaseJsonProperty.FILEPATH)]
        public string FilePath { get; set; }

        [JsonProperty(BaseJsonProperty.DOCUMENTCATEGORIES_ID)]
        public long IdDocumentCategory { get; set; }

        [JsonProperty(BaseJsonProperty.MIME)]
        public string MIME { get; set; }

        [JsonProperty(BaseJsonProperty.LINK)] 
        public string Link { get; set; }

        [JsonProperty(BaseJsonProperty.TICKETS_ID)] 
        public long IdTicket { get; set; }

        [JsonProperty(BaseJsonProperty.SHA1SUM)] 
        public string Sha1 { get; set; }

        [JsonProperty(BaseJsonProperty.IS_BLACKLISTED)] 
        public bool IsBlackList { get; set; }

        [JsonProperty(BaseJsonProperty.TAG)] 
        public string Tag { get; set; }

        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="manifestFiles"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionCheck"></exception>
        /// <exception cref="Exception"></exception>
        /// <exception cref="TimeoutException"></exception>
        // public static async Task<Document> UploadDoc(IGlpiClient clt,
        //     ManifestFile manifestFiles,
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //  
        //     client.Client.DefaultRequestHeaders.Clear();
        //     client.SetHeaderDefault(BaseData.HEADER_SESSION_TOKEN, client.Init.SessionToken);
        //     client.SetHeaderDefault(BaseData.HEADER_APP_TOKEN, client.Init.SessionToken);
        //
        //     HttpResponseMessage response = null;
        //
        //     MultipartFormDataContent form = new MultipartFormDataContent();
        //
        //
        //     string[] filesname = { manifestFiles.FileName };
        //
        //     StringContent stringContent =
        //         new StringContent(JsonConvert.SerializeObject(new
        //             {
        //                 input = new
        //                 {
        //                     name = manifestFiles.DocumentName,
        //                     _filename = filesname
        //                 }
        //             }),
        //             Encoding.UTF8,
        //             BaseData.MIMO_APPLICATION_JSON);
        //
        //
        //     StreamContent sc = new StreamContent(manifestFiles.GetStream());
        //     sc.Headers.ContentType = new MediaTypeWithQualityHeaderValue(BaseData.MIMO_MULTIPART_FORM_DATA);
        //
        //
        //     form.Add(sc, FILE_NAME_0, filesname[0]);
        //     
        //
        //     form.Add(stringContent,UP_LOAD_MANIFEST);
        //
        //     ClientRequest req = new ClientRequest(async () =>
        //             await client.Client.PostAsync(DOCUMENT,form, cancel),
        //         r => response = r.Response);
        //     
        //     clt.QueueRequest.Enqueue(req);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //         {
        //             Disable(manifestFiles, stringContent, sc, form);
        //             cancel.ThrowIfCancellationRequested();
        //         }
        //
        //         if (timeSpan < DateTime.Now)
        //         {
        //             Disable(manifestFiles, stringContent, sc, form);
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //         }
        //     }
        //
        //     Disable(manifestFiles, stringContent, sc, form);
        //     return response.IsSuccessStatusCode
        //         ? JsonConvert.DeserializeObject<Document>( await response.Content.ReadAsStringAsync(cancel))
        //         : throw new System.Exception(
        //             $"Status code:{response.StatusCode} " +
        //             $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        // }

        private static void Disable(ManifestFile mf, StringContent stringContent, StreamContent sc,
            MultipartFormDataContent form)
        {
            mf.Dispose();
            sc?.Dispose();
            stringContent?.Dispose();
            form?.Dispose();
        }

        //     private static async Task<HttpResponseMessage> CommonDLD(IGlpiClient clt,
        //         long id,
        //         bool isOctetStream,
        //         CancellationToken cancel = default)
        //     {
        //         if (clt.Checker())      throw new ExceptionCheck(clt);
        //         if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");            
        //         
        //         IGlpiClient client = (IGlpiClient)clt.Clone();
        //         if (isOctetStream) client.SetHeaderDefault(BaseData.MIMO_APPLICATION_OCTET_STREAM);
        //         else client.SetHeaderDefault();
        //     
        //         HttpResponseMessage response = null;
        //
        //         HttpRequestMessage hrm = new(HttpMethod.Get,
        //             string.Join("/", client.Client.BaseAddress!.ToString(), DOCUMENT,id));
        //
        //         ClientRequest req = new ClientRequest(async () => await client.Client.SendAsync(hrm, cancel),
        //             r => response = r.Response);
        //         clt.QueueRequest.Enqueue(req);
        //
        //         var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //         
        //         while (response == null)
        //         {
        //             if (cancel.IsCancellationRequested)
        //                 cancel.ThrowIfCancellationRequested();
        //             
        //             if (timeSpan < DateTime.Now) 
        //                 throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //         }
        //
        //         return response;
        //     }
        //
        //     public static async Task<Document> DownloadDocumentMeta(IGlpiClient clt,
        //         long id,
        //         CancellationToken cancel = default)
        //     {
        //         HttpResponseMessage response = await CommonDLD(clt, id, false, cancel);
        //
        //         return response.IsSuccessStatusCode
        //             ? JsonConvert.DeserializeObject<Document>(await response.Content.ReadAsStringAsync(cancel))
        //             : throw new System.Exception(
        //                 $"Status code:{response.StatusCode} " +
        //                 $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        //     }
        //
        //     public static async Task<Stream> DownloadDocumentMedia(IGlpiClient clt,
        //         long id,
        //         CancellationToken cancel = default)
        //     {
        //         HttpResponseMessage response = await CommonDLD(clt, id, true, cancel);
        //         return response.IsSuccessStatusCode
        //             ? await response.Content.ReadAsStreamAsync(cancel)
        //             : throw new System.Exception(
        //                 $"Status code:{response.StatusCode} " +
        //                 $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        //     }
        // }

        public class UploadResult
        {
            [JsonProperty(BaseJsonProperty.FILENAME)] 
            public List<FileName> FileNames { get; set; }
        }

        public class FileName
        {
            [JsonProperty(BaseJsonProperty.NAME)] 
            public string Name { get; set; }

            [JsonProperty(BaseJsonProperty.SIZE)] 
            public ulong Size { get; set; }

            [JsonProperty(BaseJsonProperty.TYPE)] 
            public string MimeType { get; set; }

            [JsonProperty(BaseJsonProperty.URL)] 
            public string LoadAddress { get; set; }

            [JsonProperty(BaseJsonProperty.DELETEURL)] 
            public string DeleteAddress { get; set; }

            [JsonProperty(BaseJsonProperty.DELETETYPE)] 
            public string DeleteType { get; set; }

            [JsonProperty(BaseJsonProperty.PREFIX)] 
            public string Prefix { get; set; }

            [JsonProperty(BaseJsonProperty.DISPLAY)] 
            public string DisplayName { get; set; }

            [JsonProperty(BaseJsonProperty.FILESIZE)] 
            public string DisplaySize { get; set; }

            [JsonProperty(BaseJsonProperty.ID)] 
            public string DocumentId { get; set; }
        }

        public class ManifestFile : IDisposable
        {
            public readonly string DocumentName;
            public readonly string FileName;
            public readonly string Path;
            private Stream _stream;

            private ManifestFile(string path)
            {
                if (string.IsNullOrEmpty(path)) return;
                Path = path;
                FileName = new FileInfo(path).Name;
            }

            public ManifestFile(string path, string documentName) :
                this(path) =>
                DocumentName = documentName;


            public ManifestFile(Stream stream, string fileName, string documentName) :
                this(string.Empty, documentName)
            {
                FileName = fileName;
                _stream = stream;
            }

            public Stream GetStream()
            {
                if (string.IsNullOrEmpty(Path)) return _stream;
                _stream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                return _stream;
            }


            public void Dispose() =>
                _stream?.Dispose();

        }
    }
}
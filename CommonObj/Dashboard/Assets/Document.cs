using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public class Document:Dashboard<Document>
    {
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
        /// <param name="glpiClient"></param>
        /// <param name="cancel"></param>
        /// <exception cref="ExceptionCheck"></exception>
        /// <exception cref="Exception"></exception>
        //[Obsolete("No correct method!!!")]
        // public async Task Download(IGlpiClient glpiClient,CancellationToken cancel = default)
        // {
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);
        //
        //     HttpResponseMessage response = null;
        //
        //     HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "Document");
        //     requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
        //     requestMessage.Headers.Add("Session-Token", glpiClient.Init.SessionToken);
        //     requestMessage.Headers.Add("app_token", glpiClient.AppToken);
        //     requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //     requestMessage.Content = new StringContent(JsonConvert.SerializeObject(new { input = new { id = Id } }), Encoding.UTF8, "application/json");
        //
        //     var r = await glpiClient.Client.SendAsync(requestMessage, cancel);
        //
        //     ClientRequest clientRequest = new ClientRequest
        //     (async () => 
        //     {
        //         
        //         return null;
        //
        //
        //     },
        //     w => 
        //     response = w);
        //
        //     glpiClient.QueueRequest.Enqueue(clientRequest);
        //
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //         {
        //             cancel.ThrowIfCancellationRequested();
        //         }
        //
        //     }
        //     if (response.IsSuccessStatusCode) return;
        //     throw new System.Exception(
        //         $"status code:{response.StatusCode} content:{await response.Content.ReadAsStringAsync(cancel)}");
        // }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="glpiClient"></param>
        /// <param name="uri"></param>
        /// <param name="cancel"></param>
        /// <exception cref="ExceptionCheck"></exception>
        /// <exception cref="Exception"></exception>
        // [Obsolete]
        // public static async Task GetDoc(IGlpiClient glpiClient, string uri, CancellationToken cancel = default)
        // {
        //     Uri result;
        //     if (glpiClient.Checker())
        //         throw new ExceptionCheck(glpiClient);
        //
        //     if (string.IsNullOrEmpty(uri)) throw new System.Exception("URI is null or empty");
        //     if (!Uri.TryCreate(uri, UriKind.Absolute, out result)) throw new System.Exception("Error create URI.");
        //    
        //
        //     HttpResponseMessage response = null;
        //     ClientRequest clientRequest = new ClientRequest
        //     (() => glpiClient.Client.GetAsync(result,cancel),
        //     w => response = w);
        //
        //     glpiClient.QueueRequest.Enqueue(clientRequest);
        //
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //         {
        //             cancel.ThrowIfCancellationRequested();
        //         }
        //     }
        //
        //     if (response.IsSuccessStatusCode) return;
        //     throw new System.Exception(
        //             $"status code:{response.StatusCode} content:{await response.Content.ReadAsStringAsync(cancel)}");
        // }
    }
}

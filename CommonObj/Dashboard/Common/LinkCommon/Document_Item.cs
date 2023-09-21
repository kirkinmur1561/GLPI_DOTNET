namespace CommonObj.Dashboard.Common.LinkCommon
{
    /// <summary>
    /// Document_Item
    /// </summary>
    public class Document_Item:Dashboard<Document_Item>
    {
        private const string DOC_NAME = "Document/";
        // public static async Task<string> LoadDocument(IGlpiClient clt, byte[] data,CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     // client.Client.DefaultRequestHeaders.Clear();
        //     // client.Client.DefaultRequestHeaders.Add("Content-Type","multipart/form-data");
        //     // client.Client.DefaultRequestHeaders.Add("Session-Token", client.Init.SessionToken);
        //     // client.Client.DefaultRequestHeaders.Add("app_token", client.AppToken);
        //     client.SetHeaderDefault();
        //     HttpResponseMessage response = null;
        //     
        //     MultipartFormDataContent form = new MultipartFormDataContent();
        //     MemoryStream memoryStream = new MemoryStream(data);
        //     StreamContent fileContent = new StreamContent(memoryStream);
        //     
        //
        //     fileContent.Headers.ContentType =
        //         MediaTypeHeaderValue.Parse(MediaTypeNames.Application.Octet);
        //     
        //     form.Add(fileContent);
        //     clt.QueueRequest.Enqueue(new ClientRequest(
        //         async () => await client.Client.PostAsync(DOC_NAME, form, cancel),
        //         w => response = w.Response));
        //     
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);            
        //     
        //     while (response == null) 
        //     {
        //         if (cancel.IsCancellationRequested)
        //         {
        //             Disable(form,fileContent,memoryStream);
        //             cancel.ThrowIfCancellationRequested();
        //         }
        //
        //
        //         if (timeSpan >= DateTime.Now) continue;
        //         Disable(form,fileContent,memoryStream);
        //         throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     Disable(form,fileContent,memoryStream);
        //     return await response.Content.ReadAsStringAsync(cancel);
        // }

        private static void Disable(MultipartFormDataContent form,
            StreamContent fileContent,
            MemoryStream memoryStream)
        {
            memoryStream.Dispose();
            fileContent.Dispose();
            form.Dispose();
        }
    }
}
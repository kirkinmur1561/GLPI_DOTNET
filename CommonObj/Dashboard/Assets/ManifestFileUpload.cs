using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets;

public class ManifestFileUpload
{
    [JsonProperty(BaseJsonProperty.ID)]
    public long Id { get; set; }
    
    [JsonProperty(BaseJsonProperty.MESSAGE)]
    public string Message { get; set; }

    [JsonProperty(BaseJsonProperty.UPLOAD_RESULT)]
    public UploadResult upload_result { get; set; }
    
    
}

public class UploadResult
{
    [JsonProperty(BaseJsonProperty.FILENAME)]
    public IEnumerable<FileResult> Files { get; set; }
}

public class FileResult
{
    [JsonProperty(BaseJsonProperty.ID)]
    public string Id { get; set; }
    [JsonProperty(BaseJsonProperty.NAME)]
    public string Name { get; set; }
    [JsonProperty(BaseJsonProperty.SIZE)]
    public ulong Size { get; set; }
    [JsonProperty(BaseJsonProperty.TYPE)]
    public string Type { get; set; }
    [JsonProperty(BaseJsonProperty.URL)]
    public string Url { get; set; }
    [JsonProperty(BaseJsonProperty.DELETEURL)]
    public string DeleteUrl { get; set; }
    [JsonProperty(BaseJsonProperty.PREFIX)]
    public string Prefix { get; set; }
    [JsonProperty(BaseJsonProperty.DISPLAY)]
    public string Display { get; set; }
    [JsonProperty(BaseJsonProperty.FILESIZE)]
    public string FileSize { get; set; }    
}
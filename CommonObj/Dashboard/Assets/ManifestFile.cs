namespace CommonObj.Dashboard.Assets;

public class ManifestFile:IDisposable
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
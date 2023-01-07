namespace Backups;

public class RestorePoint
{
    private List<Storage> _data;
    private DateTime creationDate;
    public RestorePoint(List<Storage> data, string path, string name)
    {
        Path = path;
        Name = name;
        _data = data;
        creationDate = DateTime.Now;
    }

    public string Path { get; }
    public string Name { get; }
}
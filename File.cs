namespace Backups;

public class File : BackupObject
{
    private readonly string _path;

    public File(string path)
        : base(path)
    {
        _path = path;
    }

    public new string GetPath()
    {
        return _path;
    }
}
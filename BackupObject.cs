namespace Backups;

public abstract class BackupObject : IComponent
{
    private readonly string _path;

    protected BackupObject(string path)
    {
        _path = path;
    }

    public string GetPath()
    {
        return _path;
    }
}
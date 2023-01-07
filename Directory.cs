namespace Backups;

public class Directory : BackupObject
{
    private readonly string _path;
    private List<IComponent> _repository = new List<IComponent>();
    public Directory(string path)
        : base(path)
    {
        _path = path;
    }

    public void Add(IComponent component)
    {
        _repository.Add(component);
    }

    public void Remove(IComponent component)
    {
        _repository.Remove(component);
    }

    public new string GetPath()
    {
        return _path;
    }
}
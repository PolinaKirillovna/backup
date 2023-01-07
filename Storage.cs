namespace Backups;

public class Storage
{
    private List<BackupObject> _storedObj;

#pragma warning disable CS8618
    public Storage(List<BackupObject> storedObj)
#pragma warning restore CS8618
    {
        _storedObj = storedObj;
    }

#pragma warning disable CS8618
    public Storage(BackupObject backupObject)
#pragma warning restore CS8618
    {
        BackupObject = backupObject;
    }

    public BackupObject BackupObject { get; }
    private IReadOnlyCollection<BackupObject> Stored => _storedObj;
}
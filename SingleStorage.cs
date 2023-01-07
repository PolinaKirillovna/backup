namespace Backups.Storage_Algorithms;

public class SingleStorage : IAlgorithm
{
    public List<Storage> StoredWithAlgo(List<BackupObject> backupObjs)
    {
        var storage = new Storage(backupObjs);
        var storages = new List<Storage>();
        storages.Add(storage);
        return storages;
    }
}
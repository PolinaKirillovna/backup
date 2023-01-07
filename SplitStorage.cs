namespace Backups.Storage_Algorithms;

public class SplitStorage : IAlgorithm
{
    public List<Storage> StoredWithAlgo(List<BackupObject> backupObjs)
    {
        var stored = new List<Storage>();
        backupObjs.ForEach(el => stored.Add(new Storage(el)));
        return stored;
    }
}
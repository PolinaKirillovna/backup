namespace Backups.Storage_Algorithms;

public interface IAlgorithm
{
    List<Storage> StoredWithAlgo(List<BackupObject> backupObjs);
}
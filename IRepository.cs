using Backups.Storage_Algorithms;

namespace Backups;

public interface IRepository
{
    public List<Storage> Archive(List<BackupObject> backupObjects, IAlgorithm algorithm, string archiveName);
}
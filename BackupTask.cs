using System.IO.Compression;
using Backups.Storage_Algorithms;

namespace Backups;

public class BackupTask : IbackupTask
{
    private List<BackupObject> _backupObjects = new List<BackupObject>();
    private List<RestorePoint> _backup = new List<RestorePoint>();

    public BackupTask(IAlgorithm algorithm, string restorePointName, string restorePointPath, IRepository repository, string archiveName)
    {
        Algorithm = algorithm;
        RestorePointName = restorePointName;
        RestorePointPath = restorePointPath;
        Repository = repository;
        ArchiveName = archiveName;
    }

    public IAlgorithm Algorithm { get; }
    public string RestorePointName { get; }
    public string RestorePointPath { get; }
    public IRepository Repository { get; }
    public string ArchiveName { get; }

    private IReadOnlyCollection<RestorePoint> Backup => _backup;

    public BackupObject AddFile(string path)
    {
        var backupObject = new File(path);
        _backupObjects.Add(backupObject);
        return backupObject;
    }

    public BackupObject AddDirectory(string path)
    {
        var backupObject = new Directory(path);
        _backupObjects.Add(backupObject);
        return backupObject;
    }

    public void Remove(BackupObject backupObject)
    {
        _backupObjects.Remove(backupObject);
    }

    public void DoTask()
    {
        var storages = Repository.Archive(_backupObjects, Algorithm, ArchiveName);
        var rP = new RestorePoint(storages, RestorePointPath, RestorePointName);
        _backup.Add(rP);
    }
}
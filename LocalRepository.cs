using System.IO.Compression;
using Backups.Storage_Algorithms;

namespace Backups;

public class LocalRepository : IRepository
{
    private string _path;

    public LocalRepository(string path)
    {
        _path = path;
    }

    public List<Storage> Archive(List<BackupObject> backupObjects, IAlgorithm algorithm, string archiveName)
    {
        var storages = algorithm.StoredWithAlgo(backupObjects);
        System.IO.Directory.CreateDirectory(_path);
        var zip = ZipFile.Open(archiveName, ZipArchiveMode.Update);
        storages.ForEach(el => zip.CreateEntryFromFile(el.BackupObject.GetPath(), archiveName));
        return storages;
    }
}
/*
using System.IO.Compression;
using Backups.Storage_Algorithms;

namespace Backups;

public class VirtualRepository : IRepository
{
    public void Archive(List<BackupObject> backupObjects, IAlgorithm algorithm, string archiveName)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            backupObjects.ForEach(el =>
            {
                using (ZipArchive archive = new ZipArchive(ms, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry entry = archive.CreateEntry(archiveName);

                }
            });
        }
    }
}
*/

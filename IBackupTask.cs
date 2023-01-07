using System.Net.Sockets;
using Backups.Storage_Algorithms;

namespace Backups;

public interface IbackupTask
{
    public BackupObject AddFile(string path);
    public BackupObject AddDirectory(string path);
    public void Remove(BackupObject backupObject);
    public void DoTask();
}
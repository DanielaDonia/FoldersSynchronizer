namespace FolderSync
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine("Usage: SyncFolders.exe <source folder> <replica folder> <interval in seconds> ");
                return;
            }
                string sourcePath = args[0];
            string replicaPath = args[1];
            int synchronizationIntervalInSeconds = int.Parse(args[2]);
       var folderSync = new Sync(sourcePath, replicaPath);
            var scheduler = new Timer(folderSync, synchronizationIntervalInSeconds); 
       Console.WriteLine($"Starting synchronization from {sourcePath} to {replicaPath} every {synchronizationIntervalInSeconds} seconds.");
         
            scheduler.Start();
        }
    }
}
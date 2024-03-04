namespace FolderSync
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                return;
            }
                string sourcePath = args[0];
            string replicaPath = args[1];
            int synInSeconds = int.Parse(args[2]);
           
           if (!Directory.Exists(sourcePath))
{
    Console.WriteLine($"{sourcePath} does not exist.");
    return;
}
           
             if (!Directory.Exists(replicaPath))
    {
        Console.WriteLine($"{replicaPath} does not exist.");
        return;
    }
            string sourceFile = Path.Combine(sourcePath, "example.txt");
            Console.WriteLine(sourceFile);

       File.WriteAllText(sourceFile, "This is an example file");
       var sync = new Sync(sourcePath, replicaPath);
            var schedule = new Timer(sync, synInSeconds); 
       Console.WriteLine($"synchronization from {sourcePath} to {replicaPath} every {synInSeconds} seconds.");
         
            schedule.Start();
        }
    }
}
namespace FolderSync
{
    public class Sync{
        private string sourcePath;
        private string replicaPath;
    public Sync(string sourcePath, string replicaPath){
        this.sourcePath = sourcePath;
        this.replicaPath = replicaPath;
    }

    public void SyncFold(){
try{
    foreach(string sourceFile in Directory.GetFiles(sourcePath))
    {
string file = Path.GetFileName(sourceFile);
string replicaFile = Path.Combine(replicaPath, file);
File.Copy(sourceFile, replicaFile, true);

    }
}catch {
Console.WriteLine($"Error  synchronization");
}
    }
    



    }


}
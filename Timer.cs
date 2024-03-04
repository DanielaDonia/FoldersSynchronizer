using System.Threading;

namespace FolderSync{

public class Timer{
    private Sync sync;
    private int syncInt;

    public Timer(Sync sync, int syncInt){
        this.sync = sync;
        this.syncInt = syncInt;
    }

public void Start(){
    while(true){
        sync.SyncFold();
        Thread.Sleep(syncInt*1000);
    }
}


}


}
using System.Diagnostics;
using System.Text;
struct LocationStruct {
    public int x, y;
    public LocationStruct(int x, int y){
        this.x = x;
        this.y = y;
    }
}

class LocationClass {
    public int x, y;
    public LocationClass(int x, int y){
        this.x = x;
        this.y = y;
    }
}

static class Program{
    static void Main(string[] args){
        LocationStruct locationA = new LocationStruct(2,3);
        LocationStruct locationB = locationA;
        locationA.x = 10;
        Console.WriteLine(locationB.x);
        
        LocationClass locationC = new LocationClass(5,6);
        LocationClass locationD = locationC;
        locationC.x = 10;
        Console.WriteLine(locationD.x);

        int iteration = 100000;
        string a = "";
        StringBuilder sb = new StringBuilder();
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 0; i < iteration; i++){
            a += "a";
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);

        sw.Restart();
        for (int i = 0; i < iteration; i++){
            sb.Append("a");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);


    }
}
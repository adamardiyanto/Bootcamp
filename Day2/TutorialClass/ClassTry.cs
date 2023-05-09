
class Cat{
    //variabel getter setter
    public string Name{get; set; }
    public int Age{get; private set; }
    public string Race{get; set; }

    //method
    public void Eat(){
        Console.WriteLine(this.Name + " eat");
    }

    public void Sleep(){
        Console.WriteLine(this.Name + " sleep");
    }

    //method to set Age with private setter
    public void SetAge(int Age){
        this.Age = Age;
    }


    //constructor
    public Cat(string Name, int Age, string Race){
        this.Name = Name;
        this.Age = Age;
        this.Race = Race;
        Console.WriteLine("cat Name: " + this.Name + " Age: " + this.Age + " Race: " + this.Race);
    }



}

public static class Calculation{


    //overloading function
    public static int Add(int a, int b){
        return a + b;
    }
    //overloading function
    public static int Add(int a,int b, int c){
        return a + b + c;
    }

    public static void Print(int[] a){
        for(int i = 0; i < a.Length; i++){
            Console.Write(a[i] + " ");
        }
    }
}

static class Program{
    static void Main(string[] args){
        Cat cotton = new Cat("cotton", 2,"anggora"); //class cat cotton
        Cat milo = new Cat("milo",1,"kampung"); //class cat milo
        cotton.Name = "coto"; //try to set new Name
        string value = cotton.Name; //try to get the Name
        Console.WriteLine(value); // print the value

        // calling method
        cotton.Eat();
        cotton.Sleep();
        milo.Eat();
        milo.SetAge(10); // to set Age with private access
        Console.WriteLine($"cat Name is {milo.Name} Age is {milo.Age} Race is {milo.Race}");
        
        
        //calling method class calculation
        int valueA = int.Parse(Console.ReadLine());
        int valueB = int.Parse(Console.ReadLine());
        int valueC = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculation.Add(valueA,valueB));
        Console.WriteLine(Calculation.Add(valueA,valueB,valueC));
        int[] values = {2,1,3,1,3,2};
        Calculation.Print(values);
    }
}
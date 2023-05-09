
class Cat{
    //variabel getter setter
    public string name{get; set; }
    public int age{get; private set; }
    public string race{get; set; }

    //method
    public void Eat(){
        Console.WriteLine(this.name + " eat");
    }

    public void Sleep(){
        Console.WriteLine(this.name + " sleep");
    }

    //method to set age with private setter
    public void setAge(int age){
        this.age = age;
    }


    //constructor
    public Cat(string name, int age, string race){
        this.name = name;
        this.age = age;
        this.race = race;
        Console.WriteLine("cat name: " + this.name + " age: " + this.age + " race: " + this.race);
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
}

static class Program{
    static void Main(string[] args){
        Cat cotton = new Cat("cotton", 2,"anggora"); //class cat cotton
        Cat milo = new Cat("milo",1,"kampung"); //class cat milo
        cotton.name = "coto"; //try to set new name
        string value = cotton.name; //try to get the name
        Console.WriteLine(value); // print the value

        // calling method
        cotton.Eat();
        cotton.Sleep();
        milo.Eat();
        milo.setAge(10); // to set age with private access
        Console.WriteLine($"cat name is {milo.name} age is {milo.age} race is {milo.race}");
        

        //calling method class calculation
        int valueA = int.Parse(Console.ReadLine());
        int valueB = int.Parse(Console.ReadLine());
        int valueC = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculation.Add(valueA,valueB));
        Console.WriteLine(Calculation.Add(valueA,valueB,valueC));
    }
}
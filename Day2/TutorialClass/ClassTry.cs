
class Cat{
    //variabel getter setter
    public string _name{get; set; }
    public int _age{get; set; }
    public string _race{get; set; }

    //method
    public void Eat(){
        Console.WriteLine(_name + " eat");
    }

    public void Sleep(){
        Console.WriteLine(_name + " sleep");
    }

    //constructor
    public Cat(string name, int age, string race){
        _name = name;
        _age = age;
        _race = race;
        Console.WriteLine("cat name: " + _name + " age: " + _age + " race: " + _race);
    }

    
    
}

static class Program{
    static void Main(string[] args){
        Cat cotton = new Cat("cotton", 2,"anggora"); //instantiate cotton
        Cat milo = new Cat("milo",1,"kampung"); //instantiate milo
        cotton._name = "coto"; //try to set new name
        string value = cotton._name; //try to get the name
        Console.WriteLine(value); // print the value

        // calling method
        cotton.Eat();
        cotton.Sleep();
        milo.Eat();
    }
}
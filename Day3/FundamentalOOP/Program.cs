using AnimalLib;

class Dog : Animals{
    //constructor to parse value for parents class

    public Dog(string name, int age) : base(name, age){
    }
    
    public void Bark(){
        Console.WriteLine("Guuk");
    }
}


class Cat:Animals{

    //constructor to parse value for parents class
    public Cat(string name, int age) : base(name, age){
    }
    public void Meong(){
        Console.WriteLine("Meoong");
    }
}


class Program{
    static void Main(string[] args)
    {
        Animals hewan = new Animals("Fido", 10);
        Dog dogo = new Dog("jing",2);
        //Cat milo = hewan;  // Cannot implicitly convert type 'Animals' to 'Cat'
        Animals animal2 = dogo;
        Cat milo = new Cat("milo",4);
        Console.WriteLine(animal2.name);

    }
}
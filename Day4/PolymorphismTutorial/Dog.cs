namespace AnimalLib;
 
class Dog: Animals {
    public Dog(string name) : base(name) { 
        Console.WriteLine("Dog with name " + name + " created");

    }

    public override void MakeSound() {
        Console.WriteLine("Dog barking sound");
    }

}
namespace AnimalLib;
 
class Bird: Animals {
    public Bird(string name) : base(name) { 
        Console.WriteLine("Bird with name " + name + "created");

    }

    public override void MakeSound() {
        Console.WriteLine("Bird twittering sound");
    }

}
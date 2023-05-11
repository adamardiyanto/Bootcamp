namespace AnimalLib;
 
class Bird: Animals {
    public Bird(string name) : base(name) { 
        Console.WriteLine("Bird with name " + name + " created");

    }

    public new void MakeSound() {
        Console.WriteLine("Bird twittering sound");
    }

}
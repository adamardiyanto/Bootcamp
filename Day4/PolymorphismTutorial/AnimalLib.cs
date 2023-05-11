namespace AnimalLib;
class Animals{
    //var name
    public string Name { get; set; }

    // method that can be overridde by derived classes
    public virtual void MakeSound(){
        Console.WriteLine("Animal can make own sounds");
    }

    //constructor
    public Animals(string name) {
        Name = name;
        Console.WriteLine("Animal created");}
}
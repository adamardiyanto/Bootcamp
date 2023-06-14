using System.IO;
using System.Text.Json;
public class Animal
{
    public int age { get; set; }
    public string name { get; set; }
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Animal() { }
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal can make own sounds");
    }
}
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
        Console.WriteLine("Cat with name " + name + " age " + age + " created");
    }
    public Cat(){}
    public override void MakeSound()
    {
        Console.WriteLine("Cat Meowing sound");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat("puss", 1);
        Cat cat2 = new Cat("meng", 2);
        string jsonString = JsonSerializer.Serialize(cat1);

        using (StreamWriter writer = new StreamWriter("cat.json"))
        {
            writer.WriteLine(jsonString);
            writer.WriteLine(JsonSerializer.Serialize(cat2));
        }
    }
}
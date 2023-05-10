namespace AnimalLib;

class Animals{
    public string name{ get; set; }
    public int age{get; set; }

    public Animals(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Animal name: " + name + " age: " + age);
    }
    public Animals()
    {
    }

}




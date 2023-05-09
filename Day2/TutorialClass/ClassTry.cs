
class Cat{
    public int age;
    //public string name;
    public string race;

    public void Eat(){
        Console.WriteLine(this.name + " eat");
    }

    public void Sleep(){
        Console.WriteLine(this.name + " sleep");
    }

    public Cat(string name, int age, string race){
        this.name = name;
        this.age = age;
        this.race = race;
    }

    
    public void SetRace(string race) {   this.race = race; }
    public void SetAge(int age) {   this.age = age; }
    public int GetAge() { return this.age;  }
    public string GetRace() { return this.race; }

    public string name{get; set; }
}

static class Program{
    static void Main(string[] args){
        Cat cotton = new Cat("cotton", 2,"anggora");
        Cat milo = new Cat("milo",1,"kampung");
        cotton.name = "coto";
        string value = cotton.name;
        Console.WriteLine(value);
        cotton.Eat();
        cotton.Sleep();
        milo.Eat();
    }
}
using AnimalLib;
namespace CatLib;

class Cat:Animals{
    public string colour;
    //constructor to parse value for parents class
    public Cat(string name, int age, int gender, string colour) : base(name, age, gender){
        this.colour= colour;
        Console.WriteLine("name: " + name + " age: " + age + " gender: " + gender + " colour: " + colour);
    }
    public void Meong(){
        Console.WriteLine("Meoong");
    }

    public void ShowMessage(){
        Console.WriteLine(base.message);// accessing value from parent class 
    }
}
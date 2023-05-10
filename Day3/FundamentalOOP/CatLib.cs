using AnimalLib;
namespace CatLib;

class Cat:Animals{

    //constructor to parse value for parents class
    public Cat(string name, int age, int gender) : base(name, age, gender){
    }
    public void Meong(){
        Console.WriteLine("Meoong");
    }

    public void ShowMessage(){
        Console.WriteLine(base.message);// accessing value from parent class 
    }
}
using AnimalLib;
namespace DogLib;


class Dog : Animals{
    //constructor to parse value for parents class

    public Dog(string name, int age, int gender) : base(name, age, gender){
    }
    
    public void Bark(){
        Console.WriteLine("Guuk");
    }
}

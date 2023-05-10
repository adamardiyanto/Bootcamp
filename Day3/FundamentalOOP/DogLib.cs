using AnimalLib;
namespace DogLib;


class Dog : Animals{
    //constructor to parse value for parents class

    public Dog(string name, int age, int gender) : base(name, age, gender){
        Console.WriteLine("name: " + name + " age: " + age + " gender: " + gender);
    }
    
    public void Bark(){
        Console.WriteLine("Guuk");
    }
}

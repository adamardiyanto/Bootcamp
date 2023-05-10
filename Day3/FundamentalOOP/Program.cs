using AnimalLib; // for calling file with namespace AnimalLib
using CatLib;
using DogLib; 



class Program{
    static void Main(string[] args)
    {
        Animals hewan = new Animals("Fido", 10,1);
        Dog dogo = new Dog("jing",2,0);
        //Cat milo = hewan;  // Cannot implicitly convert type 'Animals' to 'Cat'
        //Cat belang = (Cat) hewan; //Unable to cast object of type 'AnimalLib.Animals' to type 'Cat'.
        Animals animal2 = dogo;
        Console.WriteLine("age animal2 " + animal2.age);
        Cat milo = new Cat("milo",4,1,"putih");
        Console.WriteLine(animal2.name);

        // calling parents method
        milo.Breath(); 
        dogo.Breath();

        // calling child method
        milo.Meong(); 
        dogo.Bark();
        // try accessing the private variables
        //Console.WriteLine(milo._gender); //'Animals._gender' is inaccessible due to its protection level

        milo.ShowMessage();
        //Console.WriteLine(hewan.message); //'Animals.message' is inaccessible due to its protection level
        

    }
}
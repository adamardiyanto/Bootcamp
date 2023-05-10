namespace AnimalLib; // give this file namespace AnimalLib

class Animals{
    public string name{ get; set; }
    public int age{get; set; }

    private string _gender;

    public Animals(string name, int age, int gender)
    {
        this.name = name;
        this.age = age;
        if (gender ==1){
            _gender = "Male";
        } else {
            _gender= "Female";
        }
        Console.WriteLine("Animal name: " + name + " age: " + age + " gender: " + _gender);
    }
    public Animals()
    {
    }

    public void Breath(){
        Console.WriteLine(this.name + " is Breathing");
    }

}




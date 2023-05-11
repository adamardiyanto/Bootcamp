using AnimalLib;
class Program {
    static void Main(string[] args)
    {
        Animals animal1 = new Animals("si A");
        Bird kenari = new Bird("kenari");
        Dog pitbull = new Dog("pitbull");

        animal1.MakeSound();
        pitbull.MakeSound();
        kenari.MakeSound();
    }
}
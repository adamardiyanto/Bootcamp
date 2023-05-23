using AnimalLib;
static class Program {
    static void Main(string[] args)
    {
        Animals animal1 = new("si A");
        Bird kenari = new("kenari");
        Dog pitbull = new("pitbull");

        Animals animal2 = kenari;
        Animals animal3 = pitbull;

        animal1.MakeSound();
        pitbull.MakeSound();
        kenari.MakeSound();

        animal2.MakeSound();
        animal3.MakeSound();
    }
}
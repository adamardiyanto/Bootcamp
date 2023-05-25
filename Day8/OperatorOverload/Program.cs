namespace OperatorOverloads;


class Program
{
    static void Main(string[] args)
    {
        Fraction pecahan1 = new Fraction(3,5);
        Fraction pecahan2 = new Fraction(2,5);
        Fraction pecahan3 = new Fraction(8,5);


        Fraction pecahan4 = pecahan1 + pecahan2 + pecahan3;
        Fraction pecahan6 = pecahan1 * pecahan2;
        Console.WriteLine($"{pecahan4.atas} {pecahan4.bawah}");
        Console.WriteLine($"{pecahan6.atas} {pecahan6.bawah}");

    }

}

public class Fraction 
{
    public int atas { get; set; }
    public int bawah { get; set; }

    public Fraction(int atas, int bawah)
    {
        this.atas = atas;
        this.bawah = bawah;
    }

    public static Fraction operator + (Fraction a, Fraction b)
    { 
        int newAtas;
        int newBawah;

        newAtas = (a.atas * b.bawah) + (b.atas * a.bawah);
        newBawah = a.bawah * b.bawah;

        return new Fraction(newAtas, newBawah);

    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int newAtas;
        int newBawah;

        newAtas = (a.atas * b.bawah) - (b.atas * a.bawah);
        newBawah = a.bawah * b.bawah;

        return new Fraction(newAtas, newBawah);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.atas * b.atas, a.bawah * b.bawah);
    }

}

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

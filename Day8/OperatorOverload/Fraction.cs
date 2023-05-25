namespace OperatorOverloads;
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

    public static Fraction operator <(Fraction a, Fraction b)
    {
        
    }
}
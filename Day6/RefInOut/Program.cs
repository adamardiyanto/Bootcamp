static class Program{

    static void Add (ref int x, ref int y){
        x++;
        y++;
    }

    static void Substract (out int x, out int y){
        x = 10;
        y = 20;
        x--; y--;
    }

    static int Multiply(in int x, in int y){
        return x * y;
    }

    static int Divide(in int x, in int y){
        return x / y;
    }
    static void Main(string[] args){
        int a = 10;
        int b = 20;
        int q = 0;

        Add(ref a,ref b);
        Console.WriteLine($"{a},{b}");

        Substract(out a, out b);
        Console.WriteLine($"{a},{b}");

        int z = Multiply(in a, in q);
        Console.WriteLine($"After Multiply method, x={a}, y={q}, z={z}");

        q = Divide(in a, in b);
        Console.WriteLine($"After Divide method, x={a}, y={b}, q={q}");
    }
}
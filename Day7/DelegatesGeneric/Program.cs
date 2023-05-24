

public delegate T MyDelegate<T> (T a,T b );

static class Program{
    static void Main(string[] args){
        MyDelegate<int> hitung = Calculation<int>.Add;
        int add = hitung(5,4);
        Console.WriteLine(add);

        MyDelegate<string> hitung2 = Calculation<string>.Add;
        string add2 = hitung2("A","B");
        Console.WriteLine(add2);

        hitung = Calculation<int>.Multiply;
        float kali = hitung(2,31);
        Console.WriteLine(kali);
    }
}

static public class Calculation<T> {
    public static T Add(T a,T b) {
        if(a is int x && b is int y ){
            return (T)(object)(x +y);
        }else if(a is string x2 && b is string y2){
            return (T)(object)(x2 +y2);
        }
        else{
            throw new NotSupportedException("Cannot add");
        }
    }

    public static int Multiply(int a, int b) {
        if(a is int x && b is int y ) { 
            return (a*b);
        } else {
            throw new NotSupportedException("Operation not supported for this data type.");
        }
    }
}

public delegate void SimpleDelegates();

static class Program{
    static void Main(string[] args){
        SimpleDelegates myDelegate = SayHello;
        myDelegate();
        myDelegate = SayHi;
        myDelegate();
        myDelegate += SayHello;
        myDelegate();

    }

    static void SayHello(){
        Console.WriteLine("Hello");
    }

    static void SayHi(){
        Console.WriteLine("Hi");
    }
}
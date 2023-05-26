namespace MainProgram;

using TextLibrary;
using NumberLibrary;

static class Program
{
    static void Main(string[] args)
    {
        string textInput = "quIcK browN Fox";
        Console.WriteLine($"text input into lowercase = {Text.Lowercase(textInput)}");
        Console.WriteLine($"text input into UPPERCASE = {Text.Uppercase(textInput)}");
        Console.WriteLine($"text join lower and UPPER = {Text.Join(Text.Lowercase(textInput), Text.Uppercase(textInput))}");

        double randNum = Number.RandomNumber();
        Console.WriteLine($" Random Number = {randNum}");
        Console.WriteLine($" Round using Math.Round = {Number.getRound(randNum)}");
        Console.WriteLine($" Round using Math.Truncate = {Number.getTruncate(randNum)}");
        Console.WriteLine($" Round using Math.Floor = {Number.getFloor(randNum)}");
        Console.WriteLine($" Round using Math.Ceiling = {Number.getCeiling(randNum)}");


    }
}
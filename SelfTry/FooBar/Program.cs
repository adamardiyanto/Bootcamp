using System.Collections.Generic;
namespace foobarQuiz;
static class Program
{
    static void Main(string[] args)
    {
        Checker checker = new Checker();
        Console.WriteLine("Masukan input");
        int input;
        int.TryParse((Console.ReadLine()), out input);
        Console.WriteLine(checker.CheckInput(input));
    }
}

class Checker
{
    private int _number;
    private string result = " ";

    private string foobar = "";

    public string CheckInput(int input)
    {
        Print print = new Print();
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict.Add(3, "foo");
        myDict.Add(5, "bar");
        _number = input;
        for (int i = 1; i <= _number; i++)
        {
            foreach (KeyValuePair<int, string> dict in myDict)
            {
                // bool test = int.TryParse(print.PrintFoobar(i, dict.Key, dict.Value), out int x);
                // foobar = test? i.ToString() : print.PrintFoobar(i, dict.Key, dict.Value);  
                result += print.PrintFoobar(i, dict.Key, dict.Value);
                
            }
            
            //Console.WriteLine(foobar);
            
            
        }
        return result;
    }
}

public class Print
{
    public string PrintFoobar(int number, int key, string value)
    {
        if (number % key == 0) return value;
        else return number.ToString();
    }

}
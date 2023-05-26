using System.Collections.Generic;
namespace foobarQuiz;
static class Program
{
    static void Main(string[] args)
    {
        Checker checker = new Checker();
        checker.AddDictionary(3, "Foo");
        checker.AddDictionary(5, "Bar");
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

    Dictionary<int, string> myDict;

    public Checker()
    {
        myDict = new Dictionary<int, string>();
    }

    public string CheckInput(int input)
    {
        _number = input;


        for (int i = 1; i <= _number; i++)
        {
            Console.WriteLine(CheckSingleNumber(i));
            
            //result += tempResult;
            
        }
        return result;
    }
    
    public string PrintFoobar(int number, int key, string value)
    {
        if (number % key == 0) return value;
        else return " ";
    }

    public void AddDictionary(int key, string value)
    {
        myDict.Add(key, value);
    }

    public string CheckSingleNumber(int input)
    {
        string result = " ";
        foreach (KeyValuePair<int, string> dict in myDict)
            {
                result += PrintFoobar(input, dict.Key, dict.Value);
            }
        return result;
    }

}


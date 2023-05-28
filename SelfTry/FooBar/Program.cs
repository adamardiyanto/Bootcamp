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
    private string _result = " ";

    private string _foobar = "";
    private string _tempResult =" ";

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
            _foobar = CheckSingleNumber(i);
            if (_foobar == "   ") _tempResult = i.ToString();
            else _tempResult = _foobar;
            //_tempResult = (_foobar == " ")? i.ToString() : _foobar;
            //Console.WriteLine(_tempResult);
            _result += _tempResult;
            
        }
        return _result;
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


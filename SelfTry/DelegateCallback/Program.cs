public delegate void ResultCallback(int result);

public class Number
{
    private int _number;
    private ResultCallback _resultCallback;

    public Number(int number, ResultCallback resultCallback)
    {
        _number = number;
        _resultCallback = resultCallback;
    }

    public void Sum()
    {
        int result = 0;
        for(int i = 1; i< _number; i++)
        {
            result +=1;
        }
        if(_resultCallback != null)
        {
            _resultCallback(result);
        }
    }
}

static class Program
{
    static void Main()
    {
        ResultCallback myResultCallback = new ResultCallback(resultCallbackMethod);

        int number = 10;
        Number angka = new(number, myResultCallback);
        Thread t1 = new Thread(new ThreadStart(angka.Sum));

        t1.Start();
        Console.Read();
    }

    public static void resultCallbackMethod (int number)
    {
        Console.WriteLine(number);
    }
}
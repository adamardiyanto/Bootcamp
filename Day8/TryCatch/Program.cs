
class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        try
        {
            int result = 10/ a;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // catch (DivideByZeroException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        finally
        {
            Console.WriteLine("code excecuted");
        }

    }
}
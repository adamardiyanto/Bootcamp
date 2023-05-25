
class Program
{
    static void Main(string[] args)
    {
        
        try
        {
            int q = 0;
            int x = 10 / q; // DivideByZeroException
            
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // IndexOutOfRangeException


            string s = null;
            Console.WriteLine(s.Length); // NullReferenceException

            int y = int.Parse("hello"); // FormatException
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("code excecuted");
        }

    }
}
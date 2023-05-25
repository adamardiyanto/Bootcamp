public class BaseEmployee
{

}

public class Employee : BaseEmployee 
{
    public string name { get; set; }
}

public class Customer 
{
    public string name { get; set; }
}

public class GenericClass<T> where T : BaseEmployee 
{
    public T message;
    public void GenericMethod<T> (T param1, T param2)
    {
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Param1: {param1}");
        Console.WriteLine($"Param2: {param2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericClass<Employee> employee = new GenericClass<Employee>();
        Employee emp1 = new Employee(){name = "emp1"};
        Employee emp2 = new Employee(){name = "emp2"};
        Employee emp3 = new Employee(){name = "emp3"};
        
        employee.message = emp1;
        employee.GenericMethod(emp2, emp3);
    }
}
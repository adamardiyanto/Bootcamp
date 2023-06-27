

public interface IOrder
{
    void Order();
}

public class Chef : IOrder
{
    public void Order()
    {
        Console.WriteLine("Chef making order");
    }
}

public class Cashier : IOrder
{
    private Chef _chef;
    public Cashier(Chef chef)
    {
        _chef = chef;
    }

    public void Order()
    {
        if (CheckMenu())
        {
            this._chef.Order();

        }
    }
    public bool CheckMenu()
    {
        Console.WriteLine("cashier checking menu");
        Console.WriteLine("passing order to chef...");
        return true;
    }
    public void SalesLog()
    {
        Console.WriteLine("logging the order");
    }
}
public class Customer
{
    public void CustomerOrder(IOrder subject)
    {
        subject.Order();
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer();
        Chef chef = new Chef();
        Console.WriteLine("Customer order directly to the chef");
        customer.CustomerOrder(chef);

        Console.WriteLine();

        Console.WriteLine("Customer order via cashier");
        Cashier cashier = new Cashier(chef);
        customer.CustomerOrder(cashier);

    }


}
public class Publisher{
    public event EventHandler<string> CommandSent;

    public void SendCommand(string command){
        CommandSent.Invoke(this, command);
    }
}

public class Subscriber{
    public string nama { get; set; }
    public void CommandReceived(object sender, string command){
                Console.WriteLine($"{nama} menerima perintah: {command}");

    }
    public Subscriber(string x){
        nama = x;
    }
}

public static class Program{
    public static void Main(string[] args){
        Publisher publisher = new Publisher();
        Subscriber siA = new Subscriber("siA");
        Subscriber siB = new Subscriber("siB");

        publisher.CommandSent += siA.CommandReceived;
        publisher.CommandSent += siB.CommandReceived;

        publisher.SendCommand("Get Ready");
    }
}
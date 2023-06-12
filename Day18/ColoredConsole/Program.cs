using System.Collections.Concurrent;
public class Message
{
    public List<MessagePart> parts = new List<MessagePart>();

    public void Render()
    {
        parts.ForEach(p => p.Render());
    }

    public class MessagePart
    {

        public string text;
        public ConsoleColor color;

        public MessagePart(string text, ConsoleColor color)
        {
            this.text = text;
            this.color = color;
        }

        public void Render()
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }

    }

}

class Program
{

    static bool pause = false;
    static bool quit = false;
    static ConcurrentQueue<Message> messages = new ConcurrentQueue<Message>();

    static void Main(string[] args)
    {            
        Console.WriteLine("Press Space to Pause/UnPause.");
        Console.WriteLine("Press Enter to Quit when you are done.");
        Console.WriteLine("Press Enter to Start...");
        Console.ReadLine();

        Task.Run(() => RenderLoop());
        Task.Run(() => YellowAndBlue());
        Task.Run(() => RedAndBlue());

        while (!quit)
        {
            while (!Console.KeyAvailable)
            {
                Task.Delay(50);
            }
            switch(Console.ReadKey(false).Key)
            {
                case ConsoleKey.Enter:
                    quit = true;
                    break;
                case ConsoleKey.Spacebar:
                    pause = !pause;
                    break;
            }
        }            
    }

    static void YellowAndBlue()
    {
        Message msg = new Message();
        msg.parts.Add(new Message.MessagePart("Yellow", ConsoleColor.Yellow));
        msg.parts.Add(new Message.MessagePart(" and ", ConsoleColor.White));
        msg.parts.Add(new Message.MessagePart("Blue", ConsoleColor.Blue));
        msg.parts.Add(new Message.MessagePart(" make ", ConsoleColor.White));
        msg.parts.Add(new Message.MessagePart("Green\r\n", ConsoleColor.Green));

        while (!quit)
        {
            Task.Delay(50);
            messages.Enqueue(msg);
            while (pause)
            {
                Task.Delay(50);
            }
        }
    }

    static void RedAndBlue()
    {
        Message msg = new Message();
        msg.parts.Add(new Message.MessagePart("Red", ConsoleColor.Red));
        msg.parts.Add(new Message.MessagePart(" and ", ConsoleColor.White));
        msg.parts.Add(new Message.MessagePart("Blue", ConsoleColor.Blue));
        msg.parts.Add(new Message.MessagePart(" make ", ConsoleColor.White));
        msg.parts.Add(new Message.MessagePart("Magenta\r\n", ConsoleColor.Magenta));

        while (!quit)
        {
            Task.Delay(50);
            messages.Enqueue(msg);
            while (pause)
            {
                Task.Delay(50);
            }
        }
    }

    static void RenderLoop()
    {
        Message message;
        while (!quit)
        {                
            while (!messages.IsEmpty && !quit)
            {
                if (messages.TryDequeue(out message))
                {
                    message.Render();                        
                }
                while (pause)
                {
                    Task.Delay(50);
                }
            }
            if (!quit)
            {
                messages.Enqueue(new Message() { parts = { new Message.MessagePart("Queue Emptied!\r\n", ConsoleColor.White) } });
                Task.Delay(50);
            }                
        }
    }

}
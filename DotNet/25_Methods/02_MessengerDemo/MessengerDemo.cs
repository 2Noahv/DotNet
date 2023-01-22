using System;

class MessengerDemo
{
    public void PrintMessage(string message, string prefix = "", string suffix = "")
    {
        Console.WriteLine($"{prefix}{message}{suffix}");
    }

    static void Main()
    {
        MessengerDemo messenger = new MessengerDemo();
        messenger.PrintMessage("My");  // [A]
        messenger.PrintMessage(prefix: "Oh ", message: "My");
        messenger.PrintMessage(prefix: "Oh ", message: "My ", suffix: "God");
        messenger.PrintMessage("My ", "Oh ", "God");
    }
} 


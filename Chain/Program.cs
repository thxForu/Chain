using System;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            var Chain = new BotCheckHandler();
            Chain.SetNext(new DataHandler()).SetNext(new EmailCodeHandler()).SetNext(new CloseAuthorization());
            Console.WriteLine(Chain.Handler(new Request("newUser","newUser")));
        }
    }
}
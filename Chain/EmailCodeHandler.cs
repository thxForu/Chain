using System;

namespace Chain
{
    class BotCheckHandler : AbstractHandler
    {
        public override object Handler(object request)
        {
            Console.WriteLine("Proof that u not a robot, pls enter word 'Bot'");
            string proof = Console.ReadLine();
            if (proof == "Bot")
            {
                return base.Handler(request);   
            }
            else
            {
                Console.WriteLine("Sorry we don't like robots :(");
                return null;
            }
        }
    }

    public class DataHandler : AbstractHandler
    {
        public override object Handler(object request)
        {
            Console.WriteLine("Enter your email and password");
            string email = Console.ReadLine();
            string password = Console.ReadLine();
            Request req = request as Request;
            req = new Request(email,password);
            return base.Handler(req);
        }
    } 
    public class EmailCodeHandler: AbstractHandler
    {
        private readonly Random _random = new Random();
        private int randomNumber;
        private bool Check(string checkCode)
        {
            return checkCode == randomNumber.ToString();
        }

        private void SendEmail()
        {
            randomNumber = _random.Next(0,1000);
            Console.WriteLine("Code: "+randomNumber);
        }
        
        public override object Handler(object request)
        {
            
            SendEmail();
            Console.WriteLine("Enter Number from email");
            var code = Console.ReadLine();
            
            if (Check(code))
            {
                return base.Handler(request);
            }
            else
            {
                Console.WriteLine("Wrong code");
                return null;
            }
        }
    }
    class CloseAuthorization : AbstractHandler
    {
        public override object Handler(object request)
        {
            Console.WriteLine("Зареєстровано! Вітаємо!");
            return null;
        }
    }
}
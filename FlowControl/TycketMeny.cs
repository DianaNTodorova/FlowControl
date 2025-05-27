using System;

namespace FlowControl
{
    internal class TycketMeny
    {
        private string Message { get; set; }
        private int Price { get; set; }

        public TycketMeny()
        {
            Price = 0;
            Message = string.Empty;
        }

        public void OrderTycket()
        {
            Console.WriteLine("You can choose a ticket!");
            Console.Write("Enter your age: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int input);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            if (input < 5 || input > 100)
            {
                Message = "The ticket is free.";
            }
            else if (input < 20)
            {
                Price = 80;
                Message = $"Youth: {Price}kr";
            }
            else if (input > 64)
            {
                Price = 90;
                Message = $"Pensioner: {Price}kr";
            }
            else
            {
                Price = 120;
                Message = $"Adult: {Price}kr";
            }

            Console.WriteLine(Message);
        }
    }
}


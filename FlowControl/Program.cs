namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TycketMeny optionOne = new TycketMeny();
            

            bool isStarted = true;
            while (isStarted)
            {
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("Select an option:");
                Console.WriteLine("0/ Exit the program");
                Console.WriteLine("1/ Buy a tycket.");
                Console.Write("Your choise is: ");
                var choise =Console.ReadLine();

                switch (choise)
                {
                    case "0":
                    isStarted = false;
                        break;
                    case "1":
                     optionOne.OrderTycket();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

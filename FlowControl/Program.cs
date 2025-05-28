namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TycketMeny optionOne = new TycketMeny();
            Repeat optionTwo = new Repeat();
           
            

            
            while (true)
            {
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("Select an option:");
                Console.WriteLine("0/ Exit the program");
                Console.WriteLine("1/ Buy a tycket.");
                Console.WriteLine("2/ Repeat.");
                Console.Write("Your choise is: ");
                var choise =Console.ReadLine();

                switch (choise)
                {
                    case "0":
                    Environment.Exit(0);
                        break;
                    case "1":
                     optionOne.OrderTycket();
                        break;
                    case "2":
                        optionTwo.getRepeat();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

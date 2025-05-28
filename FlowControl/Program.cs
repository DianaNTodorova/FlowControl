namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TycketMeny optionOne = new TycketMeny();
            Repeat optionTwo = new Repeat();
            Words optionTree= new Words();
           
            

            
            while (true)
            {
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("Select an option:");
                Console.WriteLine("0/ Exit the program");
                Console.WriteLine("1/ Buy a tycket.");
                Console.WriteLine("2/ Repeat.");
                Console.WriteLine("3/ Words.");
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
                        optionTwo.GetRepeat();
                        break;
                    case "3":
                        optionTree.GetWords();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

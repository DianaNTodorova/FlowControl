namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isStarted = true;
            while (isStarted)
            {
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1/ Exit the program");
                Console.WriteLine("2/ Buy a tycket.");
                Console.Write("Your choise is: ");
                var choise =Console.ReadLine();

                switch (choise)
                {
                    case "0":
                    isStarted = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

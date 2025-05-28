using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Repeat
    {
        public void getRepeat() {
            Console.WriteLine("Write something:");
            var input=Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{input} ");

            }
            Console.WriteLine();

        }
    }
}

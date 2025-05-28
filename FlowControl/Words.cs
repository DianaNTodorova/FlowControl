using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Words
    {
        public void GetWords() 
        {
            Console.WriteLine("Write a sentence (at least 3 words):");
            string words = Console.ReadLine();
            string[] wordSplit = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (wordSplit.Length >= 3)
            {
              
                    Console.WriteLine(wordSplit[2]);
                
            }
            else 
            {
                Console.WriteLine("Please write a sentence with at leeast words in it!");
            }

        
        }
    }
}

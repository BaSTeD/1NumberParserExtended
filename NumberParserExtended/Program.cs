using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParserExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                NumberParser n1 = new NumberParser();
                n1.parseNumbers();

                Console.WriteLine("\nMöchten Sie das Programm erneut starten? [j/n]: ");
                if (Console.ReadLine() == "j")
                {
                    continue;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

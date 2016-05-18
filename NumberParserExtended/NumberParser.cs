using System;
using System.Text.RegularExpressions;

namespace NumberParserExtended
{
    class NumberParser
    {
        private String[] s;
        private int count = 1;
        private Filehandler fh;

        public NumberParser()
        {
            fh = new Filehandler();
            this.s = fh.readIn();
        }

        public void parseNumbers()
        {
            for (int i = 1; i < s.Length; i+=4)
            {
                String[] textNumbers = Regex.Split(s[i], @"\s+");
                Console.WriteLine("\n" + count + ". Zeile: ");
                count++;

                for (int j = 0; j < textNumbers.Length; j++)
                {
                    if (textNumbers[j].Equals("/"))
                    {
                        Console.Write("3");
                    }
                    else if (textNumbers[j].Equals("_|"))
                    {
                        Console.Write("2");
                    }
                    else if (textNumbers[j].Equals("|___|"))
                    {
                        Console.Write("4");
                    }
                    else if (textNumbers[j].Equals("|___"))
                    {
                        Console.Write("5");
                    }
                    else if (textNumbers[j].Equals("|"))
                    {
                        Console.Write("1");
                    }
                }
            }
        }
    }
}

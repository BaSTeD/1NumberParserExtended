using System;
using System.Text.RegularExpressions;

namespace NumberParserExtended
{
    /*
    * This Class contains the Method, to parse the textnumbers to decimal numbers
    * 
    * 
    * 
    */

    class NumberParser
    {
        private String[] s;
        private int count = 1;
        private Filehandler fh;

        //Constructor
        public NumberParser()
        {
            fh = new Filehandler();
            this.s = fh.readIn();
        }

        //This method parses the textnumbers to decimal numbers.
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

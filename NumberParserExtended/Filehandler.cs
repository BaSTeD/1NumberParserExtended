using System;
using System.IO;

namespace NumberParserExtended
{
    /*
     * This Class contains some methods to handle a textfile.
     * 
     * 
     * 
        */
    class Filehandler
    {
        private String path;
        private String[] list;
        private bool b=true;


        //This method proofs the path of a file. 
        private void proofPath(String path)
        {

            if (File.Exists(path) == true)
            {
                b = false;
                Console.WriteLine("Dateipfad gültig!");
            }
            else
            {
                Console.WriteLine("Dateipfad ungültig!");
            }
          
        }

        //This method reads all Lines of the textfile.
        public String[] readIn()
        {
            while (b)
            {
                Console.Write("Bitte geben Sie einen Dateipfad ein: ");
                this.path = Console.ReadLine();
                proofPath(path);
            }
            list = File.ReadAllLines(path);

            return list;
        }

    }
}

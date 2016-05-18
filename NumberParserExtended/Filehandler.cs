﻿using System;
using System.IO;

namespace NumberParserExtended
{
    class Filehandler
    {
        private String path;
        private String[] list;
        private bool b=true;

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

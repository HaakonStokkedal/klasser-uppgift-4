using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_uppgift_4
{
    internal class personuppgifter
    {
        public string förnamn;
        public string efternamn;
        public int ålder;
        public double längd;
        public int vikt;

        public void MataIn()
        {
            Console.WriteLine("Vad heter du i förnamn?");
            förnamn = Console.ReadLine();
            Console.WriteLine("Vad heter du i efternamn?");
            efternamn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hej {förnamn} {efternamn}!");
            Console.WriteLine("Hur gammal är du?");
            ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du?");
            vikt = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur lång är du? (meter)");
            längd = double.Parse(Console.ReadLine());

            if (Myndig() == true)
            {
                Console.WriteLine("Du är myndig!!!");
            }
            else
            {
                Console.WriteLine("Du är inte mydnig :(");
            }

            Console.WriteLine($"Ditt BMI är {BMI()}.");
        }

        public bool Myndig()
        {
            if (ålder >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double BMI()
        {
            double BMI = vikt / (längd * längd);
            return BMI;
        }
    }

}

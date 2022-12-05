using System;

namespace lab1ex3varnoua
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Ex3
          Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
          tastaura */

          

            Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg");
            Console.WriteLine("Introduceti numarul intreg");

            int numarulIntreg = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Ultima cifra este:" + numarulIntreg % 10);
            
        }
    }
}

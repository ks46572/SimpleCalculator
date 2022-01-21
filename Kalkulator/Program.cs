using System;
using System.Collections.Generic;
using System.Linq;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simplest Calculator on the world");
            Console.Write(String.Format("2 + 2 = {0}\n", Calculator.Add(2, 2)));
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}

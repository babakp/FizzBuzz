using FizzBuzzLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFizzBuzz
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int printNumberFrom = 1;
            int printNumberTo = 100;
            for (i = printNumberFrom; i <= printNumberTo; i++)
                Console.WriteLine(fizzBuzz.Output(i));
        }
    }
}

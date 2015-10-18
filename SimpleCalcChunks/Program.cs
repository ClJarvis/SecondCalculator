using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalcChunks;

namespace SimpleCalcChunks
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Evaulate calculator = new Evaulate();
            var result = calculator.Evaluate(input);
            Console.WriteLine("   = " + result);

            Console.ReadLine();
        }
    }
}

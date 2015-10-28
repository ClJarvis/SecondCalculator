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
            int x = 0;
            while (true)

            {
                
                Console.WriteLine("[" + x + "]>");
                string input = Console.ReadLine();
                Evaulate calculator = new Evaulate();
               
                    try
                {
                    var result = calculator.Evaluate(input);
                    Console.WriteLine("   = " + result);
                   
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);  
                    
                }

                x++;
                Stack.exit();
            }
        }
    }
}

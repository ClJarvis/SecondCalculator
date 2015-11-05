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
            bool RunCalcuate;
             //bool RunCalcuate = true;
            while (RunCalcuate = true) 



            { 
                Console.WriteLine("[" + x + "]>");
                string input = Console.ReadLine();
                Evaulate calculator = new Evaulate();
                if (Stack.Exit() == "exit")
                {
                    RunCalcuate = false;
                    Stack.Exit();
                }

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
         
            }
            if (Stack.Exit() == "exit") { 
                RunCalcuate = false;
                Stack.Exit();

            }
        }
    }
}

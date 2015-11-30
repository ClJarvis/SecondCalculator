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
                Evaulate eval = new Evaulate();
                Parse parse = new Parse();
                Stack stack = new Stack();
      
                        if (input.ToLower() == "exit" || input.ToLower() == "quit")
                            break;
                    try
                    {
                    var result = eval.Calculuate(input);
                    Console.WriteLine("   = " + result);
                   
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);  
                    
                }

                try
                {
                    if (input.Contains("="))
                    {
                        parse.ExtractConstant(input);
                        stack.SaveConstant(parse.ConstantKey, parse.ConstantValue);
                    }
                    else
                    {
                        parse.ExtractValue(input);
                        eval.Calculuate(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                    }
                }
                catch (System.ArgumentException)
                {
                    Console.WriteLine("You made a syntax error");
                }
               

                x++;         
                    }

                Console.WriteLine("Goodbye, Mr Bond!");
                Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            }
          
        }
    }


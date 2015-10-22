﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalcChunks;

namespace SimpleCalcChunks
{
    public class Evaulate
    {
        public string Evaluate(string input)
        {
            if (input == "lastq")
            {
                if (Stack.lastQuestion == null)
                {
                    return "No Operation entered";
                }
                return Stack.lastQuestion;
            }
            else if (input == "last")
            {
                if (Stack.lastQuestion == null)
                {
                    return "No Operation entered";
                }
                return Stack.last;
            }

            else if (input == "a")  ////////////////////////////////////////////////////
              {
                Parse parse = new Parse();
                var constant = parse.GetConstant(input);
              
                return input; //ask for int to set to constant
                Dictionary<string, int> openWith =
                 new Dictionary<string, int>();

       
                openWith.Add("a", 15);
                openWith.Add("b", 7);
                openWith.Add("c", 9);
                openWith.Add("d", 10);

                // The Add method throws an exception if the new key is 
                // already in the dictionary.
                try
                {
                    // openWith.Add("a", 15);
                    Console.WriteLine("enter a number");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("An element with Key = \"a\" already exists.");
                }
            }
            else
            {
                Parse parse = new Parse();
                var operans = parse.GetNumbers(input);
                var op = parse.GetOperator(input);
                var result = 0;
               


                switch (op)
                {
                    case '+':
                        result = Addition.AddNum(operans);
                        break;
                    case '-':
                        result = Subtraction.SubNum(operans);
                        break;
                    case '*':
                        result = Multiplication.MultiplyNum(operans);
                        break;
                    case '/':
                        result = Division.DivideNum(operans);
                        break;
                    case '%':
                        result = Modulus.ModNum(operans);
                        break;
                    default:
                        throw new ArgumentException("incorrect format");
                }
                Stack.last = result.ToString();
                Stack.lastQuestion = input;
                return result.ToString();
            }
        }

    }
}

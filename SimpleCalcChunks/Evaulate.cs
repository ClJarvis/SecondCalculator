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
                return Stack.lastQuestion;
            }
            else if (input == "last")
            {
                return Stack.last;
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
                return result.ToString();
            }
        }

    }
}

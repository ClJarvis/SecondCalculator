using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Parse  ///static??
    {
        
        private Char[] delimiterChars = { '+', '-', '*', '/', '%' };

        public string[] GetNumbers(string input)
        {

            return input.Split(delimiterChars);

        }

        public char GetOperator(string input)
        {
            foreach (char character in delimiterChars)
            {
                if (input.Contains(character))
                {
                    return character;
                }

            }
           
            throw new ArgumentException("Invalid A");
            try
            {
                throw new ArgumentException("Invalid B Input you did not include a mathmatic symbol");
            }
            catch
            {
                throw new ArgumentException("Invalid  C Input you did not include a mathmatic symbol");
            }
        }

       /*   public int Evaluate(string input)
          {
              var operans = GetNumbers(input);
              var op = GetOperator(input);

              switch (op)
              {
                  case '+':
                      return Addition.AddNum(operans);
                  case '-':
                      return Subtraction.SubNum(operans);
                  case '*':
                      return Multiplication.MultiplyNum(operans);
                  case '/':
                      return Division.DivideNum(operans);
                  case '%':
                      return Modulus.ModNum(operans);
                  default:
                      throw new ArgumentException("incorrect format");
              }     
              */

          }
          


    }


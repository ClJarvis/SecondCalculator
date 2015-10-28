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
        public Char[] constants = { '=' };

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
           
            throw new ArgumentException("Invalid Input");
        }

        internal char GetNumbers(Func<string> toString)
        {
            throw new NotImplementedException();
        }

        public char ExtractCharacter(string input)
        {
            foreach (char letter in input)
                if (input.Contains('='))
            {
                return letter;
            }
            throw new ArgumentException("Does Not set a constant to a value");
        }

     /*   public int ExtractValue(string input)
        { // Try splitting on an '=' and then parseInt from the second index of the array that returns

          
                return input.Split('=');
           var value = Int32.Parse(input[1]);
           
        } */
      }
          


    }


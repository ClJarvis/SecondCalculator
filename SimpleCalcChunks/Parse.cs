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

    /*    public char GetConstant(string input)
        {
            foreach (char character in constants)
            {
                if (input.Contains(character))
                {
                    return character;
                }

            }

            throw new ArgumentException("Sorry that is not a correct constant. It must a single lower case letter. Please retry");
        }
        */
        internal char GetNumbers(Func<string> toString)
        {
            throw new NotImplementedException();
        }

        public char ExtractCharacter(string input)
        {
            foreach (char constant in constants)
                if (input.Contains('='))
            {
                return constant;
            }
            throw new ArgumentException("Does Not set a constant to a value");
        }
    }
          


    }


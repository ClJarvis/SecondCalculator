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
       // internal static string input;

        public string[] GetNumbers(string input)
        {

            return input.Split(delimiterChars);

        }

        internal static void ExtractValue()
        {
            throw new NotImplementedException();
        }

        internal static string ExtractCharacter()
        {
            throw new NotImplementedException();
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

        public int ExtractValue(string input)
        {
            if (input.Contains('='))
            {
                Parse parse = new Parse();
                var splitInput = input.Split('=');     //splitInput looks something like ['x', '13']
              
                return int.Parse(splitInput['1']);
            }
                
                ///Tryparse 
            /// public static bool TryParse(
            //string input,
            ///out int result

           return Convert.ToInt32(input[1]);
        }       
    }
 }


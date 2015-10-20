using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Addition
    {
        public static int AddNum(string[] input)
        {
            var leftNumber = Convert.ToInt32(input[0]);
            var rightNumber = Convert.ToInt32(input[1]);
            return leftNumber + rightNumber;

         /*     if (!leftNumber = Convert.ToInt32(input[0]))
                {
                    ArgumentException argEx = new ArgumentException();
                    throw argEx;
                }

                if (!rightNumber = Convert.ToInt32(input[1])) // Throw Exception when TryParse is NOT true.
                {
                    ArgumentException argEx = new ArgumentException();
                    throw argEx;
                } 
                */
                
        }

        public int AddN(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber;
        }
    }
}

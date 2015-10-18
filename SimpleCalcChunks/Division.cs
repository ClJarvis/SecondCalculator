using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Division
    {
        public static int DivideNum(string[] input)
        {
            var leftNumber = Convert.ToInt32(input[0]);
            var rightNumber = Convert.ToInt32(input[1]);
            return leftNumber/rightNumber;
        }
    }
}

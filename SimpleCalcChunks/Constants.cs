using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Constants
    {
        //public static string Dictionary { get; set; }

        public Dictionary<char, int> calculatorConstants;
        public Constants ()
        {
            calculatorConstants = new Dictionary<char, int>();
        }

        public void setConstant(char key, int value)
        {
            calculatorConstants.Add(key, value);
        }

        public int getConstant(char key)
        {
            int value;
            if (calculatorConstants.TryGetValue(key, out value))
            {
                return value;
            }
            throw new KeyNotFoundException();
        }
    }
}
    


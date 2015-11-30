using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Stack
    {
        public static string lastQuestion { get; set; }
        public static string last { get; set; }
        private Dictionary<char, int> constant = new Dictionary<char, int>();


        public void SaveConstant(char key, int value ) 
            {
                Parse parse = new Parse();
                Stack stack = new Stack();
            string input = null;
            parse.ExtractConstant(input);
                stack.SaveConstant(parse.ConstantKey, parse.ConstantValue);
            }

         public int RetrieveConstant(char key)
            {
                 return 0;
            }
      }
       

}

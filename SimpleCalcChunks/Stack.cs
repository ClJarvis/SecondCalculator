﻿using System;
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
                
            }

         public int MyProperty(char key)
            {
                 return 0;
             }
      }
       

}

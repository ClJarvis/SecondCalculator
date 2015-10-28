using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public static class Stack
    {
        public static string lastQuestion { get; set; }
        public static string last { get; set; }
       // public  string exit { get; set; }
       // public static void Exit { get; set; }
        public static char constant { get; set; }

        internal static string exit()
        {
            throw new NotImplementedException();
        }

        /*   public static void exit()
           {
               CancelEventArgs e;
           }
           */
       }
       

    }

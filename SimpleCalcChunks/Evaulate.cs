using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcChunks
{
    public class Evaulate

    {
        public string Evaluate(string input)

        {
            if (input.Contains("="))
            {
                {
                    Parse.ExtractCharacter();
                    Parse.ExtractValue();
                
            }
            }
            if (input == "lastq")
            {
                if (Stack.lastQuestion == null)
                {
                    return "No Operation entered";
                }
                return Stack.lastQuestion;
            }
            else if (input == "last")
            {
                if (Stack.lastQuestion == null)
                {
                    return "No Operation entered";
                }
                return Stack.last;
            }
            /////////////////////////////////////////////////EXIT ATTEMPT //////////////////////////////
            else if (input == "exit")
            {
                return "Bye Felica!!!!!(Evaulate Class message)";
            }
            else
            {
                Parse parse = new Parse();
                var operans = parse.GetNumbers(input);
                var op = parse.GetOperator(input);
                var result = 0;

                switch (op)
                {
                    case '+':
                        result = Addition.AddNum(operans);
                        break;
                    case '-':
                        result = Subtraction.SubNum(operans);
                        break;
                    case '*':
                        result = Multiplication.MultiplyNum(operans);
                        break;
                    case '/':
                        result = Division.DivideNum(operans);
                        break;
                    case '%':
                        result = Modulus.ModNum(operans);
                        break;
                    default:
                        throw new ArgumentException("incorrect format");
                }
                Stack.last = result.ToString();
                Stack.lastQuestion = input;
                return result.ToString();
            }
        }

    }
}

/*
 else if (input contains "=")  //////////////////////////////////////////////////////////////
              {
                Parse parse = new Parse();
               // var constant = parse.GetConstant(input); 
                
              //  Stack.constant = Convert.ToInt32(input[0]));
                
                Dictionary<string, int> 
                setValue = new Dictionary<string, int>();
                Dictionary<string, int> dict = new Dictionary<string, int>();
                ///Convert.ToInt32(input[1])
                setValue.Add("a", Convert.ToInt32(input[1]));
                setValue.Add("b", 7);
                setValue.Add("c", 9);
                setValue.Add("d", 10);

                // The Add method throws an exception if the new key is 
                // already in the dictionary.
                return input;
                try
                {
                    setValue.Add("a", 15);
                    Console.WriteLine("enter a number");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("An element with Key = \"a\" already exists.");
                }
            }


    ////////////////////////////////////////////////////////////////////////////////////////
     if (input.Contains("="))
            {
                Parse.ExtractCharacter();
                Parse.ExtractValue();
            }


*/

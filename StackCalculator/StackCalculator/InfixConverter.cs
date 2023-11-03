using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class InfixConverter
    {       
        public static string InfixToPostfix(string input)
        {
            Stack<string> operators = new Stack<string>();
            Stack<string> output = new Stack<string>();
            string postfix = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])) 
                {
                    output.Push(input[i].ToString());
                }
            }                     
            return postfix;
        }
    }
}

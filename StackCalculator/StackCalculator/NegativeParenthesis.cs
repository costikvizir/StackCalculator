using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class NegativeParenthesis
    {
        public static List<string> InsertZeros(this List<string> input)
        {
            string operators = "+-*/";
            bool flag = false;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == "-" && input[i + 1] == "(" && operators.Contains(input[i - 1]))
                {
                    input.Insert(i++, "(");
                    input.Insert(i, "0");
                    flag = true;
                }
                if (input[i] == ")" && flag)
                {
                    input.Insert(i, ")");
                    flag = false;
                }                    
            }
            return input;
        }
    } 
}

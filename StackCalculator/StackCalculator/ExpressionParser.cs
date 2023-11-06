using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class ExpressionParser
    {
        //extension method that takes a string arithmetic expression
        //as argument and returns a list containing all tokens
        public static List<string> SplitToList(this string input)
        {
            List<string> result = new List<string>();
            string temp = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                //If the indexed char is an operator add the temporary value(if is not empty)
                //to list and then add the indexed value 
                if (!char.IsDigit(input[i]))
                {
                    if (!(temp == string.Empty))
                        result.Add(temp);
                    result.Add(input[i].ToString());
                    temp = string.Empty;
                }
                else
                    temp += input[i].ToString();                                                     
            }
            return result;
        }
    }
}

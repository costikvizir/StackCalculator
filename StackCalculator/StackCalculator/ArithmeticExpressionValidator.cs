using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    //extension method to validate arithmetic expression 
    public static class ArithmeticExpressionValidator
    {
        public static bool IsValidExpression(this string input)
        {
            const string validCharacters = "0123456789+-*/()";

            foreach (char c in input)
                if (!validCharacters.Contains(c.ToString()))
                    return false;
            return true;
        }
    }
}

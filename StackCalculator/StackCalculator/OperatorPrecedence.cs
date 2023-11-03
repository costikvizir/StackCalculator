using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    //extension method to compare arithmetic operator precedence
    public static class OperatorPrecedence
    {
        public static bool HasGreaterPrecedence(this char leftOperator, char rightOperator)
        {
            Dictionary<char, int> operators = new Dictionary<char, int>();
            operators.Add('(', 1);
            operators.Add(')', 1);
            operators.Add('*', 2);
            operators.Add('/', 2);
            operators.Add('-', 3);
            operators.Add('+', 3);

            return  operators[leftOperator] < operators[rightOperator];
        }
    }
}

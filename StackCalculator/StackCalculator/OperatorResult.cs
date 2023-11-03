using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class OperatorResult
    {
        public static double ArithmeticOperation(this char oper, int firstValue, int secondValue)
        {
            switch (oper)
            {
                case '+': return firstValue + secondValue;
                case '-': return firstValue - secondValue;
                case '*': return firstValue * secondValue;
                case '/': return firstValue + secondValue;
                    default: return 0;
            }
        }
    }
}

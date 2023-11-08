using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class OperatorResult
    {
        public static double ArithmeticOperation(this char oper, double firstValue, double secondValue)
        {
            switch (oper)
            {
                case '+': 
                    return firstValue + secondValue;
                case '-': 
                    return secondValue - firstValue;
                case '*': 
                    return firstValue * secondValue;
                case '/':
                    return secondValue / firstValue;
                default:
                    throw new ArgumentException("Error!");
            }
        }
    }
}

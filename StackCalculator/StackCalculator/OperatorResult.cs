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
            if(firstValue == 0) 
            {
                throw new DivideByZeroException();
                //Console.WriteLine("Cannot Divide By Zero");
            }
            switch (oper)
            {
                case '+': return firstValue + secondValue;
                case '-': return secondValue - firstValue;
                case '*': return firstValue * secondValue;
                case '/': return (double)secondValue / firstValue;

                    default: return 0;
            }
        }
    }
}

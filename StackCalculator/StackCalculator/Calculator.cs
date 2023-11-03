using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class Calculator
    {
        public static double Eval(this string input)
        {
            Stack<double> values = new Stack<double>();
            int x, y;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    values.Push(input[i]);

                if (!char.IsDigit(input[i]))
                {
                    x = (int)values.Pop();
                    y = (int)values.Pop();
                    values.Push(input[i].ArithmeticOperation(x, y));
                }                   
            }
            return values.Pop();
        }
    }
}

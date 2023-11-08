using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class Calculator
    {
        //Compute an expression in reverse polish notation
        //The input is a list of tokens
        public static double Eval(this  List<string> stringList)
        {
            Stack<double> values = new Stack<double>();
            double x, y;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (int.TryParse(stringList[i], out _))
                    values.Push(double.Parse(stringList[i]));

                if (!int.TryParse(stringList[i], out _))
                {
                    x = values.Pop();
                    y = values.Pop();
                    values.Push(Convert.ToChar(stringList[i]).ArithmeticOperation(x, y));
                }                  
            }
            return values.Pop();
        }
    }
}

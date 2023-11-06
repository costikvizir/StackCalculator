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
            //List<string> stringList = input.SplitToList();
            List<string> strings = new List<string>();
            //2 4 / 5 6 - *  3 5 6 + */ 5 1 – 3 *//3 5 + 2 1 + −
            strings.Add("2");
            strings.Add("4");
            strings.Add("/");
            //strings.Add("5");
            //strings.Add("6");
            //strings.Add("-");
            //strings.Add("*");
            Stack<double> values = new Stack<double>();
            int x, y;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (int.TryParse(stringList[i], out _))
                    values.Push(double.Parse(stringList[i]));

                if (!int.TryParse(stringList[i], out _))
                {
                    x = (int)values.Pop();
                    y = (int)values.Pop();
                    values.Push(Convert.ToChar(stringList[i]).ArithmeticOperation(x, y));
                }                  
            }
            return values.Pop();
        }
    }
}

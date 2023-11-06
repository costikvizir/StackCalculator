using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal static class InfixConverter
    {       
        public static List<string> InfixToPostfix(this string input)
        {
            List<string> output = new List<string>();
            List<string> tokens = input.SplitToList();
            Stack<string> operators = new Stack<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                if (int.TryParse(tokens[i], out _))
                    output.Add(tokens[i]);

                // If the scanned character is an '(', push it to the stack.
                else if (tokens[i] == "(")
                {
                    operators.Push(tokens[i]);
                }

                // If the scanned character is an ')', pop and output
                // from the stack until an '(' is encountered.
                else if (tokens[i] == ")")
                {
                    while (operators.Count > 0
                           && operators.Peek() != "(")
                        output.Add(operators.Pop());

                    operators.Pop();
                }

                else
                {
                    while (operators.Count > 0
                        && Convert.ToChar(tokens[i]).HasGreaterPrecedence(Convert.ToChar(operators.Peek())))
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(tokens[i]);
                }

            }

            // Pop all the operators from the stack
            while (operators.Count > 0)
                output.Add(operators.Pop());

            return output;
        }
    }
}

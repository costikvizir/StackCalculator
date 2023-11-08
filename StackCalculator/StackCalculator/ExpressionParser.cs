﻿using System;
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
            int i = 0;

            if (input[0] == '-')
            {
                temp = input[0].ToString();
                i++;
            }
                
            for ( ; i < input.Length; i++)
            {
                if (input[i] == '-')
                {
                    result.Add(temp);
                    if(char.IsDigit(input[i + 1]) && char.IsDigit(input[i - 1]))
                    {
                        result.Add(input[i].ToString());
                        temp = string.Empty;
                    }
                    else if(!char.IsDigit(input[i + 1]))
                    {
                        result.Add(input[i].ToString());
                        temp = string.Empty;
                    }                       
                    else
                        temp += input[i];
                }
                else if(!char.IsDigit(input[i]))
                {
                    result.Add(temp);
                    result.Add(input[i].ToString());
                    temp = string.Empty;
                }
                else  
                    temp += input[i]; 
            }
            //If last token in the list is a number then is not assigned to temp variable
            if (char.IsDigit(input[^1]))
                result.Add(temp);

            //Remove empty strings
            List<string> output = new List<string>();

            foreach (var str in result) 
            {
                if(str != string.Empty)
                    output.Add(str);    
            }

            return output;
        }
    }
}

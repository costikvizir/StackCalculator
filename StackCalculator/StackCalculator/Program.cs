
using StackCalculator;
using System.Text.RegularExpressions;

string expression = Console.ReadLine() ?? "0";

//parse each operand and store in a data structure
string noSpaceExpr = expression.Replace(" ", "");

//Console.WriteLine(noSpaceExpr.IsValidExpression() ? noSpaceExpr : "Enter a valid expression");

//Console.WriteLine(noSpaceExpr.Eval());
//validate the expression

var strings = noSpaceExpr.InfixToPostfix();



var result = noSpaceExpr.InfixToPostfix().Eval();

Console.Write("The result is: ");

Console.WriteLine(result);





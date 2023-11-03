
using StackCalculator;
using System.Text.RegularExpressions;

string expression = Console.ReadLine() ?? "0";

//parse each operand and store in a data structure
string noSpaceExpr = expression.Replace(" ", "");

Console.WriteLine(noSpaceExpr.IsValidExpression() ? noSpaceExpr : "Enter a valid expression");
//validate the expression

List<string> arguments = new List<string>();
int x, y;
Stack<int> stack = new Stack<int>();

string str = "(4+3)*( 447 -124 )";

List<char> chars = str.ToCharArray().ToList();

List<string> tokens = new List<string>();

string temp = string.Empty;
//for (int i = 0; i < noSpaceExpr.Length; i++)
//{ 
//    if (!char.IsDigit(str[i]))
//    {
//        tokens.Add(temp);
//        tokens.Add(str[i].ToString());
//        temp = string.Empty;
//    }
//    temp += str[i];       
//}

//for (int i = 0; i < noSpaceExpr.Length; i++)
//{
//    temp += noSpaceExpr[i];
//    if (!char.IsDigit(str[i]))
//    {
//        tokens.Add(temp);
//        tokens.Add(str[i].ToString());
//        temp = string.Empty;
//    }
//}
//string val = noSpaceExpr;
//int count = 0;
//while (val.Length>0)
//{
//    temp += val[count];
//    if (!char.IsDigit(val[0]))
//    {
//        tokens.Add(str[0].ToString());
//        val.Remove(0, 1);
//        temp = string.Empty;
//        count = 0;
//    }
//    count++;
//    val.Remove(0, 1);
//}

//foreach (var item in tokens)
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(noSpaceExpr.Eval());
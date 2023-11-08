
using StackCalculator;
using System.Text.RegularExpressions;


string _val = string.Empty;
Console.Write("Enter expression to calculate: ");
ConsoleKeyInfo key;

do
{
    key = Console.ReadKey(true);
    if (key.Key != ConsoleKey.Backspace)
    {
        string chars = "0123456789+-*/()";

        if (chars.Contains(key.KeyChar))
        {
            _val += key.KeyChar;
            Console.Write(key.KeyChar);
        }
    }
    else
    {
        if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
        {
            _val = _val.Substring(0, (_val.Length - 1));
            Console.Write("\b \b");
        }
    }
}
// Stops Receving Keys Once Enter is Pressed
while (key.Key != ConsoleKey.Enter);

Console.WriteLine();

try
{
    var result = _val.InfixToPostfix().Eval();
    Console.Write($"The result is: {result}");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot Divide by Zero");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Enter a Valid Expression");
}
catch (InvalidOperationException)
{
    Console.WriteLine("Enter a Valid Expression");
}
Console.WriteLine();

var result2 = _val.SplitToList().InsertZeros();

foreach (var item in result2)
{
    Console.Write(item + " ");
}


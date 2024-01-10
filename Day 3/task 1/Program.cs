using task_1;

Calculator calculator = new Calculator(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

char operation = Convert.ToChar(System.Console.ReadLine());

if (operation == '+')
{
    System.Console.WriteLine(calculator.Sum());
}
else if (operation == '-')
{
    System.Console.WriteLine(calculator.Subtract());
}
else if (operation == '*')
{
    System.Console.WriteLine(calculator.Multiplication());
}
else if (operation == '/')
{
    System.Console.WriteLine(calculator.Division());
}
//try
//{
//    string? str = Console.ReadLine();
//    int num = int.Parse(str);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
////finally
////{

////}




while (true)
{
    Console.Clear();

    // read first number
    Console.WriteLine("please input the first number:");
    if (!int.TryParse(Console.ReadLine(), out int num1))
    {
        Console.WriteLine("the input value can not be parsed to an int number! \npress any key to start a new loop");
        Console.ReadKey();
        continue;
    }

    // read operator: +-*/%
    string[] validOperators = new string[] { "+", "-", "*", "/", "%" };
    Console.WriteLine("please input the operator:");
    string? op = Console.ReadLine();
    if (op == null || op.Length != 1 || !validOperators.Contains(op))
    {
        Console.WriteLine("the input value is not a valid operator! \npress any key to start a new loop");
        Console.ReadKey();
        continue;
    }

    // read second number
    Console.WriteLine("please input the second number:");
    if (!int.TryParse(Console.ReadLine(), out int num2))
    {
        Console.WriteLine("the input value can not be parsed to an int number! \npress any key to start a new loop");
        Console.ReadKey();
        continue;
    }

    // calculate
    Console.WriteLine($"the result is:");
    switch (op)
    {
        case "+":
            Console.WriteLine($"{num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"{num1 * num2}");
            break;
        case "/":
            Console.WriteLine($"{num1 / num2}");
            break;
        case "%":
            Console.WriteLine($"{num1 % num2}");
            break;
    }
    Console.WriteLine($"press any key to start a new loop");
    Console.ReadKey();
}


string str = "";
// read user input
Console.WriteLine(str);
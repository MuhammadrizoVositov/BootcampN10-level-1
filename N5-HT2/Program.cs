var againnst = "w".Contains("e");
while (againnst==false)
{
    Console.WriteLine("Enter first number :");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number :");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter operation ");
    var op = Console.ReadLine();

    switch (op)
    {
        case "+":
            num1 += num2;
            Console.WriteLine(num1);
            break;
        case "-":
            num1 -= num2;
            Console.WriteLine(num1);
            break;
        case "*":
            num1 *= num2;
            Console.WriteLine(num1);
            break;
        case "/":
            num1 /= num2;
            Console.WriteLine(num1);
            break;
        case "e":
            againnst = true; break;
        default:
            Console.WriteLine("Bunday buyruq mavjud emas");
            break;

    }
}
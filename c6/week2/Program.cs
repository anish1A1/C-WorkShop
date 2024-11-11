

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operation;

        Console.WriteLine("Simple Calculator in C#");

        //Get the first number
        Console.Write("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.Write("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.WriteLine("Enter the operation you want to do : + , -, /, *  :");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"The sum of {num1} + {num2} is {num1 + num2}");
                break;

            case "*":
                Console.WriteLine($"The product of {num1} * {num2} is {num1 * num2}");
                break;

            case "/":
                if (num2 != 0)
                {
                    Console.WriteLine($"The division of {num1} / {num2} is {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            case "-":
                Console.WriteLine($"The difference of {num1} - {num2} is {num1 - num2}");
                break;

            default:
                Console.Write("Invalid operation. Please enter one of the following: +, -, *, /");
                break;
        }


        //Using Big Int Value (maximum Value of Integer.)

        try
        {
            checked
            {
                int x = int.MaxValue;
                Console.WriteLine('\n');
                Console.WriteLine($"Initial value of x: {x}");
                x++;
                Console.WriteLine($"Value of x after increment: {x}");
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("An overflow exception occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

             
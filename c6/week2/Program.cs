
class Program{

    static void Main(string[] args)
    {
        double num1, num2;
        string operation;

        Console.WriteLine("Simple Calculator in C#");

        //Get the first number
        Console.Write("Enter the first number:");

        //user can give int numbers so converting into Double value
        num1 = Convert.ToDouble(Console.ReadLine());
        

        Console.Write("Enter the second number:");

        //user can give int numbers so converting into Double value
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation you want to do : + , -, /, *  :");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
            Console.WriteLine($"The sum of {num1} + {num2} is {num1 + num2}");
            break;

            case "*":
            Console.WriteLine($"The mul of {num1} * {num2} is {num1 * num2}");
            break;

            case "/":
            Console.WriteLine($"The div of {num1} / {num2} is {num1 / num2}");
            break;

            case "-":
            Console.WriteLine($"The sub of {num1} - {num2} is {num1 - num2}");
            break;

            default:
            Console.WriteLine("Enter value as described");
            break;
        }


        try
        {
            checked  //a keyword
            {
                int x =int.MaxValue -1;
                Console.WriteLine($"Initia")
            }
        }
        catch (System.Exception)
        {
            
            throw;
        }

    }


}
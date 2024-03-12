using CalculatorLibrary;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            bool validChoice = false;
            int choice = 0;

            while (!validChoice)
            {
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");

                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                }
            }

            Console.WriteLine("Enter two numbers separated by space:");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length != 2 || !int.TryParse(input[0], out int a) || !int.TryParse(input[1], out int b))
            {
                Console.WriteLine("Invalid input. Please enter two valid integers separated by space.");
                return;
            }

            int result;
            switch (choice)
            {
                case 1:
                    result = calculator.Add(a, b);
                    Console.WriteLine($"Result of addition: {result}");
                    break;
                case 2:
                    result = calculator.Subtract(a, b);
                    Console.WriteLine($"Result of subtraction: {result}");
                    break;
                case 3:
                    result = calculator.Multiply(a, b);
                    Console.WriteLine($"Result of multiplication: {result}");
                    break;
                case 4:
                    try
                    {
                        result = calculator.Divide(a, b);
                        Console.WriteLine($"Result of division: {result}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
            }
        }
    }
}

using System.Threading.Channels;

namespace ConditionalBasedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number:");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            int result = 0;

            switch(operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                        break;
                default:
                    Console.WriteLine("Operation not supported!");
                    break;
            }

            Console.WriteLine($"The result is {result}");
            Console.ReadKey();

        }
    }
}

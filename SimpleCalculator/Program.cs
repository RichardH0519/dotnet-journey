namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }
}

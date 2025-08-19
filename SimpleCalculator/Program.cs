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

            Console.WriteLine($"Result: {firstNumber + secondNumber}");

            Console.ReadKey();
        }
    }
}

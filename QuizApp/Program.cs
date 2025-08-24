namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question1 = "What is the capital of Vietnam?";
            string answer1 = "Ha Noi";

            string question2 = "What is 2+5?";
            string answer2 = "7";

            string question3 = "What color do you get by mixing blue and yellow?";
            string answer3 = "Green";

            int score = 0;

            Console.WriteLine(question1);
            string userAnswer1 = Console.ReadLine();
            if (userAnswer1.Trim().Equals(answer1, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {answer1}");
            }

            Console.WriteLine(question2);
            string userAnswer2 = Console.ReadLine();
            if (userAnswer2.Trim().Equals(answer2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {answer2}");
            }

            Console.WriteLine(question3);
            string userAnswer3 = Console.ReadLine();
            if (userAnswer3.Trim().Equals(answer3, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {answer3}");
            }

            Console.WriteLine($"Your score is {score}");
            Console.ReadKey();

        }
    }
}

namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine($"The average temperature is {CalculateAverage(temperature)}");
            Console.WriteLine($"The most common condition is {MostCommonCondition(weatherConditions)}");

            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            Dictionary<string, int> conditionCount = new Dictionary<string, int>();
            foreach (string condition in conditions)
            {
                if (conditionCount.ContainsKey(condition))
                {
                    conditionCount[condition]++;
                }
                else
                {
                    conditionCount[condition] = 1;
                }
            }

            string mostCommon = null;
            int maxCount = 0;
            foreach (var pair in conditionCount)
            {
                if (pair.Value > maxCount)
                {
                    mostCommon = pair.Key;
                    maxCount = pair.Value;
                }
            }
            return mostCommon;
        }

        static double CalculateAverage(int[] temperature)
        {
            int sum = 0;
            foreach (int temp in temperature)
            {
                sum += temp;
            }

            double average = sum / temperature.Length;

            return average;
        }
    }
}

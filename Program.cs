namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days you want to simulate.");
            int days = int.Parse(Console.ReadLine());
            int[] temperatures = new int[days];
            string[] conditions = ["Sunny", "Cloudy", "Rainy", "Snowy"];
            string[] weatherConditions = new string[days];
            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            double averageTemperature = CalculateAverageTemperature(temperatures);
            Console.WriteLine($"The average temperature is {averageTemperature}");
            Console.WriteLine("The max temperature is "+ temperatures.Max());
            Console.WriteLine("The min temperature is " + temperatures.Min());
            Console.WriteLine("The min temperature is " + MinTemp(temperatures));

            Console.ReadKey();
            static double CalculateAverageTemperature(int[] temperatures) {
                int totalTemp = 0;
                foreach (int temp in temperatures)
                {
                    totalTemp += temp;
                }
                return ((Double)totalTemp / temperatures.Length);
            }
            static int MinTemp(int[] temperatures) { 
                int min = temperatures[0];
                foreach (int temp in temperatures)
                {
                    if (temp < min) { 
                    min = temp;
                    }
                }
                return min;
            }
        }
    }
}

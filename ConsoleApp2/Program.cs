namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Мой Трекер Активности ===");
            Console.WriteLine("Каждый шаг отдаляет меня от прошлого и приближает к цели.");
            Console.WriteLine();

            Console.Write("Сколько шагов Вы прошли сегодня? ");
            string inputSteps = Console.ReadLine();
            int steps = Convert.ToInt32(inputSteps);

            double stepLengthMeters = 0.7;
            double distanceMeters = steps * stepLengthMeters;
            double distanceKm = distanceMeters / 1000;

            double caloriesBurned = steps * 0.04;

            double distanceKmRounded = Math.Round(distanceKm, 2);
            double caloriesRounded = Math.Round(caloriesBurned, 0);


            Console.WriteLine();
            Console.WriteLine("--- Результаты дня ---");
            Console.WriteLine($"Пройдено расстояние: {distanceKmRounded} км");
            Console.WriteLine($"Сожжено энергии: {caloriesRounded} ккал");

            Console.WriteLine();
            Console.WriteLine("Ты управляешь своей жизнью. До завтра!");
            Console.ReadKey();
        }
    }
}

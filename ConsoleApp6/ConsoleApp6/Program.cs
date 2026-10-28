namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = startValue; i <= endValue; i++)
            {
                if (i < 2) continue;
                if (i == 2) { sum += i; continue; }
                if (i % 2 == 0) continue;
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) isPrime = false;
                }
                if (isPrime)
                {
                    sum += i;
                }

            }
            Console.WriteLine($"Сумма простых чисел = {sum}");
        }
    }
}

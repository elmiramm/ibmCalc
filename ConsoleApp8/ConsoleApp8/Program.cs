namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(" ");
            int[] numbers = new int[arr.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Наименьшее значение = {min}");
            Console.WriteLine($"Наибольшее значение = {max}");
        }
    }
}

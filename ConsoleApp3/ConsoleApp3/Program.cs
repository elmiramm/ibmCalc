namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Среднее арифметическое, сумма и произведение двух чисел=====");

            int num1, num2;

            try
            {
                Console.Write("Введите первое число: ");
                num1 = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.Write("Введено не число\n");
                num1 = 0;
            }

            try
            {
                Console.Write("Введите второе число: ");
                num2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Введено не число\n");
                num2 = 0;
            }

            Console.WriteLine("Что нужно вывести: \n1 - сумму чисел; \n2 - произведение чисел; \n3 - среднее арифметическое чисел;");
            Console.WriteLine("Введите 1, 2 или 3: ");
            int inputNum = int.Parse(Console.ReadLine());

            switch (inputNum)
            {
                case 1: 
                    Console.WriteLine($"Сумма чисел {num1} и {num2}: {num1 + num2}");
                    break; 
                case 2:
                    Console.WriteLine($"Произведение чисел {num1} и {num2}: {num1 * num2}");
                    break;
                case 3:
                    double average = (double)(num1 + num2) / 2;
                    Console.WriteLine($"Среднее арифметическое чисел {num1} и {num2}: {average}");
                    break;
                default:
                    Console.WriteLine("Ошибка! Вы ввели неверное число.");
                    break;

            }

        }
    }
}

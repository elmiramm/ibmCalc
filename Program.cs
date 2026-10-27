namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Добро пожаловать в калькулятор здоровья! ===");
            Console.WriteLine("Давай сделаем первый шаг к новой форме");
            Console.WriteLine();

            Console.Write("Введите ваш рост в сантиметрах (например, 168): ");
            double heightSm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах (например, 81): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double heightMeters = heightSm / 100;
            double bmi = weight / (heightMeters * heightMeters);

            double bmiRounded = Math.Round(bmi, 1);

            Console.WriteLine();
            Console.WriteLine($"Ваш Индекс Массы Тела (ИМТ) равен: {bmiRounded}");

            if (bmiRounded < 18.5)
            {
                Console.WriteLine("Статус: Дефицит массы тела. Нужно чуть больше кушать.");
            }
            else if (bmiRounded >= 18.5 && bmiRounded < 25)
            {
                Console.WriteLine("Статус: Нормальный вес. Отличный результат, так держать!");
            }
            else if (bmiRounded >= 25 && bmiRounded < 30)
            {
                Console.WriteLine("Статус: Избыточная масса тела. Ничего страшного, это легко скорректировать прогулками и питанием!");
            }
            else
            {
                Console.WriteLine("Статус: Ожирение. Время позаботиться о своем здоровье и бережно снизить нагрузку.");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть программу...");
            Console.ReadKey();
        }
    }
}




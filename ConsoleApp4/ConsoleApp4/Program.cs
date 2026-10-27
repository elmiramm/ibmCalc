namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("===== Генератор Геометрии =====");
            Console.WriteLine();

          
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("\nРисуем ваш прямоугольник:\n");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nПрямоугольник по контуру\n");

            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(i == 0 || i + 1 == height || j == 0 || j + 1 == width )
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}

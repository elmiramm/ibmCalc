using System.Globalization;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = new Matrix();
            A.Read();

            var B = new Matrix();
            B.Read();

            A.Sum(B);
            A.Write();
        }
    }

    public class Matrix
    {
        public double[,] data;
        public int rows;
        public int cols;

        public void Read()

        {
            Console.WriteLine("Введите размер матрицы m * n через пробел");
            string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            rows = int.Parse(size[0]);
            cols = int.Parse(size[1]);
            data = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Введите {cols} значений через пробел");
                string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = double.Parse(line[j], CultureInfo.InvariantCulture);
                }
            }

        }
        public void Sum(Matrix B)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = data[i, j] + B.data[i, j];
                }
            }
        }


        public void Write()
        {
            Console.WriteLine("Результирющая матрица:");
            for (int i = 0; i < rows; i++)
            {
                string[] rowElements = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowElements[j] = data[i, j].ToString(CultureInfo.InvariantCulture);
                }
                Console.WriteLine(string.Join(" ", rowElements));
            }
        }

    }
}

using System.Globalization;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var A = new Matrix();
                A.Read();

                var B = A.Transpose();

                B.Write();
            }
        }
        public class Matrix
        {
            public double[,] data;
            public int rows;
            public int cols;

            public void Read()
            {
                string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                rows = int.Parse(size[0]);
                cols = int.Parse(size[1]);
                data = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < cols; j++)
                    {
                        data[i, j] = double.Parse(line[j], CultureInfo.InvariantCulture);
                    }
                }

            }

            public Matrix Transpose()
            {
                Matrix C = new Matrix();
                C.rows = this.cols;
                C.cols = this.rows;
                C.data = new double[C.rows, C.cols];

                for (int i = 0; i < C.rows; i++)
                {
                    for (int j = 0; j < C.cols; j++)
                    {
                        C.data[i, j] = this.data[j, i];
                    }
                }
                return C;
            }

            public void Write()
            {

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
}

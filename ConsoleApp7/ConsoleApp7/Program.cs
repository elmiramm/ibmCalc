namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int starCount = 1;
            int spaceCount = height - 1;

            for (int i = 0; i < height; i++) {
                for(int j = 0; j < spaceCount; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < starCount; j++)
                {
                    Console.Write("*");
                }
                starCount += 2;
                spaceCount--;

                Console.WriteLine();
            }
        }
    }
}

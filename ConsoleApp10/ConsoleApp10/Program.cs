namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(" ");
            int[] numbArr = new int[arr.Length];

            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = int.Parse(arr[i]);
            }

            int counter = numbArr.Length - 1;

            while (counter > 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (numbArr[i] > numbArr[i + 1]) (numbArr[i], numbArr[i + 1]) = (numbArr[i + 1], numbArr[i]);
                }
                counter--;
            }

            Console.WriteLine(string.Join(" ", numbArr));
        }
    }
}

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int first = numbArr[0];
            int last = numbArr[numbArr.Length - 1];

            List<int> list = new List<int>();
            List<int> numbList = numbArr.ToList();

            for (int i = first; i < last; i++)
            {
                if (numbList.IndexOf(i) == -1)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

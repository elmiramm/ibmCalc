namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            list.RemoveAll(item => item.Contains('1'));

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

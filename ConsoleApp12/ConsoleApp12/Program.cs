namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>(1);
            int capacity = list.Capacity;

            Console.WriteLine($"new List<double>(1) : {capacity}"); // 1


            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            capacity = list1.Capacity;

            Console.WriteLine($"new List<int>() {{ 1, 2, 3, 4, 5 }} : {capacity}"); //8


            var list2 = new List<char>() { 'q', 'r' };
            capacity = list2.Capacity;
            Console.WriteLine($"new List<char>() {{'q','r'}} : {capacity}"); //4


            var array = new string[] { "Миша", "Витя", "Паша" };
            var list3 = new List<string>(array);
            capacity = list3.Capacity;
            Console.WriteLine($"new List<string>(array) : {capacity}"); //3

            var array1 = new string[] { "Миша", "Витя", "Паша" };
            var list4 = new List<string>(array1);
            list4.Clear();
            capacity = list4.Capacity;
            Console.WriteLine($" list4.Clear() : {capacity}"); //3

            var list5 = new List<int>();
            capacity = list5.Capacity;
            Console.WriteLine($"var list5 = new List<int>(); : {capacity}"); //0

            var list6 = new List<int>();
            for (int i = 0; i < 10; i++)
                list6.Add(i);
            capacity = list6.Capacity;
            Console.WriteLine($"new List<int>() : {capacity}"); //16

            var list7 = new List<int>(5) { 1, 2, 3 };
            list7.RemoveAt(0);
            capacity = list7.Capacity;
            Console.WriteLine($"new List<int>(5) {{ 1, 2, 3 }} : {capacity}"); //5
        }
    }
}

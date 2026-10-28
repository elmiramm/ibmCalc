namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int x = int.Parse(line);

            int y = x; //для третьего способа

            string[] hexArray = Enumerable.Range(1, x).Select(i => i.ToString("x")).ToArray();
            string answer1 = hexArray[hexArray.Length - 1];

            Console.WriteLine(answer1);

            //второй способ 

            string[] hexArray2 = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f"];

            string answer = "";

            if (x == 0)
            {
                answer = "0";
            }

            while (x != 0)
            {
                int ind = x % 16;
                answer = hexArray2[ind] + answer;
                x = x / 16;
            }


            Console.WriteLine(answer);

            //третий способ

            string answer3 = Convert.ToString(y, 16);


            Console.WriteLine(answer3);
        }
    }
}

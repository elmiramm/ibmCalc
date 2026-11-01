namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hourHandAmount = 300;
            int[] vasyaArray = { 2, 3, -1, -50 };
            AhShitHereWeGoAgain(vasyaArray, hourHandAmount);
      
        }

        public static void AhShitHereWeGoAgain(int[] vasyaArray, int hourHandAmount)
        {
            int[] arr = new int[vasyaArray.Length + 1];
            arr[0] = 0;
            int min = 0;

            for (int i = 0; i < vasyaArray.Length; i++)
            {
                arr[i + 1] = arr[i] + vasyaArray[i];
                if (arr[i + 1] < min)
                { 
                    min = arr[i + 1];
                }
            }

            arr[0] = hourHandAmount - min;
            for (int i = 0; i < vasyaArray.Length; i++)
            {
                arr[i + 1] = arr[i] + vasyaArray[i];
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

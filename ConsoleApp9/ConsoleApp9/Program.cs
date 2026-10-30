namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardNumber = Console.ReadLine(); // "1234"
            char[] arr = cardNumber.ToCharArray(); //массив символов цифр - ['1', '2', '3', '4']
            int[] numbArr = new int[arr.Length + 2]; // массив для чисел [4, 3, 2, 1, max, min]

            // устанавливаем в качестве мин и макс числовое (!не символьное) значение первого элемента массива
            // если из символа числа (например '4') отнять символ нуля: '0', то получим значение 4 (то есть саму цифру)
            // '4' - '0' = 52 - 48
            // если использовать приведение типов (int)symbol, то C# вернет не саму цифру, а её код из таблицы Юникод
            // (например, для символа '4' код будет 52, для '0' - 48).
           
            int min = arr[0] - '0'; 
            int max = min;

            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            {
                numbArr[i] = arr[j] - '0';
                if (numbArr[i] < min) min = numbArr[i];
                if (numbArr[i] > max) max = numbArr[i];
            }

            numbArr[numbArr.Length - 2] = max;
            numbArr[numbArr.Length - 1] = min;

            for (int i = 0; i < numbArr.Length; i++)
            {
                Console.Write(numbArr[i]);
            }
        }
    }
}

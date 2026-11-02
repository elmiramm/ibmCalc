namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Автоматически сортирует ключи (символы) по алфавиту
            SortedDictionary<char, List<int>> cipher = new SortedDictionary<char, List<int>>();

            // Собираем индексы для каждого символа
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (!cipher.ContainsKey(ch))
                {
                    cipher[ch] = new List<int>();
                }

                cipher[ch].Add(i);
            }

            // Формируем финальную строку
            List<string> resultParts = new List<string>();

            foreach (var pair in cipher)
            {
                // Берем символ
                resultParts.Add(pair.Key.ToString());

                // Добавляем все его индексы (они уже идут по возрастанию из-за цикла)
                foreach (int index in pair.Value)
                {
                    resultParts.Add(index.ToString());
                }
            }

            // Выводим всё через пробел
            Console.WriteLine(string.Join(" ", resultParts));
        }
    }
}

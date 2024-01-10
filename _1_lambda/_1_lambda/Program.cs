namespace _1_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę osób: ", 0, int.MaxValue);
            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imię osoby {i + 1}:");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}:", 0, 150);


            }
            List<string> namesWithA = names.Where(name => name.StartsWith("A")).ToList();

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(namesWithA[i], ages[i]);
                }
            }

            Console.WriteLine("Tablica imion i wieków: ");

            foreach (string name in adults.Keys)
            {
                Console.WriteLine(name);
            }
        }

        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj niepusty ciąg znaków");
                };
            } while (string.IsNullOrEmpty(result));
            return result;
        }

        static int ReadInt(string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczbę z zakresu {low} - {high}");
                }
            } while (!valid);
            return result;
        }
    }
}

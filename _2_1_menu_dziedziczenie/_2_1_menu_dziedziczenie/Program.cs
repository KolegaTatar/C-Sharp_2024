using _2_1_menu_dziedziczenie.classes;
using System.Linq.Expressions;

namespace _2_1_menu_dziedziczenie
{
    internal class Program
    {
        public static List<Person> users = new List<Person>();
        static void Main(string[] args)
        {
            int option = 0;

            while (option !=4)
            {
                option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        DisplayUsers();
                        break;
                    case 3:
                        users.Clear();
                        Console.WriteLine("Wszyscy użytkownicy zostali usunięci\n");
                        break;
                    case 4:
                        Console.WriteLine("\n\nKoniec programu\n\n");
                        break;
                    default:
                        Console.WriteLine("\nNieprawidłowa opcja. SPRÓBÓJ PONOWNIE\n");
                        break;
                }
            }

        }

        public static int DisplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("   - - -   MENU   - - -   ");
            Console.WriteLine("Program do zarządzania użytkownikami\n");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Wyświetl użytkowniów");
            Console.WriteLine("3. Usuń wszystkich użytkowników");
            Console.WriteLine("4. Wyjdź z programu");

            Console.Write("\nWybierz opcję: ");
            return int.Parse( Console.ReadLine() );

        }

        public static void AddUser()
        {
            Console.Write("Podaj imię użytkownika: ");
            string name = Console.ReadLine();
            Console.Write("Podaj nazwisko użytkownika: ");
            string surname = Console.ReadLine();
            Console.Write("Podaj datę urodzenia (RRRR-MM-DD): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Person user = new Person(name, surname, dateOfBirth);
            users.Add(user);

            Console.WriteLine("\nUżytkownik {0} {1} został dodany\n", name, surname);
        }

        public static void DisplayUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("\nNie ma żadnych użytkowników\n");
            }
            else
            {
                Console.WriteLine("\nLista użytkowników: ");
                foreach (Person user in users)
                {
                    Console.WriteLine($"imię {user.Name} nazwisko {user.Surname}, data urodzenia: {user.DateOfBirth}\n");
                }
            }

        }
    }
}

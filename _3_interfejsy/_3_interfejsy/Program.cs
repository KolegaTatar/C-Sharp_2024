using _3_interfejsy.classes;

namespace _3_interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book("Hobbit1", "Nowak", 1937, 45.99));
            books.Add(new Book("Hobbit2", "Pawlak", 2000, 145.99));
            books.Add(new Book("Hobbit3", "Arbuz", 2000, 5.99));
            books.Add(new Book("Hobbit4", "Arbuz", 1948, 45.99));


            Console.WriteLine("Lista książek: ");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            

            Console.WriteLine("\nPosortowane książki według ceny");
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }


            Console.WriteLine("\nPosortowane książki według daty publikacji");
            var shortedByYear = books.OrderBy(e =>e.YearOfPublication).ToList();
            foreach (Book book in shortedByYear)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nPosortowane książki według daty publikacji od końca");
            var shortedByYear_end_to_first = books.OrderByDescending(e => e.YearOfPublication).ToList();
            foreach (Book book in shortedByYear_end_to_first)
            {
                Console.WriteLine(book);
            }



            Console.WriteLine("\nPosortowane książki według autor publikacji");
            var shortedByAuthor = books.OrderBy(e => e.Author).ToList();
            foreach (Book book in shortedByAuthor)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nPosortowane książki według ceny nierosnąco, a następnie według roku publikacji od najstarszej ksiązki:");
            var shortedByPriceAndYeaar = books.OrderByDescending(e => e.Price).ThenBy(e =>e.YearOfPublication);
            foreach (Book book in shortedByPriceAndYeaar)
            {
                Console.WriteLine(book);
            }
            Console.ReadLine();


        }
    }
}

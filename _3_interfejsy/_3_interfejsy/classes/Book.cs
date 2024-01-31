using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_interfejsy.classes
{
    internal class Book: IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public ushort YearOfPublication { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, ushort year, double price)
        {
            Title = title;
            Author = author;
            YearOfPublication = year;
            Price = price;
        }

        public int CompareTo(Book? other)
        {
            if(other == null) return 1; // musi być int bo zwraca 0,1 lub -1
            return Price.CompareTo(other.Price);
        }

        
        public override string ToString()
        {
            return $"{Title}, {Author}, {YearOfPublication}, {Price}zł";
           
        }

   

    }
}

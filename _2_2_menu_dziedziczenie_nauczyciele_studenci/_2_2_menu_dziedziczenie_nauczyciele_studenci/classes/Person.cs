using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_menu_dziedziczenie_nauczyciele_studenci.classes
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public byte Age
        {
            get
            {
                TimeSpan difference = DateTime.Now - DateOfBirth;
                return (byte)(difference.Days / 365.25); // właściwość wiek
            }
        }

        public Adress Adress { get; set; }

        public Person(string name, string surname, DateTime dateofbirth, Adress adress)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateofbirth;
            Adress = adress;
        }

        public Person(string? name, string? surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public string GetFullName()
        {
            return ($"{Name} {Surname}");

        }
    }
}

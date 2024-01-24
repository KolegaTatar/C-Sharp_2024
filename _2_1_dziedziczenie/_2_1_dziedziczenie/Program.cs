using System;

namespace _2_1_dziedziczenie
{
    internal class Program
    {
        class Adress
        {
            public string City { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string PostalCode { get; set; }

            public Adress(string city, string street, string housenumber, string postalcode)
            {
                City = city;
                Street = street;
                HouseNumber = housenumber;
                PostalCode = postalcode;
            }
            public Adress() { }
        }
        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; } 

            public byte Age
            {
                get
                {
                    TimeSpan difference = DateTime.Now - DateOfBirth;
                    return (byte)(difference.Days/365.25); // właściwość wiek
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

            public string GetFullName()
            {
                return($"{Name} {Surname}");

            }
        }

        class Student:Person
        {
            public string StudentNumber { get; set; }
            public Student(string name, string surname, DateTime dateofbirth, Adress adress , string studentNumber) : base(name, surname, dateofbirth, adress)
            {
                StudentNumber = studentNumber;
            }
        }

        class Teacher : Person
        {
            public List<string> Subjects = new List<string>();

            public Teacher(string name, string surname, DateTime dateofbirth, Adress adress, List<string> subjects) : base(name, surname, dateofbirth, adress)
            {
                Subjects = subjects;
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person("Adam", "Suszek", new DateTime(1984, 1, 16), /*rok miesiąc dzień, */ new Adress("Poznań", "Polna", "1c/4", "11-222" /*muszą być "" zamiast '' bo to string a nie char*/));
            Console.WriteLine($"Imię: {p1.Name} nazwisko: {p1.Surname}, data urodzenia {p1.DateOfBirth.ToShortDateString()}\nAdress: {p1.Adress.City} ulica: {p1.Adress.Street} {p1.Adress.HouseNumber}, kod pocztowy: {p1.Adress.PostalCode}\n\n");

            Student s1 = new Student("Anna", "Kowal", new DateTime(1994, 2, 12), new Adress("Kraków", "Szkolna", "4d", "45-231"), "12345");
            Console.WriteLine($"Imię: {s1.Name} nazwisko: {s1.Surname}, data urodzenia {s1.DateOfBirth.ToShortDateString()}\nAdress: {s1.Adress.City} ulica: {s1.Adress.Street} {s1.Adress.HouseNumber}, kod pocztowy: {s1.Adress.PostalCode}, indeks: {s1.StudentNumber}\n\n");

            Teacher t1 = new Teacher("Jakub", "Nowacki", new DateTime(1977, 5, 23), new Adress("Olsztyn", "Miła", "67d", "42-236"),new List<string>() {"Matematyka","Informatyka","Geografia"});
            Console.WriteLine($"Imię: {t1.Name} nazwisko: {t1.Surname}, data urodzenia {t1.DateOfBirth.ToShortDateString()}\nAdress: {t1.Adress.City} ulica: {t1.Adress.Street} {t1.Adress.HouseNumber}, kod pocztowy: {t1.Adress.PostalCode}, Przedmioty: {string.Join(", ", t1.Subjects)}\n\n");  /*Join to taki foreach, pierwszy parametr oznacza co ma wstawić między elemenatmi dizelonymi a drugi, na czym ma to zadziałać*/
            Console.ReadKey();
        }
    }
}

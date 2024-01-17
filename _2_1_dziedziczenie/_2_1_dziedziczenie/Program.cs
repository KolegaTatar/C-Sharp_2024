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

            Console.WriteLine($"Imię: {p1.Name} nazwisko: {p1.Surname}, data urodzenia {p1.DateOfBirth.ToShortDateString()}\nAdress: {p1.Adress.City} ulica: {p1.Adress.Street} {p1.Adress.HouseNumber}, kod pocztowy: {p1.Adress.PostalCode}");

            Console.ReadKey();
        }
    }
}

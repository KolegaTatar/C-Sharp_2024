using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_menu_dziedziczenie_nauczyciele_studenci.classes
{
    internal class Student:Person
    {
        public string StudentNumber { get; set; }
        public Student(string name, string surname, DateTime dateofbirth, Adress adress, string studentNumber) : base(name, surname, dateofbirth, adress)
        {
            StudentNumber = studentNumber;
        }
    }
}

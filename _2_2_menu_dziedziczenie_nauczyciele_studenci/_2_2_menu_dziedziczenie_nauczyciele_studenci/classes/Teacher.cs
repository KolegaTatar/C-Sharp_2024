using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_menu_dziedziczenie_nauczyciele_studenci.classes
{
    internal class Teacher:Person
    {
        public List<string> Subjects = new List<string>();

        public Teacher(string name, string surname, DateTime dateofbirth, Adress adress, List<string> subjects) : base(name, surname, dateofbirth, adress)
        {
            Subjects = subjects;
        }
    }
}

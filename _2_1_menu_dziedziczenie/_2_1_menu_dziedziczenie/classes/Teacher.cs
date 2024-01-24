using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_menu_dziedziczenie.classes
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

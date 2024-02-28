using System.Diagnostics.Tracing;

namespace _4_2_delegaty
{
    delegate bool Logic(bool a, bool b);
    internal class Program
    {
        static bool Add(bool a, bool b)
        {
            return a && b;
        }
        static bool Or(bool a, bool b) 
        {
            return a || b;
        }
        static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }
        static bool Not(bool a, bool b)
        {
            return !a;
        }

        static void DisplayResult(Logic logic,bool a, bool b)
        {
            try
            {
                bool result = logic(a,b);
                Console.WriteLine($"Rezultat  {logic.Method.Name} {a}, {b} wynosi {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static bool GetBoolFromUser()
        {
            while (true)
            {
                Console.WriteLine("Wprowadz wartość boolowską  (true or false):");
                string inpput  = Console.ReadLine();
                bool val;
                if(bool.TryParse(inpput, out val))
                {
                    return val;
                }
                else
                {
                    Console.Write("\"Nieprawidłowe dane., Wprowadz wartość boolowską  (true or false):");
                    inpput = Console.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            bool x = GetBoolFromUser();
            bool y = GetBoolFromUser();

            Logic adding = new Logic(Add);
            Logic oring = new Logic(Or);
            Logic xoring = new Logic(Xor);
            Logic noting = new Logic(Not);

            DisplayResult(adding, x, y);
            DisplayResult(oring, x, y);
            DisplayResult(xoring, x, y);
            DisplayResult(noting, x, y);
        }
    }
}

namespace _5_1_1_zdarzenia
{
    // definicja delegatów
    public delegate void MessageHandler(string message, int prioryty);

    // klasa wydawcy 
    public class Publisher
    {
        //deklaracja zdarzenia 
        public event MessageHandler MessageEvent;

        //metoda która wywołuje zdarzenia 
        public void SendMessage(string message, int prioryty)
        {
            // sprawdzenie czy zdarzenie ma subskrybentów

            if (MessageEvent != null)
            {
                // wywołanie zdarzenia
                MessageEvent(message, prioryty);
            }
        }
    }


    // klasa subskrybetna 
    public class Subscriber
    {
        public int Threshold { get; set; }
        public string Name { get; set; }
        public Subscriber(int threshold, string name)
        {
            Threshold = threshold;
            Name = name;
        }

        // metoda obsługi zdarzenia

        public void OnMessageReceived(string message, int prioryty)
        {
            if(prioryty  <= Threshold)
            {
                Console.WriteLine("{0} otrzymał wiadomości: {1} o piorytecie {2}", Name, message, prioryty);
            }
            else
            {
                Console.WriteLine("{0} nie otrzymał wiadomości: {1} o piorytecie {2}", Name, message, prioryty);
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // utworzenie obiektów wydawcy i subskrybenta
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber(3,"Subskrybent 1");
            Subscriber sub2 = new Subscriber(4,"Subskrybent 2");

            //subskrybcja zdarzenia
            pub.MessageEvent += sub1.OnMessageReceived;
            

            //wywołanie metody która wysyła zdarzenie   
            pub.SendMessage("Pierwsza wiadomość",1);

            pub.MessageEvent += sub2.OnMessageReceived;
            pub.SendMessage("Druga wiadomość", 1);
            pub.SendMessage("Trzecia wiadomość", 3);
            pub.SendMessage("Czwarta wiadomość", 4);
            pub.SendMessage("Piąta wiadomość", 5);

            sub2.Threshold = 5;
            pub.SendMessage("Szósta wiadomość", 5);


            //anulowanie subskrybcji zdarzenia 

            Console.ReadKey();
        }
    }

}

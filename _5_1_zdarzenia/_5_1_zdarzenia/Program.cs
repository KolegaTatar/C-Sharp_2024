namespace _5_1_zdarzenia
{
    // definicja delegatów
    public delegate void MessageHandler(string message);

    // klasa wydawcy 
    public class Publisher
    {
        //deklaracja zdarzenia 
        public event MessageHandler MessageEvent;

        //metoda która wywołuje zdarzenia 
        public void SendMessage(string message)
        {
            // sprawdzenie czy zdarzenie ma subskrybentów

            if(MessageEvent != null)
            {
                // wywołanie zdarzenia
                MessageEvent(message);
            }
        }
    }


    // klasa subskrybetna 
    public class Subscriber
    {
        // metoda obsługi zdarzenia
        
        public void OnMessageReceived( string message )
        {
            Console.WriteLine("Otrzymałem wiadomość: {0} ", message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // utworzenie obiektów wydawcy i subskrybenta
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //subskrybcja zdarzenia
            publisher.MessageEvent += subscriber.OnMessageReceived;

            //wywołanie metody która wysyła zdarzenie   
            publisher.SendMessage("Pierwsza wiadomość");
            publisher.SendMessage("Druga wiadomość");
            publisher.SendMessage("Trzecia wiadomość");


            //anulowanie subskrybcji zdarzenia 
            publisher.MessageEvent -= subscriber.OnMessageReceived;
            publisher.SendMessage("Czwarta wiadomość");

            publisher.MessageEvent += subscriber.OnMessageReceived;
            publisher.SendMessage("Piąta wiadomość");
            Console.ReadKey();
        }
    }
}

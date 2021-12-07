using System;

namespace MybankerH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Haevekort("Phillip");
            Card card1 = new VisaDankort("Phillip");
            Card card2 = new VisaElectron("Phillip");
            Card card3 = new Maestro("Phillip");
            Card card4 = new Mastercard("Phillip");

            Console.WriteLine(card.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(card1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(card.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(card3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(card4.ToString());
        }
    }
}

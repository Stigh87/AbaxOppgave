using System;
using System.Collections.Generic;

namespace Abax_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bilene kunne har enn liste med info - laget en loop som sjekker verdiene (index) mot hverandre.

             var bil1 = new Bil("NF123456", 147, 200, "grønn", "Lett Kjøretøy");
                Console.WriteLine("Bil1: "); bil1.printCar();
                bil1.kjør();
             var bil2 = new Bil("NF654321", 150, 195, "blå", "Lett Kjøretøy");
                Console.WriteLine("Bil2: "); bil2.printCar();
             var bil3 = new Bil("NF654321", 150, 195, "blå", "Lett Kjøretøy");
                Console.WriteLine("Bil3: "); bil3.printCar();
                Console.WriteLine("\nBil 3 og bil 2 sjekk: ");

                bil3.isEqualTo(bil2);

                Console.WriteLine("\nBil 1 og bil 2 sjekk: ");
                bil1.isEqualTo(bil2);
                Console.WriteLine("\n --------FLY------- \n");
             var fly1 = new Fly("LN1234", 1000, 30, 2, 10, "Jetfly");
                fly1.printInfo();
                fly1.kjør();
                Console.WriteLine("\n -------BÅT-------- \n");
             var båt1 = new Båt("ABC123", 100, 30, 500);
                båt1.printBoat();
             
        }

    }

   
}

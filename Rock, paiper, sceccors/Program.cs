using System;
using System.Threading;
namespace Rock__paiper__sceccors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            int count = 0;
            int count1 = 0;

            Console.WriteLine("Velkommen til sten skaks eller papier");

            while (ans != "NEJ")
            {
                Console.WriteLine("vælg mellem :\n1->STEN\n2->SKAKS\n3->PAPIER");
                string[] choices = new string[3] { "STEN", "SKAKS", "PAPIER" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("skriv dit valg:");
                string user = Console.ReadLine().ToUpper();
                Thread.Sleep(1000);
                Console.WriteLine("Computern valgte " + choices[n]);

                if (user == "STEN" && choices[n] == "SKAKS")
                {
                    Console.WriteLine("spiller 1 vinder");
                    count += 1;
                }
                else if (user == "STEN" && choices[n] == "PAPIER") 
                {
                    Console.WriteLine("Computer vinder");
                    count1 += 1;
                }
                else if (user == "PAPIER" && choices[n] == "STEN")
                {
                    Console.WriteLine("spiller 1 vinder");
                    count += 1;
                }
                else if (user == "PAPIER" && choices[n] == "SKAKS")
                {
                    Console.WriteLine("Computer vinder");
                    count1 += 1;
                }
                else if (user == "SKAKS" && choices[n] == "STEN")
                {
                    Console.WriteLine("Computer vinder");
                    count1 += 1;
                }
                else if (user == "SKAKS" && choices[n] == "PAPIPER")
                {
                    Console.WriteLine("spiller 1 vinder");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Samme valg");
                }
                Console.WriteLine("vil du spille igen (ja/nej):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
                Console.Clear();
            }
            Console.WriteLine("spiller 1 vandt " + count + " gange");
            Console.WriteLine("Computer vandt " + count1 + " gange");
            Console.WriteLine("tryk enter");
            Console.ReadKey();
        }
    }
}

using System;
using KodTest.Alternativ1;

namespace KodTest
{
    /// Beräkna arean o omkretsen på en kvadrat, rektangel och parallelltrapets
    /// Skriv ut arean, omkretsen och vilken typ av figur det är, skriv ut i consolen
    /// Jag har skapat 3 arrayer, arrayen avgör vilken typ figur det är
    /// Var kreativ och visa att du testat din lösning noga

    public class Program
    {
        static void Main(string[] args)
        {
            int[] figur1 = new int[] { 5, 5 };
            int[] figur2 = new int[] { 5, 4, 5, 4 };
            int[] figur3 = new int[] { 5, 5, 4, 4, 3 };

            Console.ReadLine();

            int[] figur = figur2;

            var losningen = new Losning();
            losningen.EnLosning(figur);


        }
    }
}

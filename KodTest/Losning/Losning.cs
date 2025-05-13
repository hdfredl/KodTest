using System;

namespace KodTest.Alternativ1
{
    public class Losning
    {
        public void EnLosning(int[] fig)
        {
            if (fig != null)
            {
                if (fig[0] == fig[1] && fig.Length < 3)
                {
                    Kvadrat(fig);
                }

                if (fig.Length == 4)
                {
                    Rektangel(fig);
                }

                if (fig.Length > 4)
                {
                    Paralelltrapets(fig);
                }
            }
        }


        void Kvadrat(int[] langd)
        {
            if (langd == null || langd.Length == 0)
            {
                WriteLine("Ingen tal i arrayen");
            }

            if (langd.Length == 2 && langd[0] == langd[1])
            {
                int area = langd[0] * langd[1];
                int omkrets = langd[0] + langd[1] + langd[0] + langd[1];

                WriteLine("KVADRAT");
                WriteLine("Arean är: " + area);
                WriteLine("Omkretsen är: " + omkrets);
            }
            else
            {
                WriteLine("Tyvärr kan denna array inte bli en kvadrat");
            }
        }

        void Rektangel(int[] langd)
        {
            if (langd == null || langd.Length == 0)
            {
                WriteLine("Ingen tal i arrayen");
            }

            if (langd[0] == langd[2] && langd[1] == langd[3] || langd[0] == langd[1] && langd[2] == langd[3])
            {
                if (langd[0] != langd[1])
                {
                    int area = langd[0] * langd[1];

                    WriteLine("REKTANGEL");
                    WriteLine("Area är: " + area);
                    OmkretsRaknare(langd);
                }
                else if (langd[2] != langd[3])
                {
                    int area = langd[2] * langd[3];

                    WriteLine("REKTANGEL");
                    WriteLine("Area är: " + area);
                    OmkretsRaknare(langd);
                }
                else if (langd[0] == langd[1] || langd[2] == langd[3])
                {
                    int area = langd[2] * langd[3];

                    WriteLine("REKTANGEL");
                    WriteLine("Area är: " + area);
                    OmkretsRaknare(langd);
                }
            }
            else
            {
                WriteLine("Tyvärr kan inte dessa längder bilda en rektangel");
            }
        }

        void Paralelltrapets(int[] langd)
        {
            decimal tak = langd[2]; // 4
            decimal bas = langd[1]; // 5
            decimal hojd = langd[4]; // 3

            decimal area = hojd * (bas + tak) / 2;

            int omkrets = langd[0] + langd[1] + langd[2] + langd[3] + langd[4];

            WriteLine("PARALELLTRAPETS");
            WriteLine("Area är: " + area);
            WriteLine("Omkrets är: " + omkrets);

            WriteLine("Figur3 kan ej bli paralleltrapets om vi använder oss av siffrorna i arrayen. Det går att skriva ut talen i en trapets och räkna Area/Omkrets men ej att rita i verkligheten... ");
        }

        void Parallelogram(int[] langd)
        {
            int area = langd[4] * langd[2];
            int omkrets = langd[0] + langd[1] + langd[2] + langd[3];

            WriteLine("PARALLELLOGRAM");
            WriteLine("Figur3 kan bli en paralellogram om vi använder oss av siffror i arrayen.  ");
            WriteLine("Paralellogram var ej efterfrågat i uppgiften. Men fick ej till det med beräkningen med de siffror som finns med i arrayen.");
            WriteLine(langd[4] + " = höjd," + langd[2] + " = bas");
            WriteLine("Area är: " + area);
            WriteLine("Omkrets är: " + omkrets);
        }

        void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        void OmkretsRaknare(int[] langd)
        {
            int omkrets = langd[0] + langd[1] + langd[2] + langd[3];
            WriteLine("Omkrets är: " + omkrets);
        }
    }
}

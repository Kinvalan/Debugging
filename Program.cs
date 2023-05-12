/*
Lag en ny konsoll-applikasjon og legg inn denne koden i main metoden til program.cs


var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}

Sett et breakpoint på den første linjen (linje 9) og
et breakpoint i starten av hver av foreach løkken (linje 16), og
et breakpoint på linje 23. 

Start applikasjonen og trykk F5 når programmet stopper på den første linjen. 
Skriv “Hei på deg” når konsoll vinduet popper opp. 
Hold musepekeren over verdien character og skriv ned et notat med hvilken verdi den har når breakpointet treffes. 
Trykk så F10 flere ganger og skriv ned de forskjellige verdiene character endres til for hver runde i løkken. 
Sjekk at counts-arrayet blir oppdatert for hver character i teksten. 
Finn ut hvilke verdier variablen “i” må ha i for-løkken for at den skal treffe breakpointet på linje 23. 
(trykk F5 når du er i for-løkken isteden for F10). 
*/


namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty) // hei på deg = character = 104 (h), 101 (e), 105(i) osv. 
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                    }
                } // Hvis i har en verdi som er 0 eller mindre, vil vi treffe det siste breakpointet.
            }
        }
    }
}
// -----------------------------------------------------------
// Namn: Bjarne Rossen
// E-post: bjaros-4@student.ltu.se
// Kurs: L0002B
// Uppgift 1 Console-variant
// -----------------------------------------------------------

using System;

namespace Vaxelberakning
{
    internal class Program
    {
        // --- Konstant lista över valörer ---
        static readonly (int varde, string singular, string plural)[] valorer =
        {
            (500, "femhundralapp", "femhundralappar"),
            (200, "tvåhundralapp", "tvåhundralappar"),
            (100, "hundralapp", "hundralappar"),
            (50, "femtiolapp", "femtiolappar"),
            (20, "tjuga", "tjugolappar"),
            (10, "tiokrona", "tiokronor"),
            (5, "femkrona", "femkronor"),
            (1, "enkrona", "enkronor")
        };

        static void Main(string[] args)
        {
            Console.WriteLine("=== VÄXELBERÄKNING ===\n");

            int pris = LäsPris();
            int betalt = LäsBetalning(pris);
            int vaxel = betalt - pris;

            SkrivUtKvitto(pris, betalt, vaxel);

            if (vaxel > 0)
                SkrivUtVaxel(vaxel);
            else
                Console.WriteLine("Ingen växel behövs. Tack för köpet!\n");
        }

        // --- Metod: Läs in priset ---
        static int LäsPris()
        {
            while (true)
            {
                Console.Write("Ange pris (kr): ");
                if (int.TryParse(Console.ReadLine(), out int pris) && pris > 0 && pris < 1000000)
                    return pris;

                Console.WriteLine("Felaktig inmatning. Ange ett positivt heltal under 1 000 000.\n");
            }
        }

        // --- Metod: Läs in betalning ---
        static int LäsBetalning(int pris)
        {
            while (true)
            {
                Console.Write("Betalt (kr): ");
                if (!int.TryParse(Console.ReadLine(), out int betalt) || betalt <= 0)
                {
                    Console.WriteLine("Felaktig inmatning. Ange ett positivt heltal.\n");
                    continue;
                }

                if (betalt < pris)
                {
                    Console.WriteLine($"Kunden har betalat för lite! {pris - betalt} kr saknas.\n");
                    continue;
                }

                return betalt;
            }
        }

        // --- Metod: Skriv ut kvitto ---
        static void SkrivUtKvitto(int pris, int betalt, int vaxel)
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine($"Pris:   {pris.ToString().PadRight(6)} kr");
            Console.WriteLine($"Betalt: {betalt.ToString().PadRight(6)} kr");
            Console.WriteLine($"Växel:  {vaxel.ToString().PadRight(6)} kr");
            Console.WriteLine("-----------------------------\n");
        }

        // --- Metod: Skriv ut växeln i valörer ---
        static void SkrivUtVaxel(int vaxel)
        {
            Console.WriteLine("Växel tillbaka:");

            foreach (var valor in valorer)
            {
                int antal = vaxel / valor.varde;
                if (antal > 0)
                {
                    string namn = antal == 1 ? valor.singular : valor.plural;
                    Console.WriteLine($"{antal} {namn}");
                    vaxel %= valor.varde;
                }
            }

            Console.WriteLine("\nTack för köpet!\n");
        }
    }
}
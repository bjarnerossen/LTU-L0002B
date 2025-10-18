// -----------------------------------------------------------
// Namn: Bjarne Rossen
// E-post: bjaros-4@student.ltu.se
// Kurs: L0002B
// Uppgift 2 Console-variant
// -----------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Säljare
{
    public string Namn { get; set; }
    public string Personnummer { get; set; }
    public string Distrikt { get; set; }
    public int AntalArtiklar { get; set; }
}

class Program
{
    // Lista över tillåtna distrikt
    static readonly List<string> TillåtnaDistrikt = new List<string> { "Piteå", "Boden", "Luleå", "Kiruna" };

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Registrering av säljare ===\n");

        int antalSäljare = ReadInt("Hur många säljare vill du registrera? ", 1, 100);

        List<Säljare> säljareList = new List<Säljare>();

        // === Inmatning av säljardata ===
        for (int i = 0; i < antalSäljare; i++)
        {
            Console.WriteLine($"\nSäljare #{i + 1}:");

            string namn = ReadName("Namn (för- och efternamn): ");
            string personnummer = ReadPersonnummer("Personnummer (10 siffror): ");
            string distrikt = ReadDistrikt();
            int antal = ReadInt("Antal sålda artiklar: ", 0, 1000000);

            säljareList.Add(new Säljare
            {
                Namn = namn,
                Personnummer = personnummer,
                Distrikt = distrikt,
                AntalArtiklar = antal
            });
        }

        // === Sortera och skriv ut resultat ===
        säljareList = säljareList.OrderBy(s => s.AntalArtiklar).ToList();

        string filnamn = "resultat.txt";
        using (StreamWriter sw = new StreamWriter(filnamn))
        {
            Console.WriteLine("\n=== Resultat ===\n");
            sw.WriteLine("=== Resultat ===\n");

            if (säljareList.Count == 0)
            {
                Console.WriteLine("Inga säljare registrerade.");
                sw.WriteLine("Inga säljare registrerade.");
                return;
            }

            int föregåendeNivå = GetNivå(säljareList[0].AntalArtiklar);
            int räknare = 0;

            foreach (var s in säljareList)
            {
                int nuvarandeNivå = GetNivå(s.AntalArtiklar);

                if (nuvarandeNivå != föregåendeNivå)
                {
                    PrintLevelSummary(föregåendeNivå, räknare, sw);
                    räknare = 0;
                    föregåendeNivå = nuvarandeNivå;
                }

                string rad = $"{s.Namn,-20} {s.Personnummer,-12} {s.Distrikt,-10} {s.AntalArtiklar}";
                Console.WriteLine(rad);
                sw.WriteLine(rad);

                räknare++;
            }

            PrintLevelSummary(föregåendeNivå, räknare, sw);
        }

        Console.WriteLine($"\nResultatet har sparats i filen '{filnamn}'.");
    }

    // === Hjälpmetoder ===

    // Läs in ett giltigt heltal inom ett intervall
    static int ReadInt(string prompt, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"Felaktig inmatning. Ange ett heltal mellan {min} och {max}.");
        }
    }

    // Läs in namn: måste vara två ord och endast bokstäver
    static string ReadName(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().Trim();

            // Kontroll: minst två ord, bara bokstäver (svenska tillåts)
            if (Regex.IsMatch(input, @"^[A-Za-zÅÄÖåäö]+ [A-Za-zÅÄÖåäö]+$"))
                return input;

            Console.WriteLine("Fel: Namnet måste bestå av för- och efternamn och får bara innehålla bokstäver.");
        }
    }

    // Läs in personnummer: exakt 10 siffror
    static string ReadPersonnummer(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().Trim();

            if (Regex.IsMatch(input, @"^\d{10}$"))
                return input;

            Console.WriteLine("Fel: Personnumret måste bestå av exakt 10 siffror (utan bindestreck).");
        }
    }

    // Läs in distrikt från lista
    static string ReadDistrikt()
    {
        while (true)
        {
            Console.WriteLine("Välj distrikt genom att skriva ett av följande:");
            foreach (var d in TillåtnaDistrikt)
                Console.WriteLine($" - {d}");

            Console.Write("Distrikt: ");
            string input = Console.ReadLine().Trim();

            if (TillåtnaDistrikt.Contains(input, StringComparer.OrdinalIgnoreCase))
                return TillåtnaDistrikt.First(d => d.Equals(input, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Fel: Ange ett giltigt distrikt från listan.");
        }
    }

    // Bestäm nivå utifrån antal artiklar
    static int GetNivå(int antal)
    {
        if (antal < 50) return 1;
        else if (antal < 100) return 2;
        else if (antal < 200) return 3;
        else return 4;
    }

    // Skriv sammanfattning för en nivå
    static void PrintLevelSummary(int nivå, int antalSäljare, StreamWriter sw)
    {
        string text = nivå switch
        {
            1 => $"{antalSäljare} säljare har nått nivå 1: under 50 artiklar\n",
            2 => $"{antalSäljare} säljare har nått nivå 2: 50–99 artiklar\n",
            3 => $"{antalSäljare} säljare har nått nivå 3: 100–199 artiklar\n",
            4 => $"{antalSäljare} säljare har nått nivå 4: över 199 artiklar\n",
            _ => ""
        };

        Console.WriteLine(text);
        sw.WriteLine(text);
    }
}
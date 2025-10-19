using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002B_Uppgift3__WindowsForms_Bjarne_Rossen
{
    public class Person
    {
        // Egenskaper
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Personnummer { get; set; }

        // Konstruktor
        public Person(string förnamn, string efternamn, string personnummer)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
        }

        // Metod för att kontrollera personnummer med 21-algoritmen
        public bool ÄrPersonnummerGiltigt()
        {
            string pnr = Personnummer.Replace("-", "").Replace(" ", "");
            if (pnr.Length != 10 && pnr.Length != 12)
                return false;

            if (pnr.Length == 12)
                pnr = pnr.Substring(2); // Ta bort århundradet

            // Kontrollsiffra enligt Luhn-algoritmen (21-metoden)
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int n = int.Parse(pnr[i].ToString());
                if (i % 2 == 0)
                    n *= 2;
                if (n > 9)
                    n -= 9;
                sum += n;
            }

            int kontroll = (10 - (sum % 10)) % 10;
            int sista = int.Parse(pnr[9].ToString());
            return kontroll == sista;
        }

        // Metod för att avgöra kön
        public string Kön()
        {
            string pnr = Personnummer.Replace("-", "").Replace(" ", "");
            if (pnr.Length == 12)
                pnr = pnr.Substring(2);

            int könsSiffra = int.Parse(pnr[8].ToString());
            return könsSiffra % 2 == 0 ? "Kvinna" : "Man";
        }
    }
}

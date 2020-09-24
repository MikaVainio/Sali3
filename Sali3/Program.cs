using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            /****************************************************
             * TESTAUS ALKAA TÄSTÄ                              *
             ****************************************************/

            // Testataan Jäsen-olion muodostimen toiminta
            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "12345", "Mies", "26.6.1962");

            // Testatataan Punnitus-olion toimintaa
             Punnitus punnitus = new Punnitus("10.9.2020", "71,5", "1,71");
                    
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();

            // Testi iän laskennan toimimisesta
            int vuotta = Rasvaprosentti.Ika("26.6.1962");
            Console.WriteLine("Moon " + vuotta + " vuotta vanha");

            // Testi BMI:n laskemiskesi
            float bmi = Rasvaprosentti.BMI("1,71", "71,5");
            Console.WriteLine("Painoindeksi on " + bmi);

            // Testi Rasvaprosentin laskennasta
            float rasvaprosentti = Rasvaprosentti.laskeRasva2(bmi, vuotta, "Mies");
            Console.WriteLine("Rasvaprosentti on " + rasvaprosentti);

            // Testataan iän laskenta jäsen-oliosta

            Console.WriteLine("Ikä oliolla jasen on " + Rasvaprosentti.Ika(jasen.Syntymäaika));

            // Integraatiotesti 1. rasvaprosentin laskenta jäsen- ja punnitusolioista
            int jika = Rasvaprosentti.Ika(jasen.Syntymäaika);
            Console.WriteLine("Paino: " + punnitus.Paino);
            Console.WriteLine("Pituus: " + punnitus.Pituus);
            Console.WriteLine("Sukupuoli: " + jasen.Sukupuoli);
            float jbmi = Rasvaprosentti.BMI(punnitus.Pituus, punnitus.Paino);
            float jrprosentti = Rasvaprosentti.laskeRasva2(jbmi, jika, jasen.Sukupuoli);

            Console.WriteLine("Jäsenen ikä on " + jika + ", bmi on " + jbmi + " ja rasvaprosentti on " + jrprosentti);

            // Jako nollalla testi

            string nollapituus = "0";
            string paino = "71,5";
            float bmikaatuu = Rasvaprosentti.BMI(nollapituus, paino);
            Console.WriteLine("BMI on " + bmikaatuu);

            
        }   
    }
}

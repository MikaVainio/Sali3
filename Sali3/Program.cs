﻿using System;

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

            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            // Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Mika", "Hakala", "Kotikatu 3", "20100", "Turku");

            // Testataan Jäsen-olion muodostimen toiminta
            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "123", "1");

            // Testataan Trainer-olion muodostimen toiminta, huom. nimiavaruus Henkilosto
            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Jakke", "Jäynä", "Kotikatu 2", "21200", "Raisio", "Juoksumatto", "044 7057425", "jakke@huuhaa.com");

            // Testatataan Punnitus-olion toimintaa

            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            // Testataan Rasvaprosentti-olion toimintaa
            Rasvaprosentti rasvaprosentti = new Rasvaprosentti();
            
            // Katsotaan olioiden ominaisuuksia
            Console.WriteLine("Testi henkilön oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi henkilön muodostimelle kaikilla parametreilla");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi personal trainerin muodostimelle");
            trainer.naytaTrainer();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();
            Console.WriteLine("Painoindeksi (BMI-metodi) on " + punnitus.BMI());
            Console.WriteLine("Oletustiedot rasvaprosentin laskentaan ovat:");
            Console.WriteLine("Alkuperäinen sukupuoli on: " + rasvaprosentti.Sukupuoli);
            Console.WriteLine("Alkuperäinen ikä on: " + rasvaprosentti.Ika);
            
            // Tehdään muutokset ominaisuuksiin            
            rasvaprosentti.Ika = "19";
            rasvaprosentti.Sukupuoli = "Mies";
            Console.WriteLine("Ominaisuuksia on muutetu, uudet arvot ovat");
            Console.WriteLine("Ikä on nyt " + rasvaprosentti.Ika);
            Console.WriteLine("Sukupuoli on nyt " + rasvaprosentti.Sukupuoli);
            rasvaprosentti.
        }   
    }
}

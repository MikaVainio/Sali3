using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sali3
{
    class Punnitus
    {
        //  Kaikki kentät (field) merkkijonoja, koska syöte tulee näppäimistöstä
        protected string paiva;
        protected string paino;
        protected string pituus;

        // Kenttiä vastaavat ominaisuudet (property)
        public string Paino
        {
            get { return paino; }
        }

        public string Pituus
        {
            get { return pituus; }
        }
        // Muodostin kaikilla parametreilla
        public Punnitus(string paiva, string paino, string pituus)
        {
            this.paiva = paiva;
            this.paino = paino;
            this.pituus = pituus;
        }

        
        // Testausmetodi punnitustietojen näyttämiseen
        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino: " + this.paino);
            Console.WriteLine("Pituus: " + this.pituus);
        }
    }
}

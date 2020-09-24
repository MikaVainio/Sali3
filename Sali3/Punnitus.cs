﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sali3
{
    class Punnitus
    {
        //  Kaikki kentät merkkijonoja, koska syöte tulee näppäimistöstä
        protected string paiva;
        protected string paino;
        protected string pituus;

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

using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        // Määritellään kentät (field), huom. nimi pienellä
        protected string sukupuoli;
        protected string ika;

        // Samat tiedot ominaisuuksina (property), huom nimi isolla
        public string Sukupuoli
        {
            get
            { return sukupuoli; }
            set 
            { sukupuoli = value; }
        }

        public string Ika
        {
            get
            { return ika; }
            set
            { ika = value; }
        }
        
        // Sama voitaisiin tehdä lyhyemmin
        public string Vuotta { get; set; }
        public string Spuoli { get; set; }
        
        // Oletusmuodostin
        public Rasvaprosentti()
        {
            this.sukupuoli = "Nainen";
            this.ika = "0";
        }
    }
}

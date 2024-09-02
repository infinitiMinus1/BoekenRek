using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public class Genre
    {
        public Genre(int leeftijd, string naam)
        {

            Naam = naam;
            Categorie = new Doelgroep(leeftijd).Categorie;

        }
        public string Naam { get; set; }
        public string Categorie { get; set; }

        public class Doelgroep
        {
            public int Leeftijd { get; set; }
            public string Categorie => Leeftijd < 18 ? "Jeugd" : "Volwassen";

            public Doelgroep(int leeftijd)
            {

                Leeftijd = leeftijd;

            }
        }
    }
}

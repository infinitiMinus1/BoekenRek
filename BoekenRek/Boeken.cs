using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public abstract class Boeken : IVoorwerpen
    {
        public Boeken(string titel, string auteur, decimal aankoopPrijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            AankoopPrijs = aankoopPrijs;
            Genre = genre;
        }
        static Boeken()
        {
            Eigenaar = "VDAB_Default";
        }
        public Genre Genre { get; set; }

        private static string eigenaar;

        public static string Eigenaar
        {
            get { return eigenaar; }
            set {eigenaar = value; }
        }

        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        private string auteur;

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        private decimal aankoopPrijs;
        public decimal AankoopPrijs
        {
            get { return aankoopPrijs; }
            set
            {
                if (value > 0)
                {
                    aankoopPrijs = value;
                }
                else
                {
                    throw new ArgumentException("Geen geldige prijs.");
                }
            }
        }

        public abstract decimal Winst { get; }

        public virtual string ToonGegevens()
        {
            return $"Titel: {Titel}\n" +
                $"Auteur: {Auteur}\n" +
                $"Eigenaar: {Eigenaar}\n" +
                $"AankoopPrijs: {AankoopPrijs}\n" +
                $"Genre: {Genre.Naam}\n"+
                $"DoelGroep: {Genre.Categorie}";
        }


    }
}
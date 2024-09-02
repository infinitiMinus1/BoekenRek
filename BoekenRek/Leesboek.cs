using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public class Leesboek : Boeken
    {
        public Leesboek(string titel, string auteur, decimal aankoopPrijs,Genre genre, string onderwerp)
            :base (titel, auteur, aankoopPrijs, genre)
        {
            Onderwerp = onderwerp;
        }
        private string onderwerp;

        public string Onderwerp
        {
            get { return onderwerp; }
            set { onderwerp = value; }
        }

        public override decimal Winst => AankoopPrijs * 1.5m;

        public override string ToonGegevens()
        {
            return $"Lees boek\n" +
                   "============================\n" +
                   $"{base.ToonGegevens()}\n" +
                   $"Onderwerp: {Onderwerp}\n" +
                   $"Winst: {Winst}" +
                   $"";
        }

    }
}

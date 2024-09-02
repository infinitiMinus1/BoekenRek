using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public class WoordenBoek : Boeken
    {
        public WoordenBoek(string titel, string auteur, decimal aankoopPrijs,Genre genre, string taal) 
        : base(titel, auteur, aankoopPrijs, genre) { 

            Taal = taal;
        }
        private string taal;

        public string Taal
        {
            get { return taal; }
            set { taal = value; }
        }

        public override decimal Winst => AankoopPrijs * 1.75M;

        public override string ToonGegevens()
        {
            return $"Woorden boek\n" +
                   "============================\n" +
                   $"{base.ToonGegevens()}\n" +
                   $"Winst: {Winst}\n" +
                   $"Taal: {Taal}";
                  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public class BoekenRek : IVoorwerpen
    {
        public BoekenRek(int hoogte, int breedte, decimal kostprijs) { 
			
			Hoogte = hoogte; 
            Breedte = breedte;
            Kostprijs = kostprijs;

		}
        private int hoogte;

        public int Hoogte
        {
            get { return hoogte; }
            set { hoogte = value; }
        }

        private int breedte;
        public int Breedte
        {
            get { return breedte; }
            set { breedte = value; }
        }
        private decimal kostprijs;
        public decimal Kostprijs
        {
            get { return kostprijs; }
            set { kostprijs = value; }
        }

        public decimal Winst => Kostprijs * 2;


        public string ToonGegevens()
        {
            return "Boekenrek\n" +
                   "=============================\n" +
                   $"AankoopPrijs: {Kostprijs}\n" +
                   $"Winst: {Winst}\n" +
                   $"Hoogte: {Hoogte}\n" +
                   $"Breedte: {Breedte}";                  
        }

    }
}

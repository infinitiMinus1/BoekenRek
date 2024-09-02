using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinkel
{
    public interface IVoorwerpen
    {
        public string ToonGegevens();

        public decimal Winst {  get;  }
    }
}

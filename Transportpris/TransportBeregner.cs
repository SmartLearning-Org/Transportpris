using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportpris
{
    public class TransportBeregner
    {
        /*
         * Afstand   Vægt       Pris
         * < 5 km   < 10 kg     0
         * < 5 km   >= 10 kg    50
         * >= 5km   < 10 kg     75
         * >= 5km   >= 10 kg    100
         */
        public int getTransportPris(int afstand, int vaegt)
        {
            if (afstand < 5 && vaegt < 10)
            {
                return 0;
            }
            if (afstand < 5)
            {
                return 50;
            }

            if (vaegt < 10)
            {
                return 75;
            }

            return 100;
        }
    }
}

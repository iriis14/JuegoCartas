using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    internal class Carta
    {
        int num;
        Enum palo;

        public Carta()
        {

        }

        public Carta(int num, Enum palo)
        {
            this.num = num;
            this.palo = palo;
        }

        public int Num { get { return num; } set { num = value; } }
        public Enum Palo { get { return palo; } set { palo = value; } }

    }

}

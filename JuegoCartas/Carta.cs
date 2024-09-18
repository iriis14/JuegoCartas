using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    internal class Carta
    {
        //atributos
        int num;
        EPalos palo;

        public enum EPalos
        {
            Bastos,
            Copas,
            Oros,
            Espadas
        }

        //constructores
        public Carta()
        {

        }

        public Carta(int num, EPalos palo)
        {
            this.num = num;
            this.palo = palo;
        }

        //getters y setters
        public int Num { get { return num; } set { num = value; } }
        public EPalos Palo { get { return palo; } set { palo = value; } }

    }

}

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

        //métodos
        /// <summary>
        /// Devuelve un string con los atributos de la carta
        /// </summary>
        /// <returns> Un string con los atributos de la carta </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Carta:");
            sb.Append(" Num " + num);
            sb.Append(" Palo " + palo);
            return sb.ToString();
        }
    }

}

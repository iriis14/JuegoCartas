using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    internal class Baraja
    {
        //atributos
        List<Carta> cartas;

        //constructores
        public Baraja()
        {

        }

        public Baraja(List<Carta> cartas)
        {
            this.cartas = cartas;
        }

        //getters y setters
        public List<Carta> Cartas { get { return cartas; } set { cartas = value; } }

        //métodos
        /// <summary>
        /// Roba una carta de la baraja
        /// </summary>
        /// <returns> La carta robada </returns>
        public Carta RobarCarta()
        {
            return Cartas[0];
        }

        /// <summary>
        /// Reordena la baraja
        /// </summary>
        public Baraja Barajar()
        {
            Random r = new Random();
            List<Carta> cartasBarajadas = Cartas.OrderBy(_ => r.Next()).ToList();
            Baraja barajaBarajada = new Baraja(cartasBarajadas);
            return barajaBarajada;
        }

        /// <summary>
        /// Roba una carta de la baraja al azar
        /// </summary>
        /// <returns> La carta robada </returns>
        public Carta RobarAzar()
        {
            Random r = new Random();
            int num = r.Next(Cartas.Count);
            return Cartas[num];
        }

        /// <summary>
        /// Roba una carta de la baraja en N posición
        /// </summary>
        /// <returns> La carta robada </returns>
        public Carta RobarEnN(int posicion)
        {
            return Cartas[posicion];
        }

    }
}

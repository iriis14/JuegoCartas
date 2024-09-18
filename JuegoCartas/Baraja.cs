using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuegoCartas.Carta;

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
        /// Devuelve un string con los atributos de la baraja
        /// </summary>
        /// <returns> Un string con los atributos de la baraja </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta c in cartas)
                sb.Append(c.ToString() + "\n");

            return sb.ToString();
        }

        /// <summary>
        /// Crea una baraja con cartas
        /// </summary>
        /// <returns> La baraja llena </returns>
        public Baraja CrearBaraja()
        {
            Baraja baraja = new Baraja();
            List<Carta> cartas = new List<Carta>();

            foreach (EPalos palo in Enum.GetValues(typeof(EPalos)))
            {
                for (int i = 1; i < 13; i++)
                    cartas.Add(new Carta(i, palo));
            }
            baraja.Cartas = cartas;

            return baraja;
        }

        /// <summary>
        /// Roba una carta de la baraja
        /// </summary>
        /// <returns> La carta robada </returns>
        public Carta RobarCarta()
        {
            Carta c = new Carta(cartas[0].Num, cartas[0].Palo);
            cartas.RemoveAt(0);

            return c;
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
            Carta c = new Carta(cartas[num].Num, cartas[num].Palo);
            cartas.RemoveAt(num);

            return c;
        }

        /// <summary>
        /// Roba una carta de la baraja en N posición
        /// </summary>
        /// <returns> La carta robada </returns>
        public Carta RobarEnN(int posicion)
        {
            Carta c = new Carta(cartas[posicion].Num, cartas[posicion].Palo);
            cartas.RemoveAt(posicion);

            return c;
        }

    }
}

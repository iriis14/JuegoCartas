using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    internal class Program
    {
        //intanciamos e inicializamos las variables
        public static Baraja baraja = new Baraja();
        public static Baraja barajaBarajada = new Baraja();
        public static List<Carta> cartas = new List<Carta>();
        public static int numJugadores = 0;
        public static List<Jugador> listaJugadores = new List<Jugador>();

        public enum Palos
        {
            Bastos,
            Copas,
            Oros,
            Espadas
        }

        static void Main(string[] args)
        {
            //crear la baraja
            CrearBaraja();

            //barajar la baraja
            barajaBarajada = baraja.Barajar();

            //preguntar número de jugadores
            do
            {
                Console.WriteLine("Cuantos jugadores sois: ");
                int num = Int32.Parse(Console.ReadLine());
                if (num>1 && num<6)
                {
                    numJugadores = num;
                    break;
                }
                else
                    Console.WriteLine("El número de jugadores debe estar entre 2-5!!");
            } while (true);

            //repartir las cartas a los jugadores
            RepartirCartas(numJugadores);

            //iniciamos el juego
            Jugar();

            Console.ReadLine();
        }

        /// <summary>
        /// Creamos la baraja española
        /// </summary>
        public static void CrearBaraja()
        {
            foreach (Palos palo in Enum.GetValues(typeof(Palos)))
            {
                for (int i = 1; i < 13; i++)
                    cartas.Add(new Carta(i, palo));
            }

            baraja = new Baraja(cartas);
        }

        /// <summary>
        /// Reparte todas las cartas de la baraja a los jugadores
        /// </summary>
        /// <param name="numeroJugadores"> El número de jugadores </param>
        public static void RepartirCartas(int numeroJugadores)
        {
            //crear los jugadores
            for(int i = 0; i < numeroJugadores; i++)
                listaJugadores.Add(new Jugador("Jugador" + (i+1)));

            //repartir las cartas
            int cartasPorJugador = (barajaBarajada.Cartas.Count()) / numeroJugadores;

            foreach(Jugador j in listaJugadores)
            {
                List<Carta> listaJugador = new List<Carta>(cartasPorJugador);

                //las añadimos a la lista de cada jugador
                for (int i = 0; i < cartasPorJugador; i++)
                    listaJugador.Add(barajaBarajada.Cartas[i]);

                //las quitamos de la baraja inicial
                for(int z = 0; z < cartasPorJugador; z++)
                    barajaBarajada.Cartas.Remove(listaJugador[z]);

                j.ListaCartas = listaJugador;
            }
        }

        public static void Jugar()
        {
            //TODO
        }

    }
}

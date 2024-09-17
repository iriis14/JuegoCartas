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

        public enum Palos
        {
            Bastos,
            Copas,
            Oros,
            Espadas
        }

        static void Main(string[] args)
        {
            //primero creamos la baraja
            CrearBaraja();
            Console.WriteLine("BARAJA");
            for(int i = 0; i < cartas.Count; i++)
                Console.WriteLine("Num: " + cartas[i].Num + " Palo: " + cartas[i].Palo);
            Console.WriteLine();

            //robamos la primera carta
            Carta cartaRobada = baraja.RobarCarta();
            Console.WriteLine("PRIMERA CARTA ROBADA");
            Console.WriteLine("Num: " + cartaRobada.Num + " Palo: " + cartaRobada.Palo);
            Console.WriteLine();

            //barajamos la baraja
            barajaBarajada = baraja.Barajar();
            Console.WriteLine("BARAJA BARAJADA");
            for (int i = 0; i < barajaBarajada.Cartas.Count; i++)
                Console.WriteLine("Num: " + barajaBarajada.Cartas[i].Num + " Palo: " + barajaBarajada.Cartas[i].Palo);
            Console.WriteLine();

            //robamos una cara al azar de la baraja
            Carta cartaRobadaAzar = baraja.RobarAzar();
            Console.WriteLine("CARTA AL AZAR");
            Console.WriteLine("Num: " + cartaRobadaAzar.Num + " Palo: " + cartaRobadaAzar.Palo);
            Console.WriteLine();

            //robamos una carta en una posición N
            Console.WriteLine("CARTA EN N");
            int n = 3;
            Carta cartaRobadaN = baraja.RobarEnN(n);
            Console.WriteLine("N = " + n);
            Console.WriteLine("Num: " + cartaRobadaN.Num + " Palo: " + cartaRobadaN.Palo);

            Console.ReadLine();
        }

        /// <summary>
        /// Creamos la baraja española
        /// </summary>
        public static void CrearBaraja()
        {
            foreach (Palos palo in Enum.GetValues(typeof(Palos)))
            {
                for (int j = 0; j < 12; j++)
                    cartas.Add(new Carta(j + 1, palo));
            }

            baraja = new Baraja(cartas);
        }
    }
}

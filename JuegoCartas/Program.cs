﻿using System;
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

        static void Main(string[] args)
        {
            //crear la baraja
            baraja = baraja.CrearBaraja();

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
            //crear la lista de cartas que se van sacando
            List<Carta> cartasSacadas = new List<Carta>();

            //sacar la primera carta de cada jugador
            foreach(Jugador j in listaJugadores)
            {
                Carta c = new Carta(j.ListaCartas[0].Num, j.ListaCartas[0].Palo);
                j.ListaCartas.Remove(j.ListaCartas[0]);
                cartasSacadas.Add(c);
            }

            //mirar la carta más alta
            cartasSacadas.Max(carta => carta.Num);

            //TODO

        }

    }
}

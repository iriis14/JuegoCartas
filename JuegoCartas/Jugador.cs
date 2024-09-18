using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    internal class Jugador
    {
        //atributos
        string nombre;
        List<Carta> listaCartas;

        //constructores
        public Jugador()
        {

        }

        public Jugador(string nombre, List<Carta> listaCartas)
        {
            this.nombre = nombre;
            this.listaCartas = listaCartas;
        }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        //getters y setters
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Carta> ListaCartas { get { return listaCartas; } set { listaCartas = value; } }

        //métodos
        /// <summary>
        /// Devuelve un string con los atrinutos del jugador
        /// </summary>
        /// <returns> Un string con los atributos de los jugadores </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Jugador: " + nombre + "\n");

            foreach(Carta c in listaCartas)
                sb.Append(c.ToString() + "\n");

            return sb.ToString();
        }
    }
}

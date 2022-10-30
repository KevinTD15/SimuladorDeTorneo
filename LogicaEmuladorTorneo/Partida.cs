using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public abstract class Partida<J> : IEnumerable<Juego> where J : Juego
    {
        #region Variables de campo
        protected Jugadores<J>[] jugadores;
        protected Equipo<J>[] equipos;
        protected bool inicia = true;
        #endregion
        #region Propiedades
        public Juego Juego { get; protected set; }
        public string JugadorGanador => (IndiceGanador == -1) ? " Empate" : " gana " + ((PorEquipos) ? "Equipo " + equipos[IndiceGanador].Nombre : jugadores[IndiceGanador].Nombre) + ((PorPuntos) ? " con " + Puntuaciones[IndiceGanador] + " puntos " : "");
        public abstract int IndiceGanador { get; } //indice del ganador dentro del array de los jugadores(o equipos)
        public abstract bool PorEquipos { get; protected set; }  //indica si el juego admite por equipo/individual o solo individual o solo por equipo
        public abstract bool PorPuntos { get;  }  //indica si la partida es por puntos
        public abstract int[] Puntuaciones { get; protected set; } //donde se almacenan los puntos de los competidores en caso del juego sea por puntuacion
        public abstract int Cantjugadores { get; set; } //cantidad de jugadores por partida
        #endregion
        #region Metodos
        public abstract void Nueva<T>(T[] jugadores); //crea  instancia del juego con Jugadores
        public abstract void EjecutarJuego(); //se ejecuta en el iterador de juego. Permite capturar informacion al terminar un juego
        public abstract int BuscaIndiceGanador(); //devuelve indice del ganador
        public abstract bool Finalizo(); //true si finalizo partida
        #endregion
        #region Iterador de Juego
        /// <summary>
        /// Iterador de Juego  
        /// </summary>
        public IEnumerable<Juego> Ejecutar
        {
            get
            {
                while (!Finalizo())
                {
                    EjecutarJuego();
                    yield return Juego;
                }
            }
        }
        public IEnumerator<Juego> GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}



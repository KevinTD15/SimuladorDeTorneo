using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public abstract class Torneo<J> : IEnumerable<Partida<J>> where J : Juego
    {
        #region Variables de campo
        protected List<Equipo<J>> equipos;
        protected List<Jugadores<J>> jugadores;
        protected int[] Puntuaciones;
        readonly Random indiceAleatorio = new Random();
        protected bool inicia = true;
        #endregion
        #region Propiedades
        public Partida<J> Juego { get; protected set; }
        protected int CantidadCompetidores { get; private set; }
        #endregion
        #region Constructores
        public Torneo(List<Equipo<J>> equipos, Partida<J> juego)
        {
            int indice;
            this.Juego = juego;

            this.equipos = new List<Equipo<J>>();
            while (equipos.Count > 0)  
            {
                indice = indiceAleatorio.Next(equipos.Count - 1);
                this.equipos.Add( equipos[indice]); //la lista de equipos se ordena de forma aleatoria
                equipos.RemoveAt(indice);
            }
            Competidores(this.equipos.Count);
        }
        public Torneo(List<Jugadores<J>> jugadores, Partida<J> juego)
        {
            int indice;
            this.Juego = juego;
            this.jugadores = new List<Jugadores<J>>();
            while (jugadores.Count>0)
            {
                indice = indiceAleatorio.Next(jugadores.Count - 1);
                this.jugadores.Add(jugadores[indice]); //la lista de jugadores se ordena de forma aleatoria
                jugadores.RemoveAt(indice);
            }
            Competidores(this.jugadores.Count);
        }
        #endregion
        #region Metodos
        public abstract string Ganador(); // resultado del torneo
        public abstract void EjecutarPartida(); // ejecutar partida
        public abstract bool Finalizo(); //true si finalizo torneo
        /// <summary>
        /// Inicializa cantidad de competidores y el array de puntucaciones
        /// </summary>
        /// <param name="cantidad"></param>Cantidad de competidores
        private void Competidores(int cantidad)
        {
            CantidadCompetidores = cantidad;
            Puntuaciones = new int[CantidadCompetidores];
        }
        #endregion
        #region Iterador de Partida
        /// <summary>
        /// Iterador de Partida
        /// </summary>
        public IEnumerable<Partida<J>> Ejecutar
        {
            get
            {
                while (!Finalizo())
                {
                    EjecutarPartida();
                    yield return Juego;
                }
            }
        }
        public IEnumerator<Partida<J>> GetEnumerator()
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

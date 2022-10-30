using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
     public abstract class Juego:IEnumerable<Jugada>
     {
        #region Variables de campo
        protected Jugadores[] jugadores; 
        protected Equipo[] equipos; 
        protected List<Jugada> jugadas; //Lista de jugadas posibles a implementar por el jugador//
        protected int indiceJugadorActual = 0; //Se utiliza para moverse por el array de jugadores//
        protected List<object> fichasdeJugador; //lista de fichas para el juego que lo necesite
        bool inicia = true;
        #endregion
        #region Propiedades
        public bool Finalizo { get; protected set; } //true si juego finalizo//
        public Jugada Juega { get; protected set; }  //Jugada del Jugador en cuestion//
        public bool Valido { get; protected set; } //si es false se termino el juego pero no la partida
        public string JugadorJugo => jugadores[indiceJugadorActual - 1].Nombre; // devuelve jugador que jugo
        // JugadorGanador devuelve resultado del juego
        public string JugadorGanador => (IndiceGanador == -1) ? " Empate" : " gana " + ((PorEquipos) ? "Equipo " + equipos[IndiceGanador].Nombre : jugadores[IndiceGanador].Nombre) + ((PorPuntos) ? " con " + Puntos + " puntos " : "");
        public abstract int IndiceGanador { get; }  // indice jugador ganador,si -1 no existe ganador
        public abstract int Puntos { get; }  //puntos del ganador
        protected abstract bool PorEquipos { get; set; } //si el juego es por equipo o individual
        public abstract bool PorPuntos { get; } //si el juego es por puntos
        #endregion
        #region Metodos
        protected abstract void BuscaGanador(); //pone en indiceGanador el indice del jugador ganador de la lista de jugadores
        protected abstract void ReparteFichas(); //organizar las fichas al iniciar el juego
        protected abstract void JuegoFinalizado(); //devuelve en la propiedad Finalizo true si termino la Partida y en Valido si termino el Juego
        protected abstract void PosiblesJugadas(); //genera posibles jugadas a ejecutar
        protected abstract void OrganizarJugadas(); //evalua las jugadas para prepararlas para que los jugadores la seleccionen  en dependencia de su tipo
        protected abstract void ImplementaJugada(); // ejecuta la jugada
        /// <summary>
        /// Ejecuta el juego a partir de los metodos abstractos implementados en cada uno de ellos
        /// </summary>
        public virtual void EjecutarJugada() 
         {
             if (inicia)
             {
                inicia = false;
                ReparteFichas(); //reparte fichas en dependencia del juego
             }
             else
             {
                 if (indiceJugadorActual >= jugadores.Length)
                    indiceJugadorActual = 0;  //Cuando termine el array se inicializa en 0

                 PosiblesJugadas(); //genera las posibles jugadas segun el juego
                 OrganizarJugadas(); //organiza las jugadas generadas segun el juego
                 Juega = jugadores[indiceJugadorActual].Juega(jugadas); //el jugador en dependencia del tipo devuelve la jugada escogida
                 if (EsValidaJugada(Juega)) //valida que la jugada a ejecutar se encuentre dentro del listado de jugadas generadas
                 {
                     ImplementaJugada(); //ejecuta la jugada
                     indiceJugadorActual++; //proximo jugador
                     jugadas.Clear(); //limpia la lista de jugadas
                     JuegoFinalizado(); // Devuelve si el juego finalizo y si es valido
                     if (Finalizo && Valido) //si termino el juego y es valido( Ej no termino con trampa ni empatado)
                        BuscaGanador(); //se puebla la propiedad IndiceGanador
                 }
                 else
                 {
                     Juega = new Jugada("Juego no valido, " + jugadores[indiceJugadorActual].Nombre + " hizo trampa.");
                     Finalizo = true; //si se hizo trampa no se ejecuta la jugada, se finaliza el juego pero no es valido
                     Valido = false;
                 }
             }
        }
        /// <summary>
        /// Valida que la jugada a ejecutar se encuentre dentro del listado de jugadas generadas
        /// </summary>
        /// <param name="A"></param>jugada a validar
        /// <returns></returns>
        protected virtual bool EsValidaJugada(Jugada A)
        {
            foreach (Jugada item in jugadas)
            {
                if (item == A) return true;
            }
            return false;
        }
        #endregion
        #region Iterador de Jugada
        /// <summary>
        /// Iterador de Jugada 
        /// </summary>
        public IEnumerable<Jugada> Ejecutar
        {
            get
            {
                while ( !Valido)
                {
                    EjecutarJugada();
                    yield return Juega;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Jugada> GetEnumerator()
        {
            return  GetEnumerator();
        }
        #endregion
    }
}

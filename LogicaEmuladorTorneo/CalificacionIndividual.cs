using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class CalificacionIndividual<J> : Torneo<J> where J : Juego
    {
        #region Variables de campo
        int competidorActual = 0;   //recorre los jugadores
        #endregion
        #region Constructores
        public CalificacionIndividual(List<Equipo<J>> equipos, Partida<J> juego) : base(equipos, juego)
        {
            throw new InvalidOperationException("No se admiten equipos en este tipo de torneo");
        }
        public CalificacionIndividual(List<Jugadores<J>> jugadores,  Partida<J> juego) : base(jugadores, juego) 
        {
          if (!juego.PorPuntos || juego.Cantjugadores > 2) throw new InvalidOperationException("El juego no es compatible con este tipo de torneo");
        }
        #endregion
        #region Metodos
        public override void EjecutarPartida()
        {
           if (inicia)
           {
              inicia = false;
              Juego.Nueva(new Jugadores[1] { this.jugadores[competidorActual]} );
           }
           else 
           {
              Comprueba();
              Juego.Nueva(new Jugadores[1] { this.jugadores[competidorActual] });
           }
           competidorActual++; //siguiente jugador
        }
        /// <summary>
        /// Finaliza el juego si llego al ultimo conpetidor
        /// </summary>
        /// <returns></returns>
        public override bool Finalizo()
        {
            return competidorActual == jugadores.Count;
        }
        /// <summary>
        /// Devuelve resultado del torneo
        /// </summary>
        /// <returns></returns>
        public override string Ganador()
        {
            int i = MayorPuntuacion();
            return " Gana " + ((equipos == null) ? jugadores[i].Nombre : "Equipo "+ equipos[i].Nombre + " con " + Puntuaciones[i] + " puntos ");
        }
        void Comprueba()
        {
            if (Juego.Finalizo()) //actualiza puntuacion del jugador
            {
                Puntuaciones[competidorActual] = Juego.Puntuaciones[0];
            }
        }

        /// <summary>
        /// Devuelve indice mayor puntuacion
        /// </summary>
        /// <returns></returns>
        public int MayorPuntuacion()
        {
            int maximaPuntuacion = 0;
            int posicionMaximaPuntuacion = 0;

            for (int i = 0; i <= Puntuaciones.Length - 1; i++)
            {
                if (maximaPuntuacion < Puntuaciones[i])
                {
                    maximaPuntuacion = Puntuaciones[i];
                    posicionMaximaPuntuacion = i;
                }
            }
            return posicionMaximaPuntuacion;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class Titulo<J> : Torneo<J> where J : Juego
    {
        #region Variables de campo
        int gana =0; //posicion del ganador (en un inicio es el primero)
        int reta=1; //posicion del retador (en un inicio es el segundo)
        int proximoCompetidor = 1; //recorre posicion de competidores
        #endregion
        #region Constructores
        public Titulo(List<Equipo<J>> equipos, Partida<J> juego) : base(equipos, juego) 
        {

        }
        public Titulo(List<Jugadores<J>> jugadores, Partida<J> juego) : base(jugadores, juego) 
        { 

        }
        #endregion
        #region Metodos
        public override void EjecutarPartida()
        {
            if (inicia)
            {
                inicia = false;
                if (Juego.PorEquipos)
                    Juego.Nueva(new Equipo<J>[] { (Equipo<J>)equipos[gana], (Equipo<J>)equipos[reta] });
                else Juego.Nueva(new Jugadores<J>[] { (Jugadores<J>)jugadores[gana], (Jugadores<J>)jugadores[reta] });
            }
            else
            {
                Comprueba();
                Organiza();
                if (Juego.PorEquipos)
                    Juego.Nueva(new Equipo<J>[] { (Equipo<J>)equipos[gana], (Equipo<J>)equipos[reta] });
                else Juego.Nueva(new Jugadores<J>[] { (Jugadores<J>)jugadores[gana], (Jugadores<J>)jugadores[reta] });
             
            }
            proximoCompetidor++;
        }
        /// <summary>
        /// Verifica si finalizo el torneo
        /// </summary>
        /// <returns></returns>
        public override bool Finalizo()
        {
            if (proximoCompetidor == CantidadCompetidores)
            {
                Comprueba();

                return true;
            }
            return false;
        }
        /// <summary>
        /// Devuelve resultado del torneo
        /// </summary>
        /// <returns></returns>
        public override string Ganador()
        {
            return " gana " + ((equipos == null) ? jugadores[gana].Nombre : "Equipo " + equipos[gana].Nombre);
        }
        /// <summary>
        /// comprueba si finalizo la partida, en ese caso, actualiza ganador y suma puntos en caso que el juego lo requiera
        /// internamente le asigno uno
        /// </summary>
        void Comprueba() 
        {
            if (Juego.Finalizo()) //si la partida finalizo
            {
                //el 1er jugador o equipo que se paso fue "gana" que corresponde al indiceganador=0, el 2do fue "reta"  que corresponde al 1
                if (Juego.BuscaIndiceGanador() == 1) // si gano "reta", entonces "gana" coge el valor de "reta"
                {
                    gana = reta;                   
                }
                if (Juego.PorPuntos)
                {
                    Puntuaciones[gana] = Juego.Puntuaciones[Juego.BuscaIndiceGanador()];
                }
            }
        }
        /// <summary>
        /// Actualiza la posicion del retador para la proxima partida
        /// </summary>
        void Organiza() 
        {
            reta = proximoCompetidor;
        }
        #endregion

    }
}

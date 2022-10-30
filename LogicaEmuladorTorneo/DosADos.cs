using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class DosADos<J> : Torneo<J> where J : Juego
    {
        #region Variables de campo
        int fijo =0;    //posicion del primer competidor a jugar la partida, 
                        //posicion fija hasta que con el campo variable se recorran el resto  del arreglo de los competidores  
        int posicionProximoFijo=0;  //posicion proximo fijo que le corresponda jugar la partida
        int variable=1; //posicion del segundo equipo a jugar, posicion del competidor que se va moviendo una vez que juegue la partida
        int posicionProximoVariable=1; //posicion proximo variable que le corresponde jugar
        #endregion
        #region Constructores
        public DosADos(List<Equipo<J>> equipos, Partida<J> juego) : base(equipos, juego) 
        {

        }
		public DosADos(List<Jugadores<J>> jugadores, Partida<J> juego) : base(jugadores, juego) 
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
                    Juego.Nueva(new Equipo<J>[] { (Equipo<J>)equipos[fijo], (Equipo<J>)equipos[variable] });
                else Juego.Nueva(new Jugadores<J>[] { (Jugadores<J>)jugadores[fijo], (Jugadores<J>)jugadores[variable] });
            }
            else
            {
                Comprueba();
                Organiza();
                if (Juego.PorEquipos)
                    Juego.Nueva(new Equipo<J>[] { (Equipo<J>)equipos[fijo], (Equipo<J>)equipos[variable] });
                else Juego.Nueva(new Jugadores<J>[] { (Jugadores<J>)jugadores[fijo], (Jugadores<J>)jugadores[variable] });
            }
            ProximosJugadores();
        }
        /// <summary>
        /// Finaliza torneo si jugaron todos contra todos
        /// </summary>
        /// <returns></returns>
        public override bool Finalizo()
        {
            return posicionProximoFijo == CantidadCompetidores - 1; //se cumple si se combinaron todos con todos
        }
        /// <summary>
        /// Devuelve resultado del torneo
        /// </summary>
        /// <returns></returns>
        public override string Ganador()
        {
            int i = MayorPuntuacion();
            return " Gana " + ((equipos == null) ? jugadores[i].Nombre : "Equipo " + equipos[i].Nombre + " con " + Puntuaciones[i] + " puntos ");
        }
        /// <summary>
        /// Actualiza competidores de la  proxima Partida
        /// </summary>
        void Organiza()
        {
            fijo = posicionProximoFijo;
            variable = posicionProximoVariable;
        }
        /// <summary>
        /// Verifica si termino la partida, en tal caso actualiza las puntuaciones
        /// </summary>
        void Comprueba() 
        {
            if (Juego.Finalizo()) //si termino la partida actualizo las puntuaciones
            {
                if (Juego.BuscaIndiceGanador() == 0)
                {
                    Puntuaciones[fijo] += 1;
                    Puntuaciones[variable] -= 1;
                }
                else
                {
                    Puntuaciones[fijo] -= 1;
                    Puntuaciones[variable] += 1;
                }
            }
        }
        void ProximosJugadores()
        {
            if (posicionProximoVariable < CantidadCompetidores - 1)
                posicionProximoVariable++;
            else
                if (posicionProximoFijo < CantidadCompetidores - 2)
                {
                    posicionProximoFijo++;
                    posicionProximoVariable = posicionProximoFijo + 1;
                }
            else posicionProximoFijo++;
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
            return  posicionMaximaPuntuacion;
        }
        #endregion
    }
}

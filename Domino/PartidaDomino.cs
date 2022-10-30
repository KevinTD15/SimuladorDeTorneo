using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicaEmuladorTorneo;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class PartidaDomino:Partida<JuegoDomino>
    {
        #region Propiedades
        public override int[] Puntuaciones { get; protected set ; }
        public override bool PorEquipos { get ; protected set; }
        public override bool PorPuntos { get =>true ; }
        public override int Cantjugadores { get; set ; }
        public override int IndiceGanador => BuscaIndiceGanador();
        #endregion
        #region Constructor
        public PartidaDomino(bool porEquipos) /*: base(porEquipos, porPuntos)*/
        {
            Cantjugadores = 4;
            PorEquipos = porEquipos;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Devuelve indice del ganador de la partida
        /// </summary>
        /// <returns></returns>
        public override int BuscaIndiceGanador()
        {
            for (int i = 0; i < Puntuaciones.Length; i++)
            {
                if (Puntuaciones[i] >= 60) return i; // jugadores[i]; 
            }
            return -1;
        }
        /// <summary>
        /// Actualiza puntuaciones de los jugadores al final del juego.
        /// Crea instancia del juego si no ha finalizado. 
        /// </summary>
        public override void EjecutarJuego()
        {
            if (Juego.Finalizo == true) 
            {
                Puntuaciones[Juego.IndiceGanador] += ((JuegoDomino)Juego).PuntosGanador();
            }
            if (Finalizo()==false)
            {
                if(PorEquipos)
                    Juego = new JuegoDomino(equipos);
                else
                    Juego = new JuegoDomino(jugadores);
            }
        }
        /// <summary>
        /// Finaliza el juego si alguna puntuacion es >= 60
        /// </summary>
        /// <returns></returns>
        public override bool Finalizo()
        {
            foreach (int item in Puntuaciones)
            {
                if (item >= 60)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Prepara condiciones para ejecutar el juego
        /// </summary>
        /// <typeparam name="T"></typeparam>generico
        /// <param name="jugadores"></param>
        public override void Nueva<T>(T[] jugadores)
        {
            if (jugadores is Jugadores<JuegoDomino>[] listaJugadores )
            {
                if (jugadores.Length==0 || jugadores.Length%2!=0)
                    throw new InvalidOperationException("La cantidad de jugadores no es correcta");
                this.Juego = new JuegoDomino(listaJugadores);
                Puntuaciones = new int[listaJugadores.Length];
                this.jugadores = new Jugadores<JuegoDomino>[listaJugadores.Length];
                jugadores.CopyTo(this.jugadores, 0);
            }
            else if ( jugadores is Equipo<JuegoDomino>[] listaEquipos)
            {
                if ( jugadores.Length != 2  )
                    throw new InvalidOperationException("La cantidad de equipos no es correcta");
                this.Juego = new JuegoDomino(listaEquipos);
                Puntuaciones = new int[listaEquipos.Length];
                this.equipos = new Equipo<JuegoDomino>[listaEquipos.Length];
                jugadores.CopyTo(this.equipos, 0);
            }
            else
                throw new InvalidOperationException("Los jugadores no son de Domino");
        }
        #endregion
    }
}

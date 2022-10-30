using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
    public class PartidaTicTacToe: Partida<JuegoTicTacToe>  
    {
        #region Propiedades
        public override bool PorEquipos { get; protected set; }
        public override bool PorPuntos { get => false ;  }
        public override int[] Puntuaciones { get ; protected set ; }
        public override int Cantjugadores { get => 2;  set => throw new NotImplementedException("TicTacToe solo admite 2 jugadores por partida");}

        public override int IndiceGanador => Juego.IndiceGanador;
        #endregion
        #region Constructor
        public PartidaTicTacToe(bool porEquipos) 
        {
            if (porEquipos) throw new InvalidOperationException("TicTactoe no admite equipos");
            PorEquipos = false;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Prepara ejecucion del juego
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jugadores"></param>
        public override void Nueva<T>(T[] jugadores)
        {
            if (jugadores is Jugadores<JuegoTicTacToe>[] lista)
            {
                this.Juego = new JuegoTicTacToe(lista, 3, 3, 3);
                this.jugadores = new Jugadores<JuegoTicTacToe>[lista.Length];
                jugadores.CopyTo(this.jugadores, 0);
                Puntuaciones = new int[jugadores.Length];
            }

            else
                throw new InvalidOperationException("Los jugadores no son del TicTacToe");
        }

        public override void EjecutarJuego()
        {
            this.Juego = new JuegoTicTacToe(jugadores, 3, 3, 3);
        }
        /// <summary>
        /// Devuelve indice del ganador de la partida
        /// </summary>
        /// <returns></returns>
        public override int BuscaIndiceGanador()
        {
          return Juego.IndiceGanador;
        }
        /// <summary>
        /// Indica si finalizo la Partida o no
        /// </summary>
        /// <returns></returns>
        public override bool Finalizo()
        {
            if (Juego.Finalizo && Juego.Valido)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

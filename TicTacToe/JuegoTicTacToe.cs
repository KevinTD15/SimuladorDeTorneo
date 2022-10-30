using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
    public class JuegoTicTacToe: Juego
    {
        #region Piezas
        public enum Piezas
        {
            None,
            O,
            X
        };
        #endregion
        #region   Variables de campo
        readonly int[] posfila ={ 0, 0, 1, -1, 1, -1, 1, -1 }; //se utiliza para el analisis de los adyacentes
        readonly int[] poscolm ={ 1, -1, 0, 0, 1, -1, -1, 1 };
        Piezas piezaGanadora; //ficha que gana
        readonly int cantidadPiezasACoincidir; //cantidad de X o O que deben estar en fila o diagonal para ganar
        int elementosNone; //cantidad de elementos del tablero no poblados con X o O, es decir, None
        int indiceGanador=-1; //subindice del ganador
        protected Piezas[,] tablero;
        #endregion
        #region Propiedades
        public override int IndiceGanador => indiceGanador;
        protected override bool PorEquipos { get => false; set => throw new NotImplementedException(); }
        public override bool PorPuntos { get => false; }
        public override int Puntos { get ;  }
        #endregion
        #region Constructor
        public JuegoTicTacToe(Jugadores[] jugadores,int filas,int columnas,int cantidadPiezasACoincidir)
        {
            if (jugadores is Jugadores<JuegoTicTacToe>[]  lista)
            {
                this.jugadores = lista;
                tablero = new Piezas[filas, columnas];
                this.cantidadPiezasACoincidir = cantidadPiezasACoincidir;
                elementosNone = filas * columnas;
                fichasdeJugador = new List<object>();
                jugadas = new List<Jugada>();
            }
            else
            throw new InvalidOperationException("Los jugadores no son del TicTacToe");

        }
        #endregion
        #region Metodos 
        /// <summary>
        /// En este juego las fichas son "O" y "X", se puebla fichasdeJugador
        /// </summary>
        protected override void ReparteFichas()
        { 
            fichasdeJugador.Add(Piezas.X);  
            fichasdeJugador.Add(Piezas.O);
        }

        /// <summary>
        /// Poner en indiceGanador posicion del jugador ganador
        /// </summary>
        protected override void BuscaGanador()
        {
             indiceGanador = -1;
            for (int i = 0; i <= fichasdeJugador.Count - 1; i++)
            {
                if ((Piezas)fichasdeJugador[i] == piezaGanadora) //en gana esta "O" o "X" 
                {
                         indiceGanador = i;
                }
            }
        }
        /// <summary>
        /// Devuelve en la propiedad Finalizo true si termino la Partida y en Valido si termino el Juego
        /// </summary>
        protected override void JuegoFinalizado() 
        {
                for (int i = 0; i <= tablero.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j <= tablero.GetLength(1) - 1; j++)
                    {
                        if (!Finalizo)
                        {
                            if (tablero[i, j] != Piezas.None)
                            {
                                for (int x = 0; x <= posfila.Length - 1; x++)
                                {
                                    if (Busca(i, j, tablero[i, j], x, 1) == cantidadPiezasACoincidir)
                                    {
                                        Finalizo = true;
                                        Valido = true;
                                        piezaGanadora = tablero[i, j];
                                     
                                    }
                                }
                            }
                        }
                    }
                }
                if (!(Valido && Finalizo) ) //si no hubo ganador, chequeo si tablero lleno
                    if (EsTabla()) //si el tablero esta lleno, finaliza el juego pero no es valido
                    {
                        Finalizo = true;
                        Valido = false;
                        LimpiarTablero();
                    }
        }
        /// <summary>
        /// Genera las posibles jugadas a ejecutar
        /// </summary>
        /// <param name="numjugador">
        protected override void PosiblesJugadas()
        {
            for (int i = 0; i <= tablero.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= tablero.GetLength(1) - 1; j++)
                {
                    if (tablero[i, j] == Piezas.None)
                    {
                      jugadas.Add(new JugadaTicTacToe(" Juega " + i + ":" + j, tablero, i, j, (Piezas)fichasdeJugador[indiceJugadorActual]));
                    }
                }
            }
        }
        /// <summary>
        /// Evalua las jugadas para organizarlas para que los jugadores la seleccionen  en dependencia de su tipo.
        /// En el Tictactoe ubica como primera jugada la que tenga mayor numero de adyacentes
        /// </summary>
        protected override void OrganizarJugadas()
        {
            int MaxcantidadAdyacentes = 0;  //guarda mayor cantidad adyacentes obtenida
            int indiceJugada = 0;           //indice de la jugada con mayor cantidad de adyacentes
            Jugada mejorJugada = jugadas[0];

            for (int i = 0; i < jugadas.Count; i++)
            {
                JugadaTicTacToe jugada = (JugadaTicTacToe)jugadas[i];
                int cantidadAdyacentes = CantidadAdyacentes(jugada.fila, jugada.colum, jugada.pieza);
                //buscar ficha con mayor numero de adyacentes
                if (MaxcantidadAdyacentes <= cantidadAdyacentes)
                {
                    mejorJugada = jugada;
                    MaxcantidadAdyacentes = cantidadAdyacentes;
                    indiceJugada = i;
                }
            }

            if (indiceJugada != 0)
            {
                jugadas.Insert(0, mejorJugada);
                jugadas.RemoveAt(indiceJugada);
            }

        }
        /// <summary>
        /// Ejecuta la jugada
        /// </summary>
        protected override void ImplementaJugada()
        {
            JugadaTicTacToe jugada = (JugadaTicTacToe)Juega;
            tablero[jugada.fila, jugada.colum] = jugada.pieza;
            elementosNone--;
        }
        protected virtual bool EsTabla() 
        {
            if (elementosNone == 0) return true;
            else return false;
        }
        protected virtual int Busca(int fila, int colum, Piezas pieza, int pos,int cant)
        {            
            int a=fila + posfila[pos];
            int b=colum + poscolm[pos];

                if (0 <= a && 0 <= b && a <=tablero.GetLength(0) - 1 && b <=tablero.GetLength(1)-1)
                {
                    if (tablero[a, b] == pieza)
                   return Busca(a, b, pieza, pos,cant+1);
                }
           
            return cant;
        }
        protected virtual int CantidadAdyacentes(int fila, int colm, Piezas ficha)
        {
            int cantidadAdyacentes = 0;
            
            for (int i=0; i<= posfila.Length-1; i++)
            {
                int a=fila + posfila[i];
                int b=colm + poscolm[i];

                if (0 <= a && 0 <= b && a <=tablero.GetLength(0) - 1 && b <=tablero.GetLength(1)-1)
                { if (tablero[a, b] == ficha) { cantidadAdyacentes++; } }
                
            }
            return cantidadAdyacentes;
        }
        void LimpiarTablero()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    this.tablero[i, j] = Piezas.None;
                }
            }
            elementosNone= tablero.GetLength(0)* tablero.GetLength(1);
        }
        #endregion
    }

}

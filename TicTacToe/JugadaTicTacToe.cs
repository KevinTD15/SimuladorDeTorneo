using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
    public class JugadaTicTacToe : Jugada
    {
       public JuegoTicTacToe.Piezas[,] tablero { get; protected set; }
       public int fila { get; protected set; }
       public int colum { get; protected set; }
       public JuegoTicTacToe.Piezas pieza { get; protected set; }

       public JugadaTicTacToe(string reporte, JuegoTicTacToe.Piezas [,] tablero, int posfila, int poscolum, JuegoTicTacToe.Piezas pieza)
           : base(reporte)
       {
           this.tablero = tablero;
           fila = posfila;
           colum = poscolum;
           this.pieza = pieza;
       }
    }
}
    

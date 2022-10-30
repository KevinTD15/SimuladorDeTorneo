using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
     public class FichaDomino
    {
         public int LadoA { get; protected set; }
         public int LadoB { get; protected set; }
         public FichaDomino(int a, int b)
         {
             LadoA = a;
             LadoB = b;
         }

    }
}

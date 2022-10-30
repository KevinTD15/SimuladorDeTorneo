using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
     public class JugadaDomino: Jugada
    {
        public FichaDomino Ficha { get; protected set; }
        public JugadaDomino(FichaDomino ficha, string reporte):base(reporte)
        {
            this.Ficha = ficha;
        }
    }
}

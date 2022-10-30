using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
    public class Jugada
    {
       public string Reporte { get; protected set; }
       public Jugada(string reporte)
       {
           this.Reporte = reporte; //poner en la propiedad reporte el texto que se quiere visualizar, podia hacerse
       }                            // tambien que las clases que heredan de esta creen su propio ToString

        public override string ToString()
        {
            return Reporte;
        }
    }

}

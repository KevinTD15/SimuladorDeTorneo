using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class JugadorGoloso<J> : Jugadores<J> where J : Juego
    {
        public JugadorGoloso(string nombre)
        {
            if (nombre.Equals(string.Empty)) throw new InvalidOperationException("El Jugador no tiene nombre");
            base.Nombre = nombre;
        }       
       protected override T SeleccionarJugada<T>(List<T> posiblesjugadas)
       {
           return posiblesjugadas[0];
       } 
    }
}

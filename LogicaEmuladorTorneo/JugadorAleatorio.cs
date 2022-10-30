using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class JugadorAleatorio<J> : Jugadores<J>  where J : Juego
    {
        Random seleccionarjugada = new Random();

        public JugadorAleatorio(string nombre) 
        {
            if(nombre.Equals(string.Empty)) throw new InvalidOperationException("El Jugador no tiene nombre");
            base.Nombre=nombre;
        }

        protected override Jugada SeleccionarJugada<Jugada>(List<Jugada> posiblesjugadas)
        {
              int juega = seleccionarjugada.Next(posiblesjugadas.Count);
            return posiblesjugadas[juega];
        }
    }

}

using System.Collections.Generic;

namespace LogicaEmuladorTorneo
{
    public abstract class Jugadores<J> : Jugadores    { }
    public abstract class Jugadores 
    {
        public string Nombre { get; protected set; }
        public virtual T Juega<T>(List<T> posiblesjugadas)
        {
            return SeleccionarJugada(posiblesjugadas);
        }

        protected abstract T SeleccionarJugada<T>(List<T> posiblesjugadas);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaEmuladorTorneo
{
    public class Equipo<J> : Equipo
    {
        public Equipo(string nombre) : base(nombre) { }

    }
    public class Equipo 
    {
        public string Nombre { get; protected set; }
        public List<Jugadores> Jugadores { get; }
        public Equipo(string nombre)
        {
            this.Nombre = nombre;
            Jugadores = new List<Jugadores>();
        }
        /// <summary>
        /// Anadir jugador al equipo
        /// </summary>
        /// <param name="jugador"></param>
        public void AgregaJugador(Jugadores jugador)
        {
            if (jugador is null) throw new InvalidOperationException("No existe jugador");
            if (jugador.Nombre.Equals(string.Empty)) throw new InvalidOperationException("El Jugador no tiene nombre");
            Jugadores.Add(jugador); 
        }
        /// <summary>
        /// Verificar si existen jugadores
        /// </summary>
        /// <returns></returns>
        public bool ExistenJugadores()
        { return Jugadores.Count > 0; }
        /// <summary>
        /// Cantidad jugadores
        /// </summary>
        /// <returns></returns>
        public int CantidadJugadores()
        { return Jugadores.Count; }

    }
}

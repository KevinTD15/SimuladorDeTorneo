using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaEmuladorTorneo
{

    public class Emulador<J> where J : Juego 
    {
        #region Variables de campo
        readonly Torneo<J> torneo;
        readonly Partida<J> juego;
        readonly List<Tuple<string, string>> notificaciones = new List<Tuple<string, string>>();
        #endregion
        #region Propiedades
        public List<Tuple<string, string>> Notificaciones { get => notificaciones; }
        #endregion
        #region Constructor
        public Emulador(Torneo<J> torneo, Partida<J> juego)
        {
            this.torneo = torneo;
            this.juego = juego;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Inicia el Torneo
        /// </summary>
        public void Iniciar()
        {
            if (torneo is null ||juego is null)
            {
                throw new InvalidOperationException("Falta Torneo y/o Partida");
            }
            GuardarNotificacion("Torneo", "Comienzo de Torneo ");
            foreach (var partida in torneo.Ejecutar)
            {
                GuardarNotificacion("Partida", "Comienzo de Partida");
                foreach (var juego in partida.Ejecutar)
                {
                    if (!partida.Finalizo())
                    {
                        GuardarNotificacion("Juego", "Comienzo de Juego ");
                        foreach (var jugada in juego.Ejecutar)
                        {
                            if (!(jugada is null))
                                 GuardarNotificacion("Jugada",juego.JugadorJugo + jugada.ToString());
                        }
                        GuardarNotificacion("Juego", "Juego Finalizado "+ juego.JugadorGanador);
                    }
                }
                GuardarNotificacion("Partida", "Partida Finalizada " + partida.JugadorGanador);
            }
            GuardarNotificacion("Torneo","Torneo Finalizado " + torneo.Ganador() );
        }
        /// <summary>
        /// guardar notificaciones en una lista para mostrar segun desee el usuario
        /// </summary>
        /// <param name="tipo"></param> valores: Juego , Partida, Jugada   (depende a que corresponda la notificacion)
        /// <param name="texto"></param> notificacion que se desee mostrar
        public   void GuardarNotificacion(string tipo, string texto)
        {
            notificaciones.Add(new Tuple<string,string>(tipo, texto));
        }
        #endregion
    }
}

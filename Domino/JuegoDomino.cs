using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmuladorTorneo
{
    public class JuegoDomino: Juego
    {
        #region Variables de campo
        int pases;
        readonly int cantidadJugadores;
        List<FichaDomino> individuales;
        readonly List<FichaDomino> mesa;
        int indiceJugadorGanador=-1;
        readonly int[] puntos;
        bool vacia = true;
        readonly Random repartir = new Random();

        int derecha;
        int izquierda;
        #endregion
        #region Propiedades
        public override int IndiceGanador => (PorEquipos) ? indiceJugadorGanador % 2 : indiceJugadorGanador;
        protected override bool PorEquipos { get; set ; }
        public override bool PorPuntos { get => true;  }
        public override int Puntos => PuntosGanador();
        #endregion
        #region Constructores
        public JuegoDomino(Jugadores[] jugadores)
        {
            if (jugadores is Jugadores<JuegoDomino>[] lista)
            {
                this.jugadores = lista;
                this.cantidadJugadores = jugadores.Length;
                mesa = new List<FichaDomino>();
                CrearFichas();
                puntos = new int[cantidadJugadores];
                individuales = new List<FichaDomino>();
                fichasdeJugador = new List<object>();
                jugadas = new List<Jugada>();
                PorEquipos = false;
            }
            else
                throw new InvalidOperationException("Los jugadores no son de Domino");
        }
        public JuegoDomino(Equipo[] equipos)
        {
            if (equipos is Equipo<JuegoDomino>[] listaEquipos )
            {
                this.cantidadJugadores = equipos.Length * equipos[0].Jugadores.Count;
                this.equipos = new Equipo<JuegoDomino>[] { listaEquipos[0], listaEquipos[1] };

                this.jugadores = new Jugadores<JuegoDomino>[this.cantidadJugadores];
                for (int i = 0,j=0; i < equipos[0].Jugadores.Count; i++,j+=2)
                {
                    jugadores[j] = equipos[0].Jugadores[i];
                    jugadores[j+1] = equipos[1].Jugadores[i];
                }
                mesa = new List<FichaDomino>();
                CrearFichas();
                puntos = new int[cantidadJugadores];
                individuales = new List<FichaDomino>();
                fichasdeJugador = new List<object>();
                jugadas = new List<Jugada>();
                PorEquipos = true;
            }
            else
                throw new InvalidOperationException("Los equipos no son de Domino");
        }
        #endregion
        #region Metodos

        /// <summary>
        /// Poner en indiceGanador posicion del jugador ganador
        /// </summary>
        protected override void BuscaGanador()
        {
            SumaPuntos();
            if (pases == cantidadJugadores) // si la cantidad de pases coincide con la cantidad de jugadores
            {                               // es decir, se tranco el juego, se busca el que tenga menor puntuacion
                int indiceMenorPuntuacion = 0;
                int MayorPuntuacion = puntos[0];
                for (int i = 1; i < cantidadJugadores; i++)
                {
                    if (puntos[i] < MayorPuntuacion) 
                    {
                        MayorPuntuacion = puntos[i];
                        indiceMenorPuntuacion = i;
                    }
                }
                indiceJugadorGanador = indiceMenorPuntuacion;
            }

        }
        /// <summary>
        /// Ejecuta la jugada
        /// </summary>
        protected override void ImplementaJugada()
        {
            JugadaDomino jugada = (JugadaDomino)Juega;

            if (vacia) 
            {
                derecha = jugada.Ficha.LadoB;
                izquierda = jugada.Ficha.LadoA;
                vacia = false;
            }

            else if (jugada.Ficha == null) {pases++;}
            else if (jugada.Ficha.LadoA == derecha) {derecha= jugada.Ficha.LadoB; pases=0; }
            else if (jugada.Ficha.LadoA == izquierda) {izquierda= jugada.Ficha.LadoB; pases=0; }
            else if (jugada.Ficha.LadoB == derecha) {derecha= jugada.Ficha.LadoA; pases=0; }
            else if (jugada.Ficha.LadoB == izquierda) { izquierda = jugada.Ficha.LadoA; pases = 0; }

            List<FichaDomino> fichasDeUnJugador = (List<FichaDomino>)fichasdeJugador[ indiceJugadorActual ];
            fichasDeUnJugador.Remove(jugada.Ficha); //se elimina ficha jugada
        }
        /// <summary>
        /// Devuelve en la propiedad Finalizo true si termino la Partida y en Valido si termino el Juego
        /// </summary>
        protected override void JuegoFinalizado()
        {
            if (pases== cantidadJugadores)
            {
                Finalizo= true;
                Valido = true;
            }
            else
            {
                for (int i = 0; i < cantidadJugadores; i++)
                {
                    List<FichaDomino> fichasDeUnJugador = (List<FichaDomino>)fichasdeJugador[i];
                    if (fichasDeUnJugador.Count == 0)
                    {
                        Finalizo = true;
                        Valido = true;
                        indiceJugadorGanador = i;
                    }
                }
            }
        }
        /// <summary>
        /// Evalua las jugadas para organizarlas para que los jugadores la seleccionen  en dependencia de su tipo.
        /// En el Domino ubica como primera jugada la ficha que tenga mayor puntuacion
        /// </summary>
        protected override void OrganizarJugadas()
        {
            int suma;
            JugadaDomino mejor = (JugadaDomino)jugadas[0];
            
            if (mejor.Ficha != null)
            {
                int mayorPuntuacion = mejor.Ficha.LadoA + mejor.Ficha.LadoB;
                int jugadaConMayorPuntuacion = 0;

                for (int i = 1; i < jugadas.Count; i++)
                {
                    JugadaDomino jugada = (JugadaDomino)jugadas[i];
                    suma = jugada.Ficha.LadoA + jugada.Ficha.LadoB;
                    if (suma > mayorPuntuacion) 
                    {
                        mayorPuntuacion = suma;
                        mejor = jugada;
                        jugadaConMayorPuntuacion = i;
                    }
                }
                jugadas.RemoveAt(jugadaConMayorPuntuacion);
                jugadas.Insert(0, mejor);
            }
        }
        /// <summary>
        /// Genera posibles jugadas a ejecutar
        /// </summary>
        /// <param name="jugador"></param>
        protected override void PosiblesJugadas()
        {
            FichaDomino ficha;
            string mostrar;

            individuales = (List<FichaDomino>)fichasdeJugador[indiceJugadorActual];
            if (vacia)
            {
                for (int i = 0; i < individuales.Count; i++)
                {
                    ficha = individuales[i];
                    mostrar = " juega " + ficha.LadoA + ":" + ficha.LadoB;
                    jugadas.Add(new JugadaDomino(ficha, mostrar));
                }
           }
            else
            {
                for (int i = 0; i < individuales.Count; i++)
                {
                    ficha = individuales[i];
                    if (ficha.LadoA == derecha || ficha.LadoA == izquierda || ficha.LadoB == derecha || ficha.LadoB == izquierda)
                    {
                        mostrar = " juega  " + ficha.LadoA + ":" + ficha.LadoB;
                        jugadas.Add(new JugadaDomino(ficha, mostrar));
                    }
                }

                if (jugadas.Count == 0) { jugadas.Add(new JugadaDomino(null," se pasa")); }
            }
        }
        /// <summary>
        /// Asignar a cada jugador sus fichas. Se escogen de forma aleatoria 
        /// </summary>
        protected override void ReparteFichas()
        {
            int indiceJugador = 0;
            
            for (int i = 0; i < cantidadJugadores; i++)
            {
                fichasdeJugador.Add(new List<FichaDomino>(7));
            }

            while (indiceJugador < cantidadJugadores)
            {
                List<FichaDomino> fichasDeUnJugador = (List<FichaDomino>)fichasdeJugador[indiceJugador];
                for (int i = 0; i <= 6; i++)
                {
                  int indiceAleatorio=repartir.Next(0, mesa.Count - 1);
                  fichasDeUnJugador.Add(mesa[indiceAleatorio]); //se escoge ficha aleatoria de la mesa
                  mesa.RemoveAt(indiceAleatorio);               //elimino de la mesa la ficha asignada al jugador
                }
                indiceJugador++;
            }
        }
        /// <summary>
        /// Crea las fichas del Domino (hasta el 6)
        /// </summary>
        protected virtual void CrearFichas()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    mesa.Add(new FichaDomino(i, j));
                }
            }
        }
        /// <summary>
        /// Suma los puntos de cada jugador al terminar el juego
        /// </summary>
        protected virtual void SumaPuntos()
        {
            int p = 0;
            while (p < cantidadJugadores)
            {
                List<FichaDomino> fichasDeUnJugador = (List<FichaDomino>)fichasdeJugador[p];
                for (int i = 0; i < fichasDeUnJugador.Count; i++)
                {
                    puntos[p] += (fichasDeUnJugador[i].LadoA + fichasDeUnJugador[i].LadoB);
                }
                p++;
            }
        }
        /// <summary>
        /// Devuelve los puntos obtenidos por el Equipo o Jugador si es individual
        /// </summary>
        /// <returns></returns>
        public int PuntosGanador()
        {
            int suma = 0;

            for (int i = 0; i < cantidadJugadores; i++)
            {
                if (PorEquipos) //si es por equipo sumo los puntos de los jugadores que no pertenecen al equipo del jugador ganador
                {
                    if (i % 2 != indiceJugadorGanador % 2)
                        suma += puntos[i];
                }
                else
                {
                    if (i != indiceJugadorGanador)
                        suma += puntos[i];
                }
            }
            return suma;
        }
        #endregion
    }
}

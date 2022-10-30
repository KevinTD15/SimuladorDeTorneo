using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaEmuladorTorneo;

namespace EmuladorTorneoJuegosMesa
{
    public partial class Ejecucion : Form
    {
      //  readonly Emulador<Juego> emulador; //emulador del torneo

        //readonly Emulador<JuegoTicTacToe> emuladorTicTacToe;
        //readonly Emulador<JuegoDomino> emuladorDomino;

        string ejecutar; //indica en cual notificacion parar segun el modo de ejecucion selecionado
        int indiceNotificacion = 0; //indice notificacion en curso;
        readonly List<Tuple<string, string>> Notificaciones;
        public Ejecucion(Emulador<JuegoTicTacToe> emuladorTicTacToe)
        {
            InitializeComponent();
            Notificaciones = emuladorTicTacToe.Notificaciones;
            emuladorTicTacToe.Iniciar();
        }
        public Ejecucion(Emulador<JuegoDomino> emuladorDomino)
        {
            InitializeComponent();
            Notificaciones = emuladorDomino.Notificaciones;
            emuladorDomino.Iniciar();
        }
        /// <summary>
        /// Evaluar si se muestra o no una notificacion
        /// </summary>
        public void EvaluarMostrar()
        {
            if (!( Notificaciones[indiceNotificacion].Item2.Contains(ejecutar)))
            {
                if (SiFiltro()) //ver si hay algun filtro desmarcado de las posible a mostrar para no hacerlo
                    notificaciones.Items.Add( Notificaciones[indiceNotificacion].Item2);
                indiceNotificacion++;
            }
            else
            {
                if (SiFiltro())
                    notificaciones.Items.Add( Notificaciones[indiceNotificacion].Item2);
                indiceNotificacion++;
                timer1.Stop();
                ejecutar = string.Empty;
            }
        }
        /// <summary>
        /// Analizar si marcaron o desmarcaron filtros de notificacion
        /// </summary>
        private bool SiFiltro()  
        {  
            if (!mostraPartidas.Checked &&  Notificaciones[indiceNotificacion].Item1=="Partida") return false;
            if (!mostrarJuegos.Checked &&  Notificaciones[indiceNotificacion].Item1 == "Juego") return false;
            if (!mostrarJugadas.Checked &&  Notificaciones[indiceNotificacion].Item1 == "Jugada") return false;
            return true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BAcelerar_Click(object sender, EventArgs e)
        {
            if (timer1.Interval>100)
                 timer1.Interval -= 100;
        }

        private void BRetardar_Click(object sender, EventArgs e)
        {
            timer1.Interval += 100;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (indiceNotificacion <  Notificaciones.Count)
            {
                if (ejecutar.Equals(string.Empty))    //ejecutar automatico las jugadas
                {
                    if ( Notificaciones[indiceNotificacion].Item1.Contains("Jugada"))
                        notificaciones.Items.Add( Notificaciones[indiceNotificacion].Item2);
                    indiceNotificacion++;
                }
                else
                    EvaluarMostrar();

                if (notificaciones.Items.Count > 16) notificaciones.Items.Clear();

                if (indiceNotificacion == Notificaciones.Count)
                {
                    replay.Enabled = true;
                    MessageBox.Show(Notificaciones[indiceNotificacion - 1].Item2, "Torneo");
                }
            }
            else
            {
                timer1.Stop();
            }

        }

        private void BPartidaActual_Click(object sender, EventArgs e)
        {
            ejecutar = "Partida Finalizada";
            timer1.Start();
        }

        private void BTorneo_Click(object sender, EventArgs e)
        {
            ejecutar = "Torneo Finalizado";
            timer1.Start();
        }

        private void BJuegoActual_Click(object sender, EventArgs e)
        {
            ejecutar = "Juego Finalizado";
            timer1.Start();
        }

        private void BJugada_Click(object sender, EventArgs e)
        {
            ejecutar = "Jugada";
            timer1.Start();
        }

        private void Juegos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MostrarJugadas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Replay_Click(object sender, EventArgs e)
        {
            notificaciones.Items.Clear();
            for (int i = 0; i <  Notificaciones.Count; i++)
                notificaciones.Items.Add( Notificaciones[i].Item2);
        }

        private void BAutomaticamente_Click(object sender, EventArgs e)
        {
            ejecutar = string.Empty;
            timer1.Start();
        }
    }
}

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
    public partial class Configuracion : Form
    {
        Emulador<JuegoTicTacToe> emuladorTicTacToe;
        Emulador<JuegoDomino> emuladorDomino;

        Torneo<JuegoTicTacToe> torneoTicTacToe;
        Torneo<JuegoDomino> torneoDomino;

        PartidaTicTacToe juegoTicTacToe;
        PartidaDomino juegoDomino;

        //lista de jugadores de cada uno de los tipos de juego por si entroducen lista jugadores
        List<Jugadores<JuegoTicTacToe>> jugadoresTicTacToe = new List<Jugadores<JuegoTicTacToe>>();
        List<Jugadores<JuegoDomino>> jugadoresDomino = new List<Jugadores<JuegoDomino>>();

        //lista de jugadores de  cada uno de los tipos de juego por si entroducen por equipo
        List<Equipo<JuegoTicTacToe>> equiposTicTacToe = new List<Equipo<JuegoTicTacToe>>();
        List<Equipo<JuegoDomino>> equiposDomino = new List<Equipo<JuegoDomino>>();

        public Configuracion()
        {
            InitializeComponent();
        }

        private void GbJuegos_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void LnombreJugador_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CantidadJugadoresValida()
        {

            if (tictactoe.Checked)
            {

                if (TotalJugadoresEquipos() < 2 && jugadoresTicTacToe.Count < 2)
                    return false;
            }
            else if (domino.Checked)
            {
                if (!(TotalJugadoresEquipos() > 0 && TotalJugadoresEquipos() % juegoDomino.Cantjugadores == 0) &&
                    ! (jugadoresDomino.Count > 0 && jugadoresDomino.Count % juegoDomino.Cantjugadores == 0))
                    return false;
            }
            return true;
        }
        private int TotalJugadoresEquipos()
        {
            int cantidad=0;

            if (equiposTicTacToe.Count>0)
                foreach (var equipo in equiposTicTacToe)
                {
                    cantidad += equipo.CantidadJugadores();
                }
            else
            if (equiposDomino.Count>0)
                foreach (var equipo in equiposDomino)
                {
                    cantidad += equipo.CantidadJugadores();
                }
            return cantidad;
        }
        private void bFinalizar_Click(object sender, EventArgs e)
        {
            Form ejecucion;

            //try
            //{
                if (titulo.Checked || dosADos.Checked || calificacionIndividual.Checked)
                {
                    if (PrepararTorneo())
                    {
                        if (juegoTicTacToe != null)
                        {
                            emuladorTicTacToe = new Emulador<JuegoTicTacToe>(torneoTicTacToe, juegoTicTacToe);//listo para ejecutarse el emulador
                            Emulador<JuegoTicTacToe> emulator = emuladorTicTacToe;
                            ejecucion = new Ejecucion(emulator);
                            ejecucion.Show();
                        }
                        else if (juegoDomino != null)
                        {
                            emuladorDomino = new Emulador<JuegoDomino>(torneoDomino, juegoDomino);
                            Emulador<JuegoDomino> emulator = emuladorDomino;
                            ejecucion = new Ejecucion(emulator);
                            ejecucion.Show();
                        }

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de jugadores introducidos no es valida "); // (jugadores introducidos:" + listaJugadores.Count + " por partida=" + partida.cantjugadores);
                        gbTiposDeTorneo.Enabled = false;
                        bjJugadoresEquipos.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Falta seleccionar Tipo de Torneo");
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            string tipo = (aleatorio.Checked) ? aleatorio.Text : goloso.Text;

            if (jugador.Text.Equals(string.Empty) || tipo.Equals(string.Empty))
                MessageBox.Show("Falta Nombre o Tipo de Jugador");
            else
            if (equiposTicTacToe.Count > 0 || equiposDomino.Count>0)  //se estan introduciendo equipos
            { 
                //verificar que si estan introduciendo equipos no dejen un jugador sin equipo
                if (equipo.Text.Equals(string.Empty))
                    MessageBox.Show("Usted ha introducido los jugadores por Equipo. Falta nombre de Equipo");
                else
                {
                    if (tictactoe.Checked)
                    {
                        if (tipo == "Aleatorio") equiposTicTacToe[equiposTicTacToe.Count - 1].AgregaJugador(new JugadorAleatorio<JuegoTicTacToe>(jugador.Text));
                        else if (tipo == "Goloso") equiposTicTacToe[equiposTicTacToe.Count - 1].AgregaJugador(new JugadorGoloso<JuegoTicTacToe>(jugador.Text));
                    }
                    else if (domino.Checked)
                    {
                        if (tipo == "Aleatorio") equiposDomino[equiposDomino.Count - 1].AgregaJugador(new JugadorAleatorio<JuegoDomino>(jugador.Text));
                        else if (tipo == "Goloso") equiposDomino[equiposDomino.Count - 1].AgregaJugador(new JugadorGoloso<JuegoDomino>(jugador.Text));
                       
                    }
                    jugadores.Items.Add(jugador.Text + " " + tipo);
                }
            }
            else
            {  
                //verificar que si estan introduciendo solo jugadores no introduzcan uno con equipo
                if (equipo.Text.Equals(string.Empty) && (equiposTicTacToe.Count > 0 || equiposDomino.Count > 0))
                    MessageBox.Show("Los jugadores que ha introducido no han pertenecido a equipos. Rectifique");
                else
                {
                    if (tictactoe.Checked)
                    {
                        if (tipo == "Aleatorio") jugadoresTicTacToe.Add(new JugadorAleatorio<JuegoTicTacToe>(jugador.Text));
                        else if (tipo == "Goloso") jugadoresTicTacToe.Add(new JugadorGoloso<JuegoTicTacToe>(jugador.Text));
                    }
                    else if (domino.Checked)
                    {
                        if (tipo == "Aleatorio") jugadoresDomino.Add(new JugadorAleatorio<JuegoDomino>(jugador.Text));
                        else if (tipo == "Goloso") jugadoresDomino.Add(new JugadorGoloso<JuegoDomino>(jugador.Text));
                    }
                }
                jugadores.Items.Add(jugador.Text + " " + tipo);
            }

            jugador.Text = ""; 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private bool PrepararTorneo()
        { 
            bool porEquipos = (equiposTicTacToe.Count > 0 || equiposDomino.Count > 0);
            
            if (tictactoe.Checked)
                juegoTicTacToe = new PartidaTicTacToe(porEquipos);
            else
            if (domino.Checked)
                juegoDomino = new PartidaDomino(porEquipos);
            if (!CantidadJugadoresValida())
             return false; 
            else

            if (equiposTicTacToe.Count > 0)
            {
                if (titulo.Checked) torneoTicTacToe = new Titulo<JuegoTicTacToe>(equiposTicTacToe, juegoTicTacToe);

                else if (dosADos.Checked) torneoTicTacToe = new DosADos<JuegoTicTacToe>(equiposTicTacToe, juegoTicTacToe);

                else if (calificacionIndividual.Checked) torneoTicTacToe = new CalificacionIndividual<JuegoTicTacToe>(equiposTicTacToe, juegoTicTacToe);

            }
            else if (jugadoresTicTacToe.Count > 0)
            {
                if (titulo.Checked) torneoTicTacToe = new Titulo<JuegoTicTacToe>(jugadoresTicTacToe, juegoTicTacToe);

                else if (dosADos.Checked) torneoTicTacToe = new DosADos<JuegoTicTacToe>(jugadoresTicTacToe, juegoTicTacToe);

                else if (calificacionIndividual.Checked) torneoTicTacToe = new CalificacionIndividual<JuegoTicTacToe>(jugadoresTicTacToe, juegoTicTacToe);

            }
            else
        if (equiposDomino.Count > 0)
            {
                if (titulo.Checked) torneoDomino = new Titulo<JuegoDomino>(equiposDomino, juegoDomino);

                else if (dosADos.Checked) torneoDomino = new DosADos<JuegoDomino>(equiposDomino, juegoDomino);

                else if (calificacionIndividual.Checked)
                {
                    MessageBox.Show("Calificacion Individual no admite Domino");
                    return false;
                }

            }
            else if (jugadoresDomino.Count > 0)
            {
                if (titulo.Checked) torneoDomino = new Titulo<JuegoDomino>(jugadoresDomino, juegoDomino);

                else if (dosADos.Checked) torneoDomino = new DosADos<JuegoDomino>(jugadoresDomino, juegoDomino);

                else if (calificacionIndividual.Checked)
                {
                    MessageBox.Show("Calificacion Individual no admite Domino");
                    return false;
                }
            }

            return true;
        }

        private void BSiguienteJuegos_Click(object sender, EventArgs e)
        {
            if (!tictactoe.Checked && !domino.Checked)
                MessageBox.Show("Escoja el Juego");
            else
            {
                bjJugadoresEquipos.Enabled = true;
                gbJuegos.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if ((equiposTicTacToe.Count == 0 && jugadoresTicTacToe.Count ==0) &&
                (equiposDomino.Count == 0 && jugadoresDomino.Count == 0))
                MessageBox.Show("Introduzca jugadores");
            else
            {
                gbTiposDeTorneo.Enabled = true;
                bjJugadoresEquipos.Enabled = false;
            }
        }

        private void BAnadirEquipo_Click(object sender, EventArgs e)
        {
            if (equipo.Text.Equals(string.Empty))
                MessageBox.Show("Falta nombre de Equipo");
            else
            {
                if (tictactoe.Checked) equiposTicTacToe.Add(new Equipo<JuegoTicTacToe>(equipo.Text));
                else if (domino.Checked) equiposDomino.Add(new Equipo<JuegoDomino>(equipo.Text));

                jugadores.Items.Add("Equipo: " + equipo.Text);
                equipo.Enabled = false;
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (equiposTicTacToe.Count>0)
            {
                if ( !equiposTicTacToe[equiposTicTacToe.Count - 1].ExistenJugadores())
                    MessageBox.Show("Falta Introducir Jugadores");
                else
                {
                    equipo.Text = "";
                    equipo.Enabled = true;
                }
            }
            else
            if (equiposDomino.Count > 0)
            {
                if (!equiposDomino[equiposDomino.Count - 1].ExistenJugadores())
                    MessageBox.Show("Falta Introducir Jugadores");
                else
                {
                    equipo.Text = "";
                    equipo.Enabled = true;
                }
            }
            else
            {
                equipo.Text = "";
                equipo.Enabled = true;
            }
          
        }

        private void Blimpiar_Click(object sender, EventArgs e)
        {
            equiposTicTacToe.Clear();
            jugadoresTicTacToe.Clear();
            equiposDomino.Clear();
            jugadoresDomino.Clear();

            jugadores.Items.Clear();
            jugador.Text = "";
            equipo.Text = "";
            equipo.Enabled = true;
        }

        private void Banterior_Click(object sender, EventArgs e)
        {
            bjJugadoresEquipos.Enabled = false;
            gbJuegos.Enabled = true;
        }

        private void PorPuntos_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}

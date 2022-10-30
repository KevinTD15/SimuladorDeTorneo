namespace EmuladorTorneoJuegosMesa
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJuegos = new System.Windows.Forms.GroupBox();
            this.tictactoe = new System.Windows.Forms.RadioButton();
            this.bSiguienteJuegos = new System.Windows.Forms.Button();
            this.domino = new System.Windows.Forms.RadioButton();
            this.bjJugadoresEquipos = new System.Windows.Forms.GroupBox();
            this.banterior = new System.Windows.Forms.Button();
            this.blimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bAnadirEquipo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bAnadirJugador = new System.Windows.Forms.Button();
            this.jugadores = new System.Windows.Forms.ListBox();
            this.equipo = new System.Windows.Forms.TextBox();
            this.lequipo = new System.Windows.Forms.Label();
            this.jugador = new System.Windows.Forms.TextBox();
            this.lJugador = new System.Windows.Forms.Label();
            this.aleatorio = new System.Windows.Forms.RadioButton();
            this.goloso = new System.Windows.Forms.RadioButton();
            this.gbTiposDeTorneo = new System.Windows.Forms.GroupBox();
            this.bFinalizar = new System.Windows.Forms.Button();
            this.calificacionIndividual = new System.Windows.Forms.RadioButton();
            this.titulo = new System.Windows.Forms.RadioButton();
            this.dosADos = new System.Windows.Forms.RadioButton();
            this.gbJuegos.SuspendLayout();
            this.bjJugadoresEquipos.SuspendLayout();
            this.gbTiposDeTorneo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJuegos
            // 
            this.gbJuegos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbJuegos.Controls.Add(this.tictactoe);
            this.gbJuegos.Controls.Add(this.bSiguienteJuegos);
            this.gbJuegos.Controls.Add(this.domino);
            this.gbJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJuegos.Location = new System.Drawing.Point(12, 97);
            this.gbJuegos.Name = "gbJuegos";
            this.gbJuegos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbJuegos.Size = new System.Drawing.Size(176, 332);
            this.gbJuegos.TabIndex = 0;
            this.gbJuegos.TabStop = false;
            this.gbJuegos.Text = "Juegos";
            this.gbJuegos.Enter += new System.EventHandler(this.GbJuegos_Enter);
            // 
            // tictactoe
            // 
            this.tictactoe.AutoSize = true;
            this.tictactoe.Checked = true;
            this.tictactoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tictactoe.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoe.ForeColor = System.Drawing.Color.DarkGreen;
            this.tictactoe.Location = new System.Drawing.Point(15, 51);
            this.tictactoe.Name = "tictactoe";
            this.tictactoe.Size = new System.Drawing.Size(127, 33);
            this.tictactoe.TabIndex = 4;
            this.tictactoe.TabStop = true;
            this.tictactoe.Text = "TicTacToe";
            this.tictactoe.UseVisualStyleBackColor = true;
            // 
            // bSiguienteJuegos
            // 
            this.bSiguienteJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguienteJuegos.Location = new System.Drawing.Point(64, 298);
            this.bSiguienteJuegos.Name = "bSiguienteJuegos";
            this.bSiguienteJuegos.Size = new System.Drawing.Size(106, 29);
            this.bSiguienteJuegos.TabIndex = 3;
            this.bSiguienteJuegos.Text = " Siguiente";
            this.bSiguienteJuegos.UseVisualStyleBackColor = true;
            this.bSiguienteJuegos.Click += new System.EventHandler(this.BSiguienteJuegos_Click);
            // 
            // domino
            // 
            this.domino.AutoSize = true;
            this.domino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.domino.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domino.ForeColor = System.Drawing.Color.DarkGreen;
            this.domino.Location = new System.Drawing.Point(15, 86);
            this.domino.Name = "domino";
            this.domino.Size = new System.Drawing.Size(103, 33);
            this.domino.TabIndex = 2;
            this.domino.TabStop = true;
            this.domino.Text = "Domino";
            this.domino.UseVisualStyleBackColor = true;
            // 
            // bjJugadoresEquipos
            // 
            this.bjJugadoresEquipos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bjJugadoresEquipos.Controls.Add(this.banterior);
            this.bjJugadoresEquipos.Controls.Add(this.blimpiar);
            this.bjJugadoresEquipos.Controls.Add(this.button2);
            this.bjJugadoresEquipos.Controls.Add(this.bAnadirEquipo);
            this.bjJugadoresEquipos.Controls.Add(this.button1);
            this.bjJugadoresEquipos.Controls.Add(this.bAnadirJugador);
            this.bjJugadoresEquipos.Controls.Add(this.jugadores);
            this.bjJugadoresEquipos.Controls.Add(this.equipo);
            this.bjJugadoresEquipos.Controls.Add(this.lequipo);
            this.bjJugadoresEquipos.Controls.Add(this.jugador);
            this.bjJugadoresEquipos.Controls.Add(this.lJugador);
            this.bjJugadoresEquipos.Controls.Add(this.aleatorio);
            this.bjJugadoresEquipos.Controls.Add(this.goloso);
            this.bjJugadoresEquipos.Enabled = false;
            this.bjJugadoresEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bjJugadoresEquipos.Location = new System.Drawing.Point(194, 99);
            this.bjJugadoresEquipos.Name = "bjJugadoresEquipos";
            this.bjJugadoresEquipos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bjJugadoresEquipos.Size = new System.Drawing.Size(389, 332);
            this.bjJugadoresEquipos.TabIndex = 1;
            this.bjJugadoresEquipos.TabStop = false;
            this.bjJugadoresEquipos.Text = "Jugadores / Equipos";
            // 
            // banterior
            // 
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(228, 299);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(78, 28);
            this.banterior.TabIndex = 14;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.Banterior_Click);
            // 
            // blimpiar
            // 
            this.blimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blimpiar.Location = new System.Drawing.Point(161, 300);
            this.blimpiar.Name = "blimpiar";
            this.blimpiar.Size = new System.Drawing.Size(60, 27);
            this.blimpiar.TabIndex = 13;
            this.blimpiar.Text = "Limpiar";
            this.blimpiar.UseVisualStyleBackColor = true;
            this.blimpiar.Click += new System.EventHandler(this.Blimpiar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(20, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Siguiente Equipo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // bAnadirEquipo
            // 
            this.bAnadirEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadirEquipo.Location = new System.Drawing.Point(20, 92);
            this.bAnadirEquipo.Name = "bAnadirEquipo";
            this.bAnadirEquipo.Size = new System.Drawing.Size(111, 24);
            this.bAnadirEquipo.TabIndex = 11;
            this.bAnadirEquipo.Text = "Anadir Equipo";
            this.bAnadirEquipo.UseVisualStyleBackColor = true;
            this.bAnadirEquipo.Click += new System.EventHandler(this.BAnadirEquipo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bAnadirJugador
            // 
            this.bAnadirJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadirJugador.Location = new System.Drawing.Point(21, 249);
            this.bAnadirJugador.Name = "bAnadirJugador";
            this.bAnadirJugador.Size = new System.Drawing.Size(110, 24);
            this.bAnadirJugador.TabIndex = 8;
            this.bAnadirJugador.Text = "Anadir Jugador";
            this.bAnadirJugador.UseVisualStyleBackColor = true;
            this.bAnadirJugador.Click += new System.EventHandler(this.Button2_Click);
            // 
            // jugadores
            // 
            this.jugadores.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadores.FormattingEnabled = true;
            this.jugadores.ItemHeight = 16;
            this.jugadores.Location = new System.Drawing.Point(154, 34);
            this.jugadores.Name = "jugadores";
            this.jugadores.Size = new System.Drawing.Size(229, 260);
            this.jugadores.TabIndex = 7;
            this.jugadores.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // equipo
            // 
            this.equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipo.ForeColor = System.Drawing.Color.Blue;
            this.equipo.Location = new System.Drawing.Point(21, 58);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(110, 26);
            this.equipo.TabIndex = 6;
            // 
            // lequipo
            // 
            this.lequipo.AutoSize = true;
            this.lequipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lequipo.Location = new System.Drawing.Point(24, 35);
            this.lequipo.Name = "lequipo";
            this.lequipo.Size = new System.Drawing.Size(104, 20);
            this.lequipo.TabIndex = 5;
            this.lequipo.Text = "Nombre Equipo";
            this.lequipo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // jugador
            // 
            this.jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugador.ForeColor = System.Drawing.Color.Red;
            this.jugador.Location = new System.Drawing.Point(21, 214);
            this.jugador.Name = "jugador";
            this.jugador.Size = new System.Drawing.Size(109, 26);
            this.jugador.TabIndex = 4;
            this.jugador.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lJugador
            // 
            this.lJugador.AutoSize = true;
            this.lJugador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJugador.Location = new System.Drawing.Point(20, 191);
            this.lJugador.Name = "lJugador";
            this.lJugador.Size = new System.Drawing.Size(110, 20);
            this.lJugador.TabIndex = 3;
            this.lJugador.Text = "Nombre Jugador";
            this.lJugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lJugador.Click += new System.EventHandler(this.LnombreJugador_Click);
            // 
            // aleatorio
            // 
            this.aleatorio.AutoSize = true;
            this.aleatorio.Checked = true;
            this.aleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aleatorio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aleatorio.ForeColor = System.Drawing.Color.DarkGreen;
            this.aleatorio.Location = new System.Drawing.Point(24, 131);
            this.aleatorio.Name = "aleatorio";
            this.aleatorio.Size = new System.Drawing.Size(106, 29);
            this.aleatorio.TabIndex = 1;
            this.aleatorio.TabStop = true;
            this.aleatorio.Text = "Aleatorio";
            this.aleatorio.UseVisualStyleBackColor = true;
            // 
            // goloso
            // 
            this.goloso.AutoSize = true;
            this.goloso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goloso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goloso.ForeColor = System.Drawing.Color.DarkGreen;
            this.goloso.Location = new System.Drawing.Point(24, 157);
            this.goloso.Name = "goloso";
            this.goloso.Size = new System.Drawing.Size(90, 29);
            this.goloso.TabIndex = 2;
            this.goloso.Text = "Goloso";
            this.goloso.UseVisualStyleBackColor = true;
            // 
            // gbTiposDeTorneo
            // 
            this.gbTiposDeTorneo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbTiposDeTorneo.Controls.Add(this.bFinalizar);
            this.gbTiposDeTorneo.Controls.Add(this.calificacionIndividual);
            this.gbTiposDeTorneo.Controls.Add(this.titulo);
            this.gbTiposDeTorneo.Controls.Add(this.dosADos);
            this.gbTiposDeTorneo.Enabled = false;
            this.gbTiposDeTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiposDeTorneo.ForeColor = System.Drawing.Color.Black;
            this.gbTiposDeTorneo.Location = new System.Drawing.Point(589, 97);
            this.gbTiposDeTorneo.Name = "gbTiposDeTorneo";
            this.gbTiposDeTorneo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbTiposDeTorneo.Size = new System.Drawing.Size(199, 332);
            this.gbTiposDeTorneo.TabIndex = 2;
            this.gbTiposDeTorneo.TabStop = false;
            this.gbTiposDeTorneo.Text = "Tipos deTorneo";
            // 
            // bFinalizar
            // 
            this.bFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinalizar.Location = new System.Drawing.Point(84, 292);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(109, 35);
            this.bFinalizar.TabIndex = 3;
            this.bFinalizar.Text = "Comenzar";
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.bFinalizar_Click);
            // 
            // calificacionIndividual
            // 
            this.calificacionIndividual.AutoSize = true;
            this.calificacionIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calificacionIndividual.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificacionIndividual.ForeColor = System.Drawing.Color.DarkGreen;
            this.calificacionIndividual.Location = new System.Drawing.Point(26, 136);
            this.calificacionIndividual.Name = "calificacionIndividual";
            this.calificacionIndividual.Size = new System.Drawing.Size(139, 62);
            this.calificacionIndividual.TabIndex = 3;
            this.calificacionIndividual.TabStop = true;
            this.calificacionIndividual.Text = "Calificacion\r\nIndividual";
            this.calificacionIndividual.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.titulo.Location = new System.Drawing.Point(26, 51);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(83, 33);
            this.titulo.TabIndex = 1;
            this.titulo.TabStop = true;
            this.titulo.Text = "Titulo";
            this.titulo.UseVisualStyleBackColor = true;
            // 
            // dosADos
            // 
            this.dosADos.AutoSize = true;
            this.dosADos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosADos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosADos.ForeColor = System.Drawing.Color.DarkGreen;
            this.dosADos.Location = new System.Drawing.Point(26, 97);
            this.dosADos.Name = "dosADos";
            this.dosADos.Size = new System.Drawing.Size(128, 33);
            this.dosADos.TabIndex = 2;
            this.dosADos.TabStop = true;
            this.dosADos.Text = "Dos A Dos";
            this.dosADos.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmuladorTorneoJuegosMesa.Properties.Resources.Configuracion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTiposDeTorneo);
            this.Controls.Add(this.bjJugadoresEquipos);
            this.Controls.Add(this.gbJuegos);
            this.Name = "Configuracion";
            this.gbJuegos.ResumeLayout(false);
            this.gbJuegos.PerformLayout();
            this.bjJugadoresEquipos.ResumeLayout(false);
            this.bjJugadoresEquipos.PerformLayout();
            this.gbTiposDeTorneo.ResumeLayout(false);
            this.gbTiposDeTorneo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJuegos;
        private System.Windows.Forms.RadioButton domino;
        private System.Windows.Forms.GroupBox bjJugadoresEquipos;
        private System.Windows.Forms.Label lequipo;
        private System.Windows.Forms.TextBox jugador;
        private System.Windows.Forms.Label lJugador;
        private System.Windows.Forms.RadioButton aleatorio;
        private System.Windows.Forms.RadioButton goloso;
        private System.Windows.Forms.GroupBox gbTiposDeTorneo;
        private System.Windows.Forms.RadioButton calificacionIndividual;
        private System.Windows.Forms.RadioButton titulo;
        private System.Windows.Forms.RadioButton dosADos;
        private System.Windows.Forms.TextBox equipo;
        private System.Windows.Forms.ListBox jugadores;
        private System.Windows.Forms.Button bFinalizar;
        private System.Windows.Forms.Button bAnadirJugador;
        private System.Windows.Forms.Button bSiguienteJuegos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bAnadirEquipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton tictactoe;
        private System.Windows.Forms.Button blimpiar;
        private System.Windows.Forms.Button banterior;
    }
}
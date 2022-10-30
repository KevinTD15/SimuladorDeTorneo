namespace EmuladorTorneoJuegosMesa
{
    partial class Ejecucion
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
            this.components = new System.ComponentModel.Container();
            this.notificaciones = new System.Windows.Forms.ListBox();
            this.bPartidaActual = new System.Windows.Forms.Button();
            this.bJuegoActual = new System.Windows.Forms.Button();
            this.bJugada = new System.Windows.Forms.Button();
            this.bAutomaticamente = new System.Windows.Forms.Button();
            this.bTorneo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bRetardar = new System.Windows.Forms.Button();
            this.bAcelerar = new System.Windows.Forms.Button();
            this.mostrarJugadas = new System.Windows.Forms.CheckBox();
            this.mostrarJuegos = new System.Windows.Forms.CheckBox();
            this.mostraPartidas = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.replay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificaciones
            // 
            this.notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificaciones.ForeColor = System.Drawing.Color.Maroon;
            this.notificaciones.FormattingEnabled = true;
            this.notificaciones.ItemHeight = 20;
            this.notificaciones.Location = new System.Drawing.Point(207, 98);
            this.notificaciones.Name = "notificaciones";
            this.notificaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notificaciones.ScrollAlwaysVisible = true;
            this.notificaciones.Size = new System.Drawing.Size(397, 324);
            this.notificaciones.TabIndex = 0;
            // 
            // bPartidaActual
            // 
            this.bPartidaActual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPartidaActual.ForeColor = System.Drawing.Color.Blue;
            this.bPartidaActual.Location = new System.Drawing.Point(21, 162);
            this.bPartidaActual.Name = "bPartidaActual";
            this.bPartidaActual.Size = new System.Drawing.Size(180, 35);
            this.bPartidaActual.TabIndex = 1;
            this.bPartidaActual.Text = "Ejecutar Partida Actual";
            this.bPartidaActual.UseVisualStyleBackColor = true;
            this.bPartidaActual.Click += new System.EventHandler(this.BPartidaActual_Click);
            // 
            // bJuegoActual
            // 
            this.bJuegoActual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bJuegoActual.ForeColor = System.Drawing.Color.Blue;
            this.bJuegoActual.Location = new System.Drawing.Point(21, 226);
            this.bJuegoActual.Name = "bJuegoActual";
            this.bJuegoActual.Size = new System.Drawing.Size(180, 37);
            this.bJuegoActual.TabIndex = 2;
            this.bJuegoActual.Text = "Ejecutar Juego Actual";
            this.bJuegoActual.UseVisualStyleBackColor = true;
            this.bJuegoActual.Click += new System.EventHandler(this.BJuegoActual_Click);
            // 
            // bJugada
            // 
            this.bJugada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bJugada.ForeColor = System.Drawing.Color.Blue;
            this.bJugada.Location = new System.Drawing.Point(21, 292);
            this.bJugada.Name = "bJugada";
            this.bJugada.Size = new System.Drawing.Size(180, 37);
            this.bJugada.TabIndex = 3;
            this.bJugada.Text = "Ejecutar Jugada";
            this.bJugada.UseVisualStyleBackColor = true;
            this.bJugada.Click += new System.EventHandler(this.BJugada_Click);
            // 
            // bAutomaticamente
            // 
            this.bAutomaticamente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAutomaticamente.ForeColor = System.Drawing.Color.Blue;
            this.bAutomaticamente.Location = new System.Drawing.Point(21, 362);
            this.bAutomaticamente.Name = "bAutomaticamente";
            this.bAutomaticamente.Size = new System.Drawing.Size(180, 33);
            this.bAutomaticamente.TabIndex = 4;
            this.bAutomaticamente.Text = "Ejecutar Automaticamente";
            this.bAutomaticamente.UseVisualStyleBackColor = true;
            this.bAutomaticamente.Click += new System.EventHandler(this.BAutomaticamente_Click);
            // 
            // bTorneo
            // 
            this.bTorneo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTorneo.ForeColor = System.Drawing.Color.Blue;
            this.bTorneo.Location = new System.Drawing.Point(21, 101);
            this.bTorneo.Name = "bTorneo";
            this.bTorneo.Size = new System.Drawing.Size(180, 30);
            this.bTorneo.TabIndex = 5;
            this.bTorneo.Text = "Ejecutar Torneo";
            this.bTorneo.UseVisualStyleBackColor = true;
            this.bTorneo.Click += new System.EventHandler(this.BTorneo_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(622, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // bRetardar
            // 
            this.bRetardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bRetardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRetardar.Location = new System.Drawing.Point(622, 316);
            this.bRetardar.Name = "bRetardar";
            this.bRetardar.Size = new System.Drawing.Size(154, 27);
            this.bRetardar.TabIndex = 7;
            this.bRetardar.Text = "Retardar";
            this.bRetardar.UseVisualStyleBackColor = false;
            this.bRetardar.Click += new System.EventHandler(this.BRetardar_Click);
            // 
            // bAcelerar
            // 
            this.bAcelerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bAcelerar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAcelerar.Location = new System.Drawing.Point(622, 281);
            this.bAcelerar.Name = "bAcelerar";
            this.bAcelerar.Size = new System.Drawing.Size(154, 27);
            this.bAcelerar.TabIndex = 8;
            this.bAcelerar.Text = "Acelerar";
            this.bAcelerar.UseVisualStyleBackColor = false;
            this.bAcelerar.Click += new System.EventHandler(this.BAcelerar_Click);
            // 
            // mostrarJugadas
            // 
            this.mostrarJugadas.AutoSize = true;
            this.mostrarJugadas.Checked = true;
            this.mostrarJugadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarJugadas.Location = new System.Drawing.Point(29, 31);
            this.mostrarJugadas.Name = "mostrarJugadas";
            this.mostrarJugadas.Size = new System.Drawing.Size(79, 24);
            this.mostrarJugadas.TabIndex = 9;
            this.mostrarJugadas.Text = "Jugadas";
            this.mostrarJugadas.UseVisualStyleBackColor = true;
            this.mostrarJugadas.CheckedChanged += new System.EventHandler(this.MostrarJugadas_CheckedChanged);
            // 
            // mostrarJuegos
            // 
            this.mostrarJuegos.AutoSize = true;
            this.mostrarJuegos.Checked = true;
            this.mostrarJuegos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarJuegos.Location = new System.Drawing.Point(29, 75);
            this.mostrarJuegos.Name = "mostrarJuegos";
            this.mostrarJuegos.Size = new System.Drawing.Size(73, 24);
            this.mostrarJuegos.TabIndex = 10;
            this.mostrarJuegos.Text = "Juegos";
            this.mostrarJuegos.UseVisualStyleBackColor = true;
            this.mostrarJuegos.CheckedChanged += new System.EventHandler(this.Juegos_CheckedChanged);
            // 
            // mostraPartidas
            // 
            this.mostraPartidas.AutoSize = true;
            this.mostraPartidas.Checked = true;
            this.mostraPartidas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostraPartidas.Location = new System.Drawing.Point(29, 123);
            this.mostraPartidas.Name = "mostraPartidas";
            this.mostraPartidas.Size = new System.Drawing.Size(76, 24);
            this.mostraPartidas.TabIndex = 11;
            this.mostraPartidas.Text = "Partidas";
            this.mostraPartidas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.mostraPartidas);
            this.groupBox1.Controls.Add(this.mostrarJuegos);
            this.groupBox1.Controls.Add(this.mostrarJugadas);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(622, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // replay
            // 
            this.replay.Enabled = false;
            this.replay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.Location = new System.Drawing.Point(622, 356);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(154, 30);
            this.replay.TabIndex = 13;
            this.replay.Text = "Visualizar Juego";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Ejecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmuladorTorneoJuegosMesa.Properties.Resources.Notificaciones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.bAcelerar);
            this.Controls.Add(this.bRetardar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bTorneo);
            this.Controls.Add(this.bAutomaticamente);
            this.Controls.Add(this.bJugada);
            this.Controls.Add(this.bJuegoActual);
            this.Controls.Add(this.bPartidaActual);
            this.Controls.Add(this.notificaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejecucion";
            this.Text = "Ejecucion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notificaciones;
        private System.Windows.Forms.Button bPartidaActual;
        private System.Windows.Forms.Button bJuegoActual;
        private System.Windows.Forms.Button bJugada;
        private System.Windows.Forms.Button bAutomaticamente;
        private System.Windows.Forms.Button bTorneo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bRetardar;
        private System.Windows.Forms.Button bAcelerar;
        private System.Windows.Forms.CheckBox mostrarJugadas;
        private System.Windows.Forms.CheckBox mostrarJuegos;
        private System.Windows.Forms.CheckBox mostraPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button replay;
    }
}
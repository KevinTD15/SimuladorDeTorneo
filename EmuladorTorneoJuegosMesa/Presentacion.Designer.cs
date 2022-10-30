namespace EmuladorTorneoJuegosMesa
{
    partial class bienvenida
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
            this.entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(613, 454);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(137, 32);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmuladorTorneoJuegosMesa.Properties.Resources.Bienvenida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.entrar);
            this.Name = "bienvenida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entrar;
    }
}


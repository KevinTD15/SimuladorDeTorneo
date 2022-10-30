using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmuladorTorneoJuegosMesa
{
    public partial class bienvenida : Form
    {
        public bienvenida()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Form configurar = new Configuracion();
            configurar.Show();
            Hide();
        }
    }
}

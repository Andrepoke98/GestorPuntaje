using GestorPuntaje.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPuntaje
{
    public partial class CantidadJugadoresDialog : Form
    {
        public CantidadJugadoresDialog()
        {
            InitializeComponent();
        }

        private void trackBarJugadores_Scroll(object sender, EventArgs e)
        {
            lblCantidadJugadores.Text = trackBarJugadores.Value.ToString();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            VistaPrincipal seleccionar = new VistaPrincipal(trackBarJugadores.Value);
            this.Hide();
            seleccionar.Show();
        }
    }
}

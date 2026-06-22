using System;
using System.Collections;
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
    public partial class SeleccionarJugadorDialog : Form
    {
        String jugador;
        List<string> ocupado = new List<string>();
        public SeleccionarJugadorDialog(int numero, List<string> ocupado)
        {
            InitializeComponent();
            lblNumero.Text = numero.ToString();
            this.ocupado = ocupado;
        }

        public String getJugador()
        {
            return jugador;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            jugador = txtBoxJugador.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

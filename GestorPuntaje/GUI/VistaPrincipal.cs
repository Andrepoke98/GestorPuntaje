using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPuntaje.GUI
{
    public partial class VistaPrincipal : Form
    {
        private int ronda = 1;
        private int reparte = 0;
        private DataTable tabla;
        public bool victoriaSubida = false;
        private bool termino = false;
        List<string> ocupado = new List<string>();
        public VistaPrincipal(int cantidadJugadores)
        {
            InitializeComponent();
            tabla = new DataTable();
            bool cancelado = false;

            for (int i = 1; i <= cantidadJugadores; i++)
            {
                using (SeleccionarJugadorDialog jugador = new SeleccionarJugadorDialog(i, ocupado))
                {
                    if (jugador.ShowDialog() == DialogResult.OK)
                    {
                        if (jugador.getJugador() == "")
                        {
                            i -= 1;
                        }
                        else
                        {
                            string nombre = jugador.getJugador();
                            tabla.Columns.Add(nombre);
                            ocupado.Add(nombre);
                        }
                    }
                    else if (jugador.DialogResult == DialogResult.Cancel)
                    {
                        cancelado = true;
                        break;
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }

            if (cancelado)
            {
                Application.Restart();
            }
            else
            {
                tabla.Rows.Add();
                gridPuntajes.DataSource = tabla;
                lblReparte.Text = gridPuntajes.Columns[0].Name;

                foreach (DataGridViewColumn columna in gridPuntajes.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void VistaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTerminarRonda_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridPuntajes.ColumnCount; i++)
            {
                object valorCelda = gridPuntajes.Rows[ronda - 1].Cells[i].Value;
                string nombre = gridPuntajes.Columns[i].Name;

                if (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                {
                    MessageBox.Show($"Lo ingresado en la puntuación {ronda} de {nombre} está vacío");
                    return;
                }

                if (!int.TryParse(valorCelda.ToString(), out _))
                {
                    MessageBox.Show($"Lo ingresado en la puntuación {ronda} de {nombre} no es un valor numérico");
                    return;
                }
            }

            DataTable dt = (DataTable)gridPuntajes.DataSource;
            ronda += 1;
            reparte += 1;

            if (reparte == gridPuntajes.ColumnCount)
            {
                reparte = 0;
            }

            lblNumRonda.Text = ronda.ToString();
            lblReparte.Text = gridPuntajes.Columns[reparte].HeaderText;

            dt.Rows.Add(dt.NewRow());
        }

        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
            List<int> resultados = new List<int>();

            DataTable dt = (DataTable)gridPuntajes.DataSource;

            for (int col = 0; col < dt.Columns.Count; col++)
            {
                int sumaColumna = 0;
                for (int row = 0; row < dt.Rows.Count - (termino ? 0 : 1); row++)
                {
                    if (int.TryParse(dt.Rows[row][col].ToString(), out int valor))
                    {
                        sumaColumna += valor;
                    }
                }
                resultados.Add(sumaColumna);
            }

            VistaPosiciones vista = new VistaPosiciones(dt, resultados, this.victoriaSubida);

            vista.ShowDialog();
            
            this.victoriaSubida = vista.victoriaSubida;

            if (this.victoriaSubida && !termino)
            {
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
                gridPuntajes.ReadOnly = true;
                gridPuntajes.DefaultCellStyle.BackColor = Color.LightGray;
                gridPuntajes.Enabled = false;
                gridPuntajes.DataSource = dt;
                btnTerminarRonda.Enabled = false;

                termino = true;
            }
        }
    }
}

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
    public partial class VistaPosiciones : Form
    {
        public bool victoriaSubida = false;
        public VistaPosiciones(DataTable modelo, List<int> resultados, bool victoriaSubida)
        {
            InitializeComponent();
            this.victoriaSubida = victoriaSubida;

            List<(string nombre, int puntaje)> listaPuntajes = new List<(string, int)>();
            for (int i = 0; i < modelo.Columns.Count; i++)
            {
                string nombre = modelo.Columns[i].ColumnName;
                int puntaje = resultados[i];
                listaPuntajes.Add((nombre, puntaje));
            }

            var puntajesOrdenados = listaPuntajes.OrderByDescending(p => p.puntaje).ToList();

            DataTable nuevoModelo = new DataTable();
            foreach (var par in puntajesOrdenados)
            {
                nuevoModelo.Columns.Add(par.nombre, typeof(int));
            }

            DataRow fila = nuevoModelo.NewRow();
            for (int i = 0; i < puntajesOrdenados.Count; i++)
            {
                fila[i] = puntajesOrdenados[i].puntaje;
            }
            nuevoModelo.Rows.Add(fila);

            gridPuntajes.DataSource = nuevoModelo;

            if (puntajesOrdenados[0].puntaje >= 1000)
            {
                if (!this.victoriaSubida)
                {
                    if (puntajesOrdenados.Count > 1 && puntajesOrdenados[0].puntaje > puntajesOrdenados[1].puntaje)
                    {
                        string ganador = puntajesOrdenados[0].nombre;
                        MessageBox.Show($"Ha ganado {puntajesOrdenados[0].nombre}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

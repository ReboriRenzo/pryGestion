using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmMostrar : Form
    {
        public string[,] matrizTareas = new string[3, 5];
        int indiceFila, indiceColumna;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dgvGrillaActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizTareas.GetLength(0))
            {
                if (matrizTareas[indiceFila, indiceColumna] != null)
                {
                    dgvGrillaActividades.Rows.Add(indiceFila, indiceColumna);
                }
                indiceColumna++;
            }
            indiceColumna++;

            for (int i = 0; i < matrizTareas.GetLength(0); i++)
                if (matrizTareas[i, 0] != null)
                {
                    dgvGrillaActividades.Rows.Add(matrizTareas[i, 0],
                        matrizTareas[i, 1],
                        matrizTareas[i, 2]);

                }
        }
    }
}

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
        public string[,] matrizTareas = new string[5, 5];
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
                dgvGrillaActividades.Rows.Add(matrizTareas[indiceFila, 0],
                    matrizTareas[indiceFila, 1],
                    matrizTareas[indiceFila, 2],
                    matrizTareas[indiceFila, 3],
                    matrizTareas[indiceFila, 4]);

                        

                indiceFila++;

            }
        }

    }
}

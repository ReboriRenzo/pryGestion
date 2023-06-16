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
    public partial class frmRegistrar : Form
    {
        //Zona de declaracion global
        string datoConcatenar;
        string[] vectorActividad = new string[5];
        string[] vectorRegistroActividad = new string[4];
        int indiceRegistro = 0;
        frmMostrar ventanaMostrar =new frmMostrar();
        int indiceFilaRegistro;
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (dtpFecha.Value >= DateTime.Today)
            {
                if(cboTipo.SelectedIndex != -1)
                {
                    if (txtDetalleActidad.Text != "")
                    {
                        MessageBox.Show("Haz sido registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 1] = cboTipo.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalleActidad.Text;
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar el Detalle", "Detalle faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalleActidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una actividad..", "Falta seleccionar una Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipo.Focus();

                }
            }
            else
            { MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void cmdVerVector_Click(object sender, EventArgs e)
        {
            int indice = 0;

            while (indice <= 5)
            {
                Lista.Items.Add(vectorActividad[indice]);

                indice = indice + 1;
            }
        }

        private void cmdCargarVector_Click(object sender, EventArgs e)
        {
            int indice = 0;

            while (indice <= 5) 
            {
                vectorActividad[indice] = "" + indice;

                indice = indice + 1;
            }
        }

        private void cmdVerVector2_Click(object sender, EventArgs e)
        {
            int indice = 0;

            while (indice < vectorActividad.Length) 
            {
                Lista.Items.Add(vectorActividad[indice]);

                indice++;
            }
        }

        private void cmdVector3_Click(object sender, EventArgs e)
        {
            for (int indice = 0; indice < vectorActividad.Length; indice++)
            {
                Lista.Items.Add(vectorActividad[indice]);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.ShowDialog();
            this.Hide();
        }
    }
}
 
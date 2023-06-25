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
        
        
        readonly int indiceRegistro = 0;
        frmInicioDeSesion ventanaInicioSesion = new frmInicioDeSesion();
        frmMostrar ventanaMostrar = new frmMostrar();
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
            ventanaInicioSesion.ShowDialog();
            this.Close();
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

            //CARGA DE DATOS EN MATRIZ
        {
            string varTareas = "";
            string varReunion = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (cboTipo.SelectedIndex != -1)
                {
                    if (txtDetalleActidad.Text != "")
                    {
                        MessageBox.Show("Haz sido registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        if (optSi.Checked == true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if (chkDebate.Checked)
                        {
                            varTareas = "Debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTareas = varTareas + "Investigacion, ";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTareas = varTareas + "Notas, ";
                        }
                        if (chkRepositorio.Checked)
                        {
                            varTareas = varTareas + "Repositorio, ";
                        }

                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 1] = cboTipo.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalleActidad.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 3] = varReunion;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 4] = varTareas;



                        indiceFilaRegistro++;

                        if (indiceFilaRegistro == ventanaMostrar.matrizTareas.GetLength(0))
                        {
                            cmdRegistrar.Enabled = false;

                        }
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
        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            ventanaMostrar.ShowDialog();
            this.Hide();
            
        }
    }
}
 
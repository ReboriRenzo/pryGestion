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
    public partial class frmInicioDeSesion : Form
    {
        //Declaracion de variables

        string vUsuario;
        string vContraseña;
        int vContadorLogin = 0;
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            vUsuario = txtIniciarSesion.Text;
            vContraseña = txtContraseña.Text;

            if (vUsuario == "Empresa" && vContraseña == "Empresa321")
            {
                frmRegistrar ventanaPrincipal = new frmRegistrar();
                ventanaPrincipal.ShowDialog();

                this.Hide();
            }
            else
            {
                vContadorLogin++;
                if (vContadorLogin == 3)
                {
                    MessageBox.Show("Realizo muchos intentos", "Intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();

                }
                else
                {
                    MessageBox.Show("Algun dato incorrecto. Intenta nuevamente: " + vContadorLogin.ToString() + "de 3", "Datos mal ingresados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }
    }
}

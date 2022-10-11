using ComponentFactory.Krypton.Toolkit;
using Krypton_Toolkit_Demo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable dato = CUsuario.Validar_Acceso(this.txtUser.Text, this.txtPass.Text);
                if(dato.Rows.Count> 0)
                {
                    DataRow dr = dato.Rows[0];
                    if(dr["Resultado"].ToString() == "Acceso Exitoso")
                    {
                        frmAdminView frmAdmin = new frmAdminView();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

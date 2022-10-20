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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //    frmAdminView frmAdmin = new frmAdminView();
            //    frmAdmin.Show();
            //    this.Hide();
            //if (txtUser.Text == "" || txtPass.Text == "")
            //{
            //    MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    DataTable dato = CUsuario.Validar_Acceso(this.txtUser.Text, this.txtPass.Text);
            //    if (dato.Rows.Count > 0)
            //    {
            //        DataRow dr = dato.Rows[0];
            //        if (dr["Resultado"].ToString() == "Acceso Exitoso")
            //        {
            //            frmAdminView frmAdmin = new frmAdminView();
            //            frmAdmin.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable dato = CUsuario.Validar_Acceso(this.txtUser.Text, this.txtPass.Text);
                DataRow dr = dato.Rows[0];
                if (dato.Rows.Count > 0)
                {
                    if (dato.Columns.Count > 2)
                    {
                        string cargo = dr["NombreCargo"].ToString();
                        if (cargo == "Administrador")
                        {
                            frmAdminView frmAdmin = new frmAdminView();
                            frmAdmin.Show();
                            this.Hide();
                        }
                        else if (cargo == "Veterinario")
                        {
                            frmAnimalsZone frmVet = new frmAnimalsZone();
                            frmVet.Show();
                            this.Hide();
                        }
                    }
                    else
                    {

                        if (dr["Resultado"].ToString() == "Acceso denegado")
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (dr["Resultado"].ToString() == "Usuario deshabilitado")
                        {
                            MessageBox.Show("Usuario deshabilitado.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (dr["Resultado"].ToString() == "Debe cambiar la contraseña")
                        {
                            MessageBox.Show("Debe de cambiar la contraseña.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int idUsuario = int.Parse(dr["IdUsuario"].ToString());
                            CambiarContraseña frmCambiarContraseña = new CambiarContraseña(idUsuario);
                            frmCambiarContraseña.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}

using ComponentFactory.Krypton.Toolkit;
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
    public partial class CambiarContraseña : KryptonForm
    {
        int IdUser;
        public CambiarContraseña(int idUser)
        {
            IdUser = idUser;
            InitializeComponent();
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            Console.WriteLine(IdUser);
            
        }

        private void btnAgreagarCuidador_Click(object sender, EventArgs e)
        {
            if (txtContraseñaVieja.Text == "" || txtContraseñaNueva.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              Controller.CUsuario.Cambiar_Contrasena(IdUser, this.txtContraseñaVieja.Text, this.txtContraseñaNueva.Text);
                //View.EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD frmVet = new View.EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD();
                frmAnimalsZone frmVet = new frmAnimalsZone();
                frmVet.Show();
                this.Hide();

            }
        }
    }
}

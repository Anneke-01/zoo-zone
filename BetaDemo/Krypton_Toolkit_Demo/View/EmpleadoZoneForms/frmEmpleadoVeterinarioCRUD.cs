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

namespace Krypton_Toolkit_Demo.View.EmpleadoZoneForms
{
    public partial class frmEmpleadoVeterinarioCRUD : KryptonForm
    {
        public Boolean isUpdate = false;
        public frmEmpleadoVeterinarioCRUD()
        {
            InitializeComponent();
        }

        private void btnGuardarVeterinario_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void limpiar()
        {
            txtDireccion.Text = "";
        }
    }
}

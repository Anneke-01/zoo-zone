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
            //try
            //{
            //    string rpta = "";
            //    if (isUpdate)
            //    {
            //        if (String.IsNullOrWhiteSpace(txtPrimerNombre.Text) || String.IsNullOrWhiteSpace(txtSegundoNombre.Text) || String.IsNullOrWhiteSpace(txtSegundoApellido.Text) || String.IsNullOrWhiteSpace(txtCedula.Text) || String.IsNullOrWhiteSpace(txtAnioAntiguedad.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text));
            //        {
            //            //MessageBox.Show("Verificar que los datos de entrada no sean vacios", "Entrada de datos invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //limpiar();
            //        }
            //        else
            //        {
            //            //rpta = CVeterinario.Insertar(txtPrimerNombre, txtSegundoNombre, txtSegundoApellido, txtCedula, txtAnioAntiguedad, txtTelefono, txtDireccion);
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        private void limpiar()
        {
            txtDireccion.Text = "";
        }
    }
}

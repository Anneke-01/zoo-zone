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

namespace Krypton_Toolkit_Demo.View
{
    public partial class frmEmpleadoZone : KryptonForm
    {
        public frmEmpleadoZone()
        {
            InitializeComponent();
        }

        private void btnAgregarVeterinario_Click(object sender, EventArgs e)
        {
            EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD frmVete = new EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD();
            frmVete.Show();
            frmVete.TopMost = true;
        }

        private void btnActualizarVeterinario_Click(object sender, EventArgs e)
        {
            EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD frmVete = new EmpleadoZoneForms.frmEmpleadoVeterinarioCRUD();
            frmVete.Show();
            frmVete.TopMost = true;
        }

        private void btnAgregarCuidador_Click(object sender, EventArgs e)
        {
            EmpleadoZoneForms.frmEmpleadoCuidadorCRUD frmCuida = new EmpleadoZoneForms.frmEmpleadoCuidadorCRUD();
            frmCuida.Show();
            frmCuida.TopMost = true;
        }

        private void btnActualizarCuidador_Click(object sender, EventArgs e)
        {
            EmpleadoZoneForms.frmEmpleadoCuidadorCRUD frmCuida = new EmpleadoZoneForms.frmEmpleadoCuidadorCRUD();
            frmCuida.Show();
            frmCuida.TopMost = true;
        }
    }
}

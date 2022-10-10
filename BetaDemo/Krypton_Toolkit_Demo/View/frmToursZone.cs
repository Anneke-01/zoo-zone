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

namespace Krypton_Toolkit_Demo.View
{
    public partial class frmToursZone : KryptonForm
    {
        public frmToursZone()
        {
            InitializeComponent();
        }

        private void btnAgregarZona_Click(object sender, EventArgs e)
        {
            TourZoneForms.frmZonaCRUD zonaCRUD = new TourZoneForms.frmZonaCRUD();
            zonaCRUD.Show();
            zonaCRUD.TopMost = true;
        }

        private void btnActualizarZona_Click(object sender, EventArgs e)
        {
            TourZoneForms.frmZonaCRUD zonaCRUD = new TourZoneForms.frmZonaCRUD();
            zonaCRUD.Show();
            zonaCRUD.TopMost = true;
        }

        private void btnAgregarTours_Click(object sender, EventArgs e)
        {
            cmbDuración.Enabled = true;
            txtVisitantesAutorizados.Enabled = true;
            dtpFechaTour.Enabled = true;
            txtPrecioTour.Enabled = true;
            txtZona.Enabled = true;
            btnGuardar.Enabled = true;
            btnDescartarCambios.Enabled = true;
        }
    }
}

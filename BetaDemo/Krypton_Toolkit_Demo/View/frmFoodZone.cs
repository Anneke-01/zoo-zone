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
    public partial class frmFoodZone : KryptonForm
    {
        public frmFoodZone()
        {
            InitializeComponent();
        }

        private void btnAgregarAliemento_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmAlimentoCRUD frmAlimentos = new FoodZoneForms.frmAlimentoCRUD();
            frmAlimentos.Show();
            frmAlimentos.TopMost = true;
        }

        private void btnActualizarAlimento_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmAlimentoCRUD frmAlimentos = new FoodZoneForms.frmAlimentoCRUD();
            frmAlimentos.Show();
            frmAlimentos.TopMost = true;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmProveedorCRUD frmProveedor = new FoodZoneForms.frmProveedorCRUD();
            frmProveedor.Show();
            frmProveedor.TopMost = true;
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmProveedorCRUD frmProveedor = new FoodZoneForms.frmProveedorCRUD();
            frmProveedor.Show();
            frmProveedor.TopMost = true;
        }

        private void btnAgregarDonador_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmDonadorCRUD frmDonador = new FoodZoneForms.frmDonadorCRUD();
            frmDonador.Show();
            frmDonador.TopMost = true;
        }

        private void btnActualizarDonador_Click(object sender, EventArgs e)
        {
            FoodZoneForms.frmDonadorCRUD frmDonador = new FoodZoneForms.frmDonadorCRUD();
            frmDonador.Show();
            frmDonador.TopMost = true;
        }
    }
}

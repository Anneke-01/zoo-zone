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

namespace Krypton_Toolkit_Demo.View.FoodZoneForms
{
    public partial class frmAlimentoCRUD : KryptonForm
    {
        public frmAlimentoCRUD()
        {
            InitializeComponent();
        }

        private void btnDonacion_Click(object sender, EventArgs e)
        {
            frmDonacionCRUD frmDonacion = new frmDonacionCRUD();
            frmDonacion.Show();
            frmDonacion.TopMost = true;
            this.Close();
        }
    }
}

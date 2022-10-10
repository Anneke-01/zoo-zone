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
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmAdminView frmAdmin = new frmAdminView();
            frmAdmin.ShowDialog();
        }
    }
}

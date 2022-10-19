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
using System.Diagnostics;
using Krypton_Toolkit_Demo.View;
using Krypton_Toolkit_Demo.View.HealthZoneForms;

namespace Krypton_Toolkit_Demo
{
    public partial class frmAdminView : KryptonForm
    {
        public frmAdminView()
        {
            InitializeComponent();
            CustomizeDesign();
            ComprobacionUsers();
        }

        private void ComprobacionUsers()
        {
            string users = "";
            if (users == "Admin")
            {
                //Todos los botones activados
            }
            else if (users == "Vendedor")
            {
                btnAnimal.Visible = false;
                btnComida.Visible = false;
                btnEmpleado.Visible = false;
                btnSalud.Visible = false;
                
            }
            else if (users == "Veterinario")
            {
                btnEmpleado.Visible = false;
                btnComida.Visible = false;
                btnTours.Visible = false;
            }
            else if (users == "Cuidador")
            {
                btnEmpleado.Visible = false;
                btnEmpleado.Visible = false;
                btnTours.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al validar usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalesZone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSalesZone());
        }

        private void frmAdminView_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmHome());
        }

        private void picbLogo_Click(object sender, EventArgs e)
        {
            #region Antigua forma de llamar un childMDI (True de MDIParent in properties)
            //if (childHome == null)
            //{
            //    childHome = new frmHome();
            //    childHome.MdiParent = this;
            //    childHome.Dock = DockStyle.Fill;
            //    //childHome.FormClosed += new FormClosedEventHandler(CerrarForma);
            //    childHome.Show();
            //}
            //else
            //{
            //    childHome.Activate();
            //}
            #endregion
            OpenChildForm(new frmHome());
        }

        #region Carga hijos MDI en Parent
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForms.Controls.Add(childForm);
            pnlChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Diseño de menú dinámico

        private void CustomizeDesign()
        {
            pnlSubMenuHealthZone.Visible = false;
        }
        private void HideSubMenu()
        {
            if (pnlSubMenuHealthZone.Visible == true)
            {
                pnlSubMenuHealthZone.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion
        
        private void btnAnimalZone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAnimalsZone());
        }

        private void btnSaludHistorial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHZHistorial());
            HideSubMenu();
        }

        private void btnSaludConsulta_Click(object sender, EventArgs e)
        {
            frmHZConsulta frmHZConsulta = new frmHZConsulta();
            frmHZConsulta.Show();
            frmHZConsulta.TopMost = true;
            HideSubMenu();
        }

        private void btnSaludInsumos_Click(object sender, EventArgs e)
        {
            frmHZInsumos frmHZImsumos = new frmHZInsumos();
            frmHZImsumos.Show();
            frmHZImsumos.TopMost = true;
            HideSubMenu();
        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuHealthZone);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmpleadoZone());
        }

        private void btnTours_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmToursZone());
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmFoodZone());
        }

        private void btnApoyaProyecto_Click(object sender, EventArgs e)
        {
            //Launch browser to GitHub Project
            System.Diagnostics.Process.Start("https://github.com/Anneke-01/zoo-zone");
            MessageBox.Show("You will be redirected to the GitHub website");
        }

        private void picbGitHub_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

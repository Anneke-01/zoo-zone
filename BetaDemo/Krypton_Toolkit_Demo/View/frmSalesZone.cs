using ComponentFactory.Krypton.Toolkit;
using Krypton_Toolkit_Demo.Controller;
using Krypton_Toolkit_Demo.SalesZoneForms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo
{
    public partial class frmSalesZone : KryptonForm
    {
        #region Remove se over positions of the windows
        public class WinAPI
        {
            // Constantes para SetWindowsPos
            //   Valores de wFlags
            const int SWP_NOSIZE = 0x1;
            const int SWP_NOMOVE = 0x2;
            const int SWP_NOACTIVATE = 0x10;
            const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;
            //   Valores de hwndInsertAfter
            const int HWND_TOPMOST = -1;
            const int HWND_NOTOPMOST = -2;
            //
            /// <summary>
            /// Para mantener la ventana siempre visible
            /// </summary>
            /// <remarks>No utilizamos el valor devuelto</remarks>
            [DllImport("user32.DLL")]
            private extern static void SetWindowPos(
                int hWnd, int hWndInsertAfter,
                int X, int Y,
                int cx, int cy,
                int wFlags);

            public static void SiempreEncima(int handle)
            {
                SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags);
            }

            public static void NoSiempreEncima(int handle)
            {
                SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags);
            }
        }
        #endregion

        public frmSalesZone()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CVendedor.MostrarVendedor();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void btnAddSalesM_Click(object sender, EventArgs e)
        {
            SalesZoneForms.frmSalesCRUD salesCRUD = new frmSalesCRUD();
            salesCRUD.Show();
            salesCRUD.TopMost = true;
        }

        private void btnUpdateSalesM_Click(object sender, EventArgs e)
        {
            SalesZoneForms.frmSalesCRUD salesUpdate = new frmSalesCRUD();
            salesUpdate.Show();
            salesUpdate.TopMost = true;
        }
        private void btnAddTours_Click(object sender, EventArgs e)
        {
            frmTourCRUD tourCRUD = new frmTourCRUD();
            tourCRUD.Show();
            tourCRUD.TopMost = true; //Brillante idea kovalsky
        }

        private void btnUpdateTours_Click(object sender, EventArgs e)
        {
            frmTourCRUD tourUpdate = new frmTourCRUD();
            tourUpdate.Show();
            tourUpdate.TopMost = true;
        }
    }
}

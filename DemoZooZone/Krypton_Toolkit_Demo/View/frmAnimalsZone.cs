using ComponentFactory.Krypton.Toolkit;
using Krypton_Toolkit_Demo.View.AnimalZoneForms;
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
    public partial class frmAnimalsZone : KryptonForm
    {
        public frmAnimalsZone()
        {
            InitializeComponent();
        }

        private void btnAddAnimals_Click(object sender, EventArgs e)
        {
            frmAnimalCRUD animalCrud = new frmAnimalCRUD();
            animalCrud.Show();
            animalCrud.TopMost = true;
        }

        private void btnUpdateAnimals_Click(object sender, EventArgs e)
        {
            frmAnimalCRUD animalCrud = new frmAnimalCRUD();
            animalCrud.Show();
            animalCrud.TopMost = true;
        }
    }
}

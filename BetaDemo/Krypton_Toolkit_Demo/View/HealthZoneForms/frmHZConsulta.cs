﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo.View.HealthZoneForms
{
    public partial class frmHZConsulta : KryptonForm
    {
        public frmHZConsulta()
        {
            InitializeComponent();
        }

        private void CleanUpElements()
        {
            txtDescripcion.Text = "";
        }
    }
}
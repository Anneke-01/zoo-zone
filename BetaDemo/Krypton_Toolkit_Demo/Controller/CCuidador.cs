using Krypton_Toolkit_Demo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Krypton_Toolkit_Demo.Controller
{
    class CCuidador
    {
        public static DataTable MostrarCuidador()
        {
            return new DCuidador().MostrarCuidador();
        }
    }
}

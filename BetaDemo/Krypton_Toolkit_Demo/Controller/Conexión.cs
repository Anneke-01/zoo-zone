using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo.Controller
{
    class Conexión
    {
        //public static string cadena = "Server=tcp:oursqlserver2022.database.windows.net,1433;Initial Catalog=ZooZone;Persist Security Info=False;User ID=azureuser;Password=ZooZone#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static string cadena = "Data Source=.;Initial Catalog=ZooZone;user=sa;password=Ceavlaeb747.";
        public SqlConnection conectarbd = new SqlConnection(cadena);

        
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion con el servidor exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar  " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Krypton_Toolkit_Demo.Data
{
    class DBoleto
    {
        private int Id_Venta;
        private int CantidadNiños;
        private float PrecioNiños;
        private int CantidadAdultos;
        private float PrecioAdultos;

        public int id_Venta { get => Id_Venta; set => Id_Venta = value; }
        public int cantidadNiños { get => CantidadNiños; set => CantidadNiños = value; }
        public float precioNiños { get => PrecioNiños; set => PrecioNiños = value; }
        public int cantidadAdultos { get => CantidadAdultos; set => CantidadAdultos = value; }
        public float precioAdultos { get => PrecioAdultos; set => PrecioAdultos = value; }

        public DataTable MostrarBoletos()
        {
            DataTable dtBoletos = new DataTable("Boletos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Cargando la conexion al servidor
                SqlCon.ConnectionString = Controller.Conexión.cadena;
                // Creando un objeto SQLCommand que llamara el procedimiento de almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarBoleto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtBoletos);

            }
            catch (Exception)
            {
                dtBoletos = null;
                throw;
            }
            return dtBoletos;
        }

    }
}

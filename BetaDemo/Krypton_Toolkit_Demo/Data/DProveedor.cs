using Krypton_Toolkit_Demo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Controller
{
    class DProveedor
    {
        private int Id_Proveedor;
        private string Compania;
        private string Direccion;
        private string Telefono;

        public int id_Vendedor { get => Id_Proveedor; set => Id_Proveedor = value; }
        public string compania { get => Compania; set => Compania = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public string telefono { get => Telefono; set => Telefono = value; }

        public DataTable MostrarProveedor()
        {
            DataTable dtProveedor = new DataTable("Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Cargando la conexion al servidor
                SqlCon.ConnectionString = Controller.Conexión.cadena;
                // Creando un objeto SQLCommand que llamara el procedimiento de almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarVendedor";
                SqlCmd.CommandType = CommandType.TableDirect;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtProveedor);
            }
            catch (Exception)
            {

                dtProveedor = null;
            }


            return dtProveedor;
        }
        public string Insertar(DProveedor vendedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.cadena;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "AgregarVendedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros del procedimiento de almacenado
                SqlParameter Id_Vendedor = new SqlParameter();
                Id_Vendedor.ParameterName = "@Id_vendedor";
                Id_Vendedor.SqlDbType = SqlDbType.Int;
                Id_Vendedor.Value = vendedor.id_Vendedor;
                SqlCmd.Parameters.Add(Id_Vendedor);

                SqlParameter Compania = new SqlParameter();
                Compania.ParameterName = "@Compania";
                Compania.SqlDbType = SqlDbType.VarChar;
                Compania.Value = vendedor.Compania;
                SqlCmd.Parameters.Add(Compania);

                SqlParameter Direccion = new SqlParameter();
                Direccion.SqlDbType = SqlDbType.VarChar;
                Direccion.ParameterName = "@Direccion";
                Direccion.Value = vendedor.direccion;
                SqlCmd.Parameters.Add(Direccion);

                SqlParameter Telefono = new SqlParameter();
                Telefono.SqlDbType = SqlDbType.VarChar;
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = vendedor.telefono;
                SqlCmd.Parameters.Add(Telefono);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;
        }
    }
}

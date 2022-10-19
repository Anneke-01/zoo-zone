using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Krypton_Toolkit_Demo.Controller;

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
                SqlCmd.CommandType = CommandType.TableDirect;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtBoletos);

            }
            catch (Exception)
            {
                dtBoletos = null;
            }
            return dtBoletos;
        }

        public DataTable MostrarCantidadBoletos(int id_Venta)
        {
            DataTable dtBoletos = new DataTable("Boletos");
            SqlConnection SqlCon = new SqlConnection();
            //Try cath
            try
            {
                //Cargando la conexion al servidor
                SqlCon.ConnectionString = Controller.Conexión.cadena;
                //Creando un objeto SQLCommand que llamará el procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarCantidadBoletos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_Venta = new SqlParameter();
                Id_Venta.ParameterName = "@Id_Venta";
                Id_Venta.SqlDbType = SqlDbType.Int;
                Id_Venta.Value = id_Venta;
                SqlCmd.Parameters.Add(Id_Venta);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtBoletos);

            }
            catch (Exception)
            {
                dtBoletos = null;
            }

            return dtBoletos;
        }

        public string Insertar(DBoleto boleto)
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
                SqlCmd.CommandText = "AgregarBoleto";
                SqlCmd.CommandType = CommandType.TableDirect;

                //Parámetros del procedimiento
                SqlParameter CantidadNiños = new SqlParameter();
                CantidadNiños.SqlDbType = SqlDbType.Int;
                CantidadNiños.Value = boleto.cantidadNiños;
                SqlCmd.Parameters.Add(CantidadNiños);

                SqlParameter PrecioNiños = new SqlParameter();
                PrecioNiños.SqlDbType = SqlDbType.Float;
                PrecioNiños.Value = boleto.precioNiños;
                SqlCmd.Parameters.Add(PrecioNiños);

                SqlParameter CantidadAdultos = new SqlParameter();
                CantidadAdultos.SqlDbType = SqlDbType.Int;
                CantidadAdultos.Value = boleto.cantidadAdultos;
                SqlCmd.Parameters.Add(CantidadAdultos);

                SqlParameter PrecioAdultos = new SqlParameter();
                PrecioAdultos.SqlDbType = SqlDbType.Float;
                PrecioAdultos.Value = boleto.precioAdultos;
                SqlCmd.Parameters.Add(PrecioAdultos);

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

        public string Actualizar(DBoleto boleto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.cadena;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ActualizarBoleto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros del procedimineto
                SqlParameter CantidadNiños = new SqlParameter();
                CantidadNiños.SqlDbType = SqlDbType.Int;
                CantidadNiños.Value = boleto.cantidadNiños;
                SqlCmd.Parameters.Add(CantidadNiños);

                SqlParameter PrecioNiños = new SqlParameter();
                PrecioNiños.SqlDbType = SqlDbType.Float;
                PrecioNiños.Value = boleto.precioNiños;
                SqlCmd.Parameters.Add(PrecioNiños);

                SqlParameter CantidadAdultos = new SqlParameter();
                CantidadAdultos.SqlDbType = SqlDbType.Int;
                CantidadAdultos.Value = boleto.cantidadAdultos;
                SqlCmd.Parameters.Add(CantidadAdultos);

                SqlParameter PrecioAdultos = new SqlParameter();
                PrecioAdultos.SqlDbType = SqlDbType.Float;
                PrecioAdultos.Value = boleto.precioAdultos;
                SqlCmd.Parameters.Add(PrecioAdultos);

                //Ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso ningus registro";
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

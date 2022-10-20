using Krypton_Toolkit_Demo.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Data
{
    class DVendedor
    {
        private int Id_Vendedor;
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string Direccion;
        private string Telefono;
        private string Sexo;
        private string FechaIngreso;
        private string Cedula;

        public int id_Vendedor { get => Id_Vendedor; set => Id_Vendedor = value; }
        public string primerNombre { get => PrimerNombre; set => PrimerNombre = value; }
        public string segundoNombre { get => SegundoNombre; set => SegundoNombre = value; }
        public string primerApellido { get => PrimerApellido; set => PrimerApellido = value; }
        public string segundoApellido { get => SegundoApellido; set => SegundoApellido = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public string fechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
        public string cedula { get => Cedula; set => Cedula = value; }

        public DataTable MostrarVendedor()
        {
            DataTable dtVendedor = new DataTable("Vendedor");
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
                SqlDat.Fill(dtVendedor);
            }
            catch (Exception)
            {

                dtVendedor = null;
            }
            return dtVendedor;
        }

        public string Insertar(DVendedor vendedor)
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

                SqlParameter PrimerNombre = new SqlParameter();
                PrimerNombre.ParameterName = "@PrimerNombre";
                PrimerNombre.SqlDbType = SqlDbType.VarChar;
                PrimerNombre.Value = vendedor.primerNombre;
                SqlCmd.Parameters.Add(PrimerNombre);

                SqlParameter SegundoNombre = new SqlParameter();
                SegundoNombre.SqlDbType = SqlDbType.VarChar;
                SegundoNombre.ParameterName = "@SegundoNombre";
                SegundoNombre.Value = vendedor.segundoNombre;
                SqlCmd.Parameters.Add(SegundoNombre);

                SqlParameter PrimerApellido = new SqlParameter();
                PrimerApellido.SqlDbType = SqlDbType.VarChar;
                PrimerApellido.ParameterName = "@PrimerApellido";
                PrimerApellido.Value = vendedor.primerApellido;
                SqlCmd.Parameters.Add(PrimerApellido);

                SqlParameter SegundoApellido = new SqlParameter();
                SegundoApellido.SqlDbType = SqlDbType.VarChar;
                SegundoApellido.ParameterName = "@SegundoApellido";
                SegundoApellido.Value = vendedor.segundoApellido;
                SqlCmd.Parameters.Add(SegundoApellido);

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

                SqlParameter Sexo = new SqlParameter();
                Sexo.SqlDbType = SqlDbType.VarChar;
                Sexo.ParameterName = "@Sexo";
                Sexo.Value = vendedor.sexo;
                SqlCmd.Parameters.Add(Sexo);

                SqlParameter FechaIngreso = new SqlParameter();
                FechaIngreso.SqlDbType = SqlDbType.VarChar;
                FechaIngreso.ParameterName = "@FechaIngreso";
                FechaIngreso.Value = vendedor.fechaIngreso;
                SqlCmd.Parameters.Add(FechaIngreso);

                SqlParameter Cedula = new SqlParameter();
                Cedula.SqlDbType = SqlDbType.VarChar;
                Cedula.ParameterName = "@Cedula";
                Cedula.Value = vendedor.cedula;
                SqlCmd.Parameters.Add(Cedula);

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

        public string Actualizar(DVendedor vendedor)
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
                Id_Vendedor.ParameterName = "@Id_Vendedor";
                Id_Vendedor.SqlDbType = SqlDbType.Int;
                Id_Vendedor.Value = vendedor.id_Vendedor;
                SqlCmd.Parameters.Add(Id_Vendedor);

                SqlParameter PrimerNombre = new SqlParameter();
                PrimerNombre.ParameterName = "@PrimerNombre";
                PrimerNombre.SqlDbType = SqlDbType.VarChar;
                PrimerNombre.Value = vendedor.primerNombre;
                SqlCmd.Parameters.Add(PrimerNombre);

                SqlParameter SegundoNombre = new SqlParameter();
                SegundoNombre.SqlDbType = SqlDbType.VarChar;
                SegundoNombre.ParameterName = "@SegundoNombre";
                SegundoNombre.Value = vendedor.segundoNombre;
                SqlCmd.Parameters.Add(SegundoNombre);

                SqlParameter PrimerApellido = new SqlParameter();
                PrimerApellido.SqlDbType = SqlDbType.VarChar;
                PrimerApellido.ParameterName = "@PrimerApellido";
                PrimerApellido.Value = vendedor.primerApellido;
                SqlCmd.Parameters.Add(PrimerApellido);

                SqlParameter SegundoApellido = new SqlParameter();
                SegundoApellido.SqlDbType = SqlDbType.VarChar;
                SegundoApellido.ParameterName = "@SegundoApellido";
                SegundoApellido.Value = vendedor.segundoApellido;
                SqlCmd.Parameters.Add(SegundoApellido);

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

                SqlParameter Sexo = new SqlParameter();
                Sexo.SqlDbType = SqlDbType.VarChar;
                Sexo.ParameterName = "@Sexo";
                Sexo.Value = vendedor.sexo;
                SqlCmd.Parameters.Add(Sexo);

                SqlParameter FechaIngreso = new SqlParameter();
                FechaIngreso.SqlDbType = SqlDbType.VarChar;
                FechaIngreso.ParameterName = "@FechaIngreso";
                FechaIngreso.Value = vendedor.fechaIngreso;
                SqlCmd.Parameters.Add(FechaIngreso);

                SqlParameter Cedula = new SqlParameter();
                Cedula.SqlDbType = SqlDbType.VarChar;
                Cedula.ParameterName = "@Cedula";
                Cedula.Value = vendedor.cedula;
                SqlCmd.Parameters.Add(Cedula);
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

using Krypton_Toolkit_Demo.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Data
{
    class DVeterinario
    {
        private int Id_Veterinario;
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string Direccion;
        private string Telefono;
        private string Sexo;
        private string FechaIngreso;
        private string Cedula;
        private int AniosExperiencia;
        private byte Estado;

        public int id_Veterinario { get => Id_Veterinario; set => Id_Veterinario = value; }
        public string primerNombre { get => PrimerNombre; set => PrimerNombre = value; }
        public string segundoNombre { get => SegundoNombre; set => SegundoNombre = value; }
        public string primerApellido { get => PrimerApellido; set => PrimerApellido = value; }
        public string segundoApellido { get => SegundoApellido; set => SegundoApellido = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public string fechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
        public string cedula { get => Cedula;set => Cedula = value; }
        public int aniosExperiencia { get => AniosExperiencia; set => AniosExperiencia = value; }
        public byte estado { get => Estado; set => Estado = value; }


        public DataTable MostrarVeterinario()
        {
            DataTable dtVeterinario = new DataTable("Veterinario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Cargando la conexion al servidor
                SqlCon.ConnectionString = Controller.Conexión.cadena;
                // Creando un objeto SQLCommand que llamara el procedimiento de almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarVeterinario";
                SqlCmd.CommandType = CommandType.TableDirect;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtVeterinario);
            }
            catch (Exception)
            {

                dtVeterinario = null;
            }
            return dtVeterinario;
        }

        public string Insertar(DVeterinario veterinario)
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
                SqlCmd.CommandText = "AgregarVeterinario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros del procedimiento de almacenado
                SqlParameter PrimerNombre = new SqlParameter();
                PrimerNombre.SqlDbType = SqlDbType.VarChar;
                PrimerNombre.Size = 20;
                PrimerNombre.Value = veterinario.primerNombre;
                SqlCmd.Parameters.Add(PrimerNombre);

                SqlParameter SegundoNombre = new SqlParameter();
                SegundoNombre.SqlDbType = SqlDbType.VarChar;
                SegundoNombre.Size = 20;
                SegundoNombre.Value = veterinario.segundoNombre;
                SqlCmd.Parameters.Add(SegundoNombre);

                SqlParameter PrimerApellido = new SqlParameter();
                PrimerApellido.SqlDbType = SqlDbType.VarChar;
                PrimerApellido.Size = 20;
                PrimerApellido.Value = veterinario.primerApellido;
                SqlCmd.Parameters.Add(PrimerApellido);

                SqlParameter SegundoApellido = new SqlParameter();
                SegundoApellido.SqlDbType = SqlDbType.VarChar;
                SegundoApellido.Size = 20;
                SegundoApellido.Value = veterinario.segundoApellido;
                SqlCmd.Parameters.Add(SegundoApellido);

                SqlParameter Direccion = new SqlParameter();
                Direccion.SqlDbType = SqlDbType.VarChar;
                Direccion.Size = 40;
                Direccion.Value = veterinario.direccion;
                SqlCmd.Parameters.Add(Direccion);

                SqlParameter Telefono = new SqlParameter();
                Telefono.SqlDbType = SqlDbType.VarChar;
                Telefono.Size = 20;
                Telefono.Value = veterinario.telefono;
                SqlCmd.Parameters.Add(Telefono);

                SqlParameter Sexo = new SqlParameter();
                Sexo.SqlDbType = SqlDbType.VarChar;
                Sexo.Value = veterinario.sexo;
                Sexo.Size = 12;
                SqlCmd.Parameters.Add(Sexo);

                SqlParameter FechaIngreso = new SqlParameter();
                FechaIngreso.SqlDbType = SqlDbType.VarChar;
                FechaIngreso.Size = 20;
                FechaIngreso.Value = veterinario.fechaIngreso;
                SqlCmd.Parameters.Add(FechaIngreso);

                SqlParameter Cedula = new SqlParameter();
                Cedula.SqlDbType = SqlDbType.VarChar;
                Cedula.Size = 20;
                Cedula.Value = veterinario.cedula;
                SqlCmd.Parameters.Add(Cedula);

                SqlParameter AniosExperiencia = new SqlParameter();
                AniosExperiencia.SqlDbType = SqlDbType.Int;
                AniosExperiencia.Value = veterinario.aniosExperiencia;
                SqlCmd.Parameters.Add(AniosExperiencia);

                SqlParameter Estado = new SqlParameter();
                Estado.SqlDbType = SqlDbType.Binary;
                Estado.Value = veterinario.estado;
                SqlCmd.Parameters.Add(Estado);
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

        public string Actualizar(DVeterinario veterinario)
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
                SqlCmd.CommandText = "AgregarVeterinario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros del procedimiento de almacenado
                SqlParameter Id_Veterinario = new SqlParameter();
                Id_Veterinario.ParameterName = "@Id_Veterinario";
                Id_Veterinario.SqlDbType = SqlDbType.Int;
                Id_Veterinario.Value = veterinario.id_Veterinario;
                SqlCmd.Parameters.Add(Id_Veterinario);

                SqlParameter PrimerNombre = new SqlParameter();
                PrimerNombre.ParameterName = "@PrimerNombre";
                PrimerNombre.SqlDbType = SqlDbType.VarChar;
                PrimerNombre.Value = veterinario.primerNombre;
                SqlCmd.Parameters.Add(PrimerNombre);

                SqlParameter SegundoNombre = new SqlParameter();
                SegundoNombre.SqlDbType = SqlDbType.VarChar;
                SegundoNombre.ParameterName = "@SegundoNombre";
                SegundoNombre.Value = veterinario.segundoNombre;
                SqlCmd.Parameters.Add(SegundoNombre);

                SqlParameter PrimerApellido = new SqlParameter();
                PrimerApellido.SqlDbType = SqlDbType.VarChar;
                PrimerApellido.ParameterName = "@PrimerApellido";
                PrimerApellido.Value = veterinario.primerApellido;
                SqlCmd.Parameters.Add(PrimerApellido);

                SqlParameter SegundoApellido = new SqlParameter();
                SegundoApellido.SqlDbType = SqlDbType.VarChar;
                SegundoApellido.ParameterName = "@SegundoApellido";
                SegundoApellido.Value = veterinario.segundoApellido;
                SqlCmd.Parameters.Add(SegundoApellido);

                SqlParameter Direccion = new SqlParameter();
                Direccion.SqlDbType = SqlDbType.VarChar;
                Direccion.ParameterName = "@Direccion";
                Direccion.Value = veterinario.direccion;
                SqlCmd.Parameters.Add(Direccion);

                SqlParameter Telefono = new SqlParameter();
                Telefono.SqlDbType = SqlDbType.VarChar;
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = veterinario.telefono;
                SqlCmd.Parameters.Add(Telefono);

                SqlParameter Sexo = new SqlParameter();
                Sexo.SqlDbType = SqlDbType.VarChar;
                Sexo.ParameterName = "@Sexo";
                Sexo.Value = veterinario.sexo;
                SqlCmd.Parameters.Add(Sexo);

                SqlParameter FechaIngreso = new SqlParameter();
                FechaIngreso.SqlDbType = SqlDbType.VarChar;
                FechaIngreso.ParameterName = "@FechaIngreso";
                FechaIngreso.Value = veterinario.fechaIngreso;
                SqlCmd.Parameters.Add(FechaIngreso);

                SqlParameter Cedula = new SqlParameter();
                Cedula.SqlDbType = SqlDbType.VarChar;
                Cedula.ParameterName = "@Cedula";
                Cedula.Value = veterinario.cedula;
                SqlCmd.Parameters.Add(Cedula);

                SqlParameter AniosExperiencia = new SqlParameter();
                AniosExperiencia.SqlDbType = SqlDbType.Int;
                AniosExperiencia.ParameterName = "@AniosExperiencia";
                AniosExperiencia.Value = veterinario.aniosExperiencia;
                SqlCmd.Parameters.Add(AniosExperiencia);
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

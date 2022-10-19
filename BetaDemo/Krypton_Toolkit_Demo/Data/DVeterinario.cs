using Krypton_Toolkit_Demo.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private DateTime FechaIngreso;
        private string Cedula;
        private int AniosExperiencia;
        private byte Estado;

        public int id_Veterinario { get => Id_Veterinario; set => Id_Veterinario = value; }
        public string primerNombre { get => PrimerNombre; set => PrimerNombre = value; }
        public string segundoNombre { get => SegundoNombre; set => SegundoNombre = value; }
        public string primerAoellido { get => PrimerApellido; set => PrimerApellido = value; }
        public string segundoApellido { get => SegundoApellido; set => SegundoApellido = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public DataTime


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
            }
            catch (Exception ex)
            {

                throw;
            }


            return rpta;
        }
    }
}

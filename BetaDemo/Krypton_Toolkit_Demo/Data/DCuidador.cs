using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Data
{
    class DCuidador
    {
        private int Id_Cuidador;
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string Direccion;
        private string Telefono;
        private string Sexo;
        private string FechaIngreso;
        private string Cedula;

        public int id_Cuidador { get => Id_Cuidador; set => Id_Cuidador = value; }
        public string primerNombre { get => PrimerNombre; set => PrimerNombre = value; }
        public string segundoNombre { get => SegundoNombre; set => SegundoNombre = value; }
        public string primerApellido { get => PrimerApellido; set => PrimerApellido = value; }
        public string segundoApellido { get => SegundoApellido; set => SegundoApellido = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public string fechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
        public string cedula { get => Cedula; set => Cedula = value; }
        
        public DataTable MostrarCuidador()
        {
            DataTable dtCuidador = new DataTable("Cuidador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Controller.Conexión.cadena;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Read_Cuidador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtCuidador);

            }
            catch (Exception)
            {
                dtCuidador = null;
            }

            return dtCuidador;
        }

    }
}

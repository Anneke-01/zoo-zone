using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Krypton_Toolkit_Demo.Controller;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo.Data
{
    class DUsuario
    {
        

        public DataTable Validar_Acceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(Conexión.cadena))
            {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand("Validar_Acceso", sqlCon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter dato = new SqlParameter();
                    dato.ParameterName = "@Usuario";
                    dato.SqlDbType = SqlDbType.NVarChar;
                    dato.Size = 20;
                    dato.Value = usuario;
                    sqlcmd.Parameters.Add(dato);

                    SqlParameter dato1 = new SqlParameter();
                    dato1.ParameterName = "@Contraseña";
                    dato1.SqlDbType = SqlDbType.NVarChar;
                    dato1.Size = 20;
                    dato1.Value = contraseña;
                    sqlcmd.Parameters.Add(dato1);


                    sqlcmd.Connection.Open();

                    SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                    sqldat.Fill(DtResultado);


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                    DtResultado = null;

                }
            }
            return DtResultado;    
        }

        public DataTable Cambiar_Contrasena(int IdUsuario, string contrasena, string NuevaContrasena)
        {
            DataTable DtResultado = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(Conexión.cadena))
            {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand("Cambiar_Contraseña", sqlCon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter dato = new SqlParameter();
                    dato.ParameterName = "@IdUsuario";
                    dato.SqlDbType = SqlDbType.Int;
                    dato.Value = IdUsuario;
                    sqlcmd.Parameters.Add(dato);

                    SqlParameter dato1 = new SqlParameter();
                    dato1.ParameterName = "@Contraseña";
                    dato1.SqlDbType = SqlDbType.NVarChar;
                    dato1.Size = 20;
                    dato1.Value = contrasena;
                    sqlcmd.Parameters.Add(dato1);

                    SqlParameter dato2 = new SqlParameter();
                    dato2.ParameterName = "@NuevaContraseña";
                    dato2.SqlDbType = SqlDbType.NVarChar;
                    dato2.Size = 20;
                    dato2.Value = NuevaContrasena;
                    sqlcmd.Parameters.Add(dato2);


                    sqlcmd.Connection.Open();

                    SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                    sqldat.Fill(DtResultado);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                    DtResultado = null;

                }
            }
            return DtResultado;
        }
    }
}

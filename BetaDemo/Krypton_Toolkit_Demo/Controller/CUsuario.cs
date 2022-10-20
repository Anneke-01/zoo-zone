using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Krypton_Toolkit_Demo.Data;

namespace Krypton_Toolkit_Demo.Controller
{
    class CUsuario
    {
        public static DataTable Validar_Acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_Acceso(usuario, contraseña);
        }

        public static DataTable Cambiar_Contrasena(int IdUsuario, string contrasena, string NuevaContrasena)
        {
            return new DUsuario().Cambiar_Contrasena(IdUsuario, contrasena, NuevaContrasena);
        }
      
    }
}

using Krypton_Toolkit_Demo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Controller
{
    class CVendedor
    {
        public static DataTable MostrarVendedor()
        {
            return new DVendedor().MostrarVendedor();
        }

        public static string Insertar(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Direccion, string Telefono, string Sexo, string FechaIngreso, string Cedula, int AniosExperiencia, byte Estado)
        {
            DVendedor Obj = new DVendedor();
            Obj.primerNombre = PrimerNombre;
            Obj.segundoNombre = SegundoNombre;
            Obj.primerApellido = PrimerApellido;
            Obj.segundoApellido = SegundoApellido;
            Obj.direccion = Direccion;
            Obj.telefono = Telefono;
            Obj.sexo = Sexo;
            Obj.fechaIngreso = FechaIngreso;
            Obj.cedula = Cedula;

            return Obj.Insertar(Obj);
        }

        public static string Actualizar(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Direccion, string Telefono, string Sexo, string FechaIngreso, string Cedula, int AniosExperiencia, byte Estado)
        {
            DVendedor Obj = new DVendedor();
            Obj.primerNombre = PrimerNombre;
            Obj.segundoNombre = SegundoNombre;
            Obj.primerApellido = PrimerApellido;
            Obj.segundoApellido = SegundoApellido;
            Obj.direccion = Direccion;
            Obj.telefono = Telefono;
            Obj.sexo = Sexo;
            Obj.fechaIngreso = FechaIngreso;
            Obj.cedula = Cedula;

            return Obj.Actualizar(Obj);
        }
    }
}

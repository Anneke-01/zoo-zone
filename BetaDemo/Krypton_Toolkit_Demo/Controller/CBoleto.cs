using Krypton_Toolkit_Demo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Controller
{
    class CBoleto
    {
        public static DataTable MostrarBoleto()
        {
            return new DBoleto().MostrarBoletos();
        }

        public static DataTable MostrarCantidadBoletos(int Id_Venta)
        {
            return new DBoleto().MostrarCantidadBoletos(Id_Venta);
        }

        public static string Insertar(int CantidadNiños, float PrecioNiños, int CantidadAdultos, float PrecioAdultos)
        {
            DBoleto Obj = new DBoleto();
            Obj.cantidadNiños = CantidadNiños;
            Obj.precioNiños = PrecioNiños;
            Obj.cantidadAdultos = CantidadAdultos;
            Obj.precioAdultos = PrecioAdultos;
            return Obj.Insertar(Obj);
        }

        public static string Actualizar(int CantidadNiños, float PrecioNiños, int CantidadAdultos, float PrecioAdultos)
        {
            DBoleto Obj = new DBoleto();
            Obj.cantidadNiños = CantidadNiños;
            Obj.precioNiños = PrecioNiños;
            Obj.cantidadAdultos = CantidadAdultos;
            Obj.precioAdultos = PrecioAdultos;
            return Obj.Actualizar(Obj);
        }
    }
}

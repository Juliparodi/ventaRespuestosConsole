using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosDatos;
using VentaRespuestosEntidades.Helper;

namespace VentaRespuestosService
{
   public class Form1Service
    {
        public static List<CodigoDescripcion> getListaNombreComercio()
        {
            return Form1Datos.getListaNombreComercio();
        }

        public static List<CodigoDescripcion> getListaDireccion()
        {
            return Form1Datos.getListaDireccion();
        }
    }
}

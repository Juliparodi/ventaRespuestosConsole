using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosEntidades.Helper;
using VentaRespuestosService;

namespace VentaRespuestosController
{
    public class Forms1Controller
    {
        public static List<CodigoDescripcion> getListaNombreComercio()
        {
            return Form1Service.getListaNombreComercio();
        }

        public static List<CodigoDescripcion> getListaDireccion()
        {
            return Form1Service.getListaDireccion();
        }
    }
}

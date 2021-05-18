using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosEntidades.Helper;

namespace VentaRespuestosDatos
{
    public class Form1Datos
    {
        public static List<CodigoDescripcion> getListaNombreComercio()
        {
            return NombreComercioHelper.GetLista();
        }

        public static List<CodigoDescripcion> getListaDireccion()
        {
            return DireccionHelper.GetLista();
        }
    }
}

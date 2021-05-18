using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.Helper
{
    public static class DireccionHelper
    {
        public static List<CodigoDescripcion> GetLista()
        {
            List<CodigoDescripcion> lst = new List<CodigoDescripcion>();

            CodigoDescripcion seleccione = new CodigoDescripcion(0, "SELECCIONE");
            CodigoDescripcion direccion1 = new CodigoDescripcion(1, "Av Corrientes 2274");
            CodigoDescripcion direccion2 = new CodigoDescripcion(2, "Av Cordoba 1511");

            lst.Add(seleccione);
            lst.Add(direccion1);
            lst.Add(direccion2);

            return lst;
        }
    }
}

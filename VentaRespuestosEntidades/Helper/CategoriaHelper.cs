using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.Helper
{
    public static class CategoriaHelper
    {
        public static List<CodigoDescripcion> GetLista()
        {
            List<CodigoDescripcion> lst = new List<CodigoDescripcion>();

            CodigoDescripcion seleccione = new CodigoDescripcion(0, "SELECCIONE");
            CodigoDescripcion categoria1 = new CodigoDescripcion(1, "Accesorio para autos");
            CodigoDescripcion categoria2 = new CodigoDescripcion(2, "Herramientas de casa");
            CodigoDescripcion categoria3 = new CodigoDescripcion(3, "Limpieza");

            lst.Add(seleccione);
            lst.Add(categoria1);
            lst.Add(categoria2);
            lst.Add(categoria3);

            return lst;
        }
    }
}

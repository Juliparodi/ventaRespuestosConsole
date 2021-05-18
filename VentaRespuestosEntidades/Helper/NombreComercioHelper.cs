using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.Helper
{
   public static class NombreComercioHelper
    {
        public static List<CodigoDescripcion> GetLista()
        {
            List<CodigoDescripcion> lst = new List<CodigoDescripcion>();

            CodigoDescripcion seleccione = new CodigoDescripcion(0, "SELECCIONE");
            CodigoDescripcion juliRespuesto = new CodigoDescripcion(1, "Juli Respuestos S.A");
            CodigoDescripcion matiRepuesto = new CodigoDescripcion(2, "Mati Respuestos S.A");

            lst.Add(seleccione);
            lst.Add(juliRespuesto);
            lst.Add(matiRepuesto);

            return lst;
        }
    }
}

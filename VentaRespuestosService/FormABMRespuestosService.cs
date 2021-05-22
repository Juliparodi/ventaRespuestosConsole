using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosDatos;
using VentaRespuestosEntidades.exceptio_ns;
using VentaRespuestosEntidades.Helper;

namespace VentaRespuestosService
{
   public static class FormABMRespuestosService
    {
      public static List<CodigoDescripcion> GetListaCategorias()
        {
            return FormABMRespuestosDatos.GetListaCategorias();
        }

        
    }
}

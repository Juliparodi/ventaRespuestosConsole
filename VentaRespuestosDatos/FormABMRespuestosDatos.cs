using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosEntidades.Helper;

namespace VentaRespuestosDatos
{
    public static class FormABMRespuestosDatos
  {
    
      public static List<CodigoDescripcion> GetListaCategorias()
    {
        return CategoriaHelper.GetLista();
    }

  }
    
}

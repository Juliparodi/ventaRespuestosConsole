using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestosEntidades.Helper;
using VentaRespuestosService;

namespace VentaRespuestosController
{
    public static class FormABMRespuestosController
    {
        public static List<CodigoDescripcion> GetListaCategorias()
        {
            return FormABMRespuestosService.GetListaCategorias();
        }
    }
}

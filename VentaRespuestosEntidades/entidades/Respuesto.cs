using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.entidades
{
   public class Respuesto
    {
        int _codigo;
        string _nombre;
        double _precio;
        int _stock;
        Categoria _categoria;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

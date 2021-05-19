using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.entidades
{
    public class Categoria
    {
        int _codigo;
        string _nombre;

        public Categoria(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}

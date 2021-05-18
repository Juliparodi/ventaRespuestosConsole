using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.exceptio_ns
{
    public class ComercioNotFoundException : Exception
    {
        string _message;
        public ComercioNotFoundException(string message) : base()
        {
            this._message = message;
        }
    }
}

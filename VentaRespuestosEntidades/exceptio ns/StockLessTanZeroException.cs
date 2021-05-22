using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestosEntidades.exceptio_ns
{
    public class StockLessTanZeroException : Exception
    {
        string _message;
        public StockLessTanZeroException(string message) : base()
        {
            this._message = message;
        }
    }
}

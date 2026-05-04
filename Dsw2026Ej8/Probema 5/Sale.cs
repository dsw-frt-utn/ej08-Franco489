using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Probema_5
{
    class Sale
    {
        private decimal _importe;
        public Sale(decimal importe)
        {
            _importe= importe;
        }

        public decimal GetImporte()
        {
            return _importe;
        }
        public virtual decimal CalculateTotal()
        {
            return 0;
        }
    }
}

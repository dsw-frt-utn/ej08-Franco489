using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Probema_5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe){}

        public override decimal CalculateTotal()
        {
            decimal i = GetImporte();
            return i - (i * (decimal) 0.10);
        }
    }
}

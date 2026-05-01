using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    partial class ProductHelper
    {
        public string FormatearPrecio(decimal price)
        {
            return price.ToString("C2");
        }

      
    }
}

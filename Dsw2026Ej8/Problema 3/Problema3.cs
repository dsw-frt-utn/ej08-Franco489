using Dsw2026Ej8.Problema_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiedValue = originalValue;
            copiedValue++;

            Product copiedProduct = product;
            copiedProduct.SetDescription("Nueva Descripcion");

            return $"{originalValue}-{copiedValue}-{product.GetDescription()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    static class Extensions
    {
        public static string ToProductCode (this string code)
        {
            string cadena = code.Trim();
            cadena = cadena.ToUpper();
            cadena = cadena.Replace(' ', '-');

            return cadena;
        }
    }
}

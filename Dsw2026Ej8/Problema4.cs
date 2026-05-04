using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int? suma = 0;
            int n = 3;
            
            

            void rangoNota(int? nota)
            {
                if(nota>=0 && nota<=10 && nota.HasValue)
                {
                    suma += nota;
                }
                else
                {
                    n--;
                }
            }

            rangoNota(nota1);
            rangoNota(nota2);
            rangoNota(nota3);

            if (n == 0)
                return 0;
            else
                return (double)suma / n;



        }
    }
}

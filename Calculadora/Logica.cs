using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Logica_Operacional
    {
        public long resultado;
        public void Resultado(long numeroEntrante1, long numeroEntrante2)
        {
            if(Sumas(numeroEntrante1, numeroEntrante2) > 0)
            {
                Console.WriteLine(resultado);
            }

        }
        public long Sumas(long numeroEntrante1, long numeroEntrante2)
        {
            resultado = numeroEntrante1 + numeroEntrante2;
            Console.WriteLine(resultado);
            return resultado;
        }
        public long Restas(long numeroEntrante1, long numeroEntrante2)
        {
            resultado = numeroEntrante1 - numeroEntrante2;
            return resultado;
        }
        public long Multiplicacion(long numeroEntrante1, long numeroEntrante2)
        {
            resultado = numeroEntrante1 * numeroEntrante2;
            return resultado;
        }
        public long Division(long numeroEntrante1, long numeroEntrante2)
        {
            if (numeroEntrante1 < 0 || numeroEntrante1 > 0)
            {
                resultado = numeroEntrante1 / numeroEntrante2;
            }
            else
            {
                Console.WriteLine("Ningún número es divisible por cero");
            }
            return resultado;
        }
    }
}
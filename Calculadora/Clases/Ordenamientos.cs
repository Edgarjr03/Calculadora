using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Ordenamientos
    {
        public int[] Burbuja(ref int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambiar arreglo[j] y arreglo[j+1]
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
            return arreglo;
        }
     }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasAlgoritmo
{
    public class fibonachi
    {

        public static void mostrarSerie(int limite)
        {
            int a, b, i, auxiliar;
            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}

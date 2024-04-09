using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class CalculoFatorial
    {
        public static int Fatorial(int n)
        {
           int resultado = 1;
           while (n != 1)
           {
                resultado = resultado * n;
                n = n - 1;
           }
           return resultado;
            
        }
    }
}

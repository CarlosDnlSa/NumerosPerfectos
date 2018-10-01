using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPerfector
{
    class CalcularPerfe
    {
        public void CalPerfectos()
        {
            int i,j, sumar = 0;
            for(i = 1; i < 10000; i++)
            {
                sumar = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0 && i % j != i )
                    {
                        sumar = sumar + j;
                    }
                }
                if (sumar == i)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}

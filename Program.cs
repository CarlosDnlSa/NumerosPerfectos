using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPerfector
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularPerfe calcular = new CalcularPerfe();
            calcular.CalPerfectos();
            Console.ReadKey();
        }
    }
}

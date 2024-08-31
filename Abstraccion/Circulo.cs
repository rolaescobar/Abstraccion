using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Circulo : IForma
    {
        public void Dibujar()
        {
            Console.WriteLine("Dibujando un circulo");
        }

        public void Mover(int x, int y)
        {
            Console.WriteLine($"Moviendo circulo a ({x}, {y})");
        }
    }
}

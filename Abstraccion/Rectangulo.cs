using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Rectangulo : IForma
    {
        public void Dibujar()
        {
            Console.WriteLine("Dibujando un rectangulo");
        }

        public void Mover(int x, int y)
        {
            Console.WriteLine($"Moviendo rectangulo a ({x}, {y})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D___Semana2Explicacion
{
    internal class Rectangulo:Area
    {
        protected float a, b;

        public Rectangulo (float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public override float CalcularArea()
        {
            return b * a;
        }
    }
}

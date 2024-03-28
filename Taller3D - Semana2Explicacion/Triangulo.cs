using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D___Semana2Explicacion
{
    internal class Triangulo:Area
    {
        protected float q, w;

        public Triangulo(float q, float w)
        {
            this.q = q;
            this.w = w;
        }

        public override float CalcularArea()
        {
            return q * w;
        }
    }
}

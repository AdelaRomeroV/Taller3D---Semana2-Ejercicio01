using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D___Semana2Explicacion
{
    class Circulo:Area
    {
        protected float cRadio;

        public Circulo(float cRadio)
        {
            this.cRadio = cRadio;
        }

        public override float CalcularArea()
        {
            return cRadio * cRadio * 3.14f;
        }



    }
}

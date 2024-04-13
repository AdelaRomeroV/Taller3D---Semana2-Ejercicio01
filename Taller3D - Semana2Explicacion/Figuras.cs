using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D___Semana2Explicacion
{
    internal class Figuras
    {
        bool continueFlag = true;

        public void figurasElegir ()
        {
            while(continueFlag)
            {
                Console.WriteLine("Introduce la figura que deseas operar: \n");
                Console.WriteLine("Circulo");
                Console.WriteLine("Rectangulo");
                Console.WriteLine("Triangulo");

                string Option = Console.ReadLine();

                Area area = null; //obligatorio
                switch (Option) 
                {
                    case "Circulo":

                        float cRadio;

                        Console.WriteLine("Ingresa el radio del circulo\n");
                        cRadio = float.Parse(Console.ReadLine());

                        area = new Circulo(cRadio);
                        Console.WriteLine($"El area del circulo es {area.CalcularArea()}");
                        
                        break;

                    case "Rectangulo":

                        float b, a;

                        Console.WriteLine("Ingresar la base del rectangulo\n");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar la altura del rectangulo\n");
                        a = float.Parse(Console.ReadLine());

                        area = new Rectangulo(b, a);
                        Console.WriteLine($"El area del rectangulo es {area.CalcularArea()}");

                        break;

                    case "Triangulo":

                        float q, w;

                        Console.WriteLine("Ingresar la base del triangulo\n");
                        q = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar la altura del triangulo\n");
                        w = float.Parse(Console.ReadLine());
                        area = new Triangulo(q, w);
                        Console.WriteLine($"El area del triangulo es {area.CalcularArea()}");

                        break;
                }

                Console.WriteLine("Deseas continuar, SI/NO");
                if(Console.ReadLine() == "NO")
                {
                    continueFlag = false;
                }
            }

            
        }  
        
        public virtual float CalcularArea()
        {
            return 0;
        }
  
    }
}

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

                switch(Option) 
                {
                    case "Circulo":

                        float cRadio;

                        Console.WriteLine("Ingresa el radio del circulo\n");
                        cRadio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(cRadio);
                        Console.WriteLine($"El area del circulo es {circulo.CalcularArea()}");
                        
                        break;

                    case "Rectangulo":

                        float b, a;

                        Console.WriteLine("Ingresar la base del rectangulo\n");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar la altura del rectangulo\n");
                        a = float.Parse(Console.ReadLine());

                        Rectangulo rectangulo = new Rectangulo(b, a);
                        Console.WriteLine($"El area del rectangulo es {rectangulo.CalcularArea()}");

                        break;

                    case "Triangulo":

                        float q, w;

                        Console.WriteLine("Ingresar la base del triangulo\n");
                        q = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar la altura del triangulo\n");
                        w = float.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(q, w);
                        Console.WriteLine($"El area del triangulo es {triangulo.CalcularArea()}");

                        break;


                }

                Console.WriteLine("Deseas continuar, SI/NO");
                if(Console.ReadLine() == "NO")
                {
                    continueFlag = false;
                }
            }

            Console.WriteLine();
        }        
  
    }
}

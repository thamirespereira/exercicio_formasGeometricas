using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_formasGeometricas
{
    public class Retangulo : FormaGeometrica
    {
        public double Base {get; set;}
        public double Altura {get; set;}

        public Retangulo(double area, double b, double altura)
        : base(area)
        {
            Base = b;
            Altura = altura;
        }

        public override void CalcularArea()
        {
            Console.WriteLine("Base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            Area = Base * Altura;

            Console.WriteLine($"A área do retângulo é: {Area}");
        }
    }
}
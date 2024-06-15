namespace exercicio_formasGeometricas
{
    public class Triangulo : FormaGeometrica
    {
        public double Base {get; set;}
        public double Altura {get; set;}

        public Triangulo(double area, double b, double altura)
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

            Area = (Base * Altura) / 2;

            Console.WriteLine($"A área do triângulo é: {Area}");
        }
    }
}
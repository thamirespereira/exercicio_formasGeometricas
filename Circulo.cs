namespace exercicio_formasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        public double Raio {get; set;}

        public Circulo(double area, double raio)
        : base(area)
        {
            Raio = raio;
        }

        public override void CalcularArea()
        {
            Console.WriteLine("Raio: ");
            Raio = Convert.ToDouble(Console.ReadLine());

            Area = PI * (Raio * Raio);

            Console.WriteLine($"A área do círculo é: {Area}");
        }
    }
}
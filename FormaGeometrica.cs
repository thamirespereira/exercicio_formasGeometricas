namespace exercicio_formasGeometricas
{
    public abstract class FormaGeometrica{
        public double Area {get; set;}
        public const double PI = 3.1415926535897931;

        public FormaGeometrica(double area)
        {
            Area = area;
        }

        public abstract void CalcularArea();
    }
}
namespace AreaPerimetro_Interface
{
    public class AreaPerimetro_Interface
    {

        static void Main(string[] args)
        {
            IPieza cuadrado = new Cuadrado(5);
            IPieza trianguloRectangulo = new TrianguloRectangulo(5, 3);

            Console.WriteLine($"El área del cuadrado es {cuadrado.Area()}");
            Console.WriteLine($"El perímetro del cuadrado es {cuadrado.Perimetro()}");

            Console.WriteLine($"El área del triángulo es {trianguloRectangulo.Area()}");
            Console.WriteLine($"El perímetro del triángulo es {trianguloRectangulo.Perimetro()}"); 
        }

        public interface IPieza
        {
            decimal Area();
            decimal Perimetro();
        }

        public class Cuadrado : IPieza
        {
            public decimal Lado { get; private set; }

            public Cuadrado(decimal lado)
            {
                Lado = lado;
            }

            public decimal Area()
            {
                return Lado * Lado;
            }

            public decimal Perimetro()
            {
                return Lado * 4;
            }
        }

        public class TrianguloRectangulo : IPieza
        {
            public decimal LadoA { get; set; }
            public decimal LadoB { get; set; }
            public decimal Hipotenusa { get; set; }
            public TrianguloRectangulo(decimal ladoa, decimal ladob)
            {
                LadoA = ladoa;
                LadoB = ladob;
                Hipotenusa = CalculateHipotenusa(ladoa, ladob);
            }

            private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
            {
                return Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));

            }

            public decimal Area()
            {
                return LadoA * LadoB / 2;
            }

            public decimal Perimetro()
            {
                return LadoA + LadoB + Hipotenusa;
            }
        }
    }
}
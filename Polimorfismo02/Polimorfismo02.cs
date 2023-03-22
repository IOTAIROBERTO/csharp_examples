namespace Polimorfismo02
{
    public class Casa
    {
        //Estados - Atributos
        public string tipo;
        public double precio;
        public double areaTerreno;
        public double areaConstruida;

        //Constructores
        public Casa()
        {

        }

        public Casa(string tipo, double precio)
        {
            this.tipo = tipo;
            this.precio = precio;
        }

        public Casa(string tipo, double precio, double areaTerreno, double areaConstruida)
        {
            this.tipo = tipo;
            this.precio = precio;
            this.areaTerreno = areaTerreno;
            this.areaConstruida = areaConstruida;
        }

        //Comportamientos - Métodos
        public void vender()
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio
                );
        }
        public void vender(string cliente)
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio + " por cliente: " + cliente
                );
        }
        public void vender(double descuento)
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio + "con descuento: " + descuento
                );
        }

        static void Main (string[] args)
        {
            Casa casa = new Casa("Casa", 542345, 1000, 512);
            casa.vender(2132135);
            Console.ReadKey();
        }
        
    } 
}
namespace AreaCuadrado_POO
{
    class AreaCuadrado_POO
    {
        public void CalculaAreaCuadrado(double l)
        {
            //Variables Auxiliares
            double area = 0;

            //Realiza la operacion
            area = l * l;  
            
            //Imprimiendo el resultado
            Console.WriteLine("El Area del Cuadrado: " + area);
        }

        static void Main(string[] args)
        {
            double lado = 0, area = 0;

            //Explicacion del ejercicio
            Console.WriteLine("Encontrar el Area de un Cuadrado.");

            //Pediendo datos
            Console.Write("Ingrese el lado del cuadrado: ");

            //Convierte de texto a tipo entero
            lado = Int32.Parse(Console.ReadLine()); 

            AreaCuadrado_POO m_areacuadradopoo = new AreaCuadrado_POO();

            m_areacuadradopoo.CalculaAreaCuadrado(lado); 
        }
    }
}
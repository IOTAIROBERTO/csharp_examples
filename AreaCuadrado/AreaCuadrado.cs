namespace AreaCuadrado
{
    class AreaCuadrado
    {
        static void Main(string[] args)
        {
            //Variables Auxiliares
            double area = 0, lado = 0;

            //Explicacion del ejercicio
            Console.WriteLine("Encontrar el Area de un Cuadrado.");

            //Pediendo datos
            Console.Write("Ingrese el lado del cuadrado: ");

            //Convierte de texto a tipo entero
            lado = Int32.Parse(Console.ReadLine());

            //Realiza la operacion
            area = lado * lado;

            //Imprimiendo el resultado
            Console.WriteLine("El Area del Cuadrado: " + area);

            //El programa espera a que se reciba una tecla
            //La funcion de esto es que no se cierre el programa
            Console.ReadKey();
        }
    }
}
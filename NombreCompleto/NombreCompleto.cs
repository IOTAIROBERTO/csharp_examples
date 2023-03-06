namespace NombreCompleto
{
    class NombreCompleto
    {
        static void Main(string[] args)
        {
            //Variables Auxiliares
            string nombre, apellido, nombreCompleto;

            //Explicacion del ejercicio
            Console.WriteLine("Solicitar y desplegar en consola el nombre completo del usuario.");

            //Pediendo datos
            Console.Write("Ingrese el nombre: ");  
            nombre = Console.ReadLine(); 

            Console.Write("Ingrese el apellido: ");  
            apellido = Console.ReadLine(); 

            //Concatenar cadenas
            nombreCompleto = nombre + " " + apellido; 

            //Imprimiendo el resultado
            Console.WriteLine("Su nombre completo es: " + nombreCompleto);

            //El programa espera a que se reciba una tecla
            //La funcion de esto es que no se cierre el programa
            Console.ReadKey();
        }
    }
}
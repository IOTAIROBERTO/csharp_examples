namespace SumaNumeros
{
    class SumaNumeros
    { 
        static void Main(string[] args)
        {  
            int valor1, valor2;

            Console.Write("Ingrese el primer valor: ");  
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: "); 
            valor2 = Convert.ToInt32(Console.ReadLine());

            int resSuma = ResultadoSuma(valor1,valor2); 

            //Imprimiendo el resultado
            Console.WriteLine("La suma de los dos valores es: " + resSuma);

            //El programa espera a que se reciba una tecla
            //La funcion de esto es que no se cierre el programa
            Console.ReadKey();
        }

        public static int ResultadoSuma(int a, int b)
        {
            int suma = 0;
            suma = a + b;
            return suma;
        }
    }
}
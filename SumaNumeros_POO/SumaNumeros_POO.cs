namespace SumaNumeros_POO
{
    class SumaNumeros_POO
    { 
        static void Main(string[] args)
        {  
            int valor1, valor2;

            Console.Write("Ingrese el primer valor: ");  
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: "); 
            valor2 = Convert.ToInt32(Console.ReadLine());

            SumaNumeros_POO m_sumanumerospoo = new SumaNumeros_POO(); 

            int resSuma = m_sumanumerospoo.ResultadoSuma(valor1,valor2); 

            //Imprimiendo el resultado
            Console.WriteLine("La suma de los dos valores es: " + resSuma); 
        }

        public int ResultadoSuma(int a, int b)
        {  
            return a+b;
        }
    }
}
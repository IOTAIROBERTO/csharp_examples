﻿namespace ParImpar
{
    class ParImpar
    { 
        static void Main(string[] args)
        {  
            string resultado;

            Console.Write("Ingrese un valor para indicar si es par o impar: ");  
            resultado = Console.ReadLine();  
            resultado = IsPair(resultado);

            //Imprimiendo el resultado
            Console.WriteLine("El valor ingresado es: " + resultado); 
        }

        public static string IsPair(string input)
        {
            int validInt = int.Parse(input);
            string isPair = Pair(validInt);
            return isPair; 
        } 

        public static string Pair(int dataValue)
        {
            if (dataValue % 2 == 0) return "es Par"; 
            else return "es Impar"; 
        }
    }
}
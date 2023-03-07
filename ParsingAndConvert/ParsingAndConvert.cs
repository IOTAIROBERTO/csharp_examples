using System;

namespace ParsingAndConvert
{
    class ParsingAndConvert
    {
        /* Para guardarlo necesitamos declarar una variable
 * cuyo tipo de dato sea un número entero.
 * por lo tanto, declaramos una variable tipo byte.
 * Le asignamos de un principio el valor cero*/
        byte varNumero = 0;

        static void Main(string[] args)
        {
            string m_seleccion;
            ParsingAndConvert m_parsingandconvert = new ParsingAndConvert();

            Console.WriteLine("Seleccione el método de conversión: ");
            Console.WriteLine("1. .Parse()");
            Console.WriteLine("2. Convert.");
            Console.WriteLine("3. .ToString()");
            m_seleccion = Console.ReadLine(); 

            Console.WriteLine("Introduce un número entre 0 y 255:");
            if (m_seleccion == "1")
            {
                m_parsingandconvert.ParsingByParse();
            }
            else if (m_seleccion == "2")
            {
                m_parsingandconvert.ConvertingToByte();
            }

            else if (m_seleccion == "3")
            {
                m_parsingandconvert.ConverNumberToStringUsingToString();
            }
        }

        public void ParsingByParse()
        {
            varNumero = byte.Parse(Console.ReadLine());
            Console.WriteLine("El número es: " + varNumero + " utilizando .Parse()");
        }

        public void ConvertingToByte()
        {
            varNumero = Convert.ToByte(Console.ReadLine());

            // Ahora podemos mostrar el dato por de la variable. 
            Console.WriteLine("El número es: " + varNumero + " utilizando Convert");
        }

        public void ConverNumberToStringUsingToString()
        {
            varNumero = byte.Parse(Console.ReadLine());

            // Ahora podemos mostrar el dato por de la variable. 
            Console.WriteLine("El número es: " + varNumero.ToString() + " convirtiendo a cadena con .ToString()");
        }  
    }
}
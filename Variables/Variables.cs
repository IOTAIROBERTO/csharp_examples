using System;
namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            // Declaramos todas nuestras variables
            string nombreCliente = "Carlos";
            char primeraLetra = 'A';
            char ultimaLetra = 'Z';
            bool valorVerdadero = true;
            bool valorFalso = false;
            byte numberByte = 10;
            sbyte numberSbyte = -10;
            short numberShort = 30000;
            ushort numberUshort = 60000;
            int numberInt = 2000000;
            uint numberUint = 24000000;
            long numberLong = 800000000000000;
            ulong numberUlong = 1900000000000000000;
            float numberFloat = 15.6594225F;
            double numberDouble = 3252.6594225654152;
            decimal valorPI = 3.141592653589793238462m;
            // Podemos agregar comentarios colocando doble slash (//) al inicio de cada línea de código.
            // string apellidoCliente = "Pena";
            // string AplleidoCliente = "Pena";
            // Imprimimos las variables para que se muestre en la consola.
            Console.WriteLine("Imprimiendo el nombre del cliente: " + nombreCliente);
            Console.WriteLine("Imprimiendo primera letra del abecedario: " + primeraLetra);
            Console.WriteLine("Imprimiendo última letra del abecedario: " + ultimaLetra);
            Console.WriteLine("Imprimiendo valor verdadero: " + valorVerdadero);
            Console.WriteLine("Imprimiendo valor falso: " + valorFalso);
            Console.WriteLine("Imprimiendo valor byte: " + numberByte);
            Console.WriteLine("Imprimiendo valor sbyte: " + numberSbyte);
            Console.WriteLine("Imprimiendo valor short: " + numberShort);
            Console.WriteLine("Imprimiendo valor ushort: " + numberUshort);
            Console.WriteLine("Imprimiendo valor int: " + numberInt);
            Console.WriteLine("Imprimiendo valor uint: " + numberUint);
            Console.WriteLine("Imprimiendo valor long: " + numberLong);
            Console.WriteLine("Imprimiendo valor ulong: " + numberUlong);
            Console.WriteLine("Imprimiendo valor float: " + numberFloat);
            Console.WriteLine("Imprimiendo valor double: " + numberDouble);
            Console.WriteLine("Imprimiendo valor decimal o valor de PI: " + valorPI);
             
        }
    }
}

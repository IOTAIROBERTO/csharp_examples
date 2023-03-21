namespace CondicionSeleccionIteracion
{
    class CondicionSeleccionIteracion
    {
        static void Main(string[] args)
        {
            int nFlujo = 0, nIteraciones = 0;

            try
            {
                do
                { 
                    Console.WriteLine("Ingresa si utilizarás for, foreach o while: ");
                    Console.WriteLine("1. for");
                    Console.WriteLine("2. while");
                    nFlujo = Convert.ToInt32(Console.ReadLine());
                    if (nFlujo < 1) Console.WriteLine("Seleccione correctamente.");
                    else
                    { 
                        do
                        {
                            Console.WriteLine("Ingresa el numero de iteraciones: ");
                            nIteraciones = Convert.ToInt32(Console.ReadLine());
                            if (nIteraciones < 1) Console.WriteLine("Ingresa un numero mayor a 0");
                        }
                        while (nIteraciones < 1);

                        switch (nFlujo)
                        {
                            case 1:
                                for (int i = 1; i < nIteraciones+1; i++)
                                    Console.WriteLine("Seleccionaste iterar " + nIteraciones + " veces con ciclo for y ésta es la #" + i);
                                break;
                            case 2:
                                int contador = 1;
                                while (contador <= nIteraciones)
                                {
                                    Console.WriteLine("Seleccionaste iterar " + nIteraciones + " veces con ciclo while y ésta es la #" + contador);
                                    contador++;
                                }
                                break;
                            default: break;
                        }
                    }
                } while (nFlujo < 1);  
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
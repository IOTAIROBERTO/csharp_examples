namespace PruebaVector
{
    class PruebaVector
	{
        private string[] nombres;
        private int[] edades;


        public void Cargar()
    	{
        	nombres = new string[5];
        	edades = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese nombre "+(f+1)+": ");
            	nombres[f] = Console.ReadLine();
                Console.Write("Ingrese edad "+(f+1)+": ");
                string linea;
            	linea = Console.ReadLine();
                edades[f] = int.Parse(linea);
        	}
    	}

        public void MayoresEdad()
    	{
            Console.WriteLine("Personas mayores de edad.");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] >= 18)
            	{
                    Console.WriteLine(nombres[f]);
                }
        	}
            Console.ReadKey();
    	}

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
        	pv.Cargar();
        	pv.MayoresEdad();
    	}
	}
}
namespace MatrizDiagonal
{
    class MatrizDiagonal
	{
        private int[,] serie;


        public void Cargar()
    	{
        	serie = new int[10,10];
            for (int i = 1; i<= 6; i++)
        	{
                for (int j = 1; j <= 6; j++)
            	{
                    if (i==j)
                	{
                    	serie[i, j] = 1;
                	}
           	     else
                	{
                    	serie[i, j] = 0;
                	}
            	}
        	}
    	}


        public void visualizar()
    	{
            for (int i = 1; i <= 6; i++)
        	{
                Console.Write("\n");
                for (int j = 1; j <= 6; j++)
            	{
                    Console.Write(serie[i,j]+" ");
            	}
        	}
            Console.ReadKey();
    	}
 
        static void Main(string[] args)
    	{
            MatrizDiagonal pv = new MatrizDiagonal();
        	pv.Cargar();
        	pv.visualizar();
    	}
	}
}

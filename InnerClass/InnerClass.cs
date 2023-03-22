namespace InnerClass
{
    public class ClaseExterior
    {
        public void MetodoA()
        {
            Console.WriteLine("Clase A");
        
        }

        public class ClaseInterior
        {
            public void MetodoB()
            {
                Console.WriteLine("Clase B");
            }
        }
    }

    public class Programa
    {
        public static void Main(string[] args)
        {
            ClaseExterior claseExt = new ClaseExterior();
            claseExt.MetodoA();

            ClaseExterior.ClaseInterior claseInt = new ClaseExterior.ClaseInterior();
            claseInt.MetodoB(); 
        }
    }
}
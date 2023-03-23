namespace Ave_Interface
{
    class Ave_Interface
    {
        public interface IAve
        {
            void Volar();
            void Comer();
        }

        public class AvePropiedades : IAve
        {
            public int Patas = 2;
            public int Alas = 2;
            public int Cola = 1;
            public string Nombre { get; private set; }

            public AvePropiedades(string NAve)
            {
                this.Nombre = NAve;
            }
            public void Volar()
            {
                Console.WriteLine("Volar");
            }
            public void Comer()
            {
                Console.WriteLine("Comer");
            }
        }

        public class Ave : AvePropiedades
        {
            public Ave(string Nombre) : base(Nombre)
            {

            }
        }
        public static void Main(string[] args)
        {
            Ave canario = new Ave("Canario");
            Ave cuervo = new Ave("Cuervo");

            Ave_Interface main = new Ave_Interface();
            main.imprimir(canario);
            main.imprimir(cuervo);
            Console.ReadKey();
        }

        public void imprimir(Ave ave)
        {
            Console.WriteLine("Soy un {0} tengo {1} pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);

            Console.WriteLine("Puedo ");
            ave.Comer();
            Console.WriteLine(" y también puedo ");
            ave.Volar();
        }
    }
}
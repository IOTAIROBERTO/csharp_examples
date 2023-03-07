
namespace Fecha
{
    class Fecha
    {
        public void PrintFecha()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hoy es {0} del mes {1} de {2}",fecha.Day, fecha.Month, fecha.Year);
            DateTime manyana = fecha.AddDays(1);
            Console.WriteLine("Mañana será {0}",manyana.Day);
        } 

        public static void Main(string[] args)
        {
            Fecha m_printfecha = new Fecha();
            m_printfecha.PrintFecha();
        }
    }
}
namespace Encapsulamiento01
{
    class Encapsulamiento01
    {
       public static void Main(string[] args)
       {
            Persona alumno = new Persona();
            alumno.nombre = "Roger";
            alumno.fechaNacimiento = Convert.ToDateTime("10/10/1996");
            alumno.registrar();
            Console.ReadKey();         
       }

        public class Persona
        {
            //Atributos
            public string nombre;
            public DateTime fechaNacimiento;
            private int edad;

            //Métodos
            public void registrar()
            {
                calcularEdad(fechaNacimiento);
                Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente... " );
            }

            public void calcularEdad(DateTime fechaNacimientoPersona)
            {
                DateTime fechaActual = DateTime.Now;
                edad = fechaActual.Year - fechaNacimientoPersona.Year;
            }
        } 
    }
}
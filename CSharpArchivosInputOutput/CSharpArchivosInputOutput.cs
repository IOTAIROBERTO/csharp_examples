using System.IO;

namespace CSharpArchivosInputOutput
{
    class CSharpArchivosInputOutput
    {
        public static void Main(string[] args)
        {
            string line;
            string nombre, apellido, nombreCompleto;

            //Explicacion del ejercicio
            Console.WriteLine("Solicitar y desplegar en consola el nombre completo del usuario.");

            //Pediendo datos
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();

            //Concatenar cadenas
            nombreCompleto = nombre + " " + apellido;

            //Imprimiendo el resultado
            Console.WriteLine("Su nombre completo es: " + nombreCompleto);

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("../HelloWorld.txt");
                //Write a line of text
                sw.WriteLine(nombreCompleto);
                //Close the file
                sw.Close();

                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("../HelloWorld.txt");
                    //Read the first line of text
                    line = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the line to console window
                        Console.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    //close the file
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }  
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
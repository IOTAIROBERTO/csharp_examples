using System.IO;

namespace CSharpArchivosInputOutput
{
    class CSharpArchgivosInputOutput
    {
        public static void Main(string[] args)
        {
            string line;
            string nombre, apellido, nombreCompleto; 

            Console.WriteLine("Solicitar y desplegar en consola el nombre completo del usuario: ");

            //PEDIR DATOS:
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();

            //CONCATENAR LAS CADENAS:
            nombreCompleto = nombre + " " + apellido;

            //IMPRIMIENDO EL RESULTADO:
            Console.WriteLine("Su nombre completo es: " + nombreCompleto);

            try
            {
                //Indicar y pasar como parámetro la ruta y el archivo a StreamWriter
                StreamWriter sw = new StreamWriter("../HelloWorld.txt");

                //Escribir una línea de texto
                sw.WriteLine(nombreCompleto);

                //Cerrar el archivo
                sw.Close();

                try
                {
                    //Indicar y pasar como parámetro la ruta y el archivo a StreamWriter
                    StreamReader sr = new StreamReader("../HelloWorld.txt");

                    //Leer la primera línea de texto del archivo
                    line = sr.ReadLine();

                    while(line != null)
                    {
                        Console.WriteLine(line);

                        //Leer la siguiente linea
                        line = sr.ReadLine();
                    } 

                    //Cerrar el archivo
                    sr.Close();
                    Console.ReadLine();
                }
                catch(Exception ex)
                {
                     Console.WriteLine("Exception: " + ex.Message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);  
            }
            finally
            {
                Console.WriteLine("Ejecutando el bloque final.");
            } 
        } 
    }
}










































// using System.IO;

// namespace CSharpArchivosInputOutput
// {
//     class CSharpArchivosInputOutput
//     {
//         public static void Main(string[] args)
//         {
//             string line;
//             string nombre, apellido, nombreCompleto;

//             //Explicacion del ejercicio
//             Console.WriteLine("Solicitar y desplegar en consola el nombre completo del usuario.");

//             //Pediendo datos
//             Console.Write("Ingrese el nombre: ");
//             nombre = Console.ReadLine();

//             Console.Write("Ingrese el apellido: ");
//             apellido = Console.ReadLine();

//             //Concatenar cadenas
//             nombreCompleto = nombre + " " + apellido;

//             //Imprimiendo el resultado
//             Console.WriteLine("Su nombre completo es: " + nombreCompleto);

//             try
//             {
//                 //Pass the filepath and filename to the StreamWriter Constructor
//                 StreamWriter sw = new StreamWriter("../HelloWorld.txt", append: true);
//                 //Write a line of text
//                 sw.WriteLine(nombreCompleto);
//                 //Close the file
//                 sw.Close();

//                 try
//                 {
//                     //Pass the file path and file name to the StreamReader constructor
//                     StreamReader sr = new StreamReader("../HelloWorld.txt");
//                     //Read the first line of text
//                     line = sr.ReadLine();
//                     //Continue to read until you reach end of file
//                     while (line != null)
//                     {
//                         //write the line to console window
//                         Console.WriteLine(line);
//                         //Read the next line
//                         line = sr.ReadLine();
//                     }
//                     //close the file
//                     sr.Close();
//                     Console.ReadLine();
//                 }
//                 catch (Exception e)
//                 {
//                     Console.WriteLine("Exception: " + e.Message);
//                 }  
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("Exception: " + e.Message);
//             }
//             finally
//             {
//                 Console.WriteLine("Executing finally block.");
//             }
//         }
//     }
// }
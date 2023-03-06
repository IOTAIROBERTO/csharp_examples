using System.IO;

namespace CSharpEscrituraArchivos
{
    class CSharpEscrituraArchivos
    {
        public static void Main(string[] args)
        {
            string line;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("../HelloWorld.txt");
                //Write a line of text
                sw.WriteLine("This is the Hello World!! File writing test");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
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
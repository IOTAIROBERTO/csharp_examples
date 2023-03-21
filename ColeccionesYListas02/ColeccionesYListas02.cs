namespace ColeccionesYListas01
{
    public class ColeccionesYListas01
    {
        static void Main(string[] args)
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            ///////////////////////////////////////////////////    REMOVE
            // Remove an element from the list by specifying
            // the object.
            //salmons.Remove("coho");
            /////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////     REMOVE AT
            // Remove an element from the list by specifying
            // the object.
            //salmons.RemoveAt(0);
            ///////////////////////////////////////////////////////////// 
            
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye  
        }
    }
}
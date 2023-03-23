namespace ColeccionesYListas01
{
    public class ColeccionesYListas01
    {   
        static void Main(string[] args)
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            //salmons.Remove("chinook");

            //salmons.RemoveAt(0);

            //salmons.RemoveRange(0, 2);

            //salmons.RemoveAll(salmons => salmons.EndsWith("k"));

            salmons.Clear();

            foreach(var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }
        } 
    }
}
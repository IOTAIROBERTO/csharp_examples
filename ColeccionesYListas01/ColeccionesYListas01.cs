﻿namespace ColeccionesYListas01
{
    public class ColeccionesYListas01
    {   
        static void Main(string[] args)
        {
            // Create a list of strings.
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye
        } 
    }
}
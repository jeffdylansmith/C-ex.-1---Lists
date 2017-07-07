
using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> outerPlanetList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(outerPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            string[] output = planetList.GetRange(0, 4).ToArray();
             Console.WriteLine();
             planetList.Remove("Pluto");
            foreach( string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
        
    


using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        //MAIN method
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            //Adding new strings to the list
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");
        
            List<string> newPlanetList = new List<string>() {"Jupiter", "Saturn"};
            //Combining two lists
            planetList.AddRange(newPlanetList);
            //Adding Earth and Venus in a specific order
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");
            //Add Pluto
            planetList.Add("Pluto");
            //Remove Pluto..IT AINT REAL
            planetList.Remove("Pluto");
            //Get rocky planets into their own list(Mercury, Venus, Earth, Mars)
            List<string> rockyPlanets = planetList.GetRange(0,4);

            // for each through planetList
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
            //for each through rockyPlanets
            foreach (string rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);
            }
            
            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>> ();

            //List Mariner 10 info
            string mariner = "Mariner 10";
            List<string> marinerDestinations = new List<string>{"Mercury"};

            Dictionary<string, List<string>> mariner10 = new Dictionary<string, List<string>>();
            mariner10.Add(mariner, marinerDestinations);

            //List Voyager 1 info
            string voyagerString = "Voyager 1";

            List<string> voyagerDestinations = new List<string> {
                "Jupiter", "Saturn"
            };

            Dictionary<string, List<string>> voyager = new Dictionary<string, List<string>> ();
            voyager.Add(voyagerString, voyagerDestinations);
            

            spacecraft.Add(mariner10);
            spacecraft.Add(voyager);

            //Need to iterate over the list DICTIONARY 
            foreach (Dictionary<string, List<string>> ship in spacecraft) {

                foreach (KeyValuePair<string, List<string>> s in ship )
                {
                // string newString = "";
                //     foreach (string planet in s.Value) {
                //         newString += planet;
                //     }
                    Console.WriteLine("{0} : {1}", s.Key, String.Join(" ", s.Value));
                }
            }
            
        }
    }

}

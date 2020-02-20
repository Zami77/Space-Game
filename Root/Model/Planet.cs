using System;
using System.Collections.Generic;
using System.Text;

//add 4 additional planets

//add new planet attributes to include
//	-distance from their suns
//	-are the planets inhabited? by??

namespace SpaceGame
{
    class Planet
    {
        private string planetName = "";
        private int distanceBetweenPlanets = 0, 
                    distanceFromSun = 100,
                    planetPopulation = 0;

        private List<string> listOfInhabitantsRaces = new List<string>(); //List that stores the different races.



        //Shops was listed in the outline. Need to know if in the context of quantity, or just shop name.

        public string PlanetName //Property that gets and sets the value for the string planetName.
        {
            get { return planetName; }
            set { planetName = value; }
        }

    }
}

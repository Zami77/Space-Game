using System;

namespace SpaceGame
{
    //To do: create a story for each race, and winning requirements for each race.
    //To do: create (3) different races
    public class Character
    {
        private int age = 18, race = 0, currency = 0;
        private string charName = "", 
                       humanGoals = "";
        //test comment by Wei

        public Character()
        {
            age = 18;
            race = 1;
            currency = 15;
            charName = "Jimbo";
        }

        public Character(string cName, int raceNum)
        {
            age = 18;
            race = raceNum;
            charName = cName;
            currency = 15;

        }
        public string GetGoal()
        {
            return humanGoals;
        }
        public string GetName()
        {
            return charName;
        }
        public int GetCurrency()
        {
            return currency;
        }
        public void AddCurrency(int numToAdd)
        {
            currency += numToAdd;
        }
        public void SubtractCurrency(int numToSubtract)
        {
            currency -= numToSubtract;
        }
    }
}
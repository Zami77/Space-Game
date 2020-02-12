﻿using System;

namespace SpaceGame
{
    
    public class Character
    {
        int age = 18, race = 0, currency = 0;
        string charName = "", 
               humanGoals = "";

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
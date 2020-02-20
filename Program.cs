using System;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Space Game!");

            Character playerCharacter = new Character("Luis", 3);
            Character defaultCharacter = new Character();

            Console.WriteLine($"Name:{playerCharacter.GetName()}");
            Console.WriteLine($"Default Char Name:{defaultCharacter.GetName()}");

            Console.WriteLine($"Current Currency:{playerCharacter.GetCurrency()}");
            playerCharacter.AddCurrency(15);
            Console.WriteLine($"Current Currency:{playerCharacter.GetCurrency()}");
            playerCharacter.SubtractCurrency(7);
            Console.WriteLine($"Current Currency:{playerCharacter.GetCurrency()}");

            //Test Comment

        }
        public class Character
        {
            int age = 18, race = 0, currency = 0;
            string charName = "";
            public Character()
            {
                age = 18;
                race = 1;
                currency = 15;
                charName = "Jimbo";
            }

            public Character (string cName, int raceNum)
            {
                age = 18;
                race = raceNum;
                charName = cName;
                currency = 15;
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
}

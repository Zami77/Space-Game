using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    public class Ship
    {
        //Fields
        string shipName = "";
        int shipSpeed = 500,
            shipGasUsageRate = 20,
            shipGasCapacity = 1000,
            shipCurrentGas = 300,
            shipHealth = 1000,
            shipAttack = 200;

        public int GetCurrentGas() //Gets the remaining gas in the tank.
        {


            return shipCurrentGas;
        }
        public int GetHealth() // Gets the current health points of the ship
        {
            return shipHealth;
        }
        
        public int AddOrSubtractHealth() // Method calculates the damage taken.
        {
            var damageTaken = 0;
            return damageTaken;
        }

        //To Do - GetAttack Method

        //To Do - Add/Subtract Gas

        //To Do - Travel

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Player
    {
        //Constants
        private const int MAX_HEALTH = 7;
        private const int MAX_SHIPHEALTH = 6;
        private const int MAX_FUEL = 7;
        private const int MAX_ITEMS = 6;


        private int health = MAX_HEALTH;
        private int shipHealth = MAX_SHIPHEALTH;
        private int money = 0;
        private int fuel = MAX_FUEL;
        //Item[] inventory = new Item[MAX_ITEMS]

        //Negative change is damage, positive change is healing.
        public void UpdateHealth(int change)
        {
            health = health + change;

            //Check max/min
            if (health < 0) health = 0;
            if (health > MAX_HEALTH) health = MAX_HEALTH;
        }
        public void UpdateShipHealth(int change)
        {
            shipHealth = shipHealth + change;

            //Check max/min
            if (shipHealth < 0) shipHealth = 0;
            if (shipHealth > MAX_SHIPHEALTH) shipHealth = MAX_SHIPHEALTH;
        }
        public void UpdateFuel(int change)
        {
            fuel = fuel + change;

            //Check max/min
            if (fuel < 0) fuel = 0;
            if (fuel > MAX_FUEL) fuel = MAX_FUEL;
        }
        public void UpdateMoney(int change)
        {
            money = money + change;
        }
    }
}

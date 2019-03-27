using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    public class Player
    {
        //Constants
        private const int MAX_HEALTH = 7;
        private const int MAX_SHIPHEALTH = 6;
        private const int MAX_FUEL = 7;
        private const int MAX_ITEMS = 6;
       
        private int health = MAX_HEALTH; //temporary change to public to demonstrate the refrences
        private int shipHealth = MAX_SHIPHEALTH;
        private int money = 0;
        private int fuel = MAX_FUEL;
        //Item[] inventory = new Item[MAX_ITEMS]

        //Properties
        public int Health
        {
            get{return health;}
            set{
                //Use += for incremental differences
                health = value;
                //Check max/min
                if (health < 0) health = 0;
                if (health > MAX_HEALTH) health = MAX_HEALTH;
            }
        }
        public int ShipHealth
        {
            get { return shipHealth; }
            set
            {
                //Use += for incremental differences
                shipHealth = value;
                //Check max/min
                if (shipHealth < 0) shipHealth = 0;
                if (shipHealth > MAX_SHIPHEALTH) shipHealth = MAX_SHIPHEALTH;
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                //Use += for incremental differences
                fuel = value;
                //Check max/min
                if(fuel < 0) fuel = 0;
                if (fuel > MAX_FUEL) fuel = MAX_FUEL;
            }
        }
        public int Money { get { return money; }
            set
            {
                if (value >= 0)
                {
                    money = value;
                }
                //Else do nothing
            }
        }
        public int Distance { get; set; }
        public bool IsOnShip { get; set; }
        public bool HasMadeChoice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Scenario
    {
        //Private fields
        private string description, location;
        private int type = 1;
        private Entity entity;
        private Random rnd = new Random();

        //Button Text, Post-Click text, health effect, shipHealth effect, fuel effect, money effect. (Maybe also a post-click picture?)
        private object[] optionOne = new object[6];
        private object[] optionTwo = new object[6];
        private object[] optionThree = new object[6];


        //Pieces of randomization (Each will be made longer and more descriptive).
        private string[] locations = new string[]
        {
            //You are..
            "in the swamps of Rodia",
            "exploring the deserts of Tatooine"
        };
        private string[] descriptions = new string[]
        {
            //when..
            "you notice a ship on your scanner quickly approching you. Further scans indicate",
            "a figure startles you from behind,"
        };
        private Entity[] entities = new Entity[]
        {
            //it's a
            //Name, Race, Level, Merchant Level, alwaysEnemy (optional), alwaysMerchant (optional)
            new Entity("Kludge Scout", "Kludge", 5, 0, true),
            new Entity("Merchant Droid", "Droid", 0, 6),
        };
        private Image[] images = new Image[]
        {

        };


        //Getters
        public string GetDescription()
        {
            return description;
        }
        public string GetLocation()
        {
            return location;
        }
        public Entity GetEntity()
        {
            return entity;
        }
        public int GetScenarioType()
        {
            return type;
        }

        //You should be able to make this into a regular multidimensional array [3,6] instead of jagged, can't get it working though.
        public object[][] GetOptions()
        {
            //object[,] optionArray = new object[,] ;

            return new object[][]
            {
                optionOne, optionTwo, optionThree
            };
        }


        //Random Scenario Generation
        public virtual void GenerateScenario()
        {

            //Get location, description, entity, and later .
            location = locations[rnd.Next(0, locations.Length)];
            description = descriptions[rnd.Next(0, descriptions.Length)];
            entity = entities[rnd.Next(0, entities.Length)];

            // Type randomization
            //If the entity is a enemy, type = 1, if entity is a merchant, type = 2. If entity can be either, type is random.
            if (entity.GetEnemy())
            {
                type = 1;
            }
            else if (entity.GetMerchant()){
                type = 2;
            }
            else
            {
                type = rnd.Next(1, 3);
            }

            //Format description
            description = "You are " + location + " when " + description + " it's a " + entity.GetName() + ", " + (type == 1 ? "prepare for combat!" : "you approach the merchant.");

            //Options
            //Each option will be made longer and more descriptive.
            //Enemy
            if (type == 1) {
                //Button Text, Post-Click text, health effect, shipHealth effect, fuel effect, money effect.
                optionOne[0] = "Fight";
                optionTwo[0] = "Something else";
                optionThree[0] = "Run";
            }
            //Merchant
            else if (type == 2)
            {
                //Button Text, Post-Click text, health effect, shipHealth effect, fuel effect, money effect.
                optionOne[0] = "Browse Items";
                optionTwo[0] = "Something else";
                optionThree[0] = "Leave";
            }

        }
    }
}

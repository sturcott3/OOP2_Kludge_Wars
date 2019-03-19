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
        private const int MAX_OPTIONS = 5;
        private string description, location;
        private int type = 1;
        private Entity entity;
        private Random rnd = new Random();
        private Bitmap image;

        private string[] buttonTexts = new string[MAX_OPTIONS];
        private string[] postButtonTexts = new string[MAX_OPTIONS];
        private int[] healthEffects = new int[MAX_OPTIONS];
        private int[] shipHealthEffects = new int[MAX_OPTIONS];
        private int[] fuelEffects = new int[MAX_OPTIONS];
        private int[] moneyEffects = new int[MAX_OPTIONS];

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
        private Bitmap[] images = new Bitmap[]
        {
            new Bitmap(Properties.Resources.city_1),
            new Bitmap(Properties.Resources.city_2),
            new Bitmap(Properties.Resources.city_3),
            new Bitmap(Properties.Resources.city_4),
            new Bitmap(Properties.Resources.city_5),
            new Bitmap(Properties.Resources.forest_1),
            new Bitmap(Properties.Resources.forest_2),
            new Bitmap(Properties.Resources.forest_3),
            new Bitmap(Properties.Resources.forest_4),
            new Bitmap(Properties.Resources.nebula_1),
            new Bitmap(Properties.Resources.nebula_2),
            new Bitmap(Properties.Resources.nebula_3),
            new Bitmap(Properties.Resources.planet_1),
            new Bitmap(Properties.Resources.planet_2),
            new Bitmap(Properties.Resources.space_1),
            new Bitmap(Properties.Resources.space_2),
            new Bitmap(Properties.Resources.space_3),
            new Bitmap(Properties.Resources.space_4),
            new Bitmap(Properties.Resources.space_5)
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
        public Bitmap GetImage()
        {
            return image;
        }

        //Value relates to these below, option is which option/button
        //Button Text, post button text, health effects, ship health effect, fuel effect, money effect
        public object GetOption(int option, int value)
        {
            option--; //This is done so you enter 1 for option one, instead of 0
            switch (value)
            {
                case 1:
                    return buttonTexts[option];
                case 2:
                    return postButtonTexts[option];
                case 3:
                    return healthEffects[option];
                case 4:
                    return shipHealthEffects[option];
                case 5:
                    return fuelEffects[option];
                case 6:
                    return moneyEffects[option];
                default:
                    return 0;
            }
        }


        //Random Scenario Generation
        public virtual void GenerateScenario()
        {

            //Get location, description, entity, and later .
            location = locations[rnd.Next(0, locations.Length)];
            description = descriptions[rnd.Next(0, descriptions.Length)];
            entity = entities[rnd.Next(0, entities.Length)];
            image = images[rnd.Next(0, images.Length)];

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
                buttonTexts[0] = "Fight";
                buttonTexts[1] = "Something else";
                buttonTexts[2] = "Run";
            }
            //Merchant
            else if (type == 2)
            {
                //Button Text, Post-Click text, health effect, shipHealth effect, fuel effect, money effect.
                buttonTexts[0] = "Browse Items";
                buttonTexts[1] = "Something else";
                buttonTexts[2] = "Leave";
            }

        }
    }
}

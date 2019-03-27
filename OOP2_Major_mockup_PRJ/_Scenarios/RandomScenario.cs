﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class RandomScenario : Scenario 
    {
        public int Type { get; private set; } = 0;
        Entity Entity { get; set; }

        //Randomization still occurs here and in ScenarioController. 
        //The pieces for randomization are now contained in the Data class. 
        //They are directly accessible from anywhere (both scenario types),
        //but are read-only (safe, but only one place to update with story/enemy/NPC/location content)

        public override Option[] GetOptions(int[] index, int sceneTracker)
        {//randomizes the order of the button layout
            for (int i = 0; i < Data.MAX_OPTIONS; i++)
            {
                CurrentOptions[i] = new Option(sceneTracker, index[i], false);
            }
            return CurrentOptions;
        }

        //Random version of Scenario Generation is intended to be polymorphic against ScriptedScenario
        public override void GenerateScenario(int seed)
        {   //Seed 1 - City, 2 - Forest, 3 - Space
            LocationType = seed;

            int endIndex;
            bool onFoot = true;
            switch (seed)
            {
                case 1:
                    seed = Data.CITY_INDEX;
                    endIndex = Data.FOREST_INDEX;
                    break;
                case 2:
                    seed = Data.FOREST_INDEX;
                    endIndex = Data.SPACE_INDEX;
                    break;
                case 3:
                    seed = Data.SPACE_INDEX;
                    endIndex = Data.Locations.Length;
                    onFoot = false;
                    break;
                default:
                    //Default will give you a city or throw exception?
                    seed = Data.CITY_INDEX;
                    endIndex = Data.FOREST_INDEX;
                    break;
            }

            //Get random location, description, entity, and image
            Location = Data.Locations[Data.Rand.Next(seed, endIndex)];
            Image = Data.Images[Data.Rand.Next(seed, endIndex)];

            //Get on-foot, or on-ship
            if (onFoot)
            {
                Entity = Data.Entities[Data.Rand.Next(Data.ON_FOOT_INDEX, Data.ON_SHIP_INDEX)];
                Description = Data.Descriptions[Data.Rand.Next(Data.ON_FOOT_INDEX, Data.ON_SHIP_INDEX)];
            }
            else
            {
                Entity = Data.Entities[Data.Rand.Next(Data.ON_SHIP_INDEX, Data.Descriptions.Length)];
                Description = Data.Descriptions[Data.Rand.Next(Data.ON_SHIP_INDEX, Data.Descriptions.Length)];
            }

            // Type randomization
            //If the entity is a enemy, type = 1, if entity is a merchant, type = 2. If entity can be either, type is random.
            if (Entity.GetEnemy())
            {
                Type = 1;
            }
            else if (Entity.GetMerchant()){
                Type = 2;
            }
            else
            {
                Type = Data.Rand.Next(1, 3);//can use this to expand to more random encounter types later
            }

            //Format description ... could build a logic tree around this to give more flixibility,
            //would likely be part of the planetside/space/station tracking and binding to images
            Description = "You are " + Location + " when " + Description + " it's a " + Entity.GetName() + ", " + (Type == 1 ? "prepare for combat!" : "you approach the merchant.");
        }
    }
}

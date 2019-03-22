using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class RandomScenario : Scenario 
    {
        //Private fields, not shared with ScriptedScenario
        private int type = 0; 
        Entity Entity { get; set; }

        //Randomization still occurs here and in ScenarioController. 
        //The pieces for randomization are now contained in the Data class. 
        //They are directly accessible from anywhere (both scenario types),
        //but are read-only (safe, but only one place to update with story/enemy/NPC/location content)

        public override Option[] GetOptions(int[] index)
        {//randomizes the order of the button layout
            for (int i = 0; i < Data.MAX_OPTIONS; i++)
            {
                CurrentOptions[i] = new Option(type, index[i]);
            }
            return CurrentOptions;
        }

        //Random version of Scenario Generation is intended to be polymorphic against ScriptedScenario
        public override void GenerateScenario(int seed)
        {   //here seed arg is intended to be used to keep track of planetside/space/station (TODO)

            //Get random location, description, entity, and image
            Location = Data.Locations[Data.Rand.Next(0, Data.Locations.Length)];
            Description = Data.Descriptions[Data.Rand.Next(0, Data.Descriptions.Length)];
            Entity = Data.Entities[Data.Rand.Next(0, Data.Entities.Length)];
            Image = Data.Images[Data.Rand.Next(0, Data.Images.Length)];

            // Type randomization
            //If the entity is a enemy, type = 1, if entity is a merchant, type = 2. If entity can be either, type is random.
            if (Entity.GetEnemy())
            {
                type = 1;
            }
            else if (Entity.GetMerchant()){
                type = 2;
            }
            else
            {
                type = Data.Rand.Next(1, 3);//can use this to expand to more random encounter types later
            }

            //Format description ... could build a logic tree around this to give more flixibility,
            //would likely be part of the planetside/space/station tracking and binding to images
            Description = "You are " + Location + " when " + Description + " it's a " + Entity.GetName() + ", " + (type == 1 ? "prepare for combat!" : "you approach the merchant.");
        }
    }
}

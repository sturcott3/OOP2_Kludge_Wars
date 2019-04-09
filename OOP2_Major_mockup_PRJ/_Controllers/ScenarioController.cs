using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_Major_mockup_PRJ
{
    class ScenarioController
    {
        public Option[] CurrentOptions { get; set; }

        public RandomScenario RandScene { get; } = new RandomScenario();

        public ScriptedScenario ScriptScene { get; set; } = new ScriptedScenario();

        private int[] index  = { 0,1,2,3,4};

        //to keep track of game flow between the two scenario types
        public int StoryCounter { get; set; }

        public int LocationType {
            get
            {
                return (isScripted) ? ScriptScene.LocationType : RandScene.LocationType;
            }
        }

        public Bitmap ScenarioImage
        {
            get
            {
                return (isScripted) ? ScriptScene.Image : RandScene.Image;
            }
        }

        private bool isScripted = false;


        public void StartScenario(bool Scripted = false)
        {//called from Game to progress the game state, episode control/random scene type control is done here

            if ((Scripted) && (StoryCounter <= Data.MAX_EPISODE))
            {
                ScriptScene.GenerateScenario(StoryCounter);
                CurrentOptions = ScriptScene.GetOptions(index, StoryCounter,ScriptScene.LocationType);
                StoryCounter += 1; //keeps track of which story mission we are on
            }
            else
            {
                //1 - City, 2 - Forest, 3 - Space
                RandScene.GenerateScenario(Data.Rand.Next(1,4));
                CurrentOptions = RandScene.GetOptions(index, RandScene.Type,RandScene.LocationType);
            }
            this.isScripted = Scripted;
        }
        
    }
}

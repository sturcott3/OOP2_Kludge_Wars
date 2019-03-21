using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_Major_mockup_PRJ
{
    class ScenarioController:Controller
    {
        Random rand = new Random();

        public RandomScenario RandScene { get; } = new RandomScenario();

        public ScriptedScenario ScriptScene { get; set; } = new ScriptedScenario();

        //to keep track of game flow between the two scenario types
        private bool isScripted = false;

       
        public void StartScenario(bool isScripted)
        {//called from Game to progress the game state, episode control/random scene type control is done here
            if ((isScripted) && (ScriptScene.StoryCounter <= Data.MAX_EPISODE))
            {
                ScriptScene.GenerateScenario(ScriptScene.StoryCounter);
                ScriptScene.StoryCounter += 1; //keeps track of which story mission we are on
                this.isScripted = isScripted;
            }
            else
            {
                RandScene.GenerateScenario(rand.Next(1,2));
                this.isScripted = isScripted;
            }
        }

        public int[] RandomUniques(int numberOfValues)
        {//returns a set of randomly ordered sequential values, up to and including the arg
            //wrote it to prevent having the same option appear in multiple buttons,
            //but can be used to reorder the scripted scenarios each playthrough

            //the thing to return, in collection form
            List<int> values = new List<int>(numberOfValues);

            //the values to be reordered
            List<int> possibleValues = new List<int>(numberOfValues);

            for (int i = 0; i <= numberOfValues - 1; i++) { possibleValues.Add(i); }
            for (int i = 0; i <= numberOfValues - 1; i++)
            {
                int index = rand.Next(0, possibleValues.Count);
                values.Add(possibleValues[index]);
                possibleValues.RemoveAt(index);
            }
            int[] returnValues = values.ToArray();
            return returnValues; 
        }

        public Bitmap GetScenarioImage()
        {
            if (isScripted) { return ScriptScene.Image; }
            else { return RandScene.Image; }
        }

        //add methods and property to determine encounter level?
    }
}

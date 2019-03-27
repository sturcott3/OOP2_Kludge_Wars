using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace OOP2_Major_mockup_PRJ
{
    class ScriptedScenario: Scenario
    {
        public override void GenerateScenario(int sceneTracker)
        {//here seed is used to track which episode we are on
            Description = Data.CampaignDescriptions[sceneTracker];
            Image = Data.CampaignImages[sceneTracker];
            LocationType = Data.CampaignLocationType[sceneTracker];
        }

    public override Option[] GetOptions(int[] buttons, int sceneTracker)
        {//randomizes the order of the button layout
            for (int i = 0; i < Data.MAX_OPTIONS; i++)
            {
                CurrentOptions[i] = new Option(sceneTracker, buttons[i], true);
            }
            return CurrentOptions;
        }
    }
}

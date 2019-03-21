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
        public int StoryCounter { get; set; }


        public override void GenerateScenario(int seed)
        {//here seed is used to track which episode we are on

            this.Description = Data.CampaignDescriptions[seed];
            this.Image = Data.CampaignImages[seed];

        }
    }
}

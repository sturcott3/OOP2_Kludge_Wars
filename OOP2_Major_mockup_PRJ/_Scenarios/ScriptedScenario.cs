﻿using System;
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
            Description = Data.CampaignDescriptions[seed];
            Image = Data.CampaignImages[seed];
        }

        public override Option[] GetOptions(int[] index)
        {//index controls the order the options will be displayed only (from the RandomUnique function)
         //letter keeps the results unique, and enforces use of the overloaded constructor


            for (int i = 0; i < Data.MAX_OPTIONS; i++)
            {
                switch (index[i])
                {
                    case 0:
                        CurrentOptions[index[i]] = new Option(0, index[i], true);
                        break;
                    case 1:
                        CurrentOptions[index[i]] = new Option(1, index[i], true);
                        break;
                    case 2:
                        CurrentOptions[index[i]] = new Option(2, index[i], true);
                        break;
                    case 3:
                        CurrentOptions[index[i]] = new Option(3, index[i], true);
                        break;
                    case 4:
                        CurrentOptions[index[i]] = new Option( 4, index[i] , true);
                        break;

                }
                
            }
            return CurrentOptions;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class ScriptedScenario:Scenario
    {
        //We might need to put the arrays of random pieces in a separate class so this class doesn't inherit all that data for nothing.
        //I agree that scripted scenario shouldnt inherit all the data from random scenario. 
        //either we can make a 'Data' class of some sort, or just eliminate the inheritance relationship?

        //Scripted Scenario Generation
        public override void GenerateScenario()
        {
            //Fill fields
        }
    }
}

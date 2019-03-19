using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OOP2_Major_mockup_PRJ
{
    class ScriptedScenario:Scenario
    {
        //We might need to put the arrays of random pieces in a separate class so this class doesn't inherit all that data for nothing.
        //I agree that scripted scenario shouldnt inherit all the data from random scenario. 
        //we should either just make our scripted scenarios have all the same data members, 
        //or eliminate the inheritance relationship altogether.

        //Scripted Scenario Generation
        public override void GenerateScenario()
        {

            //readFile()?;

            //Fill fields
        }
    }
}

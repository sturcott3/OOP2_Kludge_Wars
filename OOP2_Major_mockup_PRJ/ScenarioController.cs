using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class ScenarioController:Controller
    {
        private Scenario scenario = new Scenario();

        public string StartScenario()
        {
            //TEMPORARY string return
            //Later on it will call an output controller method
            scenario.GenerateScenario();

            return scenario.GetDescription();
        }

        //TEMP button text
        public string GetOptionText(int option)
        {
            return scenario.GetOption(option, 1);
        }


        
    }
}

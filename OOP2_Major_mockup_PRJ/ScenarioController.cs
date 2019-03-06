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

        //TEMPORARY will be handled in output controller.
        public object[][] RetrieveOptions()
        {
            //For three options, the output controller should also hide the other two buttons, and the scrollbar.
            return scenario.GetOptions();
        }
    }
}

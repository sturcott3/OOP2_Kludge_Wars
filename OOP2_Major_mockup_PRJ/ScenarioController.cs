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
            //For three options, the output controller should also hide the other two buttons, (possibly?//and the scrollbar).
            return scenario.GetOptions();
        }


        //Another possible option instead of casting
        //Dynamic returns whatever type defined at runtime
        public dynamic RetrieveOption(int row, int col)
        {
            return scenario.GetOptions()[row][col];
        }
    }
}

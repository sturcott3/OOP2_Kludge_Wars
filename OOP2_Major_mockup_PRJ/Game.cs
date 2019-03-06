using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Major_mockup_PRJ
{
    public partial class Game : Form
    {
         /*_-_-_-_SYSTEM CODE NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        public Game()
        {
            InitializeComponent();
        }
        /*_-_-_-_-_-_-_-END NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/



        /*_-_-_-_-_-_-_TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        private void btnDebug_Click(object sender, EventArgs e)
        {
            //TEMPORARY, will be done in outputcontroller
            lblOutput.Text = scenarioController.StartScenario();

            //Need to cast because c# doesn't know what type each object is
            //OptionOne (0), OptionTwo (1), OptionThree (2)
            //Button Text (0), Post-Click text (1), health effect (2), shipHealth effect (3), fuel effect (4), money effect (5).

            //I think we can resolve this issue by defining class Option and overriding .ToString()..... 
            object[][] options = scenarioController.RetrieveOptions();
            btnOptionOne.Text = (string)options[0][0];
            btnOptionTwo.Text = (string)options[1][0];
            btnOptionThree.Text = (string)options[2][0];

            //^^^ ALL TEMPORARY
        }
        /*_-_-_-_-_-_-_-END TESTER_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

        // InputController input = new InputController();
        // OutputController output = new OutputController();
        ScenarioController scenarioController = new ScenarioController();
        

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(1);
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(2);
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(3);
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(4);
        }

        private void btnOptionFive_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(5);
        }
    }
}

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

            btnOptionOne.Text = scenarioController.GetOptionText(1);
            btnOptionTwo.Text = scenarioController.GetOptionText(2);
            btnOptionThree.Text = scenarioController.GetOptionText(3);

            //temp to show how to reference images and see how they look on the form
            Image[] viewscreens = { OOP2_Major_mockup_PRJ.Properties.Resources.city_1,
                                    OOP2_Major_mockup_PRJ.Properties.Resources.city_2,
            OOP2_Major_mockup_PRJ.Properties.Resources.city_3,
            OOP2_Major_mockup_PRJ.Properties.Resources.forest_2,
            OOP2_Major_mockup_PRJ.Properties.Resources.space_4,
            OOP2_Major_mockup_PRJ.Properties.Resources.game_over_space_jpg,};

            Random r = new Random();
            pbxViewScreen.Image = viewscreens[r.Next(0,6)];
            //End image temp block
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
            //input.MakeChoice(4)
        }

        private void btnOptionFive_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(5);
        }
    }
}

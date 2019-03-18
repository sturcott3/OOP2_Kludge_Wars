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

            //Other option instead of casting (Uses dynamic return type)
            btnOptionThree.Text = scenarioController.RetrieveOption(2, 0);

            //******************************
            //Probably the best option below

            //Another option instead of overcomplicating it would be to just use parallel arrays instead of a 
            //multi -dimensional array. Then we can use functions to set them. It will work the same way but 
            //be much more simple. NOTE: group members spoke and agreed to do this version.

            //^^^ ALL TEMPORARY

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

        //<temp>
        Option optionsTest4 = new Option("Combat", "Fight", "Ouch!, you took 3 damage", -3, 0, 0, 0);
        Option optionsTest5 = new Option("Combat", "Run", "Got away, but took 1 damage", -1, 0, 0, 0);
        //</temp>


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

        //in this way, we get the bridge between inputController and outputController, and more expandable robust objects
            //updateHUD(optionsTest4.getHealthEffect(),optionsTest4.getRepairEffect(),optionsTest4.getFuelEffect(),optionsTest4.getCreditEffect())
            btnOptionFour.Text = optionsTest4.getPostClickText();
        }

        private void btnOptionFive_Click(object sender, EventArgs e)
        {
            //input.MakeChoice(5);
        }
    }
}

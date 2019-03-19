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
            player = new Player();
            scenarioController = new ScenarioController();
            output = new OutputController();
            input = new InputController();

            //Set References
            output.UpdateReference(ref player);
        }
        /*_-_-_-_-_-_-_-END NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

        Player player;
        InputController input;
        OutputController output;
        ScenarioController scenarioController; 

        /*_-_-_-_-_-_-_TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        private void btnDebug_Click(object sender, EventArgs e)
        {
            //TEMPORARY, will be done in outputcontroller
            lblOutput.Text = scenarioController.StartScenario();

            btnOptionOne.Text = scenarioController.GetOptionText(1);
            btnOptionTwo.Text = scenarioController.GetOptionText(2);
            btnOptionThree.Text = scenarioController.GetOptionText(3);

            // test call to the version of the function in outputController
            lblHealth.Text = output.updateHealth(-4) ; 

        }
        /*_-_-_-_-_-_-_-END TESTER_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            //Input Testing
            MessageBox.Show(input.GetInput("Enter Name", "Enter Your Name", 1), "Output");
            input.MakeChoice(1);
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            //Testing output player reference
            player.UpdateHealth(-2);

            MessageBox.Show("Player Object Health: " + player.GetHealth() + "\nOutput Controller Player Reference Health: " + output.TestReference());
            input.MakeChoice(2);
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            input.MakeChoice(3);
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            input.MakeChoice(4);
        }

        private void btnOptionFive_Click(object sender, EventArgs e)
        {
            input.MakeChoice(5);
        }
    }
}

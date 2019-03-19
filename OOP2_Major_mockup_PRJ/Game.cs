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
            output = new OutputController(ref player);
            input = new InputController();

        }
        /*_-_-_-_-_-_-_-END NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

        Player player;
        InputController input;
        OutputController output;
        ScenarioController scenarioController;
        private int distance = 0;

        /*_-_-_-_-_-_-_TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        private void btnDebug_Click(object sender, EventArgs e)
        {
            //TEMPORARY, will be done in outputcontroller
            lblOutput.Text = scenarioController.StartScenario();
            pbxViewScreen.Image = scenarioController.GetScenarioImage();

            btnOptionOne.Text = scenarioController.GetOptionText(1);
            btnOptionTwo.Text = scenarioController.GetOptionText(2);
            btnOptionThree.Text = scenarioController.GetOptionText(3);

            

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
            //Test updating HUD
            player.Money = 250;
            player.Health = 4;
            player.Fuel = 2;
            player.ShipHealth = 5;
            distance = 25;
            UpdateHUD();
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

        private void UpdateHUD()
        {
            //Update Health
            string output = string.Empty;
            for (int i = 0; i < player.Health; i++)
            {
                output += "+ ";
            }
            lblHealth.Text = output;

            //Update Ship Health
            output = string.Empty;
            for (int i = 0; i < player.ShipHealth; i++)
            {
                output += "{} ";
            }
            lblRepair.Text = output;

            //Update Fuel
            output = string.Empty;
            for (int i = 0; i < player.Fuel; i++)
            {
                output += "[] ";
            }
            lblFuel.Text = output;

            //Update Money            
            lblMoney.Text = player.Money.ToString("C0");

            //Update Distance
            lblDistance.Text = distance + " LY";
        }
    }
}

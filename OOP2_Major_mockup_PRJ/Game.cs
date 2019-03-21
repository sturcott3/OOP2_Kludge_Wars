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
        /*fields here -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        Player player;
        InputController input;
        ScenarioController scene;
        Random r = new Random();
        Option[] currentOptions;

        /*end fields -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/


        public Game() // constructor for form; use this to instantiate all objects,
                      //and use form load below to start the game loop/initialze properties 
        {
            InitializeComponent();
            player = new Player();
            scene = new ScenarioController();
            input = new InputController();
        }

        private void Game_Load(object sender, EventArgs e)
        {//form load is just before display, but after the constructor has run. Use it to initialize data 
         //for either a game in progress (TODO), or to take input for Player name etc.(TODO)

            BlankButtons();//temp to protect from exceptions during testing
            lblOutput.Text = string.Empty;
        }

        /*_-_-_-_-_-_-_TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        private void Debug_Click(object sender, EventArgs e)
        {
            
        }
        /*_-_-_-_-_-_-_-END TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/


        /*_-_-_-_-_Button Handlers_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/
        private void NextTurn_Click(object sender, EventArgs e)
        {
            //BeginTurn(1); //uncomment to run only scripted

            BeginTurn(r.Next(1,11)); //lower bound 5 to run only randoms, 
            //change lower bound to 1 to run both at 4/6 frequency

            //# passed in to BeginTurn controls the chance of the next scripted scene occuring. 
            //(once both scene types are up and running)

        }
        private void ReturnToShip_Click(object sender, EventArgs e)
        {

        }

        private void OptionOne_Click(object sender, EventArgs e)
        {

            UpdatePlayer(0);
            UpdateHUD();
            lblOutput.Text = currentOptions[0].ResultDescription + currentOptions[0].PostClickText;
            BlankButtons();
        }

        private void OptionTwo_Click(object sender, EventArgs e)
        {
            UpdatePlayer(1);
            UpdateHUD();
            lblOutput.Text = currentOptions[1].ResultDescription + currentOptions[1].PostClickText;
            BlankButtons();
        }

        private void OptionThree_Click(object sender, EventArgs e)
        {
            UpdatePlayer(2);
            UpdateHUD();
            lblOutput.Text = currentOptions[2].ResultDescription + currentOptions[2].PostClickText;
            BlankButtons();
        }

        private void OptionFour_Click(object sender, EventArgs e)
        {
            UpdatePlayer(3);
            UpdateHUD();
            lblOutput.Text = currentOptions[3].ResultDescription + currentOptions[3].PostClickText;
            BlankButtons();
        }

        private void OptionFive_Click(object sender, EventArgs e)
        {
            UpdatePlayer(4);
            UpdateHUD();
            lblOutput.Text = currentOptions[4].ResultDescription + currentOptions[4].PostClickText;
            BlankButtons(); 
        }
        /*_-_-_-_-_End Buttons_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_*/


        /*_-_-_-_-_Begin Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void BeginTurn(int sceneType)
        {//call to start a new turn

            int[] index = scene.RandomUniques(Data.MAX_OPTIONS);

            if (sceneType <= 4)
            {//40%-ish chance to run scripted here
                bool isScripted = true;
                scene.StartScenario(isScripted);
                currentOptions = scene.ScriptScene.GetOptions(index);

                lblOutput.Text = scene.ScriptScene.Description;
            }
            else
            {//or random here
                bool isScripted = false;
                scene.StartScenario(isScripted);
                currentOptions = scene.RandScene.GetOptions(index);
                lblOutput.Text = scene.RandScene.Description;
            }

            //TODO make a system that keep the image inline with Location
            //i.e. planetside/station/space

            //change the image
            pbxViewScreen.Image = scene.GetScenarioImage();

            //set the text for each button
            btnOptionOne.Text = currentOptions[0].ButtonText;
            btnOptionTwo.Text = currentOptions[1].ButtonText;
            btnOptionThree.Text = currentOptions[2].ButtonText;
            btnOptionFour.Text = currentOptions[3].ButtonText;
            btnOptionFive.Text = currentOptions[4].ButtonText;
        }
        /*_-_-_-_-_End of Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void BlankButtons()
        {//removes text and options from buttons, so that there is no chance of double ups on results
            btnOptionOne.Text = string.Empty;
            btnOptionTwo.Text = string.Empty;
            btnOptionThree.Text = string.Empty;
            btnOptionFour.Text = string.Empty;
            btnOptionFive.Text = string.Empty;
            currentOptions = Data.EmptyOptions;
            //this is temp solution to handling null everywhere / preventing repeat outcomes. 
            //Could be much more robust, but would be alot of work
        }

        private void UpdatePlayer(int index)
        {//pass the index corresponding to the button/option, and this will update the player's 
         //data according to the contents of the corresponding option object
            player.Health += currentOptions[index].PlayerHealthEffect;
            player.ShipHealth += currentOptions[index].ShipHealthEffect;
            player.Fuel += currentOptions[index].FuelEffect;
            player.Money += currentOptions[index].MoneyEffect;
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
            lblDistance.Text = player.Distance + " LY";
        }
    }
}

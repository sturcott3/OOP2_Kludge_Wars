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
        Option[] currentOptions;
        private int sceneType;

        //<temp>
        bool messageShown = false;
        //</temp>
        
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
        {//After? taking input for Player name etc.(TODO) or have it be part of the first scene?

            BeginTurn(1); //starts the first scripted scene to be the intro
        }

        /*_-_-_-_-_Button Handlers_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/
        private void NextTurn_Click(object sender, EventArgs e)
        { 
            if (player.IsOnShip) {
                //<temp>
                if ((scene.ScriptScene.StoryCounter >= Data.MAX_EPISODE) && !(messageShown))
                {//if we are out of scripted scenes, tell the player, then allow them to keep playing randoms until they die.
                    MessageBox.Show("More Episodes Coming soon. Please continue to enjoy randomly generated scenes until your character dies horribly.", "WIP");
                    sceneType = 5;
                    messageShown = true;
                }
                else if (messageShown) { sceneType = 5; }
                else { sceneType = Data.Rand.Next(1, 11); }
                //</temp>

                //the number passed to BeginTurn controls the chance of the next scripted scene occuring. 
                //hardcode to 1 to run only scripted , change to 5 to run only randoms  
                BeginTurn(sceneType);  //runs scripted scenes roughly 4 in 10

                player.Fuel -= 1;//amount of fuel per turn could be changed to random or be based on circumstances
                player.Distance += 1;
                UpdateHUD();
            }
            //Not on ship
            else
            {
                //We can make this better
                MessageBox.Show("You must be on your ship to warp.", "Can't Warp");
            }
        }

        private void Dis_Embark_Click(object sender, EventArgs e)
        {
            player.IsOnShip = !player.IsOnShip;//filps it when you click it
            if (player.IsOnShip)
            {
                lblLocation.Text = "Shipboard";
                Dis_Embark.Text = "Disembark";
            }
            else
            {
                lblLocation.Text = "Planetside";
                Dis_Embark.Text = "Board Ship";
            }
            //will need to become a check on integers if other possibilties are added eg. space stations etc.
        }

        private void OptionOne_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = currentOptions[0].ResultDescription + currentOptions[0].PostClickText;
                ChangeButtons();
                UpdateHUD(0);
            }
        }

        private void OptionTwo_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = currentOptions[1].ResultDescription + currentOptions[1].PostClickText;
                ChangeButtons();
                UpdateHUD(1);
            }
        }

        private void OptionThree_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = currentOptions[2].ResultDescription + currentOptions[2].PostClickText;
                ChangeButtons();
                UpdateHUD(2);
            }
        }

        private void OptionFour_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = currentOptions[3].ResultDescription + currentOptions[3].PostClickText;
                ChangeButtons();
                UpdateHUD(3);
            }
        }

        private void OptionFive_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = currentOptions[4].ResultDescription + currentOptions[4].PostClickText;
                ChangeButtons();
                UpdateHUD(4);
            }
        }
        /*_-_-_-_-_End Buttons_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_*/


        /*_-_-_-_-_Begin Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void BeginTurn(int sceneType)
        {//call to start a new turn

            int[] index = scene.RandomUniques(Data.MAX_OPTIONS);
            player.HasMadeChoice = false;


            //decide scenario type
            if (sceneType <= 4)
            {//40%-ish chance to run scripted here
                scene.StartScenario(true);
                currentOptions = scene.ScriptScene.GetOptions(index);
                lblOutput.Text = scene.ScriptScene.Description;
            }
            else
            {//or random here
                scene.StartScenario();
                currentOptions = scene.RandScene.GetOptions(index);
                lblOutput.Text = scene.RandScene.Description;
            }

            //TODO make a system that keep the image inline with Location
            //i.e. planetside/station/space

            //change the image
            pbxViewScreen.Image = scene.GetScenarioImage();

            //set the text for each button

            //SUGGESTION - Instead of erasing button text when its not an option, instead use Hide() so it limits button size, 
            //and eliminates scroll bar with random scenarios.
            btnOptionOne.Text = currentOptions[0].ButtonText;
            btnOptionTwo.Text = currentOptions[1].ButtonText;
            btnOptionThree.Text = currentOptions[2].ButtonText;
            btnOptionFour.Text = currentOptions[3].ButtonText;
            btnOptionFive.Text = currentOptions[4].ButtonText;
        }
        /*_-_-_-_-_End of Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void ChangeButtons()
        {//removes text and execution ability from buttons, 
            //so that there is no chance of double ups on results, and to help the user realize the passage of events

            btnOptionOne.Text = string.Empty;
            btnOptionTwo.Text = string.Empty;
            btnOptionThree.Text = string.Empty;
            btnOptionFour.Text = string.Empty;
            btnOptionFive.Text = string.Empty;
            player.HasMadeChoice = true;
        }

        private void UpdateHUD()
        {//no arg version works without applying the option objects to it
         //will become more useful later when inventory gets implemented

            //SUGGESTION - Could be simplified. Instead of a loop, start off with a string of max value, 
            //and use substring to change size. +++++++ to string.Substring(0, health - 1).

            //Update Health
            string output = string.Empty;
            for (int i = 0; i < player.Health; i++)
            {
                output += "+ ";
            }
            lblHealth.Text = output;
            if (player.Health == 0) { GameOver("health"); };
            
            //Update Ship Health
            output = string.Empty;
            for (int i = 0; i < player.ShipHealth; i++)
            {
                output += "{} ";
            }
            lblRepair.Text = output;
            if (player.ShipHealth == 0) { GameOver("ship"); }

            //Update Fuel
            output = string.Empty;
            for (int i = 0; i < player.Fuel; i++)
            {
                output += "[] ";
            }
            lblFuel.Text = output;
            if (player.Fuel == 0) { GameOver("fuel"); }

            //Update Money            
            lblMoney.Text = player.Money.ToString("C0");

            //Update Distance
            lblDistance.Text = player.Distance + " LY";
        }
        private void UpdateHUD(int button)
        {//arg version keeps results corresponding to the button/option, 
         //and will update the player's 
         //data according to the contents of the corresponding option object

            //Update Health
            player.Health += currentOptions[button].PlayerHealthEffect;
            string output = string.Empty;
            for (int i = 0; i < player.Health; i++)
            {
                output += "+ ";
            }
            lblHealth.Text = output;
            if (player.Health == 0) { GameOver("health"); };

            //Update Ship Health
            player.ShipHealth += currentOptions[button].ShipHealthEffect;
            output = string.Empty;
            for (int i = 0; i < player.ShipHealth; i++)
            {
                output += "{} ";
            }
            lblRepair.Text = output;
            if (player.ShipHealth == 0) { GameOver("ship"); }

            //Update Fuel
            player.Fuel += currentOptions[button].FuelEffect;
            output = string.Empty;
            for (int i = 0; i < player.Fuel; i++)
            {
                output += "[] ";
            }
            lblFuel.Text = output;
            if (player.Fuel == 0) { GameOver("fuel"); }

            //Update Money
            player.Money += currentOptions[button].MoneyEffect;
            lblMoney.Text = player.Money.ToString("C0");

            //Update Distance
            lblDistance.Text = player.Distance + " LY";
        }

        private void GameOver(string reason)
        {
            if (reason == "health")
            {
                pbxViewScreen.Image = Properties.Resources.game_over_planetside;
                lblOutput.Text = Data.DeathReasons[0];
            }
            else if (reason == "ship")
            {
                pbxViewScreen.Image = Properties.Resources.game_over_space_jpg;
                lblOutput.Text = Data.DeathReasons[1];
            }
            else if (reason == "fuel")
            {
                pbxViewScreen.Image = Properties.Resources.game_over_space_jpg;
                lblOutput.Text = Data.DeathReasons[2];
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //Not implemented yet.
            MessageBox.Show("Menu not implemented.", "WIP");
        }
    }
}

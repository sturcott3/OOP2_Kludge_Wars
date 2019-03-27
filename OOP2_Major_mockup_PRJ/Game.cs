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
        {
            //Picture TEMP and could be reworked to pop up at a different time (After introduction?)
            //Temporarily set to input type 5, so you can type whatever for now
            string[] playerInfo = input.GetInput("Player Information", "Enter Your Name", "Enter Ship Name", "Start Game", 5, 3);
            Data.PlayerName = playerInfo[0];
            Data.ShipName = playerInfo[1];

            BeginTurn(1); //starts the first scripted scene to be the intro


            //Just for testing purposes, later on Option and Data can be modified to include adding items
            player.Inventory[0] = Data.Items[0];
            player.Inventory[1] = Data.Items[1];
            player.Inventory[2] = Data.Items[2];
            UpdateHUD();
        }

        /*_-_-_-_-_Button Handlers_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/
        private void NextTurn_Click(object sender, EventArgs e)
        { 
            if (player.IsOnShip) {
                //<temp>
                if ((scene.StoryCounter >= Data.MAX_EPISODE) && !(messageShown))
                {//if we are out of scripted scenes, tell the player, then allow them to keep playing randoms until they die.
                    ShowWarning("More Episodes Coming soon. Please continue to enjoy randomly generated scenes until your character dies horribly.", 2.5);
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
                ShowWarning("Unable to warp, you must be on your ship.", 2.5);

            }
        }

        private void Dis_Embark_Click(object sender, EventArgs e)
        {
            player.IsOnShip = !player.IsOnShip;
            UpdateHUD();
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

            int[] index = { 0, 1, 2, 3, 4 };
            player.HasMadeChoice = false;


            //decide scenario type
            if (sceneType <= 4)
            {//40%-ish chance to run scripted here
                scene.StartScenario(true);
                currentOptions = scene.ScriptScene.GetOptions(index,scene.StoryCounter);
                lblOutput.Text = scene.ScriptScene.Description;
            }
            else
            {//or random here
                scene.StartScenario();
                currentOptions = scene.RandScene.GetOptions(index, scene.RandScene.Type);
                lblOutput.Text = scene.RandScene.Description;
            }

            //If scene type is not in space, disembark
            if(scene.LocationType != 3) player.IsOnShip = false;

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

        private void UpdateHUD(ref Item item)
        {
            //Item version will use the item and apply it's effects
            //May need to modify if we want to prevent players from using an item if its stat is full (Using a medkit at full health)
            //0 - Health, 1 - Repair, 2 - Fuel, 3 - Money
            player.Health += item.effects[0];
            player.ShipHealth += item.effects[1];
            player.Fuel += item.effects[2];
            player.Money += item.effects[3];

            //Using the byref, will set the item in the inventory to be equal to null, updating the hud will remove that item from inventory and remove its effects
            item = null;

            UpdateHUD();
        }
        private void UpdateHUD(int button)
        {
            //int version keeps results corresponding to the button/option, 
            //and will update the player's 
            //data according to the contents of the corresponding option object

            player.Health += currentOptions[button].PlayerHealthEffect;
            player.ShipHealth += currentOptions[button].ShipHealthEffect;
            player.Fuel += currentOptions[button].FuelEffect;
            player.Money += currentOptions[button].MoneyEffect;

            UpdateHUD();
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

            //Update Inventory Icons
            btnInventory1.BackgroundImage = (player.Inventory[0] != null) ? player.Inventory[0].Icon : null;
            btnInventory2.BackgroundImage = (player.Inventory[1] != null) ? player.Inventory[1].Icon : null;
            btnInventory3.BackgroundImage = (player.Inventory[2] != null) ? player.Inventory[2].Icon : null;
            btnInventory4.BackgroundImage = (player.Inventory[3] != null) ? player.Inventory[3].Icon : null;
            btnInventory5.BackgroundImage = (player.Inventory[4] != null) ? player.Inventory[4].Icon : null;

            //Update Inventory Tooltips
            tltToolTip.SetToolTip(btnInventory1, (player.Inventory[0] != null) ? player.Inventory[0].Name + " - " + player.Inventory[0].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory2, (player.Inventory[1] != null) ? player.Inventory[1].Name + " - " + player.Inventory[1].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory3, (player.Inventory[2] != null) ? player.Inventory[2].Name + " - " + player.Inventory[2].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory4, (player.Inventory[3] != null) ? player.Inventory[3].Name + " - " + player.Inventory[3].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory5, (player.Inventory[4] != null) ? player.Inventory[4].Name + " - " + player.Inventory[4].Description : string.Empty);

            //Update location info 
            //WIP, location name is not included, but we may remove to lower complexity. (We would need to make and assign an array thats parallel to Data.Locations)
            if (player.IsOnShip)
            {
                lblShipBoard.Text = "Shipboard";
                Dis_Embark.Text = "Disembark";
            }
            else
            {
                Dis_Embark.Text = "Board Ship";
                switch (scene.LocationType)
                {
                    //1 - City, 2 - Forest, 3 - Space
                    case 1:
                        lblShipBoard.Text = "In City";
                        break;
                    case 2:
                        lblShipBoard.Text = "In Wilderness";
                        break;
                    case 3:
                        lblShipBoard.Text = "In Exosuit";
                        break;
                    default:
                        lblShipBoard.Text = "Planetside";
                        break;
                }
            }
        }

        private void GameOver(string reason)
        {
            //DISABLED death for debug purposes.

            /*
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
            */
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //Not implemented yet.
            ShowWarning("Menu not implemented.", 2.5);
        }

        //Inventory interaction
        private void btnInventory1_Click(object sender, EventArgs e)
        {
            if (player.Inventory[0] != null) UpdateHUD(ref player.Inventory[0]);
        }

        private void btnInventory2_Click(object sender, EventArgs e)
        {
            if (player.Inventory[1] != null) UpdateHUD(ref player.Inventory[1]);
        }

        private void btnInventory3_Click(object sender, EventArgs e)
        {
            if (player.Inventory[2] != null) UpdateHUD(ref player.Inventory[2]);
        }

        private void btnInventory4_Click(object sender, EventArgs e)
        {
            if (player.Inventory[3] != null) UpdateHUD(ref player.Inventory[3]);
        }

        private void btnInventory5_Click(object sender, EventArgs e)
        {
            if (player.Inventory[4] != null) UpdateHUD(ref player.Inventory[4]);
        }

        private void btnInventory6_Click(object sender, EventArgs e)
        {
            if (player.Inventory[5] != null) UpdateHUD(ref player.Inventory[5]);
        }

        public void ShowWarning(string message, double seconds)
        {
            sblWarning.Text = message;
            sblWarning.Visible = true;

            Timer t = new Timer
            {
                Interval = Convert.ToInt32(seconds * 1000)
            };

            t.Tick += (s, e) =>
            {
                sblWarning.Visible = false;
                t.Stop();
            };

            t.Start();
        }
    }
}

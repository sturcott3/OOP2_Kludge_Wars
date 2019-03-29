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
        Timer t = new Timer();
        
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

            //<temp comment out for debug>
            //Temporarily set to input type 5, so you don't have to type anything for now
            //string[] playerInfo = input.GetInput("Player Information", "Enter Your Name", "Enter Ship Name", "Start Game", 5, 3);
            //Data.PlayerName = playerInfo[0];
            //Data.ShipName = playerInfo[1];
            //</temp comment out>

            for (int i = 0; i < Data.StartingItems.Length; i++)
            {//just add or remove items to the starting items array if testing is needed
                player.Inventory.Add(Data.StartingItems[i]);
            }
            
            BeginTurn(1); //starts the first scripted scene to be the intro

            UpdateHUD();
        }

        /*_-_-_-_-_Button Handlers_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/
        private void NextTurn_Click(object sender, EventArgs e)
        { 
            if (player.IsOnShip) {          
                if ((scene.StoryCounter >= Data.MAX_EPISODE) && !(messageShown))
                {//if we are out of scripted scenes, tell the player, then allow them to keep playing randoms until they die.
                    //can remove now, or leave both. I like both, then we can cut down to just jokes and thanking the player in the script
                    ShowWarning("Story unavailable, initializing 100% procedural scenarios.", 2, Color.Salmon);
                    sceneType = 5;
                    messageShown = true;
                }
                else if (messageShown) { sceneType = 5; }
                else { sceneType = Data.Rand.Next(1, 11); }

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
                //We can make this better. added a little, could do a lot more with colours....
                ShowWarning("Unable to warp, you must be on your ship.", 2 , Color.Salmon);
            }
        }

        private void Dis_Embark_Click(object sender, EventArgs e)
        {
            if (scene.LocationType == 3) {
                ShowWarning("Can't disembark in space!", 2 ,Color.Salmon);
            }
            else
            player.IsOnShip = !player.IsOnShip;
            UpdateHUD();
        }

        private void OptionOne_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                lblOutput.Text = scene.CurrentOptions[0].ResultDescription;
                ShowWarning(scene.CurrentOptions[0].PostClickText, 2 , Color.Gold);

                if (scene.CurrentOptions[0].CombatReward != null)
                {
                    lblOutput.Text += "You found a " + scene.CurrentOptions[0].CombatReward.Name;
                    player.Inventory.Add(scene.CurrentOptions[0].CombatReward);
                }

                HideButtons(0);
                UpdateHUD(0); 
            }
        }

        private void OptionTwo_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                ShowWarning(scene.CurrentOptions[1].PostClickText, 2, Color.Gold);
                lblOutput.Text = scene.CurrentOptions[1].ResultDescription;
                if (scene.CurrentOptions[1].CombatReward != null)
                {
                    lblOutput.Text += "You found a " + scene.CurrentOptions[1].CombatReward.Name;
                    player.Inventory.Add(scene.CurrentOptions[1].CombatReward);
                }
                HideButtons(1);
                UpdateHUD(1);
            }
        }

        private void OptionThree_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                ShowWarning(scene.CurrentOptions[2].PostClickText, 2, Color.Gold);
                lblOutput.Text = scene.CurrentOptions[2].ResultDescription;
                if (scene.CurrentOptions[2].CombatReward != null)
                {
                    lblOutput.Text += "You found a " + scene.CurrentOptions[2].CombatReward.Name;
                    player.Inventory.Add(scene.CurrentOptions[2].CombatReward);
                }
                HideButtons(2);
                UpdateHUD(2);
            }
        }

        private void OptionFour_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                ShowWarning(scene.CurrentOptions[3].PostClickText, 2, Color.Gold);
                lblOutput.Text = scene.CurrentOptions[3].ResultDescription;
                if (scene.CurrentOptions[3].CombatReward != null)
                {
                    lblOutput.Text += "You found a " + scene.CurrentOptions[3].CombatReward.Name;
                    player.Inventory.Add(scene.CurrentOptions[3].CombatReward);
                }
                HideButtons(3);
                UpdateHUD(3);
            }
        }

        private void OptionFive_Click(object sender, EventArgs e)
        {
            if (!player.HasMadeChoice)
            {
                ShowWarning(scene.CurrentOptions[4].PostClickText, 2, Color.Gold);
                lblOutput.Text = scene.CurrentOptions[4].ResultDescription;
                if (scene.CurrentOptions[4].CombatReward != null)
                {
                    lblOutput.Text += "You found a " + scene.CurrentOptions[4].CombatReward.Name;
                    player.Inventory.Add(scene.CurrentOptions[4].CombatReward);
                }
                HideButtons(4);
                UpdateHUD(4);
            }
        }
        /*_-_-_-_-_End Buttons_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_*/


        /*_-_-_-_-_Begin Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void BeginTurn(int sceneType)
        {//call to start a new turn

            
            player.HasMadeChoice = false;
          
            //decide scenario type
            if (sceneType <= 4)
            {//40%-ish chance to run scripted here
                scene.StartScenario(true);
                lblOutput.Text = scene.ScriptScene.Description;
                lblPlaceName.Text = scene.ScriptScene.PlaceName;
                lblDate.Text = scene.ScriptScene.Date;
                ShowButtons(Data.ScriptedVisibilities[scene.StoryCounter]);
            }
            else
            {//or random here
                scene.StartScenario();
                lblOutput.Text = scene.RandScene.Description;
                lblPlaceName.Text = scene.RandScene.PlaceName;
                lblDate.Text = scene.RandScene.Date;
                ShowButtons(Data.Rand.Next(3, 6));
            }

            //If scene type is not in space, disembark
            if(scene.LocationType != 3) player.IsOnShip = false;

            //change the image
            pbxViewScreen.Image = scene.ScenarioImage;
            
            //set the text for each button SUGGESTION implemented
            btnOptionOne.Text = scene.CurrentOptions[0].ButtonText;
            btnOptionTwo.Text = scene.CurrentOptions[1].ButtonText;
            btnOptionThree.Text = scene.CurrentOptions[2].ButtonText;
            btnOptionFour.Text = scene.CurrentOptions[3].ButtonText;
            btnOptionFive.Text = scene.CurrentOptions[4].ButtonText;
        }
        /*_-_-_-_-_End of Game Loop_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/

        private void HideButtons(int clickedButton)
        {//Changed to control button visibility instead, as discussed
            // for choice made, hides them all and shows the correct one again.
            btnOptionOne.Hide();
            btnOptionTwo.Hide();
            btnOptionThree.Hide();
            btnOptionFour.Hide();
            btnOptionFive.Hide(); 
            //switch (clickedButton)
            //{
            //    case 0:
            //        btnOptionOne.Show();
            //        btnOptionOne.Text = currentOptions[0].PostClickText;
            //        break;
            //    case 1:
            //        btnOptionTwo.Show();
            //        btnOptionTwo.Text = currentOptions[1].PostClickText;
            //        break;
            //    case 2:
            //        btnOptionThree.Show();
            //        btnOptionThree.Text = currentOptions[2].PostClickText;
            //        break;
            //    case 3:
            //        btnOptionFour.Show();
            //        btnOptionFour.Text = currentOptions[3].PostClickText;
            //        break;
            //    case 4:
            //        btnOptionFive.Show();
            //        btnOptionFive.Text = currentOptions[4].PostClickText;
            //        break;
            //}
            player.HasMadeChoice = true;
        }

        private void ShowButtons(int numberOfButtons)
        {//shows a number of options, forces at least one
            btnOptionOne.Show();
            btnOptionTwo.Show();
            btnOptionThree.Show();
            btnOptionFour.Show();
            btnOptionFive.Show();
            switch (numberOfButtons)
            {
                case 2:
                    btnOptionThree.Hide();
                    btnOptionFour.Hide();
                    btnOptionFive.Hide();
                    break;
                case 3:
                    btnOptionFour.Hide();
                    btnOptionFive.Hide();
                    break;
                case 4:
                    btnOptionFive.Hide();
                    break;
                case 5:
                    break;
                default:
                    btnOptionTwo.Hide();
                    btnOptionThree.Hide();
                    btnOptionFour.Hide();
                    btnOptionFive.Hide();
                    break;

            }

        }

        private void UpdateHUD(Item item)
        {
            //Item version will use the item and apply it's effects
            //May need to modify if we want to prevent players from using an item if its stat is full (Using a medkit at full health)
            //0 - Health, 1 - Repair, 2 - Fuel, 3 - Money
            player.Health += item.effects[0];
            player.ShipHealth += item.effects[1];
            player.Fuel += item.effects[2];
            player.Money += item.effects[3];

            UpdateHUD();
            
        }

        private void UpdateHUD(int button)
        {
            //int version keeps results corresponding to the button/option, 
            //and will update the player's 
            //data according to the contents of the corresponding option object

            player.Health += scene.CurrentOptions[button].PlayerHealthEffect;
            player.ShipHealth += scene.CurrentOptions[button].ShipHealthEffect;
            player.Fuel += scene.CurrentOptions[button].FuelEffect;
            player.Money += scene.CurrentOptions[button].MoneyEffect;

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

            int rowIndex = (player.InventoryRow - 1) * 5;

            //Update Inventory Icons
            btnInventory1.BackgroundImage = (player.Inventory.ElementAtOrDefault(rowIndex) != null) ? player.Inventory[rowIndex].Icon : null;
            btnInventory2.BackgroundImage = (player.Inventory.ElementAtOrDefault(rowIndex + 1) != null) ? player.Inventory[rowIndex + 1].Icon : null;
            btnInventory3.BackgroundImage = (player.Inventory.ElementAtOrDefault(rowIndex + 2) != null) ? player.Inventory[rowIndex + 2].Icon : null;
            btnInventory4.BackgroundImage = (player.Inventory.ElementAtOrDefault(rowIndex + 3) != null) ? player.Inventory[rowIndex + 3].Icon : null;
            btnInventory5.BackgroundImage = (player.Inventory.ElementAtOrDefault(rowIndex + 4) != null) ? player.Inventory[rowIndex + 4].Icon : null;

            //Update Inventory Tooltips
            tltToolTip.SetToolTip(btnInventory1, (player.Inventory.ElementAtOrDefault(rowIndex) != null) ? player.Inventory[rowIndex].Name + " - " + player.Inventory[rowIndex].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory2, (player.Inventory.ElementAtOrDefault(rowIndex + 1) != null) ? player.Inventory[rowIndex + 1].Name + " - " + player.Inventory[rowIndex + 1].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory3, (player.Inventory.ElementAtOrDefault(rowIndex + 2) != null) ? player.Inventory[rowIndex + 2].Name + " - " + player.Inventory[rowIndex + 2].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory4, (player.Inventory.ElementAtOrDefault(rowIndex + 3) != null) ? player.Inventory[rowIndex + 3].Name + " - " + player.Inventory[rowIndex + 3].Description : string.Empty);
            tltToolTip.SetToolTip(btnInventory5, (player.Inventory.ElementAtOrDefault(rowIndex + 4) != null) ? player.Inventory[rowIndex + 4].Name + " - " + player.Inventory[rowIndex + 4].Description : string.Empty);

            //Update location info
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

        public void ShowWarning(string message, double seconds, Color color)
        {
            sblWarning.Text = message;
            sblWarning.Visible = true;
            srpWarning.BackColor = color;
            sblWarning.ForeColor = Color.Black;

            t.Stop();
            t.Interval = Convert.ToInt32(seconds * 1000);


            t.Tick += (s, e) =>
            {
                sblWarning.Visible = false;
                srpWarning.BackColor = Color.FromArgb(0, 0, 64);
                t.Stop();
            };

            t.Start();
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

        public void UseInventoryItem(int slot)
        {
            int rowIndex = ((player.InventoryRow - 1) * 5) + (slot - 1);
            if (player.Inventory.ElementAtOrDefault(rowIndex) != null)
            {
                Item item = player.Inventory[rowIndex];
                player.Inventory.RemoveAt(rowIndex);
                UpdateHUD(item);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //Not implemented yet.
            ShowWarning("Menu not implemented.", 2 ,Color.Yellow);
        }

        //Inventory interaction
        private void btnInventory1_Click(object sender, EventArgs e)
        {
            //You can't pass list elements like you can array elements.
            UseInventoryItem(1);
        }

        private void btnInventory2_Click(object sender, EventArgs e)
        {
            UseInventoryItem(2);
        }

        private void btnInventory3_Click(object sender, EventArgs e)
        {
            UseInventoryItem(3);
        }

        private void btnInventory4_Click(object sender, EventArgs e)
        {
            UseInventoryItem(4);
        }

        private void btnInventory5_Click(object sender, EventArgs e)
        {
            UseInventoryItem(5);
        }

        private void btnInventoryDown_Click(object sender, EventArgs e)
        {
            player.InventoryRow--;
            UpdateHUD();
        }

        private void btnInventoryUp_Click(object sender, EventArgs e)
        {
            player.InventoryRow++;
            UpdateHUD();
        }
    }
}

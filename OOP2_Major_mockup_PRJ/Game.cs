using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Major_mockup_PRJ
{
    public partial class Game : Form
    {
        /*fields-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        //Our classes
        Player player;
        InputController input;
        ScenarioController scene;
       
        //.NET timer
        Timer t = new Timer();

        //Tracking of persistent game state
        private bool messageShown = false;
        private int sceneType;
        
        /*end fields -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public Game() 
        {//constructor instantiates objects, and gets input from the player through 
         //an additional form. (InputController creates the form)
            InitializeComponent();
            player = new Player();
            scene = new ScenarioController();
            input = new InputController();
            string[] playerInfo = input.GetInput("Player Information", "Enter Your Name", "Enter Ship Name", "Start Game", 4, 3);
            player.PlayerName = playerInfo[0];
            player.ShipName = playerInfo[1];
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.StartingItems.Length; i++)
            {//populate the starting inventory
                player.Inventory.Add(Data.StartingItems[i]);
            }
        
            BeginTurn(scene.StoryCounter); //'starts' the first scripted scene 
            
            UpdateHUD(); 
        }
        /*_-_-_-_-_Button Handlers_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_*/
        private void NextTurn_Click(object sender, EventArgs e)
        { //(WARP button)
            if (player.IsOnShip && player.HasMadeChoice)
            {
                if ((scene.StoryCounter >= Data.MAX_EPISODE) && !(messageShown))
                {//if we are out of scripted scenes, tell the player, then allow them to keep playing randoms until they die.
                    ShowWarning("Further story unavailable, initializing 100% procedural scenarios.", 7, Color.White);
                    sceneType = 5;
                    messageShown = true;
                }

                //or, if we have told them already, just keep playing randoms
                else if (messageShown) { sceneType = 5; }
                else
                {//but if none of the above is true
                    if (scene.StoryCounter <= 2)
                    {//play the first three scripted scenes every time, 
                        sceneType = 1;
                    }
                    //then allow the randoms to mix in
                    else { sceneType = Data.Rand.Next(1, 11); }
                }
               
                //the number passed to BeginTurn controls the type of scene that will start below 3 runs scripted, otherwise random
                BeginTurn(sceneType);  

                player.Fuel -= 1;
                player.Distance += 1;
                UpdateHUD();
            }
            //Not on ship
            else if (!player.IsOnShip && player.HasMadeChoice)
            { 
                ShowWarning("Unable to warp, you must be on your ship.", 2.5, Color.Gold);
            }
            else if(player.IsOnShip && !player.HasMadeChoice) { ShowWarning("Unable to end turn until dialog has proceeded", 2.5, Color.Gold); }
        }

        private void Dis_Embark_Click(object sender, EventArgs e)
        {//(Board Ship/ Leave ship button)
            if (scene.LocationType == 3)
            {
                ShowWarning("Can't disembark in space!", 2.5, Color.Gold);
            }
            else
            {
                player.IsOnShip = !player.IsOnShip;
            }
            UpdateHUD();
        }

        private void OptionOne_Click(object sender, EventArgs e)
        {
            MakeChoice(0);
        }

        private void OptionTwo_Click(object sender, EventArgs e)
        {
            MakeChoice(1);
        }

        private void OptionThree_Click(object sender, EventArgs e)
        {
            MakeChoice(2);
        }

        private void OptionFour_Click(object sender, EventArgs e)
        {
            MakeChoice(3);
        }

        private void OptionFive_Click(object sender, EventArgs e)
        {
            MakeChoice(4);
        }
        /*_-_-_-_-_End Buttons_-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-__-_-_-_-_-_-_-_-_*/

        private void BeginTurn(int sceneType)
        {
            player.HasMadeChoice = false;
         
            
            if (sceneType <= 3)
            {//30%-ish chance to run scripted here
                scene.StartScenario(true);
                lblOutput.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular); //smaller font to allow for the wordiness of the scripted scenes 
                lblOutput.Text = scene.ScriptScene.Description;
                lblPlaceName.Text = scene.ScriptScene.PlaceName;
                lblDate.Text = scene.ScriptScene.Date;
                ShowButtons(Data.ScriptedVisibilities[scene.StoryCounter -1]);
            }
            else
            {//or 70%-ish chance for random here
                scene.StartScenario();
                lblOutput.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblOutput.Text = scene.RandScene.Description;
                lblPlaceName.Text = scene.RandScene.PlaceName;
                lblDate.Text = scene.RandScene.Date;
                ShowButtons(Data.Rand.Next(3, 6));
            }

            //If scene type is not in space, disembark
            if(scene.LocationType != 3) player.IsOnShip = false;

            //change the image
            pbxViewScreen.Image = scene.ScenarioImage;
            
            //set the text for each button 
            btnOptionOne.Text = scene.CurrentOptions[0].ButtonText;
            btnOptionTwo.Text = scene.CurrentOptions[1].ButtonText;
            btnOptionThree.Text = scene.CurrentOptions[2].ButtonText;
            btnOptionFour.Text = scene.CurrentOptions[3].ButtonText;
            btnOptionFive.Text = scene.CurrentOptions[4].ButtonText;
        }

        private void HideButtons()
        {//hide the buttons after the player makes a choice.
            btnOptionOne.Hide(); 
            btnOptionTwo.Hide();
            btnOptionThree.Hide();
            btnOptionFour.Hide();
            btnOptionFive.Hide(); 
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

        private void MakeChoice(int button)
        {//player.HasMadeChoice prevents the player from doing more than one thing per scene whether by accidental button click or on purpose
            if (!player.HasMadeChoice && !player.isDead)
            {
                lblOutput.Text = scene.CurrentOptions[button].ResultDescription;

                if (scene.CurrentOptions[button].MoneyEffect < player.Money)
                {
                    ShowWarning("You can't afford that!", 4, Color.Red);
                    lblOutput.Text = "The merchant, outraged, pushes you away from their wares. You turn back toward the ship, forlorn";
                }
                else
                {
                    //text and Item
                    if (scene.CurrentOptions[button].PostClickText != string.Empty && scene.CurrentOptions[button].Reward != null)
                    {
                        ShowWarning(scene.CurrentOptions[button].PostClickText + " You got " + scene.CurrentOptions[button].Reward.Name + "!", 4, Color.Green);
                        player.Inventory.Add(scene.CurrentOptions[button].Reward);
                    }
                    //item but no text
                    else if (scene.CurrentOptions[button].Reward != null && scene.CurrentOptions[button].PostClickText == string.Empty)
                    {
                        ShowWarning("You got " + scene.CurrentOptions[button].Reward.Name + "!", 4, Color.Green);
                        player.Inventory.Add(scene.CurrentOptions[button].Reward);
                    }
                    //text but no item
                    else if (scene.CurrentOptions[button].Reward == null && scene.CurrentOptions[button].PostClickText != string.Empty)
                    {
                        ShowWarning(scene.CurrentOptions[button].PostClickText, 4, Color.Green);
                    }
                }
                //show the post-choice text, hide inputs appropraitely, and update the Heads Up display
                
                HideButtons();
                UpdateHUD(button);
            }
        }

        private void UpdateHUD(Item item)
        {
            //Item version will use the item and apply it's effects
            //TODO? modify this to prevent players from using an item if its stat is full (Using a medkit at full health)
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
                lblShipBoard.Text = player.ShipName;
                Dis_Embark.Text = "Disembark";
            }
            else
            {
                Dis_Embark.Text = "Board Ship";
                switch (scene.LocationType)
                {
                    //1 - City, 2 - Forest, 3 - Space, 4 Scripted   
                    case 1:
                        lblShipBoard.Text = "City streets";
                        break;
                    case 2:
                        lblShipBoard.Text = "Wilderness";
                        break;
                    case 3:
                        lblShipBoard.Text = "In Exosuit";//unused right now, leaving becasue useful
                        break;
                    default:
                        lblShipBoard.Text = "Planetside";
                        break;
                }
            }

            //Update Highscore
            sblHighscore.Text = "Highscore: " + SetHighscore();
        }

        public void ShowWarning(string message, double seconds, Color color)
        {
            sblWarning.Text = message;
            sblWarning.Visible = true;
            srpWarning.BackColor = color;
            sblWarning.ForeColor = Color.Black;
            sblHighscore.BackColor = color;
            sblHighscore.ForeColor = Color.Black;

            t.Stop();
            t.Interval = Convert.ToInt32(seconds * 1000);


            t.Tick += (s, e) =>
            {
                sblWarning.Visible = false;
                srpWarning.BackColor = Color.FromArgb(0, 0, 64);
                sblHighscore.BackColor = Color.FromArgb(0, 0, 64);
                sblHighscore.ForeColor = SystemColors.MenuHighlight;

                t.Stop();
            };

            t.Start();
        }

        private void GameOver(string reason)
        {   //to disable 'death', simply comment out **from here** 
            //If the player dies, hide everything
            HideButtons();
            player.isDead = true;
            lblDate.Text = string.Empty;
            lblPlaceName.Text = string.Empty;
            lblShipBoard.Text = string.Empty;

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
                lblPlaceName.Text = "ERROR";
                lblDate.Text = "ERROR";
                lblShipBoard.Text = player.ShipName;
            }

            //**to here** to disable

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
            ShowWarning("Menu not implemented.", 2.5, Color.Gold);
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


        private string SetHighscore()
        {
            //Could run into issues with read/write permissions.

            string highScore = "No Score - 0 LY";
            try
            {
                //Get High Score
                if (File.Exists("Highscore.txt"))
                {
                    StreamReader reader = new StreamReader("Highscore.txt");
                    highScore = reader.ReadLine();
                    reader.Close();
                }

                int score = int.Parse(highScore.Substring(highScore.Length - 4, 1));
                

                //If highscore is lower than current score or highscore is not set
                if(score < player.Distance || score == 0)
                {
                    highScore = player.PlayerName + " - " + player.Distance + " LY";

                    //Uses File.WriteAllText instead of a writer so it overrides any text already in document.
                    File.WriteAllText("Highscore.txt", highScore);
                }
                
            }
            catch (Exception ex)
            {
                ShowWarning("Unable to Set High Score: " + ex.Message, 3, Color.Red);
            }

            return highScore;
        }

    }
}

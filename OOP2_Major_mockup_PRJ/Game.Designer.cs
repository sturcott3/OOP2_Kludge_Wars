namespace OOP2_Major_mockup_PRJ
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbxViewScreen = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlHUD = new System.Windows.Forms.Panel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblRepair = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.btnInventoryUp = new System.Windows.Forms.Button();
            this.btnInventory1 = new System.Windows.Forms.Button();
            this.btnInventory2 = new System.Windows.Forms.Button();
            this.btnInventory3 = new System.Windows.Forms.Button();
            this.btnInventory4 = new System.Windows.Forms.Button();
            this.btnInventory5 = new System.Windows.Forms.Button();
            this.btnInventoryDown = new System.Windows.Forms.Button();
            this.fpnlChoices = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.btnOptionFive = new System.Windows.Forms.Button();
            this.NextTurn = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Dis_Embark = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblShipBoard = new System.Windows.Forms.Label();
            this.tltToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.srpWarning = new System.Windows.Forms.StatusStrip();
            this.sblWarning = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewScreen)).BeginInit();
            this.pnlHUD.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.fpnlChoices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.srpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxViewScreen
            // 
            this.pbxViewScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pbxViewScreen.Image = global::OOP2_Major_mockup_PRJ.Properties.Resources.LogoGameWide_2;
            this.pbxViewScreen.Location = new System.Drawing.Point(16, 70);
            this.pbxViewScreen.Margin = new System.Windows.Forms.Padding(4);
            this.pbxViewScreen.Name = "pbxViewScreen";
            this.pbxViewScreen.Size = new System.Drawing.Size(1268, 252);
            this.pbxViewScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxViewScreen.TabIndex = 26;
            this.pbxViewScreen.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOutput.Location = new System.Drawing.Point(488, 335);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(797, 156);
            this.lblOutput.TabIndex = 28;
            this.lblOutput.Text = resources.GetString("lblOutput.Text");
            // 
            // pnlHUD
            // 
            this.pnlHUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlHUD.Controls.Add(this.lblDistance);
            this.pnlHUD.Controls.Add(this.label6);
            this.pnlHUD.Controls.Add(this.lblMoney);
            this.pnlHUD.Controls.Add(this.lblFuel);
            this.pnlHUD.Controls.Add(this.lblRepair);
            this.pnlHUD.Controls.Add(this.lblHealth);
            this.pnlHUD.Controls.Add(this.label4);
            this.pnlHUD.Controls.Add(this.label3);
            this.pnlHUD.Controls.Add(this.label2);
            this.pnlHUD.Controls.Add(this.label1);
            this.pnlHUD.Location = new System.Drawing.Point(16, 15);
            this.pnlHUD.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHUD.Name = "pnlHUD";
            this.pnlHUD.Size = new System.Drawing.Size(1267, 43);
            this.pnlHUD.TabIndex = 29;
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.Black;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.Lavender;
            this.lblDistance.Location = new System.Drawing.Point(896, 4);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(125, 32);
            this.lblDistance.TabIndex = 36;
            this.lblDistance.Text = "0 LY";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(801, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Distance:";
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.Black;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Lime;
            this.lblMoney.Location = new System.Drawing.Point(1152, 5);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(108, 32);
            this.lblMoney.TabIndex = 34;
            this.lblMoney.Text = "$0";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuel
            // 
            this.lblFuel.BackColor = System.Drawing.Color.Black;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.ForeColor = System.Drawing.Color.Blue;
            this.lblFuel.Location = new System.Drawing.Point(597, 6);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(177, 32);
            this.lblFuel.TabIndex = 33;
            this.lblFuel.Text = "[] [] [] [] [] [] [] []";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRepair
            // 
            this.lblRepair.BackColor = System.Drawing.Color.Black;
            this.lblRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRepair.Location = new System.Drawing.Point(341, 6);
            this.lblRepair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(177, 32);
            this.lblRepair.TabIndex = 5;
            this.lblRepair.Text = "{} {} {} {} {} {} {} {}";
            this.lblRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Black;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(79, 6);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(177, 32);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "+ + + + + + + + +";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(1072, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credits: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(543, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fuel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repair: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health: ";
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInventory.Controls.Add(this.btnInventoryUp);
            this.pnlInventory.Controls.Add(this.btnInventory1);
            this.pnlInventory.Controls.Add(this.btnInventory2);
            this.pnlInventory.Controls.Add(this.btnInventory3);
            this.pnlInventory.Controls.Add(this.btnInventory4);
            this.pnlInventory.Controls.Add(this.btnInventory5);
            this.pnlInventory.Controls.Add(this.btnInventoryDown);
            this.pnlInventory.Location = new System.Drawing.Point(13, 337);
            this.pnlInventory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(467, 82);
            this.pnlInventory.TabIndex = 33;
            // 
            // btnInventoryUp
            // 
            this.btnInventoryUp.BackColor = System.Drawing.Color.Transparent;
            this.btnInventoryUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryUp.BackgroundImage")));
            this.btnInventoryUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventoryUp.FlatAppearance.BorderSize = 0;
            this.btnInventoryUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInventoryUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventoryUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryUp.Location = new System.Drawing.Point(407, 1);
            this.btnInventoryUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventoryUp.Name = "btnInventoryUp";
            this.btnInventoryUp.Size = new System.Drawing.Size(37, 34);
            this.btnInventoryUp.TabIndex = 47;
            this.btnInventoryUp.UseVisualStyleBackColor = false;
            this.btnInventoryUp.Click += new System.EventHandler(this.btnInventoryUp_Click);
            // 
            // btnInventory1
            // 
            this.btnInventory1.BackColor = System.Drawing.Color.Black;
            this.btnInventory1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventory1.Location = new System.Drawing.Point(8, 10);
            this.btnInventory1.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory1.Name = "btnInventory1";
            this.btnInventory1.Size = new System.Drawing.Size(67, 62);
            this.btnInventory1.TabIndex = 46;
            this.btnInventory1.UseVisualStyleBackColor = false;
            this.btnInventory1.Click += new System.EventHandler(this.btnInventory1_Click);
            // 
            // btnInventory2
            // 
            this.btnInventory2.BackColor = System.Drawing.Color.Black;
            this.btnInventory2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventory2.Location = new System.Drawing.Point(85, 10);
            this.btnInventory2.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory2.Name = "btnInventory2";
            this.btnInventory2.Size = new System.Drawing.Size(67, 62);
            this.btnInventory2.TabIndex = 45;
            this.btnInventory2.UseVisualStyleBackColor = false;
            this.btnInventory2.Click += new System.EventHandler(this.btnInventory2_Click);
            // 
            // btnInventory3
            // 
            this.btnInventory3.BackColor = System.Drawing.Color.Black;
            this.btnInventory3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventory3.Location = new System.Drawing.Point(163, 10);
            this.btnInventory3.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory3.Name = "btnInventory3";
            this.btnInventory3.Size = new System.Drawing.Size(67, 62);
            this.btnInventory3.TabIndex = 44;
            this.btnInventory3.UseVisualStyleBackColor = false;
            this.btnInventory3.Click += new System.EventHandler(this.btnInventory3_Click);
            // 
            // btnInventory4
            // 
            this.btnInventory4.BackColor = System.Drawing.Color.Black;
            this.btnInventory4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventory4.Location = new System.Drawing.Point(240, 10);
            this.btnInventory4.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory4.Name = "btnInventory4";
            this.btnInventory4.Size = new System.Drawing.Size(67, 62);
            this.btnInventory4.TabIndex = 43;
            this.btnInventory4.UseVisualStyleBackColor = false;
            this.btnInventory4.Click += new System.EventHandler(this.btnInventory4_Click);
            // 
            // btnInventory5
            // 
            this.btnInventory5.BackColor = System.Drawing.Color.Black;
            this.btnInventory5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventory5.Location = new System.Drawing.Point(315, 10);
            this.btnInventory5.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory5.Name = "btnInventory5";
            this.btnInventory5.Size = new System.Drawing.Size(67, 62);
            this.btnInventory5.TabIndex = 42;
            this.btnInventory5.UseVisualStyleBackColor = false;
            this.btnInventory5.Click += new System.EventHandler(this.btnInventory5_Click);
            // 
            // btnInventoryDown
            // 
            this.btnInventoryDown.BackColor = System.Drawing.Color.Transparent;
            this.btnInventoryDown.BackgroundImage = global::OOP2_Major_mockup_PRJ.Properties.Resources.Down;
            this.btnInventoryDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventoryDown.FlatAppearance.BorderSize = 0;
            this.btnInventoryDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInventoryDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventoryDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryDown.ForeColor = System.Drawing.Color.Black;
            this.btnInventoryDown.Location = new System.Drawing.Point(407, 44);
            this.btnInventoryDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventoryDown.Name = "btnInventoryDown";
            this.btnInventoryDown.Size = new System.Drawing.Size(37, 34);
            this.btnInventoryDown.TabIndex = 41;
            this.btnInventoryDown.UseVisualStyleBackColor = false;
            this.btnInventoryDown.Click += new System.EventHandler(this.btnInventoryDown_Click);
            // 
            // fpnlChoices
            // 
            this.fpnlChoices.AutoScroll = true;
            this.fpnlChoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.fpnlChoices.Controls.Add(this.btnOptionOne);
            this.fpnlChoices.Controls.Add(this.btnOptionTwo);
            this.fpnlChoices.Controls.Add(this.btnOptionThree);
            this.fpnlChoices.Controls.Add(this.btnOptionFour);
            this.fpnlChoices.Controls.Add(this.btnOptionFive);
            this.fpnlChoices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlChoices.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fpnlChoices.Location = new System.Drawing.Point(491, 500);
            this.fpnlChoices.Margin = new System.Windows.Forms.Padding(4);
            this.fpnlChoices.Name = "fpnlChoices";
            this.fpnlChoices.Size = new System.Drawing.Size(791, 164);
            this.fpnlChoices.TabIndex = 34;
            this.fpnlChoices.WrapContents = false;
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionOne.Location = new System.Drawing.Point(4, 4);
            this.btnOptionOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(760, 47);
            this.btnOptionOne.TabIndex = 36;
            this.btnOptionOne.Text = "Option 1: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.btnOptionOne.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptionOne.UseVisualStyleBackColor = false;
            this.btnOptionOne.Click += new System.EventHandler(this.OptionOne_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionTwo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionTwo.Location = new System.Drawing.Point(4, 59);
            this.btnOptionTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(760, 47);
            this.btnOptionTwo.TabIndex = 37;
            this.btnOptionTwo.Text = "Option 2: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.btnOptionTwo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            this.btnOptionTwo.Click += new System.EventHandler(this.OptionTwo_Click);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionThree.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionThree.Location = new System.Drawing.Point(4, 114);
            this.btnOptionThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(760, 47);
            this.btnOptionThree.TabIndex = 38;
            this.btnOptionThree.Text = "Option 3: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.btnOptionThree.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptionThree.UseVisualStyleBackColor = false;
            this.btnOptionThree.Click += new System.EventHandler(this.OptionThree_Click);
            // 
            // btnOptionFour
            // 
            this.btnOptionFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionFour.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionFour.Location = new System.Drawing.Point(4, 169);
            this.btnOptionFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(760, 47);
            this.btnOptionFour.TabIndex = 39;
            this.btnOptionFour.Text = "Option 4: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.btnOptionFour.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptionFour.UseVisualStyleBackColor = false;
            this.btnOptionFour.Click += new System.EventHandler(this.OptionFour_Click);
            // 
            // btnOptionFive
            // 
            this.btnOptionFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionFive.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionFive.Location = new System.Drawing.Point(4, 224);
            this.btnOptionFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionFive.Name = "btnOptionFive";
            this.btnOptionFive.Size = new System.Drawing.Size(760, 47);
            this.btnOptionFive.TabIndex = 40;
            this.btnOptionFive.Text = "Option 5: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.btnOptionFive.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOptionFive.UseVisualStyleBackColor = false;
            this.btnOptionFive.Click += new System.EventHandler(this.OptionFive_Click);
            // 
            // NextTurn
            // 
            this.NextTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NextTurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.NextTurn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextTurn.Location = new System.Drawing.Point(16, 427);
            this.NextTurn.Margin = new System.Windows.Forms.Padding(4);
            this.NextTurn.Name = "NextTurn";
            this.NextTurn.Size = new System.Drawing.Size(211, 71);
            this.NextTurn.TabIndex = 38;
            this.NextTurn.Text = "Warp";
            this.NextTurn.UseVisualStyleBackColor = false;
            this.NextTurn.Click += new System.EventHandler(this.NextTurn_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.Location = new System.Drawing.Point(16, 594);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(211, 69);
            this.btnMenu.TabIndex = 39;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Dis_Embark
            // 
            this.Dis_Embark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Dis_Embark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dis_Embark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Dis_Embark.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Dis_Embark.Location = new System.Drawing.Point(17, 510);
            this.Dis_Embark.Margin = new System.Windows.Forms.Padding(4);
            this.Dis_Embark.Name = "Dis_Embark";
            this.Dis_Embark.Size = new System.Drawing.Size(211, 71);
            this.Dis_Embark.TabIndex = 40;
            this.Dis_Embark.Text = "Board Ship";
            this.Dis_Embark.UseVisualStyleBackColor = false;
            this.Dis_Embark.Click += new System.EventHandler(this.Dis_Embark_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPlaceName);
            this.panel1.Controls.Add(this.lblShipBoard);
            this.panel1.Location = new System.Drawing.Point(244, 430);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 234);
            this.panel1.TabIndex = 35;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.MintCream;
            this.lblDate.Location = new System.Drawing.Point(11, 158);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(205, 63);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "2037 AD";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.BackColor = System.Drawing.Color.Black;
            this.lblPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPlaceName.ForeColor = System.Drawing.Color.MintCream;
            this.lblPlaceName.Location = new System.Drawing.Point(11, 12);
            this.lblPlaceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(205, 63);
            this.lblPlaceName.TabIndex = 39;
            this.lblPlaceName.Text = " Earth";
            this.lblPlaceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipBoard
            // 
            this.lblShipBoard.BackColor = System.Drawing.Color.Black;
            this.lblShipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblShipBoard.ForeColor = System.Drawing.Color.MintCream;
            this.lblShipBoard.Location = new System.Drawing.Point(11, 84);
            this.lblShipBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipBoard.Name = "lblShipBoard";
            this.lblShipBoard.Size = new System.Drawing.Size(205, 63);
            this.lblShipBoard.TabIndex = 38;
            this.lblShipBoard.Text = "Planetside";
            this.lblShipBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srpWarning
            // 
            this.srpWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.srpWarning.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.srpWarning.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblWarning});
            this.srpWarning.Location = new System.Drawing.Point(0, 677);
            this.srpWarning.Name = "srpWarning";
            this.srpWarning.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.srpWarning.Size = new System.Drawing.Size(1295, 22);
            this.srpWarning.SizingGrip = false;
            this.srpWarning.TabIndex = 41;
            // 
            // sblWarning
            // 
            this.sblWarning.BackColor = System.Drawing.Color.Transparent;
            this.sblWarning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sblWarning.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sblWarning.Name = "sblWarning";
            this.sblWarning.Size = new System.Drawing.Size(83, 20);
            this.sblWarning.Text = "sblWarning";
            this.sblWarning.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::OOP2_Major_mockup_PRJ.Properties.Resources._947454_outer_space_wallpaper_dark_hd_wallpapers_1920x1200_h;
            this.ClientSize = new System.Drawing.Size(1295, 699);
            this.Controls.Add(this.srpWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dis_Embark);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.NextTurn);
            this.Controls.Add(this.fpnlChoices);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlHUD);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbxViewScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Kludge Wars: The Kludge Awakens";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewScreen)).EndInit();
            this.pnlHUD.ResumeLayout(false);
            this.pnlHUD.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.fpnlChoices.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.srpWarning.ResumeLayout(false);
            this.srpWarning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxViewScreen;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlHUD;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblRepair;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.FlowLayoutPanel fpnlChoices;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Button btnOptionFive;
        private System.Windows.Forms.Button NextTurn;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button Dis_Embark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblShipBoard;
        private System.Windows.Forms.Button btnInventory1;
        private System.Windows.Forms.Button btnInventory2;
        private System.Windows.Forms.Button btnInventory3;
        private System.Windows.Forms.Button btnInventory4;
        private System.Windows.Forms.Button btnInventory5;
        private System.Windows.Forms.ToolTip tltToolTip;
        private System.Windows.Forms.StatusStrip srpWarning;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnInventoryUp;
        private System.Windows.Forms.Button btnInventoryDown;
        private System.Windows.Forms.ToolStripStatusLabel sblWarning;
    }
}


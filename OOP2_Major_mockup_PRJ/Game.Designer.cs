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
            this.pbxInventory6 = new System.Windows.Forms.PictureBox();
            this.pbxInventory5 = new System.Windows.Forms.PictureBox();
            this.pbxInventory4 = new System.Windows.Forms.PictureBox();
            this.pbxInventory3 = new System.Windows.Forms.PictureBox();
            this.pbxInventory2 = new System.Windows.Forms.PictureBox();
            this.pbxInventory1 = new System.Windows.Forms.PictureBox();
            this.fpnlChoices = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.btnOptionFive = new System.Windows.Forms.Button();
            this.NextTurn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.Dis_Embark = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewScreen)).BeginInit();
            this.pnlHUD.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory1)).BeginInit();
            this.fpnlChoices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxViewScreen
            // 
            this.pbxViewScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pbxViewScreen.Location = new System.Drawing.Point(12, 57);
            this.pbxViewScreen.Name = "pbxViewScreen";
            this.pbxViewScreen.Size = new System.Drawing.Size(951, 205);
            this.pbxViewScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxViewScreen.TabIndex = 26;
            this.pbxViewScreen.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOutput.Location = new System.Drawing.Point(366, 272);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(598, 127);
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
            this.pnlHUD.Location = new System.Drawing.Point(12, 12);
            this.pnlHUD.Name = "pnlHUD";
            this.pnlHUD.Size = new System.Drawing.Size(950, 35);
            this.pnlHUD.TabIndex = 29;
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.Black;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.Lavender;
            this.lblDistance.Location = new System.Drawing.Point(672, 3);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(94, 26);
            this.lblDistance.TabIndex = 36;
            this.lblDistance.Text = "0 LY";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(601, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Distance:";
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.Black;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Lime;
            this.lblMoney.Location = new System.Drawing.Point(864, 4);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(81, 26);
            this.lblMoney.TabIndex = 34;
            this.lblMoney.Text = "$0";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuel
            // 
            this.lblFuel.BackColor = System.Drawing.Color.Black;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.ForeColor = System.Drawing.Color.Blue;
            this.lblFuel.Location = new System.Drawing.Point(448, 5);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(133, 26);
            this.lblFuel.TabIndex = 33;
            this.lblFuel.Text = "[] [] [] [] [] [] [] []";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRepair
            // 
            this.lblRepair.BackColor = System.Drawing.Color.Black;
            this.lblRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRepair.Location = new System.Drawing.Point(256, 5);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(133, 26);
            this.lblRepair.TabIndex = 5;
            this.lblRepair.Text = "{} {} {} {} {} {} {} {}";
            this.lblRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Black;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(59, 5);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(133, 26);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "+ + + + + + + + +";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(804, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credits: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(407, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fuel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(199, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repair: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health: ";
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInventory.Controls.Add(this.pbxInventory6);
            this.pnlInventory.Controls.Add(this.pbxInventory5);
            this.pnlInventory.Controls.Add(this.pbxInventory4);
            this.pnlInventory.Controls.Add(this.pbxInventory3);
            this.pnlInventory.Controls.Add(this.pbxInventory2);
            this.pnlInventory.Controls.Add(this.pbxInventory1);
            this.pnlInventory.Location = new System.Drawing.Point(10, 274);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(350, 67);
            this.pnlInventory.TabIndex = 33;
            // 
            // pbxInventory6
            // 
            this.pbxInventory6.BackColor = System.Drawing.Color.Black;
            this.pbxInventory6.Location = new System.Drawing.Point(294, 8);
            this.pbxInventory6.Name = "pbxInventory6";
            this.pbxInventory6.Size = new System.Drawing.Size(50, 50);
            this.pbxInventory6.TabIndex = 34;
            this.pbxInventory6.TabStop = false;
            // 
            // pbxInventory5
            // 
            this.pbxInventory5.BackColor = System.Drawing.Color.Black;
            this.pbxInventory5.Location = new System.Drawing.Point(236, 8);
            this.pbxInventory5.Name = "pbxInventory5";
            this.pbxInventory5.Size = new System.Drawing.Size(50, 50);
            this.pbxInventory5.TabIndex = 32;
            this.pbxInventory5.TabStop = false;
            // 
            // pbxInventory4
            // 
            this.pbxInventory4.BackColor = System.Drawing.Color.Black;
            this.pbxInventory4.Location = new System.Drawing.Point(180, 8);
            this.pbxInventory4.Name = "pbxInventory4";
            this.pbxInventory4.Size = new System.Drawing.Size(50, 50);
            this.pbxInventory4.TabIndex = 30;
            this.pbxInventory4.TabStop = false;
            // 
            // pbxInventory3
            // 
            this.pbxInventory3.BackColor = System.Drawing.Color.Black;
            this.pbxInventory3.Location = new System.Drawing.Point(122, 8);
            this.pbxInventory3.Name = "pbxInventory3";
            this.pbxInventory3.Size = new System.Drawing.Size(52, 50);
            this.pbxInventory3.TabIndex = 28;
            this.pbxInventory3.TabStop = false;
            // 
            // pbxInventory2
            // 
            this.pbxInventory2.BackColor = System.Drawing.Color.Black;
            this.pbxInventory2.Location = new System.Drawing.Point(64, 8);
            this.pbxInventory2.Name = "pbxInventory2";
            this.pbxInventory2.Size = new System.Drawing.Size(50, 50);
            this.pbxInventory2.TabIndex = 26;
            this.pbxInventory2.TabStop = false;
            // 
            // pbxInventory1
            // 
            this.pbxInventory1.BackColor = System.Drawing.Color.Black;
            this.pbxInventory1.Location = new System.Drawing.Point(6, 8);
            this.pbxInventory1.Name = "pbxInventory1";
            this.pbxInventory1.Size = new System.Drawing.Size(50, 50);
            this.pbxInventory1.TabIndex = 24;
            this.pbxInventory1.TabStop = false;
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
            this.fpnlChoices.Location = new System.Drawing.Point(368, 406);
            this.fpnlChoices.Name = "fpnlChoices";
            this.fpnlChoices.Size = new System.Drawing.Size(593, 133);
            this.fpnlChoices.TabIndex = 34;
            this.fpnlChoices.WrapContents = false;
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOptionOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOptionOne.Location = new System.Drawing.Point(3, 3);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(570, 38);
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
            this.btnOptionTwo.Location = new System.Drawing.Point(3, 47);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(570, 38);
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
            this.btnOptionThree.Location = new System.Drawing.Point(3, 91);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(570, 38);
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
            this.btnOptionFour.Location = new System.Drawing.Point(3, 135);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(570, 38);
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
            this.btnOptionFive.Location = new System.Drawing.Point(3, 179);
            this.btnOptionFive.Name = "btnOptionFive";
            this.btnOptionFive.Size = new System.Drawing.Size(570, 38);
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
            this.NextTurn.Location = new System.Drawing.Point(190, 415);
            this.NextTurn.Name = "NextTurn";
            this.NextTurn.Size = new System.Drawing.Size(170, 58);
            this.NextTurn.TabIndex = 38;
            this.NextTurn.Text = "Warp";
            this.NextTurn.UseVisualStyleBackColor = false;
            this.NextTurn.Click += new System.EventHandler(this.NextTurn_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Menu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu.Location = new System.Drawing.Point(12, 454);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(86, 81);
            this.Menu.TabIndex = 39;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Dis_Embark
            // 
            this.Dis_Embark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Dis_Embark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dis_Embark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Dis_Embark.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Dis_Embark.Location = new System.Drawing.Point(190, 479);
            this.Dis_Embark.Name = "Dis_Embark";
            this.Dis_Embark.Size = new System.Drawing.Size(170, 58);
            this.Dis_Embark.TabIndex = 40;
            this.Dis_Embark.Text = "Board Ship";
            this.Dis_Embark.UseVisualStyleBackColor = false;
            this.Dis_Embark.Click += new System.EventHandler(this.Dis_Embark_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(190, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 60);
            this.panel1.TabIndex = 35;
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.Black;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.MintCream;
            this.lblLocation.Location = new System.Drawing.Point(9, 24);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(154, 28);
            this.lblLocation.TabIndex = 38;
            this.lblLocation.Text = "Planetside";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(27, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Current Location:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::OOP2_Major_mockup_PRJ.Properties.Resources._947454_outer_space_wallpaper_dark_hd_wallpapers_1920x1200_h;
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dis_Embark);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.NextTurn);
            this.Controls.Add(this.fpnlChoices);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlHUD);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbxViewScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Text = "Kludge Wars: The Kludge Awakens";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewScreen)).EndInit();
            this.pnlHUD.ResumeLayout(false);
            this.pnlHUD.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventory1)).EndInit();
            this.fpnlChoices.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pbxInventory6;
        private System.Windows.Forms.PictureBox pbxInventory5;
        private System.Windows.Forms.PictureBox pbxInventory4;
        private System.Windows.Forms.PictureBox pbxInventory3;
        private System.Windows.Forms.PictureBox pbxInventory2;
        private System.Windows.Forms.FlowLayoutPanel fpnlChoices;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Button btnOptionFive;
        private System.Windows.Forms.PictureBox pbxInventory1;
        private System.Windows.Forms.Button NextTurn;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Dis_Embark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label5;
    }
}


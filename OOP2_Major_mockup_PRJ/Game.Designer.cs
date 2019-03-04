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
            this.btnDebug = new System.Windows.Forms.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pbxInventory6 = new System.Windows.Forms.PictureBox();
            this.pbxInventory5 = new System.Windows.Forms.PictureBox();
            this.pbxInventory4 = new System.Windows.Forms.PictureBox();
            this.pbxInventory3 = new System.Windows.Forms.PictureBox();
            this.pbxInventory2 = new System.Windows.Forms.PictureBox();
            this.pbxInventory1 = new System.Windows.Forms.PictureBox();
            this.fpnlChoices = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.lblDistance.Text = "0 AU";
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
            this.lblMoney.Text = "0.00";
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
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(12, 485);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(108, 48);
            this.btnDebug.TabIndex = 27;
            this.btnDebug.Text = "TEST";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
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
            this.pbxInventory3.Size = new System.Drawing.Size(50, 50);
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
            this.fpnlChoices.Controls.Add(this.button4);
            this.fpnlChoices.Controls.Add(this.button1);
            this.fpnlChoices.Controls.Add(this.button2);
            this.fpnlChoices.Controls.Add(this.button3);
            this.fpnlChoices.Controls.Add(this.button5);
            this.fpnlChoices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlChoices.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fpnlChoices.Location = new System.Drawing.Point(368, 406);
            this.fpnlChoices.Name = "fpnlChoices";
            this.fpnlChoices.Size = new System.Drawing.Size(593, 133);
            this.fpnlChoices.TabIndex = 34;
            this.fpnlChoices.WrapContents = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(570, 38);
            this.button4.TabIndex = 36;
            this.button4.Text = "Option 1: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(3, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(570, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Option 2: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(3, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(570, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "Option 3: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(3, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(570, 38);
            this.button3.TabIndex = 39;
            this.button3.Text = "Option 4: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(3, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(570, 38);
            this.button5.TabIndex = 40;
            this.button5.Text = "Option 5: Room for two lines of text because options might get long. Lorem ipsum " +
    "sit dolor amet butts butts butts butts";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::OOP2_Major_mockup_PRJ.Properties.Resources._947454_outer_space_wallpaper_dark_hd_wallpapers_1920x1200_h;
            this.ClientSize = new System.Drawing.Size(971, 545);
            this.Controls.Add(this.fpnlChoices);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlHUD);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.pbxViewScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Text = "Kludge Wars: The Kludge Awakens";
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxViewScreen;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlHUD;
        private System.Windows.Forms.Button btnDebug;
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
        private System.Windows.Forms.PictureBox pbxInventory1;
        private System.Windows.Forms.FlowLayoutPanel fpnlChoices;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}


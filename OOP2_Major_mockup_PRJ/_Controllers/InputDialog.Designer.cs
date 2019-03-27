namespace OOP2_Major_mockup_PRJ
{
    partial class InputDialog
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxInput1 = new System.Windows.Forms.TextBox();
            this.lblDirections1 = new System.Windows.Forms.Label();
            this.lblDirections2 = new System.Windows.Forms.Label();
            this.tbxInput2 = new System.Windows.Forms.TextBox();
            this.pbxStartup = new System.Windows.Forms.PictureBox();
            this.srpWarning = new System.Windows.Forms.StatusStrip();
            this.sblWarning = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStartup)).BeginInit();
            this.srpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(177, 335);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Enter";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxInput1
            // 
            this.tbxInput1.Location = new System.Drawing.Point(29, 42);
            this.tbxInput1.Name = "tbxInput1";
            this.tbxInput1.Size = new System.Drawing.Size(153, 20);
            this.tbxInput1.TabIndex = 1;
            // 
            // lblDirections1
            // 
            this.lblDirections1.AutoSize = true;
            this.lblDirections1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDirections1.Location = new System.Drawing.Point(26, 26);
            this.lblDirections1.Name = "lblDirections1";
            this.lblDirections1.Size = new System.Drawing.Size(88, 13);
            this.lblDirections1.TabIndex = 2;
            this.lblDirections1.Text = "Enter Your Name";
            // 
            // lblDirections2
            // 
            this.lblDirections2.AutoSize = true;
            this.lblDirections2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDirections2.Location = new System.Drawing.Point(26, 84);
            this.lblDirections2.Name = "lblDirections2";
            this.lblDirections2.Size = new System.Drawing.Size(87, 13);
            this.lblDirections2.TabIndex = 4;
            this.lblDirections2.Text = "Enter Ship Name";
            // 
            // tbxInput2
            // 
            this.tbxInput2.Location = new System.Drawing.Point(29, 100);
            this.tbxInput2.Name = "tbxInput2";
            this.tbxInput2.Size = new System.Drawing.Size(153, 20);
            this.tbxInput2.TabIndex = 3;
            // 
            // pbxStartup
            // 
            this.pbxStartup.Image = global::OOP2_Major_mockup_PRJ.Properties.Resources.planet_1;
            this.pbxStartup.Location = new System.Drawing.Point(12, 140);
            this.pbxStartup.Name = "pbxStartup";
            this.pbxStartup.Size = new System.Drawing.Size(240, 186);
            this.pbxStartup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxStartup.TabIndex = 5;
            this.pbxStartup.TabStop = false;
            // 
            // srpWarning
            // 
            this.srpWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.srpWarning.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblWarning});
            this.srpWarning.Location = new System.Drawing.Point(0, 359);
            this.srpWarning.Name = "srpWarning";
            this.srpWarning.Size = new System.Drawing.Size(264, 22);
            this.srpWarning.SizingGrip = false;
            this.srpWarning.TabIndex = 42;
            // 
            // sblWarning
            // 
            this.sblWarning.BackColor = System.Drawing.Color.Transparent;
            this.sblWarning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sblWarning.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sblWarning.Name = "sblWarning";
            this.sblWarning.Size = new System.Drawing.Size(67, 17);
            this.sblWarning.Text = "sblWarning";
            this.sblWarning.Visible = false;
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(264, 381);
            this.Controls.Add(this.srpWarning);
            this.Controls.Add(this.pbxStartup);
            this.Controls.Add(this.lblDirections2);
            this.Controls.Add(this.tbxInput2);
            this.Controls.Add(this.lblDirections1);
            this.Controls.Add(this.tbxInput1);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStartup)).EndInit();
            this.srpWarning.ResumeLayout(false);
            this.srpWarning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxInput1;
        private System.Windows.Forms.Label lblDirections1;
        private System.Windows.Forms.Label lblDirections2;
        private System.Windows.Forms.TextBox tbxInput2;
        private System.Windows.Forms.PictureBox pbxStartup;
        private System.Windows.Forms.StatusStrip srpWarning;
        private System.Windows.Forms.ToolStripStatusLabel sblWarning;
    }
}
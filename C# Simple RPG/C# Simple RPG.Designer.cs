﻿namespace C__Simple_RPG
{
    partial class SimpleRpg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblGold = new Label();
            lblHitPoints = new Label();
            lblExperience = new Label();
            lblLevel = new Label();
            label5 = new Label();
            cboWeapons = new ComboBox();
            cboPotions = new ComboBox();
            btnUseWeapon = new Button();
            btnUsePotion = new Button();
            btnNorth = new Button();
            btnEast = new Button();
            btnSouth = new Button();
            btnWest = new Button();
            rtbLocation = new RichTextBox();
            rtbMessages = new RichTextBox();
            dgvInventory = new DataGridView();
            dvgQuests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgQuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(110, 46);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 15);
            lblGold.TabIndex = 4;
            lblGold.Click += label5_Click;
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Location = new Point(110, 20);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 15);
            lblHitPoints.TabIndex = 5;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(110, 73);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 15);
            lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(110, 99);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 15);
            lblLevel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 531);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 8;
            label5.Text = "Select Action";
            // 
            // cboWeapons
            // 
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(369, 559);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(121, 23);
            cboWeapons.TabIndex = 9;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(369, 593);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(121, 23);
            cboPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.Location = new Point(620, 559);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(75, 23);
            btnUseWeapon.TabIndex = 11;
            btnUseWeapon.Text = "Use";
            btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(620, 593);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(75, 23);
            btnUsePotion.TabIndex = 12;
            btnUsePotion.Text = "Use";
            btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(493, 433);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 23);
            btnNorth.TabIndex = 13;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += button1_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(573, 457);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 23);
            btnEast.TabIndex = 14;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(493, 487);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 23);
            btnSouth.TabIndex = 15;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(412, 457);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 23);
            btnWest.TabIndex = 16;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            // 
            // rtbLocation
            // 
            rtbLocation.Location = new Point(347, 19);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 17;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(347, 130);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(360, 286);
            rtbMessages.TabIndex = 18;
            rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.Location = new Point(16, 130);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.Size = new Size(312, 309);
            dgvInventory.TabIndex = 19;
            dgvInventory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dvgQuests
            // 
            dvgQuests.AllowUserToAddRows = false;
            dvgQuests.AllowUserToDeleteRows = false;
            dvgQuests.AllowUserToResizeRows = false;
            dvgQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dvgQuests.Enabled = false;
            dvgQuests.Location = new Point(16, 446);
            dvgQuests.MultiSelect = false;
            dvgQuests.Name = "dvgQuests";
            dvgQuests.ReadOnly = true;
            dvgQuests.RowHeadersVisible = false;
            dvgQuests.Size = new Size(312, 189);
            dvgQuests.TabIndex = 20;
            // 
            // SimpleRpg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 651);
            Controls.Add(dvgQuests);
            Controls.Add(dgvInventory);
            Controls.Add(rtbMessages);
            Controls.Add(rtbLocation);
            Controls.Add(btnWest);
            Controls.Add(btnSouth);
            Controls.Add(btnEast);
            Controls.Add(btnNorth);
            Controls.Add(btnUsePotion);
            Controls.Add(btnUseWeapon);
            Controls.Add(cboPotions);
            Controls.Add(cboWeapons);
            Controls.Add(label5);
            Controls.Add(lblLevel);
            Controls.Add(lblExperience);
            Controls.Add(lblHitPoints);
            Controls.Add(lblGold);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SimpleRpg";
            Text = "Simple RPG";
            Load += SimpleRpg_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgQuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblGold;
        private Label lblHitPoints;
        private Label lblExperience;
        private Label lblLevel;
        private Label label5;
        private ComboBox cboWeapons;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button btnEast;
        private Button btnSouth;
        private Button btnWest;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        private DataGridView dgvInventory;
        private DataGridView dvgQuests;
    }
}

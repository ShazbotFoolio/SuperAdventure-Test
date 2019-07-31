using System.Windows.Forms;

namespace SuperAdventure
{
    partial class SuperAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdventure));
            this.label_Gold_Gold = new System.Windows.Forms.Label();
            this.label_ExperienceBlackOnTeal = new System.Windows.Forms.Label();
            this.label_LevelLilacOnIndigo = new System.Windows.Forms.Label();
            this.lblCurrentHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnIncreaseValue = new System.Windows.Forms.Button();
            this.btnDecreaseValue = new System.Windows.Forms.Button();
            this.label_Current_White = new System.Windows.Forms.Label();
            this.label_Max_White = new System.Windows.Forms.Label();
            this.pictureBox_Current_Aqua_Test = new System.Windows.Forms.PictureBox();
            this.pictureBox_Max_Aqua_Test = new System.Windows.Forms.PictureBox();
            this.label_Hitpoints_White = new System.Windows.Forms.Label();
            this.pictureBox_Hitpoints_Aqua_Test = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gold_Light_Yellow_Border = new System.Windows.Forms.PictureBox();
            this.label_Slash_Between_Current_And_Max_Hitpoints = new System.Windows.Forms.Label();
            this.lblMaximumHitPoints = new System.Windows.Forms.Label();
            this.pictureBox_ExperienceWhiteOnBrightTeal = new System.Windows.Forms.PictureBox();
            this.pictureBox_LevelRedOnPurple = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnRJMRandomTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Current_Aqua_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max_Aqua_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hitpoints_Aqua_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold_Light_Yellow_Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ExperienceWhiteOnBrightTeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LevelRedOnPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Gold_Gold
            // 
            this.label_Gold_Gold.Image = ((System.Drawing.Image)(resources.GetObject("label_Gold_Gold.Image")));
            this.label_Gold_Gold.Location = new System.Drawing.Point(13, 58);
            this.label_Gold_Gold.Name = "label_Gold_Gold";
            this.label_Gold_Gold.Size = new System.Drawing.Size(215, 35);
            this.label_Gold_Gold.TabIndex = 1;
            this.label_Gold_Gold.MouseEnter += new System.EventHandler(this.Label2_Gold_Gold_MouseEnter);
            // 
            // label_ExperienceBlackOnTeal
            // 
            this.label_ExperienceBlackOnTeal.Image = ((System.Drawing.Image)(resources.GetObject("label_ExperienceBlackOnTeal.Image")));
            this.label_ExperienceBlackOnTeal.Location = new System.Drawing.Point(13, 94);
            this.label_ExperienceBlackOnTeal.Name = "label_ExperienceBlackOnTeal";
            this.label_ExperienceBlackOnTeal.Size = new System.Drawing.Size(215, 35);
            this.label_ExperienceBlackOnTeal.TabIndex = 2;
            this.label_ExperienceBlackOnTeal.MouseEnter += new System.EventHandler(this.Label_ExperienceBlackOnTeal_MouseEnter);
            // 
            // label_LevelLilacOnIndigo
            // 
            this.label_LevelLilacOnIndigo.Image = ((System.Drawing.Image)(resources.GetObject("label_LevelLilacOnIndigo.Image")));
            this.label_LevelLilacOnIndigo.Location = new System.Drawing.Point(13, 130);
            this.label_LevelLilacOnIndigo.Name = "label_LevelLilacOnIndigo";
            this.label_LevelLilacOnIndigo.Size = new System.Drawing.Size(215, 35);
            this.label_LevelLilacOnIndigo.TabIndex = 3;
            this.label_LevelLilacOnIndigo.MouseEnter += new System.EventHandler(this.Label_LevelLilacOnIndigo_MouseEnter);
            // 
            // lblCurrentHitPoints
            // 
            this.lblCurrentHitPoints.AutoSize = true;
            this.lblCurrentHitPoints.BackColor = System.Drawing.Color.DimGray;
            this.lblCurrentHitPoints.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentHitPoints.Location = new System.Drawing.Point(251, 37);
            this.lblCurrentHitPoints.Name = "lblCurrentHitPoints";
            this.lblCurrentHitPoints.Size = new System.Drawing.Size(27, 13);
            this.lblCurrentHitPoints.TabIndex = 4;
            this.lblCurrentHitPoints.Text = "asdf";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.DimGray;
            this.lblGold.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGold.Location = new System.Drawing.Point(251, 73);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(27, 13);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "asdf";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.DimGray;
            this.lblExperience.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExperience.Location = new System.Drawing.Point(251, 109);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(27, 13);
            this.lblExperience.TabIndex = 6;
            this.lblExperience.Text = "asdf";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.DimGray;
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLevel.Location = new System.Drawing.Point(251, 145);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(27, 13);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "asdf";
            // 
            // btnIncreaseValue
            // 
            this.btnIncreaseValue.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreaseValue.Image")));
            this.btnIncreaseValue.Location = new System.Drawing.Point(653, 28);
            this.btnIncreaseValue.Name = "btnIncreaseValue";
            this.btnIncreaseValue.Size = new System.Drawing.Size(24, 24);
            this.btnIncreaseValue.TabIndex = 8;
            this.btnIncreaseValue.UseVisualStyleBackColor = true;
            this.btnIncreaseValue.Click += new System.EventHandler(this.BtnIncreaseValue_Click);
            // 
            // btnDecreaseValue
            // 
            this.btnDecreaseValue.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseValue.Image")));
            this.btnDecreaseValue.Location = new System.Drawing.Point(683, 28);
            this.btnDecreaseValue.Name = "btnDecreaseValue";
            this.btnDecreaseValue.Size = new System.Drawing.Size(24, 24);
            this.btnDecreaseValue.TabIndex = 9;
            this.btnDecreaseValue.UseVisualStyleBackColor = true;
            this.btnDecreaseValue.Click += new System.EventHandler(this.BtnDecreaseValue_Click);
            // 
            // label_Current_White
            // 
            this.label_Current_White.BackColor = System.Drawing.Color.Brown;
            this.label_Current_White.Image = ((System.Drawing.Image)(resources.GetObject("label_Current_White.Image")));
            this.label_Current_White.Location = new System.Drawing.Point(13, 22);
            this.label_Current_White.Margin = new System.Windows.Forms.Padding(0);
            this.label_Current_White.Name = "label_Current_White";
            this.label_Current_White.Size = new System.Drawing.Size(70, 17);
            this.label_Current_White.TabIndex = 14;
            this.label_Current_White.MouseEnter += new System.EventHandler(this.Label5_Current_White_MouseEnter);
            // 
            // label_Max_White
            // 
            this.label_Max_White.BackColor = System.Drawing.Color.Brown;
            this.label_Max_White.Image = ((System.Drawing.Image)(resources.GetObject("label_Max_White.Image")));
            this.label_Max_White.Location = new System.Drawing.Point(13, 40);
            this.label_Max_White.Name = "label_Max_White";
            this.label_Max_White.Size = new System.Drawing.Size(70, 17);
            this.label_Max_White.TabIndex = 15;
            this.label_Max_White.MouseEnter += new System.EventHandler(this.Label6_Max_White_MouseEnter);
            // 
            // pictureBox_Current_Aqua_Test
            // 
            this.pictureBox_Current_Aqua_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Current_Aqua_Test.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Current_Aqua_Test.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Current_Aqua_Test.Image")));
            this.pictureBox_Current_Aqua_Test.Location = new System.Drawing.Point(379, 11);
            this.pictureBox_Current_Aqua_Test.Name = "pictureBox_Current_Aqua_Test";
            this.pictureBox_Current_Aqua_Test.Size = new System.Drawing.Size(70, 17);
            this.pictureBox_Current_Aqua_Test.TabIndex = 18;
            this.pictureBox_Current_Aqua_Test.TabStop = false;
            this.pictureBox_Current_Aqua_Test.Visible = false;
            this.pictureBox_Current_Aqua_Test.Click += new System.EventHandler(this.PictureBox1_Current_Aqua_Test_Click);
            this.pictureBox_Current_Aqua_Test.MouseLeave += new System.EventHandler(this.PictureBox1_Current_Aqua_Test_MouseLeave);
            // 
            // pictureBox_Max_Aqua_Test
            // 
            this.pictureBox_Max_Aqua_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Max_Aqua_Test.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Max_Aqua_Test.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Max_Aqua_Test.Image")));
            this.pictureBox_Max_Aqua_Test.Location = new System.Drawing.Point(379, 29);
            this.pictureBox_Max_Aqua_Test.Name = "pictureBox_Max_Aqua_Test";
            this.pictureBox_Max_Aqua_Test.Size = new System.Drawing.Size(70, 17);
            this.pictureBox_Max_Aqua_Test.TabIndex = 19;
            this.pictureBox_Max_Aqua_Test.TabStop = false;
            this.pictureBox_Max_Aqua_Test.Visible = false;
            this.pictureBox_Max_Aqua_Test.Click += new System.EventHandler(this.PictureBox2_Max_Aqua_Test_Click);
            this.pictureBox_Max_Aqua_Test.MouseLeave += new System.EventHandler(this.PictureBox2_Max_Aqua_Test_MouseLeave);
            // 
            // label_Hitpoints_White
            // 
            this.label_Hitpoints_White.BackColor = System.Drawing.Color.Brown;
            this.label_Hitpoints_White.Image = ((System.Drawing.Image)(resources.GetObject("label_Hitpoints_White.Image")));
            this.label_Hitpoints_White.Location = new System.Drawing.Point(84, 22);
            this.label_Hitpoints_White.Margin = new System.Windows.Forms.Padding(0);
            this.label_Hitpoints_White.Name = "label_Hitpoints_White";
            this.label_Hitpoints_White.Size = new System.Drawing.Size(144, 35);
            this.label_Hitpoints_White.TabIndex = 13;
            this.label_Hitpoints_White.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Hitpoints_White.MouseEnter += new System.EventHandler(this.Label1_Hitpoints_White_MouseEnter);
            // 
            // pictureBox_Hitpoints_Aqua_Test
            // 
            this.pictureBox_Hitpoints_Aqua_Test.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hitpoints_Aqua_Test.Image")));
            this.pictureBox_Hitpoints_Aqua_Test.Location = new System.Drawing.Point(455, 11);
            this.pictureBox_Hitpoints_Aqua_Test.Name = "pictureBox_Hitpoints_Aqua_Test";
            this.pictureBox_Hitpoints_Aqua_Test.Size = new System.Drawing.Size(144, 35);
            this.pictureBox_Hitpoints_Aqua_Test.TabIndex = 20;
            this.pictureBox_Hitpoints_Aqua_Test.TabStop = false;
            this.pictureBox_Hitpoints_Aqua_Test.Visible = false;
            this.pictureBox_Hitpoints_Aqua_Test.Click += new System.EventHandler(this.PictureBox3_Hitpoints_Aqua_Test_Click);
            this.pictureBox_Hitpoints_Aqua_Test.MouseLeave += new System.EventHandler(this.PictureBox3_Hitpoints_Aqua_Test_MouseLeave);
            // 
            // pictureBox_Gold_Light_Yellow_Border
            // 
            this.pictureBox_Gold_Light_Yellow_Border.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Gold_Light_Yellow_Border.Image")));
            this.pictureBox_Gold_Light_Yellow_Border.Location = new System.Drawing.Point(384, 52);
            this.pictureBox_Gold_Light_Yellow_Border.Name = "pictureBox_Gold_Light_Yellow_Border";
            this.pictureBox_Gold_Light_Yellow_Border.Size = new System.Drawing.Size(215, 35);
            this.pictureBox_Gold_Light_Yellow_Border.TabIndex = 21;
            this.pictureBox_Gold_Light_Yellow_Border.TabStop = false;
            this.pictureBox_Gold_Light_Yellow_Border.Visible = false;
            this.pictureBox_Gold_Light_Yellow_Border.Click += new System.EventHandler(this.PictureBox_Gold_Light_Yellow_Border_Click);
            this.pictureBox_Gold_Light_Yellow_Border.MouseLeave += new System.EventHandler(this.PictureBox_Gold_Light_Yellow_Border_MouseLeave);
            // 
            // label_Slash_Between_Current_And_Max_Hitpoints
            // 
            this.label_Slash_Between_Current_And_Max_Hitpoints.AutoSize = true;
            this.label_Slash_Between_Current_And_Max_Hitpoints.Location = new System.Drawing.Point(284, 37);
            this.label_Slash_Between_Current_And_Max_Hitpoints.Name = "label_Slash_Between_Current_And_Max_Hitpoints";
            this.label_Slash_Between_Current_And_Max_Hitpoints.Size = new System.Drawing.Size(12, 13);
            this.label_Slash_Between_Current_And_Max_Hitpoints.TabIndex = 22;
            this.label_Slash_Between_Current_And_Max_Hitpoints.Text = "/";
            // 
            // lblMaximumHitPoints
            // 
            this.lblMaximumHitPoints.AutoSize = true;
            this.lblMaximumHitPoints.BackColor = System.Drawing.Color.DimGray;
            this.lblMaximumHitPoints.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaximumHitPoints.Location = new System.Drawing.Point(302, 37);
            this.lblMaximumHitPoints.Name = "lblMaximumHitPoints";
            this.lblMaximumHitPoints.Size = new System.Drawing.Size(27, 13);
            this.lblMaximumHitPoints.TabIndex = 23;
            this.lblMaximumHitPoints.Text = "asdf";
            // 
            // pictureBox_ExperienceWhiteOnBrightTeal
            // 
            this.pictureBox_ExperienceWhiteOnBrightTeal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ExperienceWhiteOnBrightTeal.Image")));
            this.pictureBox_ExperienceWhiteOnBrightTeal.Location = new System.Drawing.Point(384, 93);
            this.pictureBox_ExperienceWhiteOnBrightTeal.Name = "pictureBox_ExperienceWhiteOnBrightTeal";
            this.pictureBox_ExperienceWhiteOnBrightTeal.Size = new System.Drawing.Size(215, 35);
            this.pictureBox_ExperienceWhiteOnBrightTeal.TabIndex = 24;
            this.pictureBox_ExperienceWhiteOnBrightTeal.TabStop = false;
            this.pictureBox_ExperienceWhiteOnBrightTeal.Visible = false;
            this.pictureBox_ExperienceWhiteOnBrightTeal.Click += new System.EventHandler(this.PictureBox_ExperienceWhiteOnBrightTeal_Click);
            this.pictureBox_ExperienceWhiteOnBrightTeal.MouseLeave += new System.EventHandler(this.PictureBox_ExperienceWhiteOnBrightTeal_MouseLeave);
            // 
            // pictureBox_LevelRedOnPurple
            // 
            this.pictureBox_LevelRedOnPurple.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LevelRedOnPurple.Image")));
            this.pictureBox_LevelRedOnPurple.Location = new System.Drawing.Point(384, 134);
            this.pictureBox_LevelRedOnPurple.Name = "pictureBox_LevelRedOnPurple";
            this.pictureBox_LevelRedOnPurple.Size = new System.Drawing.Size(215, 35);
            this.pictureBox_LevelRedOnPurple.TabIndex = 25;
            this.pictureBox_LevelRedOnPurple.TabStop = false;
            this.pictureBox_LevelRedOnPurple.Visible = false;
            this.pictureBox_LevelRedOnPurple.Click += new System.EventHandler(this.PictureBox_LevelRedOnPurple_Click);
            this.pictureBox_LevelRedOnPurple.MouseLeave += new System.EventHandler(this.PictureBox_LevelRedOnPurple_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 559);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 27;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(369, 593);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 28;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 29;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.BtnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 30;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.BtnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 31;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 32;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.BtnEast_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 33;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.BtnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 34;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 35;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(347, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 286);
            this.rtbMessages.TabIndex = 36;
            this.rtbMessages.Text = "";
            this.rtbMessages.TextChanged += new System.EventHandler(this.RtbMessages_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 174);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(312, 265);
            this.dgvInventory.TabIndex = 37;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 38;
            // 
            // btnRJMRandomTest
            // 
            this.btnRJMRandomTest.BackColor = System.Drawing.Color.Gold;
            this.btnRJMRandomTest.Location = new System.Drawing.Point(334, 422);
            this.btnRJMRandomTest.Name = "btnRJMRandomTest";
            this.btnRJMRandomTest.Size = new System.Drawing.Size(75, 23);
            this.btnRJMRandomTest.TabIndex = 39;
            this.btnRJMRandomTest.Text = "Random Test 10";
            this.btnRJMRandomTest.UseVisualStyleBackColor = false;
            this.btnRJMRandomTest.Visible = false;
            this.btnRJMRandomTest.Click += new System.EventHandler(this.BtnRJMRandomTest_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.btnRJMRandomTest);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_LevelRedOnPurple);
            this.Controls.Add(this.pictureBox_ExperienceWhiteOnBrightTeal);
            this.Controls.Add(this.lblMaximumHitPoints);
            this.Controls.Add(this.label_Slash_Between_Current_And_Max_Hitpoints);
            this.Controls.Add(this.pictureBox_Gold_Light_Yellow_Border);
            this.Controls.Add(this.pictureBox_Current_Aqua_Test);
            this.Controls.Add(this.label_Max_White);
            this.Controls.Add(this.label_Current_White);
            this.Controls.Add(this.label_Hitpoints_White);
            this.Controls.Add(this.btnDecreaseValue);
            this.Controls.Add(this.btnIncreaseValue);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblCurrentHitPoints);
            this.Controls.Add(this.label_LevelLilacOnIndigo);
            this.Controls.Add(this.label_ExperienceBlackOnTeal);
            this.Controls.Add(this.label_Gold_Gold);
            this.Controls.Add(this.pictureBox_Hitpoints_Aqua_Test);
            this.Controls.Add(this.pictureBox_Max_Aqua_Test);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperAdventure";
            this.Text = "Game [RJM]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Current_Aqua_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max_Aqua_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hitpoints_Aqua_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold_Light_Yellow_Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ExperienceWhiteOnBrightTeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LevelRedOnPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Gold_Gold;
        private System.Windows.Forms.Label label_ExperienceBlackOnTeal;
        private System.Windows.Forms.Label label_LevelLilacOnIndigo;
        private System.Windows.Forms.Label lblCurrentHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnIncreaseValue;
        private System.Windows.Forms.Button btnDecreaseValue;
        private Label label_Current_White;
        private Label label_Max_White;
        private PictureBox pictureBox_Current_Aqua_Test;
        private PictureBox pictureBox_Max_Aqua_Test;
        private Label label_Hitpoints_White;
        private PictureBox pictureBox_Hitpoints_Aqua_Test;
        private PictureBox pictureBox_Gold_Light_Yellow_Border;
        private Label label_Slash_Between_Current_And_Max_Hitpoints;
        private Label lblMaximumHitPoints;
        private PictureBox pictureBox_ExperienceWhiteOnBrightTeal;
        private PictureBox pictureBox_LevelRedOnPurple;
        private Label label1;
        private ComboBox cboWeapons;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button btnEast;
        private Button btnWest;
        private Button btnSouth;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        //private RichTextBoxRJM rtbMessages; //tch Tue 07/30/2019 6:01:18.57 //didn't seem to work. Tue 07/30/2019 6:12:30.84
        private DataGridView dgvInventory;
        private DataGridView dgvQuests;
        private Button btnRJMRandomTest;
    }
}


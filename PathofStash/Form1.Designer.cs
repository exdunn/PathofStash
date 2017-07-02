using System.Windows.Forms;

namespace PathofStash
{
    partial class Form1 : Form
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
            this.snipeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.socketsMaxTextBox = new System.Windows.Forms.TextBox();
            this.socketsMinTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linksMinTextBox = new System.Windows.Forms.TextBox();
            this.linksMaxTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.levelMinTextBox = new System.Windows.Forms.TextBox();
            this.levelMaxTextBox = new System.Windows.Forms.TextBox();
            this.iLvlMaxTextBox = new System.Windows.Forms.TextBox();
            this.iLvlMinTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.qualityMinTextBox = new System.Windows.Forms.TextBox();
            this.qualityMaxTextBox = new System.Windows.Forms.TextBox();
            this.addAffixButton = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.modMinTextBox1 = new System.Windows.Forms.TextBox();
            this.modMaxTextBox1 = new System.Windows.Forms.TextBox();
            this.affixPanel = new System.Windows.Forms.Panel();
            this.modPanel1 = new System.Windows.Forms.Panel();
            this.modComboBox1 = new System.Windows.Forms.ComboBox();
            this.evasionMinTextBox = new System.Windows.Forms.TextBox();
            this.evasionMaxTextBox = new System.Windows.Forms.TextBox();
            this.energyShieldMinTextBox = new System.Windows.Forms.TextBox();
            this.energyShieldMaxTextBox = new System.Windows.Forms.TextBox();
            this.armorMinTextBox = new System.Windows.Forms.TextBox();
            this.armorMaxTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.explicitModHeaderLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.modsLabel = new System.Windows.Forms.Label();
            this.ilvlLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.corrComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enchantComboBox = new System.Windows.Forms.ComboBox();
            this.enchantValueLabel = new System.Windows.Forms.Label();
            this.enchantMaxTextBox = new System.Windows.Forms.TextBox();
            this.enchantMinTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.whisperButton = new System.Windows.Forms.Button();
            this.affixPanel.SuspendLayout();
            this.modPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // snipeButton
            // 
            this.snipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snipeButton.Location = new System.Drawing.Point(811, 155);
            this.snipeButton.Name = "snipeButton";
            this.snipeButton.Size = new System.Drawing.Size(116, 36);
            this.snipeButton.TabIndex = 0;
            this.snipeButton.Text = "Snipe";
            this.snipeButton.UseVisualStyleBackColor = true;
            this.snipeButton.Click += new System.EventHandler(this.Snipe_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Armor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Energy Shield";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Evasion";
            // 
            // socketsMaxTextBox
            // 
            this.socketsMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.socketsMaxTextBox.Location = new System.Drawing.Point(331, 39);
            this.socketsMaxTextBox.Name = "socketsMaxTextBox";
            this.socketsMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.socketsMaxTextBox.TabIndex = 11;
            // 
            // socketsMinTextBox
            // 
            this.socketsMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.socketsMinTextBox.Location = new System.Drawing.Point(287, 39);
            this.socketsMinTextBox.Name = "socketsMinTextBox";
            this.socketsMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.socketsMinTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sockets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Links";
            // 
            // linksMinTextBox
            // 
            this.linksMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.linksMinTextBox.Location = new System.Drawing.Point(287, 75);
            this.linksMinTextBox.Name = "linksMinTextBox";
            this.linksMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.linksMinTextBox.TabIndex = 15;
            // 
            // linksMaxTextBox
            // 
            this.linksMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.linksMaxTextBox.Location = new System.Drawing.Point(331, 75);
            this.linksMaxTextBox.Name = "linksMaxTextBox";
            this.linksMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.linksMaxTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Level/Tier";
            // 
            // levelMinTextBox
            // 
            this.levelMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelMinTextBox.Location = new System.Drawing.Point(287, 112);
            this.levelMinTextBox.Name = "levelMinTextBox";
            this.levelMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.levelMinTextBox.TabIndex = 18;
            // 
            // levelMaxTextBox
            // 
            this.levelMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelMaxTextBox.Location = new System.Drawing.Point(331, 112);
            this.levelMaxTextBox.Name = "levelMaxTextBox";
            this.levelMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.levelMaxTextBox.TabIndex = 17;
            // 
            // iLvlMaxTextBox
            // 
            this.iLvlMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iLvlMaxTextBox.Location = new System.Drawing.Point(331, 152);
            this.iLvlMaxTextBox.Name = "iLvlMaxTextBox";
            this.iLvlMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.iLvlMaxTextBox.TabIndex = 20;
            // 
            // iLvlMinTextBox
            // 
            this.iLvlMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iLvlMinTextBox.Location = new System.Drawing.Point(287, 152);
            this.iLvlMinTextBox.Name = "iLvlMinTextBox";
            this.iLvlMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.iLvlMinTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ItemLevel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quality";
            // 
            // qualityMinTextBox
            // 
            this.qualityMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qualityMinTextBox.Location = new System.Drawing.Point(287, 192);
            this.qualityMinTextBox.Name = "qualityMinTextBox";
            this.qualityMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.qualityMinTextBox.TabIndex = 24;
            // 
            // qualityMaxTextBox
            // 
            this.qualityMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qualityMaxTextBox.Location = new System.Drawing.Point(331, 192);
            this.qualityMaxTextBox.Name = "qualityMaxTextBox";
            this.qualityMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.qualityMaxTextBox.TabIndex = 23;
            // 
            // addAffixButton
            // 
            this.addAffixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAffixButton.Location = new System.Drawing.Point(242, 73);
            this.addAffixButton.Name = "addAffixButton";
            this.addAffixButton.Size = new System.Drawing.Size(101, 26);
            this.addAffixButton.TabIndex = 26;
            this.addAffixButton.Text = "Add Affix";
            this.addAffixButton.UseVisualStyleBackColor = true;
            this.addAffixButton.Click += new System.EventHandler(this.Add_Affix_Btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Explicit Mod";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Value";
            // 
            // modMinTextBox1
            // 
            this.modMinTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modMinTextBox1.Location = new System.Drawing.Point(87, 29);
            this.modMinTextBox1.Name = "modMinTextBox1";
            this.modMinTextBox1.ReadOnly = true;
            this.modMinTextBox1.Size = new System.Drawing.Size(38, 20);
            this.modMinTextBox1.TabIndex = 30;
            // 
            // modMaxTextBox1
            // 
            this.modMaxTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modMaxTextBox1.Location = new System.Drawing.Point(131, 29);
            this.modMaxTextBox1.Name = "modMaxTextBox1";
            this.modMaxTextBox1.ReadOnly = true;
            this.modMaxTextBox1.Size = new System.Drawing.Size(38, 20);
            this.modMaxTextBox1.TabIndex = 29;
            // 
            // affixPanel
            // 
            this.affixPanel.AutoSize = true;
            this.affixPanel.Controls.Add(this.modPanel1);
            this.affixPanel.Controls.Add(this.addAffixButton);
            this.affixPanel.Location = new System.Drawing.Point(395, 39);
            this.affixPanel.Name = "affixPanel";
            this.affixPanel.Size = new System.Drawing.Size(373, 121);
            this.affixPanel.TabIndex = 32;
            // 
            // modPanel1
            // 
            this.modPanel1.Controls.Add(this.modComboBox1);
            this.modPanel1.Controls.Add(this.label12);
            this.modPanel1.Controls.Add(this.modMaxTextBox1);
            this.modPanel1.Controls.Add(this.modMinTextBox1);
            this.modPanel1.Controls.Add(this.label11);
            this.modPanel1.Location = new System.Drawing.Point(3, 3);
            this.modPanel1.Name = "modPanel1";
            this.modPanel1.Size = new System.Drawing.Size(367, 59);
            this.modPanel1.TabIndex = 33;
            // 
            // modComboBox1
            // 
            this.modComboBox1.FormattingEnabled = true;
            this.modComboBox1.Location = new System.Drawing.Point(87, 3);
            this.modComboBox1.Name = "modComboBox1";
            this.modComboBox1.Size = new System.Drawing.Size(277, 21);
            this.modComboBox1.TabIndex = 45;
            this.modComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // evasionMinTextBox
            // 
            this.evasionMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.evasionMinTextBox.Location = new System.Drawing.Point(97, 192);
            this.evasionMinTextBox.Name = "evasionMinTextBox";
            this.evasionMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.evasionMinTextBox.TabIndex = 38;
            // 
            // evasionMaxTextBox
            // 
            this.evasionMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.evasionMaxTextBox.Location = new System.Drawing.Point(141, 192);
            this.evasionMaxTextBox.Name = "evasionMaxTextBox";
            this.evasionMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.evasionMaxTextBox.TabIndex = 37;
            // 
            // energyShieldMinTextBox
            // 
            this.energyShieldMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.energyShieldMinTextBox.Location = new System.Drawing.Point(97, 152);
            this.energyShieldMinTextBox.Name = "energyShieldMinTextBox";
            this.energyShieldMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.energyShieldMinTextBox.TabIndex = 36;
            // 
            // energyShieldMaxTextBox
            // 
            this.energyShieldMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.energyShieldMaxTextBox.Location = new System.Drawing.Point(141, 152);
            this.energyShieldMaxTextBox.Name = "energyShieldMaxTextBox";
            this.energyShieldMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.energyShieldMaxTextBox.TabIndex = 35;
            // 
            // armorMinTextBox
            // 
            this.armorMinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.armorMinTextBox.Location = new System.Drawing.Point(97, 112);
            this.armorMinTextBox.Name = "armorMinTextBox";
            this.armorMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.armorMinTextBox.TabIndex = 34;
            // 
            // armorMaxTextBox
            // 
            this.armorMaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.armorMaxTextBox.Location = new System.Drawing.Point(141, 112);
            this.armorMaxTextBox.Name = "armorMaxTextBox";
            this.armorMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.armorMaxTextBox.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(21, 421);
            this.panel3.MaximumSize = new System.Drawing.Size(928, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 250);
            this.panel3.TabIndex = 39;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.whisperButton);
            this.panel4.Controls.Add(this.explicitModHeaderLabel);
            this.panel4.Controls.Add(this.priceLabel);
            this.panel4.Controls.Add(this.sellerLabel);
            this.panel4.Controls.Add(this.modsLabel);
            this.panel4.Controls.Add(this.ilvlLabel);
            this.panel4.Controls.Add(this.levelLabel);
            this.panel4.Controls.Add(this.baseLabel);
            this.panel4.Controls.Add(this.nameLabel);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(6, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 188);
            this.panel4.TabIndex = 0;
            // 
            // explicitModHeaderLabel
            // 
            this.explicitModHeaderLabel.AutoSize = true;
            this.explicitModHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicitModHeaderLabel.Location = new System.Drawing.Point(397, 10);
            this.explicitModHeaderLabel.Name = "explicitModHeaderLabel";
            this.explicitModHeaderLabel.Size = new System.Drawing.Size(87, 16);
            this.explicitModHeaderLabel.TabIndex = 9;
            this.explicitModHeaderLabel.Text = "Explicit Mods";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(752, 33);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 16);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerLabel.Location = new System.Drawing.Point(752, 10);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(43, 16);
            this.sellerLabel.TabIndex = 7;
            this.sellerLabel.Text = "Seller";
            // 
            // modsLabel
            // 
            this.modsLabel.AutoSize = true;
            this.modsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modsLabel.Location = new System.Drawing.Point(397, 33);
            this.modsLabel.Name = "modsLabel";
            this.modsLabel.Size = new System.Drawing.Size(80, 16);
            this.modsLabel.TabIndex = 6;
            this.modsLabel.Text = "Mod Anchor";
            // 
            // ilvlLabel
            // 
            this.ilvlLabel.AutoSize = true;
            this.ilvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilvlLabel.Location = new System.Drawing.Point(155, 79);
            this.ilvlLabel.Name = "ilvlLabel";
            this.ilvlLabel.Size = new System.Drawing.Size(24, 16);
            this.ilvlLabel.TabIndex = 5;
            this.ilvlLabel.Text = "Ilvl";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(155, 56);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(41, 16);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(155, 33);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(40, 16);
            this.baseLabel.TabIndex = 3;
            this.baseLabel.Text = "Base";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(155, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(811, 209);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 36);
            this.clearButton.TabIndex = 40;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(811, 263);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(116, 36);
            this.stopButton.TabIndex = 41;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueComboBox.FormattingEnabled = true;
            this.leagueComboBox.Location = new System.Drawing.Point(811, 44);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(121, 21);
            this.leagueComboBox.TabIndex = 42;
            // 
            // corrComboBox
            // 
            this.corrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.corrComboBox.FormattingEnabled = true;
            this.corrComboBox.Location = new System.Drawing.Point(811, 91);
            this.corrComboBox.Name = "corrComboBox";
            this.corrComboBox.Size = new System.Drawing.Size(121, 21);
            this.corrComboBox.TabIndex = 43;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTextBox.Location = new System.Drawing.Point(96, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // baseComboBox
            // 
            this.baseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.baseComboBox.FormattingEnabled = true;
            this.baseComboBox.Location = new System.Drawing.Point(97, 75);
            this.baseComboBox.Name = "baseComboBox";
            this.baseComboBox.Size = new System.Drawing.Size(99, 21);
            this.baseComboBox.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enchantComboBox);
            this.panel1.Controls.Add(this.enchantValueLabel);
            this.panel1.Controls.Add(this.enchantMaxTextBox);
            this.panel1.Controls.Add(this.enchantMinTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 59);
            this.panel1.TabIndex = 46;
            // 
            // enchantComboBox
            // 
            this.enchantComboBox.FormattingEnabled = true;
            this.enchantComboBox.Location = new System.Drawing.Point(84, 3);
            this.enchantComboBox.Name = "enchantComboBox";
            this.enchantComboBox.Size = new System.Drawing.Size(277, 21);
            this.enchantComboBox.TabIndex = 45;
            this.enchantComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // enchantValueLabel
            // 
            this.enchantValueLabel.AutoSize = true;
            this.enchantValueLabel.Location = new System.Drawing.Point(44, 32);
            this.enchantValueLabel.Name = "enchantValueLabel";
            this.enchantValueLabel.Size = new System.Drawing.Size(34, 13);
            this.enchantValueLabel.TabIndex = 31;
            this.enchantValueLabel.Text = "Value";
            // 
            // enchantMaxTextBox
            // 
            this.enchantMaxTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enchantMaxTextBox.Location = new System.Drawing.Point(128, 29);
            this.enchantMaxTextBox.Name = "enchantMaxTextBox";
            this.enchantMaxTextBox.ReadOnly = true;
            this.enchantMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.enchantMaxTextBox.TabIndex = 29;
            // 
            // enchantMinTextBox
            // 
            this.enchantMinTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enchantMinTextBox.Location = new System.Drawing.Point(84, 29);
            this.enchantMinTextBox.Name = "enchantMinTextBox";
            this.enchantMinTextBox.ReadOnly = true;
            this.enchantMinTextBox.Size = new System.Drawing.Size(38, 20);
            this.enchantMinTextBox.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Enchant";
            // 
            // whisperButton
            // 
            this.whisperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whisperButton.Location = new System.Drawing.Point(724, 116);
            this.whisperButton.Name = "whisperButton";
            this.whisperButton.Size = new System.Drawing.Size(108, 44);
            this.whisperButton.TabIndex = 10;
            this.whisperButton.Text = "Whisper";
            this.whisperButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(970, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baseComboBox);
            this.Controls.Add(this.corrComboBox);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evasionMinTextBox);
            this.Controls.Add(this.evasionMaxTextBox);
            this.Controls.Add(this.energyShieldMinTextBox);
            this.Controls.Add(this.energyShieldMaxTextBox);
            this.Controls.Add(this.armorMinTextBox);
            this.Controls.Add(this.armorMaxTextBox);
            this.Controls.Add(this.affixPanel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qualityMinTextBox);
            this.Controls.Add(this.qualityMaxTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iLvlMinTextBox);
            this.Controls.Add(this.iLvlMaxTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.levelMinTextBox);
            this.Controls.Add(this.levelMaxTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linksMinTextBox);
            this.Controls.Add(this.linksMaxTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.socketsMinTextBox);
            this.Controls.Add(this.socketsMaxTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.snipeButton);
            this.MaximumSize = new System.Drawing.Size(986, 930);
            this.Name = "Form1";
            this.Text = "PathofStash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.affixPanel.ResumeLayout(false);
            this.modPanel1.ResumeLayout(false);
            this.modPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snipeButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox socketsMaxTextBox;
        private TextBox socketsMinTextBox;
        private Label label6;
        private Label label7;
        private TextBox linksMinTextBox;
        private TextBox linksMaxTextBox;
        private Label label8;
        private TextBox levelMinTextBox;
        private TextBox levelMaxTextBox;
        private TextBox iLvlMaxTextBox;
        private TextBox iLvlMinTextBox;
        private Label label9;
        private Label label10;
        private TextBox qualityMinTextBox;
        private TextBox qualityMaxTextBox;
        private Button addAffixButton;
        private System.ServiceProcess.ServiceController serviceController1;
        private Label label11;
        private Label label12;
        private TextBox modMinTextBox1;
        private TextBox modMaxTextBox1;
        private Panel affixPanel;
        private Panel modPanel1;
        private TextBox evasionMinTextBox;
        private TextBox evasionMaxTextBox;
        private TextBox energyShieldMinTextBox;
        private TextBox energyShieldMaxTextBox;
        private TextBox armorMinTextBox;
        private TextBox armorMaxTextBox;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label nameLabel;
        private Button clearButton;
        private Button stopButton;
        private ComboBox leagueComboBox;
        private ComboBox corrComboBox;
        private TextBox nameTextBox;
        private ComboBox baseComboBox;
        private Label levelLabel;
        private Label baseLabel;
        private Label priceLabel;
        private Label sellerLabel;
        private Label modsLabel;
        private Label ilvlLabel;
        private ComboBox modComboBox1;
        private Panel panel1;
        private ComboBox enchantComboBox;
        private Label enchantValueLabel;
        private TextBox enchantMaxTextBox;
        private TextBox enchantMinTextBox;
        private Label label14;
        private Label explicitModHeaderLabel;
        private Button whisperButton;
    }
}
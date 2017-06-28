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
            this.explicitMod1TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.value1MinTextBox = new System.Windows.Forms.TextBox();
            this.value1MaxTextBox = new System.Windows.Forms.TextBox();
            this.affixPanel = new System.Windows.Forms.Panel();
            this.modPanel1 = new System.Windows.Forms.Panel();
            this.evasionMinTextBox = new System.Windows.Forms.TextBox();
            this.evasionMaxTextBox = new System.Windows.Forms.TextBox();
            this.energyShieldMinTextBox = new System.Windows.Forms.TextBox();
            this.energyShieldMaxTextBox = new System.Windows.Forms.TextBox();
            this.armorMinTextBox = new System.Windows.Forms.TextBox();
            this.armorMaxTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.corrComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.affixPanel.SuspendLayout();
            this.modPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // snipeButton
            // 
            this.snipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snipeButton.Location = new System.Drawing.Point(832, 360);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // explicitMod1TextBox
            // 
            this.explicitMod1TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.explicitMod1TextBox.Location = new System.Drawing.Point(87, 3);
            this.explicitMod1TextBox.Name = "explicitMod1TextBox";
            this.explicitMod1TextBox.Size = new System.Drawing.Size(264, 20);
            this.explicitMod1TextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Explicit Mod";
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            // value1MinTextBox
            // 
            this.value1MinTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.value1MinTextBox.Location = new System.Drawing.Point(87, 29);
            this.value1MinTextBox.Name = "value1MinTextBox";
            this.value1MinTextBox.Size = new System.Drawing.Size(38, 20);
            this.value1MinTextBox.TabIndex = 30;
            // 
            // value1MaxTextBox
            // 
            this.value1MaxTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.value1MaxTextBox.Location = new System.Drawing.Point(131, 29);
            this.value1MaxTextBox.Name = "value1MaxTextBox";
            this.value1MaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.value1MaxTextBox.TabIndex = 29;
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
            this.affixPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // modPanel1
            // 
            this.modPanel1.Controls.Add(this.explicitMod1TextBox);
            this.modPanel1.Controls.Add(this.label12);
            this.modPanel1.Controls.Add(this.value1MaxTextBox);
            this.modPanel1.Controls.Add(this.value1MinTextBox);
            this.modPanel1.Controls.Add(this.label11);
            this.modPanel1.Location = new System.Drawing.Point(3, 3);
            this.modPanel1.Name = "modPanel1";
            this.modPanel1.Size = new System.Drawing.Size(367, 59);
            this.modPanel1.TabIndex = 33;
            this.modPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(39, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 183);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 116);
            this.panel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 110);
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
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(832, 306);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(116, 36);
            this.addItemButton.TabIndex = 40;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.Add_Item_Btn_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(832, 410);
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
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(97, 75);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(99, 21);
            this.typeComboBox.TabIndex = 44;
            this.typeComboBox.TextUpdate += new System.EventHandler(this.comboBox3_TextUpdate);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "label15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 706);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.corrComboBox);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.addItemButton);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.affixPanel.ResumeLayout(false);
            this.modPanel1.ResumeLayout(false);
            this.modPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private TextBox explicitMod1TextBox;
        private Label label11;
        private Label label12;
        private TextBox value1MinTextBox;
        private TextBox value1MaxTextBox;
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
        private Label label13;
        private Button addItemButton;
        private Button stopButton;
        private ComboBox leagueComboBox;
        private ComboBox corrComboBox;
        private TextBox nameTextBox;
        private ComboBox typeComboBox;
        private Label label15;
        private Label label14;
    }
}
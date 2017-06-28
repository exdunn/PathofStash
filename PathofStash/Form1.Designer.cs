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
            this.Snipe_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Add_Affix_Btn = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Item_Btn = new System.Windows.Forms.Button();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Snipe_Btn
            // 
            this.Snipe_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snipe_Btn.Location = new System.Drawing.Point(832, 360);
            this.Snipe_Btn.Name = "Snipe_Btn";
            this.Snipe_Btn.Size = new System.Drawing.Size(116, 36);
            this.Snipe_Btn.TabIndex = 0;
            this.Snipe_Btn.Text = "Snipe";
            this.Snipe_Btn.UseVisualStyleBackColor = true;
            this.Snipe_Btn.Click += new System.EventHandler(this.Snipe_Btn_Click);
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
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.Location = new System.Drawing.Point(331, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(38, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.Location = new System.Drawing.Point(287, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(38, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox8.Location = new System.Drawing.Point(287, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(38, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox9.Location = new System.Drawing.Point(331, 75);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(38, 20);
            this.textBox9.TabIndex = 14;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
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
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox10.Location = new System.Drawing.Point(287, 112);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(38, 20);
            this.textBox10.TabIndex = 18;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox11.Location = new System.Drawing.Point(331, 112);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(38, 20);
            this.textBox11.TabIndex = 17;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox13.Location = new System.Drawing.Point(331, 152);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(38, 20);
            this.textBox13.TabIndex = 20;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox12.Location = new System.Drawing.Point(287, 152);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(38, 20);
            this.textBox12.TabIndex = 21;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox14.Location = new System.Drawing.Point(287, 192);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(38, 20);
            this.textBox14.TabIndex = 24;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox15.Location = new System.Drawing.Point(331, 192);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(38, 20);
            this.textBox15.TabIndex = 23;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // Add_Affix_Btn
            // 
            this.Add_Affix_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Affix_Btn.Location = new System.Drawing.Point(242, 73);
            this.Add_Affix_Btn.Name = "Add_Affix_Btn";
            this.Add_Affix_Btn.Size = new System.Drawing.Size(101, 26);
            this.Add_Affix_Btn.TabIndex = 26;
            this.Add_Affix_Btn.Text = "Add Affix";
            this.Add_Affix_Btn.UseVisualStyleBackColor = true;
            this.Add_Affix_Btn.Click += new System.EventHandler(this.Add_Affix_Btn_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox16.Location = new System.Drawing.Point(87, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(264, 20);
            this.textBox16.TabIndex = 27;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
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
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox17.Location = new System.Drawing.Point(87, 29);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(38, 20);
            this.textBox17.TabIndex = 30;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox18.Location = new System.Drawing.Point(131, 29);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(38, 20);
            this.textBox18.TabIndex = 29;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Add_Affix_Btn);
            this.panel1.Location = new System.Drawing.Point(395, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 121);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 59);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Location = new System.Drawing.Point(97, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 38;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Location = new System.Drawing.Point(141, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 37;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(97, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 20);
            this.textBox5.TabIndex = 36;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox19.Location = new System.Drawing.Point(141, 152);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(38, 20);
            this.textBox19.TabIndex = 35;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox20.Location = new System.Drawing.Point(97, 112);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(38, 20);
            this.textBox20.TabIndex = 34;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox21.Location = new System.Drawing.Point(141, 112);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(38, 20);
            this.textBox21.TabIndex = 33;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
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
            this.label13.Location = new System.Drawing.Point(181, 13);
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
            // Add_Item_Btn
            // 
            this.Add_Item_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Item_Btn.Location = new System.Drawing.Point(832, 306);
            this.Add_Item_Btn.Name = "Add_Item_Btn";
            this.Add_Item_Btn.Size = new System.Drawing.Size(116, 36);
            this.Add_Item_Btn.TabIndex = 40;
            this.Add_Item_Btn.Text = "Add Item";
            this.Add_Item_Btn.UseVisualStyleBackColor = true;
            this.Add_Item_Btn.Click += new System.EventHandler(this.Add_Item_Btn_Click);
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Btn.Location = new System.Drawing.Point(832, 410);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(116, 36);
            this.Stop_Btn.TabIndex = 41;
            this.Stop_Btn.Text = "Stop";
            this.Stop_Btn.UseVisualStyleBackColor = true;
            this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(811, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(811, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.Text = "Corrupted";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTextBox.Location = new System.Drawing.Point(96, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(97, 75);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 21);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.TextUpdate += new System.EventHandler(this.comboBox3_TextUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 706);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Stop_Btn);
            this.Controls.Add(this.Add_Item_Btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Snipe_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Snipe_Btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label6;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox12;
        private Label label9;
        private Label label10;
        private TextBox textBox14;
        private TextBox textBox15;
        private Button Add_Affix_Btn;
        private System.ServiceProcess.ServiceController serviceController1;
        private TextBox textBox16;
        private Label label11;
        private Label label12;
        private TextBox textBox17;
        private TextBox textBox18;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label13;
        private Button Add_Item_Btn;
        private Button Stop_Btn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox nameTextBox;
        private ComboBox comboBox3;
    }
}
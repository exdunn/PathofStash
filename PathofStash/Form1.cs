using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PathofStash.Data_Beans;
using System.Threading;

namespace PathofStash
{
    public partial class Form1 : Form
    {
        int affixCount;
        int itemCount;
        bool isResetting;
        Sniper sniper;
        object snipeLock = new Object();
        Query query = new Query();

        public Form1()
        { 
            InitializeComponent();
            affixCount = 1;
            itemCount = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            sniper = new Sniper(this);
            DropDownListInit();
        }

        #region public methods

        public void AddMatch(Item item)
        {
            Invoke((MethodInvoker)delegate
            {
                //create new elements for item panel
                var newPanel = new Panel();
                var newPictureBox = new PictureBox();
                var newNameLabel = new Label();

                // set size and text for panel elements
                newPictureBox.Size = pictureBox1.Size;
                newPictureBox.Load(item.icon);
                newNameLabel.Text = item.name;
                newPanel.Size = panel4.Size;

                // add elements to new panel
                newPanel.Controls.Add(newPictureBox);
                newPanel.Controls.Add(newNameLabel);

                // set location of new elements
                newPictureBox.Location = pictureBox1.Location;
                newNameLabel.Location = label13.Location;

                // add new panel to item panel
                panel3.Controls.Add(newPanel);

                // set location of new panel
                newPanel.Location = new Point(6, panel4.Size.Height * (itemCount++));
            });
        }

        #endregion

        #region private methods

        private void DropDownListInit()
        {
            foreach (string league in Globals.LEAGUES)
            {
                comboBox1.Items.Add(league);
            }
        }

        #endregion

        #region button callbacks

        private void Snipe_Btn_Click(object sender, EventArgs e)
        {
            lock(snipeLock)
            {
                sniper.sniping = true;
                Thread thread = new Thread(sniper.StartSniping);
                thread.Start();
            }
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            lock (snipeLock)
            {
                sniper.sniping = false;
                Console.WriteLine("Stopping sniper...");
            }
        }

        private void Add_Affix_Btn_Click(object sender, EventArgs e)
        {
            if (++affixCount > 6)
            {
                return;
            }

            // create panel and elements for the new mod
            var newPanel = new Panel();
            var newModLabel = new Label();
            var newModText = new TextBox();
            var newValueLabel = new Label();
            var newMinText = new TextBox();
            var newMaxText = new TextBox();
            
            // set labels
            newModLabel.Text = "Explicit Mod";
            newValueLabel.Text = "Value";

            // set size of text
            newPanel.Size = panel2.Size;
            newModText.Size = textBox16.Size;
            newMinText.Size = textBox17.Size;
            newMaxText.Size = textBox18.Size;

            // add elements to the new panel
            newPanel.Controls.Add(newModText);
            newPanel.Controls.Add(newModLabel);
            newPanel.Controls.Add(newMinText);
            newPanel.Controls.Add(newMaxText);
            newPanel.Controls.Add(newValueLabel);

            // set location of new elements
            newModLabel.Location = label11.Location;
            newModText.Location = textBox16.Location;
            newValueLabel.Location = label12.Location;
            newMinText.Location = textBox17.Location;
            newMaxText.Location = textBox18.Location;  

            // add new panel to panel1
            panel1.Controls.Add(newPanel);
            newPanel.Location = new Point(24, newPanel.Size.Height * (affixCount - 1));

            // move button down
            Add_Affix_Btn.Location = new Point(Add_Affix_Btn.Location.X, + Add_Affix_Btn.Location.Y + newPanel.Size.Height);
        }

        private void Add_Item_Btn_Click(object sender, EventArgs e)
        {
            // add query to sniper
            if (!query.Equals(null))
            {
                sniper.AddQuery(query);
            }

            // remove affix elements in affix panel
            foreach (Control item in panel1.Controls)
            {
                if (!(item is Button))
                {
                    if (!item.Name.Equals("panel2"))
                    {
                        item.Dispose();
                    }
                }   
            }

            // reset textboxes
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    //item.Text = "";
                }
            }

            affixCount = 1;
            Add_Affix_Btn.Location = new Point(242, 73);
            query = new Query();
        }

        #endregion

        #region label callbacks

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region textbox callbacks

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.name = text.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.type = text.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.armorMin = Convert.ToInt32(text.Text);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.armorMax = Convert.ToInt32(text.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.energyShieldMin = Convert.ToInt32(text.Text);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.energyShieldMax = Convert.ToInt32(text.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.evasionMin = Convert.ToInt32(text.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.evasionMax = Convert.ToInt32(text.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.levelMin = Convert.ToInt32(text.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.levelMax = Convert.ToInt32(text.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.iLvlMin = Convert.ToInt32(text.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.IlvlMax = Convert.ToInt32(text.Text);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.qualityMin = Convert.ToInt32(text.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
            TextBox text = sender as TextBox;
            query.qualityMax = Convert.ToInt32(text.Text);
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (isResetting)
            {
                return;
            }
        }

        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region combobox callbacks

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            query.league = combo.Text;
        }

        #endregion
    }
}

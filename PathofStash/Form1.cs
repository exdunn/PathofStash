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
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PathofStash
{
    public partial class Form1 : Form
    {
        int affixCount;
        int itemCount;
        bool isResetting;
        Sniper sniper;
        string[] bases;
        object snipeLock = new Object();

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
            bases = Utilities.DeserializeJson("../../Resources/bases.json");
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
                leagueComboBox.Items.Add(league);
            }
            leagueComboBox.SelectedIndex = 0;

            corrComboBox.Items.Add("Corrupted");
            corrComboBox.Items.Add("Uncorrupted");
        }

        private static void ClearComboBox(ComboBox cb)
        {
            if (cb.Items.Count <= 0)
            {
                return;
            }
           foreach (var item in new System.Collections.ArrayList(cb.Items))
            {
                try
                {
                    cb.Items.Remove(item);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.ToString());
                }
            }
        }

        // returns list of strings based on input for autocomplete functionality of bases TextBox
        private List<string> SuggestBases(string input)
        {
            List<string> matches = new List<string>();
            foreach (string item in bases)
            {
                Match match = Regex.Match(item, "(?i)" + input);
                if (match.Success)
                {
                    matches.Add(item);
                }
            }
            return matches;
        }

        #endregion

        #region button callbacks

        private void Snipe_Btn_Click(object sender, EventArgs e)
        {
            lock (snipeLock)
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
            newPanel.Size = modPanel1.Size;
            newModText.Size = explicitMod1TextBox.Size;
            newMinText.Size = value1MinTextBox.Size;
            newMaxText.Size = value1MaxTextBox.Size;

            // add elements to the new panel
            newPanel.Controls.Add(newModText);
            newPanel.Controls.Add(newModLabel);
            newPanel.Controls.Add(newMinText);
            newPanel.Controls.Add(newMaxText);
            newPanel.Controls.Add(newValueLabel);

            // set location of new elements
            newModLabel.Location = label11.Location;
            newModText.Location = explicitMod1TextBox.Location;
            newValueLabel.Location = label12.Location;
            newMinText.Location = value1MinTextBox.Location;
            newMaxText.Location = value1MaxTextBox.Location;

            // add new panel to panel1
            affixPanel.Controls.Add(newPanel);
            newPanel.Location = new Point(modPanel1.Location.X, newPanel.Size.Height * (affixCount - 1));

            // move button down
            addAffixButton.Location = new Point(addAffixButton.Location.X, +addAffixButton.Location.Y + newPanel.Size.Height);
        }

        private void Add_Item_Btn_Click(object sender, EventArgs e)
        {
            // if user hasn't added any parameters then ignore query
            bool empty = true;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (!string.IsNullOrEmpty(control.Text))
                    {
                        empty = false;
                    }
                }
            }
            if(!string.IsNullOrEmpty(typeComboBox.Text))
            {
                empty = false;
            }
            if (empty)
            {

                MessageBox.Show("Your search is empty.  Add requirements before adding a query.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // if form isn't empty then add a new query
            Query query = new Query();
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                Console.WriteLine("name: " + nameTextBox.Text);
                query.name = nameTextBox.Text;
            }
            if (!string.IsNullOrEmpty(typeComboBox.Text))
            {
                Console.WriteLine("base: " + typeComboBox.Text);
                query.league = typeComboBox.Text;
            }
            if (!string.IsNullOrEmpty(armorMinTextBox.Text))
            {
                Console.WriteLine("armorMin: " + armorMinTextBox.Text);
                query.league = armorMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(armorMaxTextBox.Text))
            {
                Console.WriteLine("armorMax: " + armorMaxTextBox.Text);
                query.league = armorMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(energyShieldMinTextBox.Text))
            {
                query.league = energyShieldMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(energyShieldMaxTextBox.Text))
            {
                query.league = energyShieldMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(evasionMinTextBox.Text))
            {
                query.league = evasionMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(evasionMaxTextBox.Text))
            {
                query.league = evasionMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMinTextBox.Text))
            {
                query.league = socketsMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMaxTextBox.Text))
            {
                query.league = socketsMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(levelMinTextBox.Text))
            {
                query.league = levelMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(levelMaxTextBox.Text))
            {
                query.league = levelMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(iLvlMinTextBox.Text))
            {
                query.league = iLvlMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(iLvlMaxTextBox.Text))
            {
                query.league = iLvlMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(qualityMinTextBox.Text))
            {
                query.league = qualityMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(qualityMaxTextBox.Text))
            {
                query.league = qualityMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(corrComboBox.Text))
            {
                query.corrupted = corrComboBox.Text;
            }
            if (!string.IsNullOrEmpty(leagueComboBox.Text))
            {
                query.league = leagueComboBox.Text;
            }

            // remove all controls in affix panel except button
            affixPanel.Controls.Remove(addAffixButton);
            affixPanel.Controls.Remove(modPanel1);
            affixPanel.Controls.Clear();
            affixPanel.Controls.Add(addAffixButton);
            affixPanel.Controls.Add(modPanel1);

            // reset textboxes
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    //item.Text = "";
                }
            }

            affixCount = 1;
            addAffixButton.Location = new Point(242, 73);
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

        private void comboBox3_TextUpdate(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            ClearComboBox(combo);

            if (combo.Text.Length >= 3)
            {
                List<string> matches = SuggestBases(combo.Text);
                foreach (string match in matches)
                {
                    combo.Items.Add(match);
                }
            }
        }
    }

    #endregion
}

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

namespace PathofStash {
    public partial class Form1 : Form {
        int affixCount;
        int itemCount;
        Font labelFont1;
        Font labelFont2;
        Sniper sniper;
        string[] bases;
        JsonMod[] explicitMods;
        List<QueryModifier> queryMods = new List<QueryModifier>();
        object snipeLock = new Object();

        public Form1() {
            InitializeComponent();
            affixCount = 1;
            itemCount = 0;
        }

        private void Form1_Load(object sender, EventArgs e) {
            panel4.Visible = false;
            sniper = new Sniper(this);
            labelFont1 = new Font("Microsoft Sans Serifs", 10);
            labelFont2 = new Font("Microsoft Sans Serifs", 12);
            bases = Utilities.DeserializeJson<string>("../../Resources/bases.json");
            explicitMods = Utilities.DeserializeJson<JsonMod>("../../Resources/mods.json");
            DropDownListInit();
        }

        #region public methods

        public void AddMatch(Item item) {
            Invoke((MethodInvoker)delegate {
                //create new elements for item panel
                var newPanel = new Panel();
                var newPictureBox = new PictureBox();
                var newNameLabel = new Label();
                var newBaseLabel = new Label();
                var newLevelLabel = new Label();
                var newILvlLabel = new Label();
                var newSellerLabel = new Label();
                var newPriceLabel = new Label();
                List<Label> explicitModLabels = new List<Label>();

                // set size and text for panel elements
                newNameLabel.AutoSize = true;
                newNameLabel.Font = labelFont2;
                newNameLabel.ForeColor = GetItemColor(item.frameType);
                newPictureBox.Size = pictureBox1.Size;
                newPictureBox.Load(item.icon);
                newNameLabel.Text = item.name;
                newBaseLabel.Text = item.typeLine;
                newLevelLabel.Text = "Level: " + item.level;
                newILvlLabel.Text = "ilvl: " + item.iLvl;
                newSellerLabel.Text = "Seller: " + item.seller;
                newPriceLabel.Text = "Price: " + item.price;
                newPanel.Size = panel4.Size;

                // add elements to new panel
                newPanel.Controls.Add(newPictureBox);
                newPanel.Controls.Add(newNameLabel);
                newPanel.Controls.Add(newBaseLabel);
                newPanel.Controls.Add(newLevelLabel);
                newPanel.Controls.Add(newILvlLabel);
                newPanel.Controls.Add(newSellerLabel);
                newPanel.Controls.Add(newPriceLabel);

                // set location of new elements
                newPictureBox.Location = pictureBox1.Location;
                newNameLabel.Location = nameLabel.Location;
                newBaseLabel.Location = baseLabel.Location;
                newILvlLabel.Location = ilvlLabel.Location;
                newLevelLabel.Location = levelLabel.Location;
                newSellerLabel.Location = sellerLabel.Location;
                newPriceLabel.Location = priceLabel.Location;

                // add explicit mods Labels
                int i = 0;
                foreach (Modifier mod in item.explicitMods) {
                    var newModLabel = new Label();
                    newModLabel.AutoSize = true;
                    newModLabel.Text = mod.ToString();
                    newPanel.Controls.Add(newModLabel);
                    newModLabel.Location = new Point(modsLabel.Location.X,
                        modsLabel.Location.Y + 30 * i++);

                }

                // add new panel to item panel
                panel3.Controls.Add(newPanel);

                // set location of new panel
                newPanel.Location = new Point(6, panel4.Size.Height * (itemCount++));
            });
        }

        #endregion

        #region private methods

        private Color GetItemColor(int input) {
            switch (input) {
                case 0:
                    return Color.FromArgb(255, 200, 200, 200);
                case 1:
                    return Color.FromArgb(255, 136, 136, 255);
                case 2:
                    return Color.FromArgb(255, 255, 255, 119);
                case 3:
                    return Color.FromArgb(255, 175, 96, 37);
                case 4:
                    return Color.FromArgb(255, 27, 162, 155);
                case 5:
                    return Color.FromArgb(255, 170, 158, 130);
                case 6:
                    return Color.FromArgb(255, 14, 186, 255);
                case 8:
                    return Color.FromArgb(255, 208, 32, 144);
                case 9:
                    return Color.FromArgb(255, 50, 230, 100);
                default:
                    return Color.FromArgb(255, 200, 200, 200);

            }
        }

        private void DropDownListInit() {
            leagueComboBox.DataSource = Globals.LEAGUES;
            baseComboBox.DataSource = bases;
            baseComboBox.SelectedIndex = -1;
            modComboBox1.DataSource = Array.ConvertAll(explicitMods, x => x.mod);
            modComboBox1.SelectedIndex = -1;
            corrComboBox.Items.Add("Corrupted");
            corrComboBox.Items.Add("Uncorrupted");
        }

        private static void ClearComboBox(ComboBox cb) {
            if (cb.Items.Count <= 0) {
                return;
            }
            foreach (var item in new System.Collections.ArrayList(cb.Items)) {
                try {
                    cb.Items.Remove(item);
                } catch (Exception e) {
                    Console.WriteLine("Error: " + e.ToString());
                }
            }
        }

        private void ResetForm() {

            // remove all controls in affix panel except button
            affixPanel.Controls.Remove(addAffixButton);
            affixPanel.Controls.Remove(modPanel1);
            affixPanel.Controls.Clear();
            affixPanel.Controls.Add(addAffixButton);
            affixPanel.Controls.Add(modPanel1);
            modComboBox1.SelectedIndex = -1;

            // reset textboxes
            foreach (Control item in this.Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
            }

            affixCount = 1;
            addAffixButton.Location = new Point(242, 73);
        }

        private Control FindControlRecursive(Control root, string name) {
            if (root.Name == name) {
                return root;
            }

            foreach (Control c in root.Controls) {
                Control t = FindControlRecursive(c, name);
                if (t != null) {
                    return t;
                }
            }

            return null;
        }

        #endregion

        #region button callbacks

        private void Snipe_Btn_Click(object sender, EventArgs e) {
            // if user hasn't added any parameters then ignore query
            bool empty = true;
            foreach (Control control in Controls) {
                if (control is TextBox) {
                    if (!string.IsNullOrEmpty(control.Text)) {
                        empty = false;
                    }
                }
            }

            if (!string.IsNullOrEmpty(baseComboBox.Text)) {
                empty = false;
            }

            if (empty) {
                MessageBox.Show("Your search is empty.  Add requirements before adding a query.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // if form isn't empty then add a new query
            Query query = new Query();
            if (!string.IsNullOrEmpty(nameTextBox.Text)) {
                query.name = nameTextBox.Text;
            }
            if (!string.IsNullOrEmpty(baseComboBox.Text)) {
                query.type = baseComboBox.Text;
            }
            if (!string.IsNullOrEmpty(armorMinTextBox.Text)) {
                query.armorMin = armorMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(armorMaxTextBox.Text)) {
                query.armorMax = armorMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(energyShieldMinTextBox.Text)) {
                query.energyShieldMin = energyShieldMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(energyShieldMaxTextBox.Text)) {
                query.energyShieldMax = energyShieldMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(evasionMinTextBox.Text)) {
                query.evasionMin = evasionMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(evasionMaxTextBox.Text)) {
                query.evasionMax = evasionMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMinTextBox.Text)) {
                query.socketsMin = socketsMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMaxTextBox.Text)) {
                query.socketsMax = socketsMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(levelMinTextBox.Text)) {
                query.levelMin = levelMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(levelMaxTextBox.Text)) {
                query.levelMax = levelMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(iLvlMinTextBox.Text)) {
                query.iLvlMin = iLvlMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(iLvlMaxTextBox.Text)) {
                query.ilvlMax = iLvlMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(qualityMinTextBox.Text)) {
                query.qualityMin = qualityMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(qualityMaxTextBox.Text)) {
                query.qualityMax = qualityMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(corrComboBox.Text)) {
                query.corrupted = corrComboBox.Text;
            }
            if (!string.IsNullOrEmpty(leagueComboBox.Text)) {
                query.league = leagueComboBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMinTextBox.Text)) {
                query.socketsMin = socketsMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(socketsMaxTextBox.Text)) {
                query.socketsMax = socketsMaxTextBox.Text;
            }
            if (!string.IsNullOrEmpty(linksMinTextBox.Text)) {
                query.linksMin = linksMinTextBox.Text;
            }
            if (!string.IsNullOrEmpty(linksMaxTextBox.Text)) {
                query.linksMax = linksMaxTextBox.Text;
            }
            for (int i = 1; i < affixCount + 1; i++) {
                string mod = FindControlRecursive(affixPanel, "modComboBox" + i.ToString()).Text;
                string min = FindControlRecursive(affixPanel, "modMinTextBox" + i.ToString()).Text;
                string max = FindControlRecursive(affixPanel, "modMaxTextBox" + i.ToString()).Text;

                if (!string.IsNullOrEmpty(mod)) {
                    QueryModifier queryMod = new QueryModifier();
                    queryMod.mod = mod;
                    if (!string.IsNullOrEmpty(min) || !string.IsNullOrEmpty(max)) {
                        if (!string.IsNullOrEmpty(min)) {
                            queryMod.min = Convert.ToDouble(min);
                        }
                        if (!string.IsNullOrEmpty(max)) {
                            queryMod.max = Convert.ToDouble(max);
                        }
                        query.AddExplicitMod(queryMod);
                    }
                }
            }
            query.Print();
            sniper.query = query;

            if (Globals.TESTMODE) {
                sniper.TestSnipe();
            } else {
                lock (snipeLock) {
                    sniper.sniping = true;
                    Thread thread = new Thread(sniper.StartSniping);
                    thread.Start();
                }

            }
            ResetForm();
        }

        private void Stop_Btn_Click(object sender, EventArgs e) {
            lock (snipeLock) {
                sniper.sniping = false;
                Console.WriteLine("Stopping sniper...");
            }
        }

        private void Add_Affix_Btn_Click(object sender, EventArgs e) {
            if (affixCount >= 6) {
                return;
            }
            affixCount++;

            // create panel and elements for the new mod
            var newPanel = new Panel();
            var newModLabel = new Label();
            var newModComboBox = new ComboBox();
            var newValueLabel = new Label();
            var newMinText = new TextBox();
            var newMaxText = new TextBox();

            // set panel
            newPanel.Size = modPanel1.Size;
            newModLabel.Text = "Explicit Mod";
            newValueLabel.Text = "Value";
            newModComboBox.Name = "modComboBox" + affixCount.ToString();
            newMinText.Name = "modMinTextBox" + affixCount.ToString();
            newMaxText.Name = "modMaxTextBox" + affixCount.ToString();
            newModComboBox.Size = modComboBox1.Size;
            newModComboBox.DataSource = Array.ConvertAll(explicitMods, x => x.mod);
            newMinText.Size = modMinTextBox1.Size;
            newMaxText.Size = modMaxTextBox1.Size;

            // add elements to the new panel
            newPanel.Controls.Add(newModComboBox);
            newPanel.Controls.Add(newModLabel);
            newPanel.Controls.Add(newMinText);
            newPanel.Controls.Add(newMaxText);
            newPanel.Controls.Add(newValueLabel);

            // set location of new elements
            newModLabel.Location = label11.Location;
            newModComboBox.Location = modComboBox1.Location;
            newValueLabel.Location = label12.Location;
            newMinText.Location = modMinTextBox1.Location;
            newMaxText.Location = modMaxTextBox1.Location;

            // add new panel to panel1
            affixPanel.Controls.Add(newPanel);
            newPanel.Location = new Point(modPanel1.Location.X, newPanel.Size.Height * (affixCount - 1));

            // clear mod  ComboBox text
            newModComboBox.SelectedIndex = -1;

            // move button down
            addAffixButton.Location = new Point(addAffixButton.Location.X, +addAffixButton.Location.Y + newPanel.Size.Height);
        }

        private void clearButton_Click(object sender, EventArgs e) {
            ResetForm();
        }

        #endregion

    }
}

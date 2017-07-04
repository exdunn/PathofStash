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
using System.Net;
using System.IO;

namespace PathofStash {
    public partial class Form1 : Form {
        int affixCount;
        int itemCount;
        Size defaultSize;
        Font labelFont1;
        Font labelFont2;
        Sniper sniper;
        System.Windows.Forms.Timer rotationTimer = new System.Windows.Forms.Timer();
        string[] bases;
        JsonMod[] explicitMods;
        JsonMod[] enchants;
        List<Image> iconList = new List<Image>();
        List<QueryModifier> queryMods = new List<QueryModifier>();
        object snipeLock = new Object();
        List<Item> matches = new List<Item>();

        public Form1() {
            InitializeComponent();
            affixCount = 1;
            itemCount = 0;
            defaultSize = this.Size;
            foreach (string item in Globals.CURRICONS) {
                iconList.Add(Image.FromFile(item));
            }
            snipingPictureBox.Image = iconList[0];
            snipingPictureBox.Size = snipingPictureBox.Image.Size;
            rotationTimer.Interval = 150;
            rotationTimer.Tick += rotationTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e) {
            panel4.Visible = false;
            sniper = new Sniper(this);
            labelFont1 = new Font("Fontin", 10, FontStyle.Underline);
            labelFont2 = new Font("Fontin", 12);      
            bases = Utilities.DeserializeJson<string>("Resources/bases.json");
            explicitMods = Array.FindAll(
                Utilities.DeserializeJson<JsonMod>("Resources/mods.json"),
                x => x.type.Equals("explicit", StringComparison.CurrentCultureIgnoreCase));
            enchants = Array.FindAll(
                Utilities.DeserializeJson<JsonMod>("Resources/mods.json"),
                x => x.type.Equals("enchant", StringComparison.CurrentCultureIgnoreCase));
            DropDownListInit();
        }

        #region public methods

        public void UpdateMatchPanel(List<Item> matches) {

            Invoke((MethodInvoker)delegate {
                foreach (Item item in matches) {
                    //create new elements for item panel
                    var newPanel = new Panel();
                    var newPictureBox = new PictureBox();
                    var newNameLabel = new Label();
                    var newBaseLabel = new Label();
                    var newLevelLabel = new Label();
                    var newILvlLabel = new Label();
                    var newSellerLabel = new Label();
                    var newPriceLabel = new Label();
                    var newCorruptedLabel = new Label();
                    var newWhisperButton = new Button();

                    // set size and text for panel elements
                    newNameLabel.AutoSize = true;
                    newNameLabel.Font = labelFont2;
                    newNameLabel.ForeColor = GetItemColor(item.frameType);
                    newPictureBox.Size = pictureBox1.Size;
                    newPictureBox.Load(item.icon);
                    Padding pad = new Padding();
                    pad.Left = (newPictureBox.Width - newPictureBox.Image.Width) / 2;
                    pad.Top = (newPictureBox.Height - newPictureBox.Image.Height) / 2;
                    newPictureBox.Padding = pad;
                    newPictureBox.BorderStyle = BorderStyle.FixedSingle;
                    newPictureBox.BackColor = SystemColors.AppWorkspace;
                    newNameLabel.Text = item.name;
                    newBaseLabel.Text = item.typeLine;
                    newPriceLabel.AutoSize = true;
                    newLevelLabel.Text = "Level: " + item.level;
                    newILvlLabel.Text = "ilvl: " + item.iLvl;
                    newSellerLabel.Text = "Seller: " + item.seller;
                    newSellerLabel.AutoSize = true;
                    newPriceLabel.Text = "Price: " + item.price;
                    newPanel.BorderStyle = BorderStyle.FixedSingle;
                    newPanel.Size = panel4.Size;
                    newWhisperButton.Location = whisperButton.Location;
                    newWhisperButton.Size = whisperButton.Size;
                    newWhisperButton.Text = "Whisper";
                    newWhisperButton.Font = labelFont2;
                    newWhisperButton.MouseClick += new MouseEventHandler((sender, e) => whisperButton_MouseClick(sender, e, item));
                    newWhisperButton.Parent = newPanel;

                    // set location of new elements
                    newPictureBox.Location = pictureBox1.Location;
                    newNameLabel.Location = nameLabel.Location;
                    newBaseLabel.Location = corruptedLabel.Location;
                    newILvlLabel.Location = ilvlLabel.Location;
                    newLevelLabel.Location = levelLabel.Location;
                    newSellerLabel.Location = sellerLabel.Location;
                    newPriceLabel.Location = priceLabel.Location;

                    if (item.corrupted) {
                        newBaseLabel.Location = baseLabel.Location;
                        newCorruptedLabel.Text = "Corrupted";
                        newCorruptedLabel.AutoSize = true;
                        newCorruptedLabel.Location = corruptedLabel.Location;
                        newCorruptedLabel.BackColor = Color.FromArgb(255, 139, 0, 0);
                        newCorruptedLabel.ForeColor = Color.White;
                        newCorruptedLabel.Parent = newPanel;
                    }

                    // add socket PictureBox
                    PictureBox socketPictureBox = new PictureBox();
                    socketPictureBox.BackColor = Color.Transparent;
                    socketPictureBox.Parent = newPictureBox;
                    newPictureBox.MouseEnter += new EventHandler(pictureBox_MouseEnter);
                    socketPictureBox.MouseLeave += new EventHandler(pictureBox_MouseLeave);
                    socketPictureBox.Location = new Point(-200, -200);
                    socketPictureBox.Image = CombineSocketsAndLinksImages(item, newPictureBox.Size.Width, newPictureBox.Size.Height);
                    socketPictureBox.Size = socketPictureBox.Image.Size;

                    // add elements to new panel
                    newPanel.Controls.Add(newPictureBox);
                    newPanel.Controls.Add(newNameLabel);
                    newPanel.Controls.Add(newBaseLabel);
                    newPanel.Controls.Add(newLevelLabel);
                    newPanel.Controls.Add(newILvlLabel);
                    newPanel.Controls.Add(newSellerLabel);
                    newPanel.Controls.Add(newPriceLabel);
                    newPanel.Controls.Add(explicitModLabel);

                    

                    // add mod labels
                    int i = 0;
                    foreach (Modifier mod in item.implicitMods) {
                        var newModLabel = new Label();
                        newModLabel.AutoSize = true;
                        newModLabel.Text = mod.ToString();
                        newModLabel.Font = labelFont1;
                        newPanel.Controls.Add(newModLabel);
                        newModLabel.Location = new Point(explicitModLabel.Location.X,
                            10 + 20 * i++);
                    }

                    foreach (Modifier mod in item.enchantMods) {
                        var newModLabel = new Label();
                        newModLabel.AutoSize = true;
                        newModLabel.Text = mod.ToString();
                        newModLabel.Font = labelFont1;
                        newPanel.Controls.Add(newModLabel);
                        newModLabel.Location = new Point(explicitModLabel.Location.X,
                            10 + 20 * i++);
                    }

                    foreach (Modifier mod in item.explicitMods) {
                        var newModLabel = new Label();
                        newModLabel.AutoSize = true;
                        newModLabel.Text = mod.ToString();
                        newPanel.Controls.Add(newModLabel);
                        newModLabel.Location = new Point(explicitModLabel.Location.X,
                            10 + 20 * i++);
                    }

                    // add new panel to item panel
                    panel3.Controls.Add(newPanel);
                    int posY = (panel4.Size.Height * itemCount++) + panel3.AutoScrollPosition.Y;

                    // set location of new panel
                    newPanel.Location = new Point(6, posY);
                } 
            });
        }

        #endregion

        #region private methods

        private static Bitmap CombineSocketsAndLinksImages(Item item, int width, int height) {
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result)) {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                // draw the images into the target bitmap
                Image sockIcon = Image.FromFile("Resources/str.png");
                for (int i = 0; i < item.sockets.Count; i++) {
                    if (item.sockets[i].attr.Equals("s", StringComparison.CurrentCultureIgnoreCase)) {
                        sockIcon = Image.FromFile("Resources/str.png");
                    } else if (item.sockets[i].attr.Equals("i", StringComparison.CurrentCultureIgnoreCase)) {
                        sockIcon = Image.FromFile("Resources/int.png");
                    } else if (item.sockets[i].attr.Equals("d", StringComparison.CurrentCultureIgnoreCase)) {
                        sockIcon = Image.FromFile("Resources/dex.png");
                    } else {
                        sockIcon = Image.FromFile("Resources/gen.png");
                    }
                    if (i == 2) {
                        graphics.DrawImage(sockIcon,
                        sockIcon.Size.Width * (3 % 2),
                        sockIcon.Size.Height * (3 / 2),
                        sockIcon.Size.Width,
                        sockIcon.Size.Height);
                    } else if (i == 3) {
                        graphics.DrawImage(sockIcon,
                        sockIcon.Size.Width * (2 % 2),
                        sockIcon.Size.Height * (2 / 2),
                        sockIcon.Size.Width,
                        sockIcon.Size.Height);
                    } else {
                        graphics.DrawImage(sockIcon,
                        sockIcon.Size.Width * (i % 2),
                        sockIcon.Size.Height * (i / 2),
                        sockIcon.Size.Width,
                        sockIcon.Size.Height);
                    }    
                }
                Image linkIcon;
                for (int i = 0; i < item.sockets.Count-1; i++) {
                    if(item.sockets[i].group == item.sockets[i+1].group) {
                        if (i == 0 || i == 2 || i == 4) {
                            linkIcon = Image.FromFile("Resources/Socket_Link_Horizontal.png");
                            graphics.DrawImage(linkIcon,
                            sockIcon.Size.Width / 2 + 5,
                            sockIcon.Size.Height * (i / 2) + 16,
                            linkIcon.Size.Width,
                            linkIcon.Size.Height);
                        } else if (i == 1) {
                            linkIcon = Image.FromFile("Resources/Socket_Link_Vertical.png");
                            graphics.DrawImage(linkIcon,
                            sockIcon.Size.Width * 1.33f,
                            sockIcon.Size.Height * 0.62f,
                            linkIcon.Size.Width,
                            linkIcon.Size.Height);
                        } else {
                            linkIcon = Image.FromFile("Resources/Socket_Link_Vertical.png");
                            graphics.DrawImage(linkIcon,
                            sockIcon.Size.Width * 0.33f,
                            sockIcon.Size.Height * 1.62f,
                            linkIcon.Size.Width,
                            linkIcon.Size.Height);
                        }
                    } 
                }
            }
            return result;
        }

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
            enchantComboBox.DataSource = Array.ConvertAll(enchants, x => x.mod);
            enchantComboBox.SelectedIndex = -1;
            corrComboBox.Items.Add("Corrupted");
            corrComboBox.Items.Add("Uncorrupted");
        }

        // clear all TextBox and ComboBox controls
        private void ResetForm() {
            // remove all controls in affix panel except button
            affixPanel.Controls.Remove(addAffixButton);
            affixPanel.Controls.Remove(modPanel1);
            affixPanel.Controls.Clear();
            affixPanel.Controls.Add(addAffixButton);
            affixPanel.Controls.Add(modPanel1);
            modComboBox1.SelectedIndex = -1;
            enchantComboBox.SelectedIndex = -1;

            // clear textboxes
            FormTraversal(this, x => {
                if (x is TextBox) {
                    x.Text = "";
                }
            });

            affixCount = 1;
            addAffixButton.Location = new Point(242, 73);
        }

        // recursive method for finding control
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

        // depth first traversal from root
        // func performs an action on each child of root
        private bool FormTraversal(Control root, Action<Control> func) {
            foreach (Control child in root.Controls) {
                func(child);
                FormTraversal(child, func);
            }
            return false;
        }

        //checks if form represents a valid query
        private void IsValidQuery(Control root, ref bool valid) {
            foreach (Control child in root.Controls) {
                if (child is TextBox && !string.IsNullOrEmpty(child.Text)) {
                    Console.WriteLine(child.Text);
                    valid = true;
                }
                IsValidQuery(child, ref valid);
            }
        }

        // load image from url
        private Image LoadImage(string url) {
            WebRequest req = WebRequest.Create(url);
            Stream stream = req.GetResponse().GetResponseStream();
            return Image.FromStream(stream);
        }

        #endregion

        #region button callbacks

        private void Snipe_Btn_Click(object sender, EventArgs e) {
            // if user hasn't added any parameters then ignore query
            bool valid = false;
            IsValidQuery(this, ref valid);

            if (!string.IsNullOrEmpty(baseComboBox.Text)) {
                valid = true;
            }
            if(!string.IsNullOrEmpty(corrComboBox.Text)) {
                valid = true;
            }
            if (!valid) {
                MessageBox.Show("Your search is empty.  Add requirements before adding a query.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            rotationTimer.Start();

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
            if (!string.IsNullOrEmpty(enchantComboBox.Text)) {
                if (!string.IsNullOrEmpty(enchantMinTextBox.Text) || !string.IsNullOrEmpty(enchantMaxTextBox.Text)) {
                    QueryModifier enchant = new QueryModifier();
                    enchant.mod = enchantComboBox.Text;
                    if (!string.IsNullOrEmpty(enchantMinTextBox.Text)) {
                        enchant.min = Convert.ToDouble(enchantMinTextBox.Text);
                    }
                    if (!string.IsNullOrEmpty(enchantMaxTextBox.Text)) {
                        enchant.max = Convert.ToDouble(enchantMaxTextBox.Text);
                    }
                    query.enchant = enchant;
                }
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
                rotationTimer.Stop();
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
            newModComboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
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
            itemCount = 0;
            panel3.Controls.Clear();
            this.Size = defaultSize;
        }

        #endregion

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            var combo = sender as ComboBox;
            var parent = combo.Parent;

            foreach (Control child in parent.Controls) {
                if (child is TextBox) {
                    if (combo.SelectedIndex >= 0) {
                        child.BackColor = SystemColors.ControlLightLight;
                        (child as TextBox).ReadOnly = false;
                    } else {
                        child.BackColor = SystemColors.ControlDark;
                        (child as TextBox).ReadOnly = true;
                    }
                }
            }
        }

        private void pictureBox_MouseEnter(Object sender, EventArgs e) {
            var pBox = sender as PictureBox;
            pBox.Controls[0].Location = pictureBox1.Location;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e) {
            var pBox = sender as PictureBox;
            pBox.Location = new Point(-200, -200);
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e) {
            Console.WriteLine("click position: " + e.Location);
        }

        private void whisperButton_MouseClick(object sender, EventArgs e, Item item) {
            Clipboard.SetText("@" + item.seller + " Hi, I would like to buy " + item.name+ " listed for " + item.price + ".");
        }

        private void rotationTimer_Tick(object sender, EventArgs e) {
            Image im = snipingPictureBox.Image;
           im.RotateFlip(RotateFlipType.Rotate270FlipNone);
            snipingPictureBox.Image = im;
        }

        private void snipingPictureBox_MouseClick(object sender, MouseEventArgs e) {
            int index = iconList.IndexOf(snipingPictureBox.Image);
            snipingPictureBox.Image = iconList[(index + 1) % iconList.Count];
        }

        private void explicitModLabel_MouseEnter(object sender, EventArgs e, Item item) {
            Control label = sender as Control;
            Panel newPanel = new Panel();
            newPanel.Name = "modsPanel";
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.AutoSize = true;
            newPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;         
            
            int i = 0;

            foreach (Modifier mod in item.implicitMods) {
                var newModLabel = new Label();
                newModLabel.AutoSize = true;
                newModLabel.Text = mod.ToString();
                newModLabel.Font = labelFont1;

                if (item.corrupted) {
                    newModLabel.ForeColor = Color.FromArgb(255, 139, 0, 0);
                }

                newPanel.Controls.Add(newModLabel);
                newModLabel.Location = new Point(0,
                    10 + 20 * i++);
            }

            foreach (Modifier mod in item.enchantMods) {
                var newModLabel = new Label();
                newModLabel.AutoSize = true;
                newModLabel.Text = mod.ToString();
                newModLabel.Font = labelFont1;
                newPanel.Controls.Add(newModLabel);
                newModLabel.Location = new Point(0,
                    10 + 20 * i++);
            }

            foreach (Modifier mod in item.explicitMods) {
                var newModLabel = new Label();
                newModLabel.AutoSize = true;
                newModLabel.Text = mod.ToString();
                newPanel.Controls.Add(newModLabel);
                newModLabel.Location = new Point(0,
                    10 + 20 * i++);
            }

            newPanel.Location = new Point(explicitModLabel.Location.X - (newPanel.Size.Width - explicitModLabel.Size.Width) / 2,
                explicitModLabel.Location.Y + 20);
            newPanel.Parent = label.Parent;
            newPanel.BringToFront();
        }

        private void explicitModLable_MouseLeave(object sender, EventArgs e) {
            Control parent = (sender as Control).Parent;
            if (parent.Controls.Find("modsPanel", true).Length > 0) {
                parent.Controls.Find("modsPanel", true)[0].Dispose();
            }
        }
    }
}

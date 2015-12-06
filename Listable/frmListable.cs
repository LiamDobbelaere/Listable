using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Digaly.ControlAnimations;
using System.IO;

namespace Listable
{
    public partial class frmListable : Form
    {
        public Color accentColor;
        public Color accentColorDark;
        public Animator anims = new Animator();
        public frmProcess Spawner;
        private bool isClosing = false;
        private bool ShowArchives = false;

        public frmListable()
        {
            InitializeComponent();

            //Animation setup with ControlAnimations
            this.Height = 300;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.TopMost = true;

            //anims.Add("Listable_open", this.MakeAnimation("Height", 300));
            anims.Add("Listable_open2", this.MakeAnimation("Left", 300));
            anims.SetStateRaw("Listable_open2", true);
            anims.Add("Listable_open3", this.MakeAnimation("Opacity", 0, 100, 0.4));

            RefreshColorScheme();
            RefreshList();

            txtNewItem.SelectionStart = 0;
            txtNewItem.SelectionLength = 0;
        }

        public void RefreshColorScheme()
        {
            if (Globals.IsWin10 & Properties.Settings.Default.UseCustomColor == false)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent", false);
                byte[] value = (byte[])key.GetValue("AccentPalette");
                accentColor = Color.FromArgb(value[12], value[13], value[14]);
                accentColorDark = Color.FromArgb(value[16], value[17], value[18]);
            }
            else
            {
                accentColor = Properties.Settings.Default.CustomColor;
                accentColorDark = Properties.Settings.Default.CustomColorAcc;
            }

            this.BackColor = accentColor;
            txtNewItem.BackColor = accentColorDark;
            btnSettings.BackColor = accentColor;
            tableLayoutPanel1.BackColor = accentColorDark;

            bool alternate = false;
            foreach (ListItem item in pnlList.Controls)
            {
                if (alternate)
                {
                    item.BackColor = accentColorDark;
                }

                alternate = !alternate;
            }

            //RefreshList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Play the slide up animation
            //anims.Toggle("Listable_open", true);
            anims.Toggle("Listable_open2", true);
            anims.Toggle("Listable_open3", true);

            RefreshList();

            //Remove the global hotkey so that you can't open another instance of the form
            Spawner.hk.Unregister();
        }

        public void RefreshList()
        {
            pnlList.Hide();
            pnlList.Controls.Clear();

            //Load in the list or create a new one if it doesn't exist
            if (!File.Exists(Properties.Settings.Default.SaveLocation))
            {
                try
                {
                    File.CreateText(Properties.Settings.Default.SaveLocation).Close();
                }
                catch (Exception) {
                    return;
                    /*Properties.Settings.Default.SaveLocation = @"C:\";
                    MessageBox.Show("The current list location isn't valid, please select a proper location from the settings screen. This should be a text file. Press OK to continue.");
                    frmSettings settings = frmSettings.GetForm;
                    settings.suParent = this;
                    settings.Location = new Point(this.Location.X - settings.Width, this.Location.Y);
                    settings.Show();*/
                }
            }

            bool alternate = false;
            string[] itemslist;
            if (ShowArchives)
            {
                string dir = Path.GetDirectoryName(Properties.Settings.Default.SaveLocation);
                string filename = Path.GetFileNameWithoutExtension(Properties.Settings.Default.SaveLocation) + "_archive.txt";
                string archpath = dir + @"\" + filename;

                itemslist = File.ReadAllLines(archpath);
            }
            else itemslist = File.ReadAllLines(Properties.Settings.Default.SaveLocation);


            foreach (string item in itemslist)
            {
                ListItem btnTest = new ListItem();
                btnTest.Location = new Point(0, this.Height);
                btnTest.Text = item;
                btnTest.Dock = DockStyle.Top;
                if (alternate)
                {
                    btnTest.BackColor = accentColorDark;
                }

                if (ShowArchives)
                    btnTest.StripButtons();

                pnlList.Controls.Add(btnTest);
                alternate = !alternate;
            }
            pnlList.Show();

        }

        private void txtNewItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                StreamWriter list = File.AppendText(Properties.Settings.Default.SaveLocation);
                list.WriteLine(txtNewItem.Text);
                list.Close();

                frmSaved savedNotification = new frmSaved();
                savedNotification.Show();

                Spawner.SafeRegisterHotkey();

                e.Handled = true;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                frmListable_KeyPress(sender, e);
            }
        }

        private void frmListable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape) & !isClosing)
            {
                //Spawner.SafeRegisterHotkey();
                isClosing = true;
                tmrClose.Enabled = true;
                tmrClose.Start();
                anims.Toggle("Listable_open2", true);
                anims.Toggle("Listable_open3", true);
                e.Handled = true;
                //this.Close();
            }
        }

        public void RemoveItemWithName(string name)
        {
            List<string> itemslist = new List<string>(File.ReadAllLines(Properties.Settings.Default.SaveLocation));
            itemslist.Remove(name);

            File.WriteAllLines(Properties.Settings.Default.SaveLocation, itemslist);

            if (Properties.Settings.Default.EnableArchiving)
            {
                string dir = Path.GetDirectoryName(Properties.Settings.Default.SaveLocation);
                string filename = Path.GetFileNameWithoutExtension(Properties.Settings.Default.SaveLocation) + "_archive.txt";
                string archpath = dir + @"\" + filename;

                if (!File.Exists(archpath))
                {
                    File.CreateText(archpath).Close();
                }

                List<string> archive = new List<string>(File.ReadAllLines(archpath));
                archive.Add(name);

                File.WriteAllLines(archpath, archive);
            }

            RefreshList();
        }

        public void PrioritizeItemWithName(string name)
        {
            List<string> itemslist = new List<string>(File.ReadAllLines(Properties.Settings.Default.SaveLocation));
            itemslist.Remove(name);
            itemslist.Add(name);

            File.WriteAllLines(Properties.Settings.Default.SaveLocation, itemslist);

            RefreshList();
        }

        private void frmListable_Leave(object sender, EventArgs e)
        {
            Spawner.SafeRegisterHotkey();
            this.Close();
        }

        private void frmListable_Deactivate(object sender, EventArgs e)
        {
            if (frmSettings.GetForm.isOpened) return;

            Spawner.SafeRegisterHotkey();

            if (!tmrClose.Enabled & !isClosing)
            {
                tmrClose.Enabled = true;
                tmrClose.Start();
                anims.Toggle("Listable_open2", true);
                anims.Toggle("Listable_open3", true);
            }
        }

        private void btnSettings_MouseClick(object sender, MouseEventArgs e)
        {
            frmSettings settings = frmSettings.GetForm;
            settings.suParent = this;
            settings.Location = new Point(this.Location.X - settings.Width, this.Location.Y);
            settings.Show();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            anims.Remove("Listable_open2");
            anims.Remove("Listable_open3");

            this.Close();
        }

        private void dyShowArchive_MouseEnter(object sender, EventArgs e)
        {
            dyShowArchive.BackColor = Color.FromArgb(224, 185, 67);
        }

        private void dyShowArchive_MouseLeave(object sender, EventArgs e)
        {
            if (!ShowArchives)
            {
                dyShowArchive.BackColor = Color.Transparent;
            }
        }

        private void dyShowArchive_Click(object sender, EventArgs e)
        {
            ShowArchives = !ShowArchives;
            RefreshList();
        }
    }
}

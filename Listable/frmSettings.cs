using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Listable
{
    public partial class frmSettings : Form
    {
        public Color accentColor;
        public Color accentColorDark;
        public frmListable suParent;
        public bool isOpened = false;

        private static frmSettings inst;
        public static frmSettings GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmSettings();
                return inst;
            }
        }

        public frmSettings()
        {
            InitializeComponent();

            RefreshColorScheme();

            txtSaveloc.Text = Properties.Settings.Default.SaveLocation;
            txtSaveloc.SelectionStart = txtSaveloc.Text.Length;
        }

        void RefreshColorScheme()
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
            //dyTitleBar.BackColor = accentColorDark;
            //lblTitle.BackColor = accentColorDark;
            txtSaveloc.BackColor = accentColorDark;
            btnBrowse.BackColor = accentColorDark;
            btnClose.BackColor = accentColorDark;
            btnClearArchives.BackColor = accentColorDark;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdSelectSave.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtSaveloc.Text = ofdSelectSave.FileName;
            }

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            chkUseCustom.Checked = Properties.Settings.Default.UseCustomColor;
            chkArchiving.Checked = Properties.Settings.Default.EnableArchiving;

            string runStart = (string)Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).GetValue("Listable");

            if (runStart == null)
            {
                chkRunStart.Checked = false;
            }
            else
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("Listable", System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                chkRunStart.Checked = true;
            }

            dyMainColor.BackColor = Properties.Settings.Default.CustomColor;
            dyAccentColor.BackColor = Properties.Settings.Default.CustomColorAcc;

            isOpened = true;
            this.TopMost = true;
        }

        private void chkUseCustom_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseCustomColor = chkUseCustom.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            RefreshColorScheme();
            suParent.RefreshColorScheme();
        }

        private void chkArchiving_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableArchiving = chkArchiving.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            suParent.RefreshList();
        }

        /*private void dyColorPicker1_SelectedColorChanged()
        {
            chkUseCustom.Checked = true;
            Properties.Settings.Default.CustomColor = dyColorPicker1.SelectedColor;
            Properties.Settings.Default.CustomColorAcc = ColorConversion.FromAhsb(255, dyColorPicker1.SelectedColor.GetHue(), dyColorPicker1.SelectedColor.GetSaturation(), 0.35f);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            RefreshColorScheme();
            suParent.RefreshColorScheme();
        }*/

        private void txtSaveloc_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveLocation = txtSaveloc.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void chkRunStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRunStart.Checked)
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Listable", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("Listable", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"");
            }
            else
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Listable", false);
            }
        }

        private void dyMainColor_Click(object sender, EventArgs e)
        {
            clrPicker.Color = Properties.Settings.Default.CustomColor;
            clrPicker.ShowDialog();
            dyMainColor.BackColor = clrPicker.Color;
            chkUseCustom.Checked = true;
            Properties.Settings.Default.CustomColor = clrPicker.Color;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            RefreshColorScheme();
            suParent.RefreshColorScheme();
        }

        private void dyAccentColor_Click(object sender, EventArgs e)
        {
            clrPicker.Color = Properties.Settings.Default.CustomColorAcc;
            clrPicker.ShowDialog();
            dyAccentColor.BackColor = clrPicker.Color;
            chkUseCustom.Checked = true;
            Properties.Settings.Default.CustomColorAcc = clrPicker.Color;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            RefreshColorScheme();
            suParent.RefreshColorScheme();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpened = false;
        }

        private void btnClearArchives_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure you want to remove all archived entries?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dlr == DialogResult.Yes)
            {
                string dir = Path.GetDirectoryName(Properties.Settings.Default.SaveLocation);
                string filename = Path.GetFileNameWithoutExtension(Properties.Settings.Default.SaveLocation) + "_archive.txt";
                string archpath = dir + @"\" + filename;

                if (File.Exists(archpath))
                {
                    File.WriteAllText(archpath, string.Empty);
                }
            }

        }
    }
}

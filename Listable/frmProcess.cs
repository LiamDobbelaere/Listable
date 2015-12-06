using MovablePython;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Listable
{
    public partial class frmProcess : Form
    {
        public Hotkey hk = new Hotkey();

        public frmProcess()
        {
            InitializeComponent();
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();

            hk.KeyCode = Keys.Up;
            hk.Alt = true;
            hk.Pressed += Listable;

            SafeRegisterHotkey();

            byte[] accents = (byte[]) Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent", false).GetValue("AccentPalette");
            if (accents != null)
            {
                Globals.IsWin10 = true;
            }
            else
            {
                Properties.Settings.Default.UseCustomColor = true;
                Properties.Settings.Default.Save();
            }
        }

        private void frmProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hk.Registered)
            {
                hk.Unregister();
            }
        }

        private void frmProcess_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        void Listable(object sender, HandledEventArgs args)
        {
            ShowListable();

            args.Handled = true;
        }

        void ShowListable()
        {
            frmListable frmListable = new frmListable();
            frmListable.Spawner = this;
            frmListable.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SafeRegisterHotkey()
        {
            if (!hk.Registered)
            {
                hk.Register(this);
            }
        }

        private void niTaskbar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void niTaskbar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowListable();
            }
        }
    }
}

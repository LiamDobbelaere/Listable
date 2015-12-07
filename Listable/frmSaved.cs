using System;
using System.Drawing;
using System.Windows.Forms;
using Digaly.ControlAnimations;
using Microsoft.Win32;

namespace Listable
{
    public partial class frmSaved : Form
    {
        public Color accentColor;
        public Color accentColorDark;
        public Animator anims = new Animator();

        public frmSaved()
        {
            InitializeComponent();

            //Animation setup with ControlAnimations
            this.Height = 64;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 64;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.TopMost = true;

            //anims.Add("Listable_open", this.MakeAnimation("Height", 64));
            anims.Add("Listable_open2", this.MakeAnimation("Left", 284));
            anims.SetStateRaw("Listable_open2", true);
            anims.Add("Listable_open3", this.MakeAnimation("Opacity", 0, 100, 0.35));

            if (Properties.Settings.Default.SaveLocation.Length < 23) {
                lblSaved.Text = "Saved to " + Properties.Settings.Default.SaveLocation;
            }
            else
            {
                lblSaved.Text = "Saved to .." + Properties.Settings.Default.SaveLocation.Substring(Properties.Settings.Default.SaveLocation.Length - 24, 24);
            }
        }

        private void frmSaved_Load(object sender, EventArgs e)
        {
            //Play the slide up animation
            //anims.Toggle("Listable_open", true);
            anims.Toggle("Listable_open2", true);
            anims.Toggle("Listable_open3", true);
            tmrClose.Start();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            //Play the slide up animation
            //anims.Toggle("Listable_open", true);
            anims.Toggle("Listable_open2", true);
            anims.Toggle("Listable_open3", true);
            tmrFullClose.Start();
        }

        private void tmrFullClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

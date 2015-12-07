using System;
using System.Drawing;
using System.Windows.Forms;
using Digaly.ControlAnimations;

namespace Listable
{
    public partial class ListItem : UserControl
    {
        protected Animator anims = new Animator();
        bool isOpen = false;

        public ListItem()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                lblItem.Text = value;
            }
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip labelTip = new ToolTip();

            // Set up the delays for the ToolTip.
            labelTip.AutoPopDelay = 0;
            labelTip.InitialDelay = 1000;
            labelTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            labelTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            labelTip.SetToolTip(this.lblItem, Text);

            if (Properties.Settings.Default.EnableArchiving)
            {
                btnDelete.ButtonImage = Properties.Resources.archive;
            }

            using (Graphics g = CreateGraphics())
            {
                int charsfilled = 0;
                int linesfilled = 0;
                SizeF size = g.MeasureString(lblItem.Text, lblItem.Font, lblItem.Size, StringFormat.GenericDefault, out charsfilled, out linesfilled);
                if (linesfilled > 1)
                {
                    //anims.Add("openclose", this.MakeAnimation("Height", (int) size.Height - this.Height + 4));
                    if (lblItem.Text.Length > 50)
                    {
                        anims.Add("openclose", this.MakeAnimation("Height", (int) size.Height - (int) this.Height + 8));
                    }
                    else
                    {
                        this.Height = (int)size.Height + 8;
                    }
                }
            }

        }

        private void dyFlatButton1_Click_1(object sender, EventArgs e)
        {
            frmListable parent = (frmListable) this.ParentForm;
            parent.RemoveItemWithName(Text);
        }

        void OpenIfNecessary()
        {
            if (isOpen)
            {
                anims.SetState("openclose", false);
                isOpen = false;
            }
            else
            {
                using (Graphics g = CreateGraphics())
                {
                    SizeF size = g.MeasureString(lblItem.Text, lblItem.Font, lblItem.MaximumSize.Width);
                    if (size.Height > this.Height)
                    {
                        anims.SetState("openclose", true);
                        isOpen = true;
                    }
                }
            }
        }

        private void ListItem_MouseClick(object sender, MouseEventArgs e)
        {
            OpenIfNecessary();
        }

        private void lblItem_MouseClick(object sender, MouseEventArgs e)
        {
            OpenIfNecessary();
        }

        private void dyFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableArchiving)
            {
                btnDelete.BackColor = Globals.ArchiveColor;
            }
            else
            {
                btnDelete.BackColor = Color.FromArgb(224, 67, 67);
            }
        }

        private void dyFlatButton1_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }

        private void dyFlatButton2_Click(object sender, EventArgs e)
        {
            frmListable parent = (frmListable)this.ParentForm;
            parent.PrioritizeItemWithName(Text);
            Dispose();
        }

        public void StripButtons()
        {
            btnDelete.Dispose();
            btnPriority.Dispose();
        }
    }
}

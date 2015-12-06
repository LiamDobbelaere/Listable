namespace Listable
{
    partial class frmProcess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.niTaskbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // niTaskbar
            // 
            this.niTaskbar.ContextMenuStrip = this.cmsNotify;
            this.niTaskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("niTaskbar.Icon")));
            this.niTaskbar.Text = "Shift Up";
            this.niTaskbar.Visible = true;
            this.niTaskbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niTaskbar_MouseClick);
            this.niTaskbar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTaskbar_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(68, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmProcess";
            this.ShowInTaskbar = false;
            this.Text = "frmProcess";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProcess_FormClosing);
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.Shown += new System.EventHandler(this.frmProcess_Shown);
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon niTaskbar;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
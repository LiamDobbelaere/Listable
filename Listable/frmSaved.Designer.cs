namespace Listable
{
    partial class frmSaved
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
            this.lblSaved = new System.Windows.Forms.Label();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.tmrFullClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSaved
            // 
            this.lblSaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaved.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.ForeColor = System.Drawing.Color.White;
            this.lblSaved.Location = new System.Drawing.Point(0, 0);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(284, 64);
            this.lblSaved.TabIndex = 0;
            this.lblSaved.Text = "Saved!";
            this.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 2500;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // tmrFullClose
            // 
            this.tmrFullClose.Interval = 400;
            this.tmrFullClose.Tick += new System.EventHandler(this.tmrFullClose_Tick);
            // 
            // frmSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 64);
            this.Controls.Add(this.lblSaved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaved";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSaved";
            this.Load += new System.EventHandler(this.frmSaved_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.Timer tmrFullClose;
    }
}
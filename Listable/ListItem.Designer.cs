namespace Listable
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItem = new System.Windows.Forms.Label();
            this.btnPriority = new wclDigaly.dyFlatButton();
            this.btnDelete = new wclDigaly.dyFlatButton();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.White;
            this.lblItem.Location = new System.Drawing.Point(0, 0);
            this.lblItem.Margin = new System.Windows.Forms.Padding(0);
            this.lblItem.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Padding = new System.Windows.Forms.Padding(4);
            this.lblItem.Size = new System.Drawing.Size(173, 93);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "The following error was encountered: TF400813: Resource not available for anonymo" +
    "us access. Client authentication required.";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblItem_MouseClick);
            // 
            // btnPriority
            // 
            this.btnPriority.BackgroundImage = null;
            this.btnPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPriority.BorderWidth = 0;
            this.btnPriority.ButtonImage = global::Listable.Properties.Resources.priority;
            this.btnPriority.ColorIcons = false;
            this.btnPriority.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnPriority.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPriority.ImagePadding = null;
            this.btnPriority.Inverted = false;
            this.btnPriority.Location = new System.Drawing.Point(437, 0);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(0);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.ScaleIcons = false;
            this.btnPriority.Size = new System.Drawing.Size(35, 29);
            this.btnPriority.TabIndex = 3;
            this.btnPriority.Click += new System.EventHandler(this.dyFlatButton2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = null;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.BorderWidth = 0;
            this.btnDelete.ButtonImage = global::Listable.Properties.Resources.delete;
            this.btnDelete.ColorIcons = false;
            this.btnDelete.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.ImagePadding = null;
            this.btnDelete.Inverted = false;
            this.btnDelete.Location = new System.Drawing.Point(472, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ScaleIcons = false;
            this.btnDelete.Size = new System.Drawing.Size(35, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Click += new System.EventHandler(this.dyFlatButton1_Click_1);
            this.btnDelete.MouseEnter += new System.EventHandler(this.dyFlatButton1_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.dyFlatButton1_MouseLeave);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnDelete);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(507, 29);
            this.Load += new System.EventHandler(this.ListItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wclDigaly.dyFlatButton btnPriority;
        private wclDigaly.dyFlatButton btnDelete;
        private System.Windows.Forms.Label lblItem;
    }
}

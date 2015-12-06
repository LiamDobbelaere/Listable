namespace Listable
{
    partial class frmListable
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dyShowArchive = new wclDigaly.dyFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bwWaitForAnim = new System.ComponentModel.BackgroundWorker();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new wclDigaly.dyFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Listable";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewItem
            // 
            this.txtNewItem.AcceptsReturn = true;
            this.txtNewItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewItem.ForeColor = System.Drawing.Color.White;
            this.txtNewItem.Location = new System.Drawing.Point(28, 4);
            this.txtNewItem.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(220, 18);
            this.txtNewItem.TabIndex = 1;
            this.txtNewItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewItem_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.dyShowArchive, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewItem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 27);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dyShowArchive
            // 
            this.dyShowArchive.BackgroundImage = null;
            this.dyShowArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dyShowArchive.BorderWidth = 0;
            this.dyShowArchive.ButtonImage = global::Listable.Properties.Resources.archive;
            this.dyShowArchive.ColorIcons = false;
            this.dyShowArchive.ColorIconsColor = System.Drawing.Color.Empty;
            this.dyShowArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dyShowArchive.ForeColor = System.Drawing.Color.White;
            this.dyShowArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dyShowArchive.ImagePadding = null;
            this.dyShowArchive.Inverted = false;
            this.dyShowArchive.Location = new System.Drawing.Point(248, 4);
            this.dyShowArchive.Margin = new System.Windows.Forms.Padding(0);
            this.dyShowArchive.Name = "dyShowArchive";
            this.dyShowArchive.ScaleIcons = false;
            this.dyShowArchive.Size = new System.Drawing.Size(32, 19);
            this.dyShowArchive.TabIndex = 5;
            this.dyShowArchive.Click += new System.EventHandler(this.dyShowArchive_Click);
            this.dyShowArchive.MouseEnter += new System.EventHandler(this.dyShowArchive_MouseEnter);
            this.dyShowArchive.MouseLeave += new System.EventHandler(this.dyShowArchive_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Listable.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 18);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(8, 79);
            this.pnlList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlList.Size = new System.Drawing.Size(284, 229);
            this.pnlList.TabIndex = 3;
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 400;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = null;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.BorderWidth = 0;
            this.btnSettings.ButtonImage = global::Listable.Properties.Resources.settings;
            this.btnSettings.ColorIcons = false;
            this.btnSettings.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.ImagePadding = null;
            this.btnSettings.Inverted = false;
            this.btnSettings.Location = new System.Drawing.Point(246, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ScaleIcons = false;
            this.btnSettings.Size = new System.Drawing.Size(35, 33);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseClick);
            // 
            // frmListable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 308);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListable";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(8, 16, 8, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.frmListable_Deactivate);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmListable_KeyPress);
            this.Leave += new System.EventHandler(this.frmListable_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bwWaitForAnim;
        private System.Windows.Forms.Panel pnlList;
        private wclDigaly.dyFlatButton btnSettings;
        private System.Windows.Forms.Timer tmrClose;
        private wclDigaly.dyFlatButton dyShowArchive;
    }
}


namespace Listable
{
    partial class frmSettings
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
            this.txtSaveloc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new wclDigaly.dyFlatButton();
            this.ofdSelectSave = new System.Windows.Forms.OpenFileDialog();
            this.lblCustomColor = new System.Windows.Forms.Label();
            this.chkUseCustom = new System.Windows.Forms.CheckBox();
            this.chkRunStart = new System.Windows.Forms.CheckBox();
            this.clrPicker = new System.Windows.Forms.ColorDialog();
            this.dyMainColor = new wclDigaly.dyFlatButton();
            this.dyAccentColor = new wclDigaly.dyFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new wclDigaly.dyFlatButton();
            this.chkArchiving = new System.Windows.Forms.CheckBox();
            this.btnClearArchives = new wclDigaly.dyFlatButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSaveloc
            // 
            this.txtSaveloc.AcceptsReturn = true;
            this.txtSaveloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveloc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveloc.ForeColor = System.Drawing.Color.White;
            this.txtSaveloc.Location = new System.Drawing.Point(15, 36);
            this.txtSaveloc.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.txtSaveloc.Name = "txtSaveloc";
            this.txtSaveloc.Size = new System.Drawing.Size(278, 25);
            this.txtSaveloc.TabIndex = 2;
            this.txtSaveloc.Text = "Save location";
            this.txtSaveloc.TextChanged += new System.EventHandler(this.txtSaveloc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "List file location:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Green;
            this.btnBrowse.BackgroundImage = null;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowse.BorderWidth = 4;
            this.btnBrowse.ButtonImage = null;
            this.btnBrowse.ColorIcons = false;
            this.btnBrowse.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.ImagePadding = null;
            this.btnBrowse.Inverted = false;
            this.btnBrowse.Location = new System.Drawing.Point(296, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ScaleIcons = true;
            this.btnBrowse.Size = new System.Drawing.Size(65, 25);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdSelectSave
            // 
            this.ofdSelectSave.CheckFileExists = false;
            this.ofdSelectSave.FileName = "openFileDialog1";
            // 
            // lblCustomColor
            // 
            this.lblCustomColor.AutoSize = true;
            this.lblCustomColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomColor.ForeColor = System.Drawing.Color.White;
            this.lblCustomColor.Location = new System.Drawing.Point(12, 206);
            this.lblCustomColor.Name = "lblCustomColor";
            this.lblCustomColor.Size = new System.Drawing.Size(125, 17);
            this.lblCustomColor.TabIndex = 6;
            this.lblCustomColor.Text = "Select custom color:";
            // 
            // chkUseCustom
            // 
            this.chkUseCustom.AutoSize = true;
            this.chkUseCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUseCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseCustom.ForeColor = System.Drawing.Color.White;
            this.chkUseCustom.Location = new System.Drawing.Point(15, 97);
            this.chkUseCustom.Name = "chkUseCustom";
            this.chkUseCustom.Size = new System.Drawing.Size(126, 21);
            this.chkUseCustom.TabIndex = 7;
            this.chkUseCustom.Text = "Use custom color";
            this.chkUseCustom.UseVisualStyleBackColor = true;
            this.chkUseCustom.CheckedChanged += new System.EventHandler(this.chkUseCustom_CheckedChanged);
            // 
            // chkRunStart
            // 
            this.chkRunStart.AutoSize = true;
            this.chkRunStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRunStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRunStart.ForeColor = System.Drawing.Color.White;
            this.chkRunStart.Location = new System.Drawing.Point(15, 124);
            this.chkRunStart.Name = "chkRunStart";
            this.chkRunStart.Size = new System.Drawing.Size(110, 21);
            this.chkRunStart.TabIndex = 8;
            this.chkRunStart.Text = "Run on startup";
            this.chkRunStart.UseVisualStyleBackColor = true;
            this.chkRunStart.CheckedChanged += new System.EventHandler(this.chkRunStart_CheckedChanged);
            // 
            // clrPicker
            // 
            this.clrPicker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clrPicker.FullOpen = true;
            // 
            // dyMainColor
            // 
            this.dyMainColor.BackColor = System.Drawing.Color.Green;
            this.dyMainColor.BackgroundImage = null;
            this.dyMainColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dyMainColor.BorderWidth = 4;
            this.dyMainColor.ButtonImage = null;
            this.dyMainColor.ColorIcons = false;
            this.dyMainColor.ColorIconsColor = System.Drawing.Color.Empty;
            this.dyMainColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dyMainColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyMainColor.ForeColor = System.Drawing.Color.White;
            this.dyMainColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dyMainColor.ImagePadding = null;
            this.dyMainColor.Inverted = false;
            this.dyMainColor.Location = new System.Drawing.Point(5, 5);
            this.dyMainColor.Name = "dyMainColor";
            this.dyMainColor.ScaleIcons = true;
            this.dyMainColor.Size = new System.Drawing.Size(42, 40);
            this.dyMainColor.TabIndex = 9;
            this.dyMainColor.Click += new System.EventHandler(this.dyMainColor_Click);
            // 
            // dyAccentColor
            // 
            this.dyAccentColor.BackColor = System.Drawing.Color.Green;
            this.dyAccentColor.BackgroundImage = null;
            this.dyAccentColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dyAccentColor.BorderWidth = 4;
            this.dyAccentColor.ButtonImage = null;
            this.dyAccentColor.ColorIcons = false;
            this.dyAccentColor.ColorIconsColor = System.Drawing.Color.Empty;
            this.dyAccentColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dyAccentColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyAccentColor.ForeColor = System.Drawing.Color.White;
            this.dyAccentColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dyAccentColor.ImagePadding = null;
            this.dyAccentColor.Inverted = false;
            this.dyAccentColor.Location = new System.Drawing.Point(53, 5);
            this.dyAccentColor.Name = "dyAccentColor";
            this.dyAccentColor.ScaleIcons = true;
            this.dyAccentColor.Size = new System.Drawing.Size(42, 40);
            this.dyAccentColor.TabIndex = 10;
            this.dyAccentColor.Click += new System.EventHandler(this.dyAccentColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(143, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 50);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dyMainColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dyAccentColor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 50);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.BackgroundImage = null;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.BorderWidth = 4;
            this.btnClose.ButtonImage = null;
            this.btnClose.ColorIcons = false;
            this.btnClose.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImagePadding = null;
            this.btnClose.Inverted = false;
            this.btnClose.Location = new System.Drawing.Point(292, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.ScaleIcons = true;
            this.btnClose.Size = new System.Drawing.Size(69, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkArchiving
            // 
            this.chkArchiving.AutoSize = true;
            this.chkArchiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkArchiving.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArchiving.ForeColor = System.Drawing.Color.White;
            this.chkArchiving.Location = new System.Drawing.Point(15, 151);
            this.chkArchiving.Name = "chkArchiving";
            this.chkArchiving.Size = new System.Drawing.Size(291, 21);
            this.chkArchiving.TabIndex = 13;
            this.chkArchiving.Text = "Archive notes instead of permanently deleting";
            this.chkArchiving.UseVisualStyleBackColor = true;
            this.chkArchiving.CheckedChanged += new System.EventHandler(this.chkArchiving_CheckedChanged);
            // 
            // btnClearArchives
            // 
            this.btnClearArchives.BackColor = System.Drawing.Color.Green;
            this.btnClearArchives.BackgroundImage = null;
            this.btnClearArchives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearArchives.BorderWidth = 4;
            this.btnClearArchives.ButtonImage = null;
            this.btnClearArchives.ColorIcons = false;
            this.btnClearArchives.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnClearArchives.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearArchives.ForeColor = System.Drawing.Color.White;
            this.btnClearArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearArchives.ImagePadding = null;
            this.btnClearArchives.Inverted = false;
            this.btnClearArchives.Location = new System.Drawing.Point(12, 178);
            this.btnClearArchives.Name = "btnClearArchives";
            this.btnClearArchives.ScaleIcons = true;
            this.btnClearArchives.Size = new System.Drawing.Size(93, 25);
            this.btnClearArchives.TabIndex = 14;
            this.btnClearArchives.Text = "Clear archives";
            this.btnClearArchives.Click += new System.EventHandler(this.btnClearArchives_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(12, 64);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(340, 17);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "Changes only visible after hiding and re-opening Listable";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(373, 300);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnClearArchives);
            this.Controls.Add(this.chkArchiving);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkRunStart);
            this.Controls.Add(this.chkUseCustom);
            this.Controls.Add(this.lblCustomColor);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveloc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSaveloc;
        private System.Windows.Forms.Label label1;
        private wclDigaly.dyFlatButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdSelectSave;
        private System.Windows.Forms.Label lblCustomColor;
        private System.Windows.Forms.CheckBox chkUseCustom;
        private System.Windows.Forms.CheckBox chkRunStart;
        private System.Windows.Forms.ColorDialog clrPicker;
        private wclDigaly.dyFlatButton dyMainColor;
        private wclDigaly.dyFlatButton dyAccentColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private wclDigaly.dyFlatButton btnClose;
        private System.Windows.Forms.CheckBox chkArchiving;
        private wclDigaly.dyFlatButton btnClearArchives;
        private System.Windows.Forms.Label lblNote;
    }
}
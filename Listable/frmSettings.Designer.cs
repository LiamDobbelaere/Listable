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
            this.chkUseCustom = new wclDigaly.dyCheckbox();
            this.chkRunStart = new wclDigaly.dyCheckbox();
            this.clrPicker = new System.Windows.Forms.ColorDialog();
            this.btnClose = new wclDigaly.dyFlatButton();
            this.chkArchiving = new wclDigaly.dyCheckbox();
            this.btnClearArchives = new wclDigaly.dyFlatButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.dyCustomCol = new wclDigaly.dyColorPicker();
            this.SuspendLayout();
            // 
            // txtSaveloc
            // 
            this.txtSaveloc.AcceptsReturn = true;
            this.txtSaveloc.BackColor = global::Listable.Properties.Settings.Default.CustomColorAcc;
            this.txtSaveloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveloc.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Listable.Properties.Settings.Default, "CustomColorAcc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.btnBrowse.BackColor = global::Listable.Properties.Settings.Default.CustomColorAcc;
            this.btnBrowse.BackgroundImage = null;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowse.BorderWidth = 0;
            this.btnBrowse.ButtonImage = null;
            this.btnBrowse.ColorIcons = false;
            this.btnBrowse.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnBrowse.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Listable.Properties.Settings.Default, "CustomColorAcc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.lblCustomColor.Location = new System.Drawing.Point(12, 175);
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
            // btnClose
            // 
            this.btnClose.BackColor = global::Listable.Properties.Settings.Default.CustomColorAcc;
            this.btnClose.BackgroundImage = null;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.BorderWidth = 0;
            this.btnClose.ButtonImage = null;
            this.btnClose.ColorIcons = false;
            this.btnClose.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnClose.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Listable.Properties.Settings.Default, "CustomColorAcc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.chkArchiving.Size = new System.Drawing.Size(222, 21);
            this.chkArchiving.TabIndex = 13;
            this.chkArchiving.Text = "Archive entries instead of deleting";
            this.chkArchiving.UseVisualStyleBackColor = true;
            this.chkArchiving.CheckedChanged += new System.EventHandler(this.chkArchiving_CheckedChanged);
            // 
            // btnClearArchives
            // 
            this.btnClearArchives.BackColor = global::Listable.Properties.Settings.Default.CustomColorAcc;
            this.btnClearArchives.BackgroundImage = null;
            this.btnClearArchives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearArchives.BorderWidth = 0;
            this.btnClearArchives.ButtonImage = null;
            this.btnClearArchives.ColorIcons = false;
            this.btnClearArchives.ColorIconsColor = System.Drawing.Color.Empty;
            this.btnClearArchives.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Listable.Properties.Settings.Default, "CustomColorAcc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClearArchives.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearArchives.ForeColor = System.Drawing.Color.White;
            this.btnClearArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearArchives.ImagePadding = null;
            this.btnClearArchives.Inverted = false;
            this.btnClearArchives.Location = new System.Drawing.Point(243, 151);
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
            this.lblNote.Size = new System.Drawing.Size(341, 17);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "List file change is only visible after hiding and re-opening";
            // 
            // dyCustomCol
            // 
            this.dyCustomCol.BackColor = System.Drawing.Color.White;
            this.dyCustomCol.BlockSize = 25;
            this.dyCustomCol.Brightness = 75;
            this.dyCustomCol.Location = new System.Drawing.Point(15, 195);
            this.dyCustomCol.Name = "dyCustomCol";
            this.dyCustomCol.Saturation = 178;
            this.dyCustomCol.SelectedColor = System.Drawing.Color.Black;
            this.dyCustomCol.Size = new System.Drawing.Size(245, 95);
            this.dyCustomCol.Spacing = 5;
            this.dyCustomCol.TabIndex = 16;
            this.dyCustomCol.SelectedColorChanged += new wclDigaly.dyColorPicker.SelectedColorChangedEventHandler(this.dyCustomCol_SelectedColorChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Listable.Properties.Settings.Default.CustomColor;
            this.ClientSize = new System.Drawing.Size(373, 300);
            this.Controls.Add(this.dyCustomCol);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnClearArchives);
            this.Controls.Add(this.chkArchiving);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkRunStart);
            this.Controls.Add(this.chkUseCustom);
            this.Controls.Add(this.lblCustomColor);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveloc);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Listable.Properties.Settings.Default, "CustomColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSaveloc;
        private System.Windows.Forms.Label label1;
        private wclDigaly.dyFlatButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdSelectSave;
        private System.Windows.Forms.Label lblCustomColor;
        private wclDigaly.dyCheckbox chkUseCustom;
        private wclDigaly.dyCheckbox chkRunStart;
        private System.Windows.Forms.ColorDialog clrPicker;
        private wclDigaly.dyFlatButton btnClose;
        private wclDigaly.dyCheckbox chkArchiving;
        private wclDigaly.dyFlatButton btnClearArchives;
        private System.Windows.Forms.Label lblNote;
        private wclDigaly.dyColorPicker dyCustomCol;
    }
}
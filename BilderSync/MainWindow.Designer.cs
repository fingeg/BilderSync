namespace BilderSync
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Path_SdCard = new System.Windows.Forms.ComboBox();
            this.Path_aimFolder = new System.Windows.Forms.ComboBox();
            this.Search_SdCard = new System.Windows.Forms.Button();
            this.Search_aimPath = new System.Windows.Forms.Button();
            this.CB_onlyOneDay = new System.Windows.Forms.CheckBox();
            this.CoB_selectDay = new System.Windows.Forms.ComboBox();
            this.CB_compareWithAimFolder = new System.Windows.Forms.CheckBox();
            this.Btn_sync = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Path_SdCard
            // 
            this.Path_SdCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Path_SdCard.FormattingEnabled = true;
            this.Path_SdCard.Location = new System.Drawing.Point(74, 51);
            this.Path_SdCard.Name = "Path_SdCard";
            this.Path_SdCard.Size = new System.Drawing.Size(578, 24);
            this.Path_SdCard.TabIndex = 0;
            // 
            // Path_aimFolder
            // 
            this.Path_aimFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Path_aimFolder.FormattingEnabled = true;
            this.Path_aimFolder.Location = new System.Drawing.Point(74, 103);
            this.Path_aimFolder.Name = "Path_aimFolder";
            this.Path_aimFolder.Size = new System.Drawing.Size(578, 24);
            this.Path_aimFolder.TabIndex = 1;
            // 
            // Search_SdCard
            // 
            this.Search_SdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_SdCard.Location = new System.Drawing.Point(670, 51);
            this.Search_SdCard.Name = "Search_SdCard";
            this.Search_SdCard.Size = new System.Drawing.Size(121, 24);
            this.Search_SdCard.TabIndex = 2;
            this.Search_SdCard.Text = "Durchsuchen";
            this.Search_SdCard.UseVisualStyleBackColor = true;
            this.Search_SdCard.Click += new System.EventHandler(this.Search_SdCard_Click);
            // 
            // Search_aimPath
            // 
            this.Search_aimPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_aimPath.Location = new System.Drawing.Point(670, 103);
            this.Search_aimPath.Name = "Search_aimPath";
            this.Search_aimPath.Size = new System.Drawing.Size(121, 24);
            this.Search_aimPath.TabIndex = 3;
            this.Search_aimPath.Text = "Durchsuchen";
            this.Search_aimPath.UseVisualStyleBackColor = true;
            this.Search_aimPath.Click += new System.EventHandler(this.Search_aimPath_Click);
            // 
            // CB_onlyOneDay
            // 
            this.CB_onlyOneDay.AutoSize = true;
            this.CB_onlyOneDay.Location = new System.Drawing.Point(74, 150);
            this.CB_onlyOneDay.Name = "CB_onlyOneDay";
            this.CB_onlyOneDay.Size = new System.Drawing.Size(121, 21);
            this.CB_onlyOneDay.TabIndex = 4;
            this.CB_onlyOneDay.Text = "Nur einen Tag";
            this.CB_onlyOneDay.UseVisualStyleBackColor = true;
            this.CB_onlyOneDay.CheckedChanged += new System.EventHandler(this.CB_onlyOneDay_CheckedChanged);
            // 
            // CoB_selectDay
            // 
            this.CoB_selectDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoB_selectDay.FormattingEnabled = true;
            this.CoB_selectDay.Location = new System.Drawing.Point(74, 177);
            this.CoB_selectDay.Name = "CoB_selectDay";
            this.CoB_selectDay.Size = new System.Drawing.Size(121, 24);
            this.CoB_selectDay.TabIndex = 5;
            this.CoB_selectDay.Visible = false;
            // 
            // CB_compareWithAimFolder
            // 
            this.CB_compareWithAimFolder.AutoSize = true;
            this.CB_compareWithAimFolder.Location = new System.Drawing.Point(384, 150);
            this.CB_compareWithAimFolder.Name = "CB_compareWithAimFolder";
            this.CB_compareWithAimFolder.Size = new System.Drawing.Size(194, 21);
            this.CB_compareWithAimFolder.TabIndex = 6;
            this.CB_compareWithAimFolder.Text = "Mit Zielordner vergleichen";
            this.CB_compareWithAimFolder.UseVisualStyleBackColor = true;
            // 
            // Btn_sync
            // 
            this.Btn_sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sync.Location = new System.Drawing.Point(74, 227);
            this.Btn_sync.Name = "Btn_sync";
            this.Btn_sync.Size = new System.Drawing.Size(717, 61);
            this.Btn_sync.TabIndex = 7;
            this.Btn_sync.Text = "Synk";
            this.Btn_sync.UseVisualStyleBackColor = true;
            this.Btn_sync.Click += new System.EventHandler(this.Btn_sync_Click);
            // 
            // Btn_settings
            // 
            this.Btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_settings.Image = global::BilderSync.Properties.Resources.settings;
            this.Btn_settings.Location = new System.Drawing.Point(670, 150);
            this.Btn_settings.Name = "Btn_settings";
            this.Btn_settings.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_settings.Size = new System.Drawing.Size(121, 23);
            this.Btn_settings.TabIndex = 8;
            this.Btn_settings.UseVisualStyleBackColor = true;
            this.Btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(863, 340);
            this.Controls.Add(this.Btn_settings);
            this.Controls.Add(this.Btn_sync);
            this.Controls.Add(this.CB_compareWithAimFolder);
            this.Controls.Add(this.CoB_selectDay);
            this.Controls.Add(this.CB_onlyOneDay);
            this.Controls.Add(this.Search_aimPath);
            this.Controls.Add(this.Search_SdCard);
            this.Controls.Add(this.Path_aimFolder);
            this.Controls.Add(this.Path_SdCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Bilder Synk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Path_SdCard;
        private System.Windows.Forms.ComboBox Path_aimFolder;
        private System.Windows.Forms.Button Search_SdCard;
        private System.Windows.Forms.Button Search_aimPath;
        private System.Windows.Forms.CheckBox CB_onlyOneDay;
        private System.Windows.Forms.ComboBox CoB_selectDay;
        private System.Windows.Forms.CheckBox CB_compareWithAimFolder;
        private System.Windows.Forms.Button Btn_sync;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button Btn_settings;
    }
}


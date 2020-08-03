namespace BilderSync
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.btn_addFilter = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delFilter = new System.Windows.Forms.Button();
            this.lV_fileFilters = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delDirectory = new System.Windows.Forms.Button();
            this.lV_directories = new System.Windows.Forms.ListView();
            this.btn_addDirectory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addFilter
            // 
            this.btn_addFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFilter.Location = new System.Drawing.Point(127, 22);
            this.btn_addFilter.Name = "btn_addFilter";
            this.btn_addFilter.Size = new System.Drawing.Size(27, 29);
            this.btn_addFilter.TabIndex = 3;
            this.btn_addFilter.Text = "+";
            this.btn_addFilter.UseVisualStyleBackColor = true;
            this.btn_addFilter.Click += new System.EventHandler(this.btn_addFilter_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(410, 187);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(102, 28);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(298, 187);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 28);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Abbrechen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delFilter);
            this.groupBox1.Controls.Add(this.lV_fileFilters);
            this.groupBox1.Controls.Add(this.btn_addFilter);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ignorierte Dateien";
            // 
            // btn_delFilter
            // 
            this.btn_delFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delFilter.Location = new System.Drawing.Point(126, 57);
            this.btn_delFilter.Name = "btn_delFilter";
            this.btn_delFilter.Size = new System.Drawing.Size(28, 27);
            this.btn_delFilter.TabIndex = 6;
            this.btn_delFilter.Text = "-";
            this.btn_delFilter.UseVisualStyleBackColor = true;
            this.btn_delFilter.Click += new System.EventHandler(this.btn_delFilter_Click);
            // 
            // lV_fileFilters
            // 
            this.lV_fileFilters.AutoArrange = false;
            this.lV_fileFilters.LabelEdit = true;
            this.lV_fileFilters.Location = new System.Drawing.Point(6, 21);
            this.lV_fileFilters.Name = "lV_fileFilters";
            this.lV_fileFilters.Size = new System.Drawing.Size(115, 131);
            this.lV_fileFilters.TabIndex = 5;
            this.lV_fileFilters.UseCompatibleStateImageBehavior = false;
            this.lV_fileFilters.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delDirectory);
            this.groupBox2.Controls.Add(this.lV_directories);
            this.groupBox2.Controls.Add(this.btn_addDirectory);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zu dursuchende Ordner";
            // 
            // btn_delDirectory
            // 
            this.btn_delDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delDirectory.Location = new System.Drawing.Point(287, 54);
            this.btn_delDirectory.Name = "btn_delDirectory";
            this.btn_delDirectory.Size = new System.Drawing.Size(28, 27);
            this.btn_delDirectory.TabIndex = 5;
            this.btn_delDirectory.Text = "-";
            this.btn_delDirectory.UseVisualStyleBackColor = true;
            this.btn_delDirectory.Click += new System.EventHandler(this.btn_delDirectory_Click);
            // 
            // lV_directories
            // 
            this.lV_directories.AutoArrange = false;
            this.lV_directories.LabelEdit = true;
            this.lV_directories.Location = new System.Drawing.Point(6, 22);
            this.lV_directories.Name = "lV_directories";
            this.lV_directories.Size = new System.Drawing.Size(275, 130);
            this.lV_directories.TabIndex = 4;
            this.lV_directories.UseCompatibleStateImageBehavior = false;
            this.lV_directories.View = System.Windows.Forms.View.List;
            // 
            // btn_addDirectory
            // 
            this.btn_addDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDirectory.Location = new System.Drawing.Point(287, 21);
            this.btn_addDirectory.Name = "btn_addDirectory";
            this.btn_addDirectory.Size = new System.Drawing.Size(28, 27);
            this.btn_addDirectory.TabIndex = 3;
            this.btn_addDirectory.Text = "+";
            this.btn_addDirectory.UseVisualStyleBackColor = true;
            this.btn_addDirectory.Click += new System.EventHandler(this.btn_addDirectory_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(524, 227);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungs Dialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addFilter;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addDirectory;
        private System.Windows.Forms.ListView lV_fileFilters;
        private System.Windows.Forms.ListView lV_directories;
        private System.Windows.Forms.Button btn_delFilter;
        private System.Windows.Forms.Button btn_delDirectory;
    }
}
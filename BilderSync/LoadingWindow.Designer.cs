namespace BilderSync
{
    partial class LoadingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingWindow));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Btn_cancle = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 34);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(422, 23);
            this.progressBar.TabIndex = 0;
            // 
            // Btn_ok
            // 
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ok.Location = new System.Drawing.Point(359, 74);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 31);
            this.Btn_ok.TabIndex = 1;
            this.Btn_ok.Text = "Ok";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Btn_cancle
            // 
            this.Btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancle.Location = new System.Drawing.Point(265, 74);
            this.Btn_cancle.Name = "Btn_cancle";
            this.Btn_cancle.Size = new System.Drawing.Size(88, 31);
            this.Btn_cancle.TabIndex = 2;
            this.Btn_cancle.Text = "Abbrechen";
            this.Btn_cancle.UseVisualStyleBackColor = true;
            this.Btn_cancle.Click += new System.EventHandler(this.Btn_cancle_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(13, 74);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(189, 17);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "0 von 0 Dateien kopiert (0%)";
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Location = new System.Drawing.Point(16, 11);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(95, 17);
            this.lbl_operation.TabIndex = 4;
            this.lbl_operation.Text = "Vergleichen...";
            // 
            // LoadingWindow
            // 
            this.AcceptButton = this.Btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 117);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.Btn_cancle);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synk: 0%";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Button Btn_cancle;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_operation;
    }
}
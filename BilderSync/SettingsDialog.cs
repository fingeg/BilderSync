using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilderSync
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        { 
            InitializeComponent();

            List<String> fileFilter = new List<string>(Properties.Settings.Default.fileFilter.Split(':'));
            List<String> sdCardDirectories = new List<string>(Properties.Settings.Default.sdCardDirectories.Split(':'));

            // Add all old filter to the combo box...
            foreach (string filter in fileFilter)
            {
                lV_fileFilters.Items.Add(new ListViewItem(filter));
            }
            foreach (string directory in sdCardDirectories)
            {
                lV_directories.Items.Add(new ListViewItem(directory));
            }
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            String fileFilter= "";
            String sdCardDirectories = "";

            // Create the setting strings...
            foreach (ListViewItem filter in lV_fileFilters.Items)
            {
                fileFilter = String.Format("{0}:{1}", fileFilter, filter.Text);
            }

            foreach (ListViewItem directory in lV_directories.Items)
            {
                sdCardDirectories = String.Format("{0}:{1}", sdCardDirectories, directory.Text);
            }

            // Save the strings in the settings...
            Properties.Settings.Default.fileFilter = fileFilter.Remove(0, 1);
            Properties.Settings.Default.sdCardDirectories = sdCardDirectories.Remove(0, 1);
            Properties.Settings.Default.Save();

            // Reread the settings in the main programm...
            Synchronisation.ReadUserSettings();

            Close();
        }

        private void btn_addFilter_Click(object sender, EventArgs e)
        {
            // Add a new file filter...
            string input = Prompt.ShowDialog("Neuer Filter:", "Filter");
            if (input.Length == 0) return;
            if (!input.Contains('.')) input = input.Insert(0, ".");
            lV_fileFilters.Items.Add(new ListViewItem(input.ToUpper()));
        }

        private void btn_delFilter_Click(object sender, EventArgs e)
        {
            // Delete all selected filters
            for (int i = lV_fileFilters.Items.Count - 1; i >= 0 ; i--)
            {
                if (lV_fileFilters.Items[i].Selected)
                {
                    lV_fileFilters.Items.RemoveAt(i);
                }
            }
        }

        private void btn_addDirectory_Click(object sender, EventArgs e)
        {
            // Add a new directory...
            string input = Prompt.ShowDialog("Neuer Pfad:", "Pfad");
            if (input.Length == 0) return;
            input = input.Replace('/', '\\');
            if (!input[0].Equals('\\')) input = input.Insert(0, "\\");
            lV_directories.Items.Add(new ListViewItem(input));
        }

        private void btn_delDirectory_Click(object sender, EventArgs e)
        {
            // Delete all selected directories
            for (int i = lV_directories.Items.Count - 1; i >= 0; i--)
            {
                if (lV_directories.Items[i].Selected)
                {
                    lV_directories.Items.RemoveAt(i);
                }
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, Height = 30, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            confirmation.FlatStyle = FlatStyle.Flat;
            prompt.BackColor = Color.White;
            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}

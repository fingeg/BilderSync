using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;

namespace BilderSync
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();

            // Read user settings...
            Synchronisation.ReadUserSettings();

            // Get the old paths...
            StringCollection lastSdCardPath = Properties.Settings.Default.lastSdCardPath;
            StringCollection lastAimFolderPath = Properties.Settings.Default.lastAimFolderPath;

            // Add all old paths to the combo boxes...
            if (lastSdCardPath != null)
            {
                foreach (string lastPath in lastSdCardPath)
                {
                    this.Path_SdCard.Items.Add(lastPath);
                }

                if (this.Path_SdCard.Items.Count > 0)
                {
                    this.Path_SdCard.SelectedIndex = 0;
                }
            }

            if (lastAimFolderPath != null)
            {
                foreach (string lastPath in lastAimFolderPath)
                {
                    this.Path_aimFolder.Items.Add(lastPath);
                }
                if (this.Path_aimFolder.Items.Count > 0)
                {
                    this.Path_aimFolder.SelectedIndex = 0;
                }
            }
        }

        private void Search_SdCard_Click(object sender, EventArgs e)
        {
            AddFolder(this.Path_SdCard);
        }

        private void Search_aimPath_Click(object sender, EventArgs e)
        {
            AddFolder(this.Path_aimFolder);
        }

        private void AddFolder(ComboBox pathsBox)
        {
            // Create the dialog...
            FolderBrowserDialog dialog = this.folderBrowserDialog;

            // Set start location...
            if (pathsBox.SelectedItem != null)
            {
                if (!File.Exists(pathsBox.SelectedItem.ToString()))
                {
                    dialog.SelectedPath = pathsBox.SelectedItem.ToString();
                }
            }

            // Show the dialog...
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
                if (pathsBox.Items.Contains(folder))
                {
                    pathsBox.Items.Remove(folder);
                }
                pathsBox.Items.Insert(0, folder);
                pathsBox.SelectedItem = folder;
            }
        }

        private void Btn_sync_Click(object sender, EventArgs e)
        {
            Logging.Info("Button sync clicked");

            // Create the string collections...
            StringCollection lastAimFolderPath = new StringCollection();
            foreach (string path in this.Path_aimFolder.Items)
            {
                if (path.Equals(Path_aimFolder.SelectedItem.ToString())) lastAimFolderPath.Insert(0, path);
                else lastAimFolderPath.Add(path);
            }

            StringCollection lastSdCardPath = new StringCollection();
            foreach (string path in this.Path_SdCard.Items)
            {
                if (path.Equals(Path_SdCard.SelectedItem.ToString())) lastSdCardPath.Insert(0, path);
                else lastSdCardPath.Add(path);
            }

            // Set the settings..
            Properties.Settings.Default.lastAimFolderPath = lastAimFolderPath;
            Properties.Settings.Default.lastSdCardPath= lastSdCardPath;

            // Save the settings...
            Properties.Settings.Default.Save();

            String pathSdCard = Path_SdCard.SelectedItem.ToString();
            String pathTargetFolder = Path_aimFolder.SelectedItem.ToString();

            // Check if the given paths exsist...
            if (!Directory.Exists(pathSdCard) || !Directory.Exists(pathTargetFolder))
            {
                String path;
                if (!Directory.Exists(pathSdCard)) path = pathSdCard;
                else path = pathTargetFolder;
                string message = String.Format("Der angegebene Pfad \"{0}\" konnte nicht gefunden werden!", path);
                string caption = "Pfad exsitiert nicht!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                return;
            }

            String day = "all";
            if (CB_onlyOneDay.Checked) day = CoB_selectDay.SelectedItem.ToString();

            // Open Loading window...
            LoadingWindow loadingWindow = new LoadingWindow(pathSdCard, pathTargetFolder, CB_compareWithAimFolder.Checked, day);
            loadingWindow.ShowDialog(this);
        }

        private void CB_onlyOneDay_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CB_onlyOneDay.Checked)
            {
                String pathSdCard = Path_SdCard.SelectedItem.ToString();

                // Check if the given paths exsist...
                if (!Directory.Exists(pathSdCard))
                {
                    this.CB_onlyOneDay.Checked = false;
                    string message = String.Format("Der angegebene Pfad \"{0}\" konnte nicht gefunden werden!", pathSdCard);
                    string caption = "Pfad exsitiert nicht!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    return;
                }

                new Thread(
                    new ThreadStart(() =>
                    {
                        List<FileInfo> files = Synchronisation.GetAllSdCardFiles(pathSdCard);
                        List<String> addedDates = new List<String>();

                        foreach (FileInfo file in files)
                        {
                            if (!addedDates.Contains(file.date))
                            {
                                addedDates.Add(file.date);
                                CoB_selectDay.BeginInvoke(new Action(() =>
                                    { CoB_selectDay.Items.Add(file.date); }
                                )); 
                            }
                        }

                        CoB_selectDay.BeginInvoke(new Action(() =>
                            { CoB_selectDay.SelectedIndex = 0; }
                        ));
                    }

                )).Start();
                
            }

            this.CoB_selectDay.Visible = this.CB_onlyOneDay.Checked;
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            SettingsDialog dialog = new SettingsDialog();
            dialog.Show();
        }
    }
}

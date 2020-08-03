using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BilderSync
{

    public partial class LoadingWindow : Form
    {
        string pathSdCard;
        string pathTargetFolder;
        string day;

        public LoadingWindow(string pathSdCard, string pathTargetFolder, bool compareWithTargetFolder, string day)
        {
            InitializeComponent();

            Btn_ok.Enabled = false;
            Btn_cancle.Enabled = false;
            this.day = day;

            this.pathSdCard = pathSdCard;
            this.pathTargetFolder = pathTargetFolder;

            Logging.Debug("SD card: " + pathSdCard);
            Logging.Debug("Target folder: " + pathTargetFolder);
            Logging.Debug("Compare with target: " + (compareWithTargetFolder ? "true" : "false"));

            lbl_operation.Text = "Vergleiche...";
            new Thread(
                new ThreadStart(() =>
                {
                    List<FileInfo> allFilesToCopy = Compare(compareWithTargetFolder);

                    Logging.Info("Finished compairing");

                    lbl_operation.BeginInvoke(new Action(() =>
                        { lbl_operation.Text = "Kopiere..."; }
                    ));

                    Copy(allFilesToCopy);

                    Logging.Info("Finished copying");

                    Synchronisation.StoreAllOldCopies(allFilesToCopy);

                    lbl_operation.BeginInvoke(new Action(() =>
                    { lbl_operation.Text = "Fertig"; }
                    ));

                    Btn_ok.BeginInvoke(new Action(() =>
                        { Btn_ok.Enabled = true; }
                    ));
                }
            )).Start();
        }

        private void Copy(List<FileInfo> files)
        {
            if (files.ToArray().Length == 0)
            {
                progressBar.BeginInvoke(new Action(() =>
                { progressBar.Value = 100; }
                ));
                return;
            }

            // Update window information...
            lbl_info.BeginInvoke(new Action(() =>
            { lbl_info.Text = String.Format("0 von {0} Dateien kopiert", files.ToArray().Length); }
            ));

            float percentPerFile = (float) 100 / files.ToArray().Length;
            Logging.Info("Percent per File: " + percentPerFile);
            int fileIndex = 0;
            foreach (FileInfo file in files)
            {
                fileIndex++;
                // Get Path information...
                String directory = pathTargetFolder + "\\" + file.date;
                String newPathName = directory + "\\" + file.GetFileName();

                // Update Lable...
                lbl_operation.BeginInvoke(new Action(() =>
                    { lbl_operation.Text = "Kopiere... (" + file.path + ")"; }
                ));

                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                for (int i = 0; i < i + 1; i++)
                {
                    try {
                        File.Copy(file.path, newPathName);
                        break;
                    }
                    catch (IOException e) { newPathName = newPathName.Split('.')[0] + "_2." + newPathName.Split('.')[1]; }
                }

                try
                {
                    // Set copytime...
                    File.SetLastWriteTime(newPathName, file.lastWriteTime);
                }
                catch (IOException e) { Console.WriteLine("Cannot set date of file: " + file.path); }
                

                // Update window information...
                lbl_info.BeginInvoke(new Action(() =>
                    { lbl_info.Text = String.Format("{0} von {1} Dateien kopiert", fileIndex, files.ToArray().Length); }
                ));
                progressBar.BeginInvoke(new Action(() =>
                        { progressBar.Value = Math.Min((int) Math.Round(percentPerFile * fileIndex), 100); }
                ));
                BeginInvoke(new Action(() =>
                { Text = "Sync: " + Math.Min((int)Math.Round(percentPerFile * fileIndex), 100) + "%"; }
            ));
            }

            progressBar.BeginInvoke( new Action(() =>
                        { progressBar.Value = 100; }
            ));
        }

        private List<FileInfo> Compare(bool compareWithTargetFolder)
        {
            List<FileInfo> sdCardFiles = Synchronisation.GetAllSdCardFiles(pathSdCard);
            List<FileInfo> allFilesToCopy = new List<FileInfo>();

            if (!compareWithTargetFolder)
            {
                List<String> oldCopies = Synchronisation.GetAllOldCopyies();
                foreach (FileInfo file in sdCardFiles)
                {
                    String fileString = String.Format("{0}%{1}", file.GetFileName(), file.date);
                    if (oldCopies.Contains(fileString))
                    {
                        String date = oldCopies[oldCopies.IndexOf(fileString)].Split('%')[1];
                        if (date == file.date) continue;
                    }
                    Console.WriteLine("New file to Copy: " + file.path + " (" + file.date + ")");
                    allFilesToCopy.Add(file);
                }
            } else
            {
                List<FileInfo> compareFiles = Synchronisation.GetAllFiles(pathTargetFolder);
                List<String> compareFileNames = new List<String>();
                foreach (FileInfo file in compareFiles) compareFileNames.Add(file.GetFileName());
                foreach (FileInfo file in sdCardFiles)
                {
                    if (compareFileNames.Contains(file.GetFileName()))
                    {
                        if (compareFiles[compareFileNames.IndexOf(file.GetFileName())].date == file.date) continue;
                    }
                    Console.WriteLine("New file to Copy: " + file.path + " (" + file.date + ")");
                    allFilesToCopy.Add(file);
                }
            }

            if (!day.Equals("all"))
            {
                for (int i = allFilesToCopy.Count - 1; i >= 0; i--)
                {
                    FileInfo file = allFilesToCopy[i];
                    if (!file.date.Equals(day)) allFilesToCopy.RemoveAt(i);
                }
            }

            return allFilesToCopy;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cancle_Click(object sender, EventArgs e)
        {

        }
    }

    public class FileInfo
    {
        public string path;
        public string date;
        public DateTime lastWriteTime;

        public FileInfo(string filepath)
        {
            this.path = filepath;
            this.date = GetDate();
        }

        public FileInfo(string filepath, string fileDate)
        {
            this.path = filepath;
            this.date = fileDate;
        }

        private string GetDate()
        {
            DateTime dt = File.GetLastWriteTime(path);
            lastWriteTime = dt;
            return dt.ToString("yyyy_MM_dd");
        }

        public string GetFileName()
        {
            return path.Replace("\\", "/").Split('/')[path.Replace("\\", "/").Split('/').Length - 1];
        }

    }
}

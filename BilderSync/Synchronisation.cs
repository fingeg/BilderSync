using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace BilderSync
{
    public static class Synchronisation
    {
        private static List<String> fileFilter = new List<string>();
        private static List<String> searchDiractories = new List<string>();

        public static List<FileInfo> GetAllSdCardFiles(string folder)
        {
            List<FileInfo> allFiles = new List<FileInfo>();

            foreach (String directory in searchDiractories)
            {
                try
                {
                    allFiles.AddRange(GetAllFiles(folder + directory));
                } catch (IOException e)
                {
                    Logging.Error("Cannont find path \"" + folder + directory + "\"!");
                }
            }

            return allFiles;
        }

        public static void ReadUserSettings()
        {
            fileFilter.Clear();
            searchDiractories.Clear();
            fileFilter.AddRange(Properties.Settings.Default.fileFilter.Split(':'));
            searchDiractories.AddRange(Properties.Settings.Default.sdCardDirectories.Split(':'));

            Logging.Debug("FileFilter: " + Properties.Settings.Default.fileFilter);
            Logging.Debug("Search in SD-Card directories: " + Properties.Settings.Default.sdCardDirectories);
        }

        public static List<FileInfo> GetAllFiles(string folder)
        {
            List<FileInfo> allFiles = new List<FileInfo>();

            // Get all files in DCIM...
            string[] fileEntries = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
            foreach (string fileName in fileEntries)
            {
                if (!fileFilter.Contains("." + fileName.Split('.')[fileName.Split('.').Length - 1].ToUpper()))
                {
                    allFiles.Add(new FileInfo(fileName));
                }
            }

            return allFiles;
        }

        public static void StoreAllOldCopies(List<FileInfo> newFiles)
        {
            List<String> newList = GetAllOldCopyies();

            // Delete double entries...
            foreach (FileInfo fileInfo in newFiles)
            {
                String infoString = String.Format("{0}%{1}", fileInfo.GetFileName(), fileInfo.date);
                if (!newList.Contains(infoString)) newList.Add(infoString);
            }

            FileStream file = new FileStream("syncedImages.txt", FileMode.OpenOrCreate);

            try
            {
                StreamWriter sw = new StreamWriter(file, Encoding.GetEncoding("iso-8859-1"));

                // Datei schreiben...
                foreach (String oldCopy in newList)
                {
                    // Example line: IMG_6304.JPG%2017_08_19
                    sw.WriteLine(oldCopy);
                    sw.Flush();
                }
            }
            catch (IOException e)
            {
                Logging.Error("IO Error in Write Settings");
                Logging.Error(e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        public static List<String> GetAllOldCopyies()
        {
            List<String> oldCopies = new List<String>();

            if (File.Exists("syncedImages.txt"))
            {
                FileStream file = new FileStream("syncedImages.txt", FileMode.Open);

                try
                {
                    StreamReader sr = new StreamReader(file, Encoding.GetEncoding("iso-8859-1"));
                    string line;

                    // Datei einlesen...
                    while ((line = sr.ReadLine()) != null)
                    {

                        // Split line in all old copies (One copy example: IMG_6304.JPG%2017_08_19)

                        if (line.Length > 0)
                        {
                            oldCopies.Add(line);
                            Logging.Info("Found old copy: " + line);
                        }
                    }

                }
                catch (IOException e)
                {
                    Logging.Error("IO Error in Read Settings");
                    Logging.Error(e.Message);
                }
                finally
                {
                    if (file != null)
                        file.Close();
                }
            }

            return oldCopies;
        }
    }
}

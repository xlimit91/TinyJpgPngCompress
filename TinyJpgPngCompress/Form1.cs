using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinifyAPI;

// Install-Package Tinify

namespace TinyJpgPngCompress
{
    public partial class Form : System.Windows.Forms.Form
    {
        string tinyKey = "";
        int min = 0;
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };

        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open folder browser dialog. Choose directory with image files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_folderSearch_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_folder.Text = folderDialog.SelectedPath;
                }
            }

        }

        /// <summary>
        /// Start compression task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_apiKey.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox_folder.Text))
                {
                    // Collect all image files and save in list
                    MessageBox.Show("Important: All files will be overwritten, please make a backup of your source images.");
                    tinyKey = textBox_apiKey.Text;
                    string path = textBox_folder.Text;
                    List<string> fileList = FileList(path);

                    // Compress every image file in list
                    foreach (string file in fileList)
                    {
                        try
                        {
                            textBox_currentFile.Text = file;
                            textBox_currentFile.Update();
                            CompressFile(file);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    textBox_currentFile.Text = "";
                }
                else
                {
                    MessageBox.Show("Please choose a directory.");
                }
            }
            else
            {
                MessageBox.Show("Please provide your api key.");
            }
        }

        /// <summary>
        /// Search image files in directory and save in list.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string> FileList(string path)
        {
            List<string> fileList = new List<string>();
            DirSearch(textBox_folder.Text, fileList);
            return fileList;
        }

        /// <summary>
        /// Recursive file search.
        /// </summary>
        /// <param name="sDir"></param>
        /// <param name="fileList"></param>
        public static void DirSearch(string sDir, List<string> fileList)
        {
            try
            {
                foreach (string file in Directory.GetFiles(sDir, "*.*"))
                {
                    string extension = Path.GetExtension(file.ToLower());

                    if (extension != null &&
                        extension.Contains(".gif") ||
                        extension.Contains(".jpg") ||
                        extension.Contains(".jpeg") ||
                        extension.Contains(".png"))
                    {
                        fileList.Add(file);
                    }
                }

                foreach (string directory in Directory.GetDirectories(sDir))
                {
                    DirSearch(directory, fileList);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Return percentage of compression.
        /// </summary>
        /// <param name="uncomp"></param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public double CompressedPercentage(double uncomp, double comp)
        {
            double result = 100 * comp;
            result = result / uncomp;
            result = Math.Round(result, 2);
            result = 100 - result;
            return result;
        }

        /// <summary>
        /// Return file size.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        public string HumanReadableFileSize(string filePath, double fileSize)
        {
            int order = 0;

            while (fileSize >= 1024 && order < sizes.Length - 1)
            {
                order++;
                fileSize = fileSize / 1024;
            }

            fileSize = Math.Round(fileSize, 2);
            return string.Format("{0:0.##} {1}", fileSize, sizes[order]);
        }

        /// <summary>
        /// Compress image file.
        /// </summary>
        /// <param name="filePath"></param>
        public async void CompressFile(string filePath)
        {
            try
            {
                double fileSize = new FileInfo(filePath).Length;
                Log("Compress File:" + filePath);
                Log("Original Size:" + HumanReadableFileSize(filePath, fileSize));
                Tinify.Key = tinyKey;
                var source = Tinify.FromFile(filePath);
                await source.ToFile(filePath);
                min = Convert.ToInt32(Tinify.CompressionCount);
                UpdateLabels();
                double fileSizeCompressed = new FileInfo(filePath).Length;
                Log("Compressed Size:" + HumanReadableFileSize(filePath, fileSizeCompressed) + " ---> Safed: " + CompressedPercentage(fileSize, fileSizeCompressed) + "%");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Update label in form.
        /// </summary>
        public void UpdateLabels()
        {
            label_min.Text = min.ToString();
        }

        /// <summary>
        /// Add listbox.item and select latest item (for auto-scroll)
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            listBox_log.Items.Add(message);
            listBox_log.SetSelected(listBox_log.Items.Count - 1, true);
            listBox_log.SetSelected(listBox_log.Items.Count - 1, false);
        }
    }
}

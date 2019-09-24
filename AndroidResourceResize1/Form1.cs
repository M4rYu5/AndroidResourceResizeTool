using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AndroidResourceResize1
{
    public partial class Form1 : Form
    {
        protected delegate void AddToProgressBarAction(int valueToBeAdded);

        private OpenFileDialog FileDialog = new OpenFileDialog();
        private FolderBrowserDialog OutputDialog = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();

            //FileDialog
            FileDialog.Multiselect = true;
            FileDialog.Title = "Select Images";
            FileDialog.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";
            FileDialog.RestoreDirectory = true;
            FileDialog.FileOk += (obj, arg) =>
            {
                listBox1.Items.AddRange(FileDialog.FileNames);
            };
            //OutputDialog
            OutputDialog.Description = "Select Resource folder";
        }


        public void AddToProgressBar(int value)
        {
            progressBar1.BeginInvoke(new AddToProgressBarAction((i) => { progressBar1.Value += i; }), value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (OutputDialog.ShowDialog() == DialogResult.OK)
            {
                var itemsCount = listBox1.Items.Count;
                if (itemsCount != 0)
                {
                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    original.Enabled = false;
                    mdpi.Enabled = false;
                    hdpi.Enabled = false;
                    xhdpi.Enabled = false;
                    xxhdpi.Enabled = false;
                    xxxhdpi.Enabled = false;
                    widthValue.Enabled = false;
                    heightValue.Enabled = false;
                    checkBoxHeight.Enabled = false;
                    checkBoxWidth.Enabled = false;
                    listBox1.Enabled = false;

                    progressBar1.Maximum = itemsCount * 2;

                    await CreateBackgroundTasks();

                    progressBar1.Value = 0;

                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    original.Enabled = true;
                    mdpi.Enabled = true;
                    hdpi.Enabled = true;
                    xhdpi.Enabled = true;
                    xxhdpi.Enabled = true;
                    xxxhdpi.Enabled = true;
                    widthValue.Enabled = true;
                    heightValue.Enabled = true;
                    checkBoxHeight.Enabled = true;
                    checkBoxWidth.Enabled = true;
                    listBox1.Enabled = true;

                    MessageBox.Show("Resources saved in: \"" + OutputDialog.SelectedPath + "\"", "Completed!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Select a image", "Error!", MessageBoxButtons.OK);
                }
            }
        }

        private async Task CreateBackgroundTasks()
        {
            await Task.Run(() =>
            {
                int fileNamesLength = FileDialog.FileNames.Length; //readonly
                double width = (double)widthValue.Value; //readonly
                double height = (double)heightValue.Value; //readonly

                Task[] tasks = new Task[fileNamesLength];

                for (int i = 0; i < fileNamesLength; i++)
                {
                    var j = i;
                    tasks[i] = Task.Run(() =>
                    {
                        AddToProgressBar(1);
                        ExportResources(FileDialog.FileNames[j], width, height);
                        AddToProgressBar(1);
                    });
                }
                Task.WaitAll(tasks);
            });
        }

        /// <summary>
        /// Save image in all required dimensions
        /// </summary>
        /// <param name="sourcePath">Image source path</param>
        /// <param name="widthConstraint">The maximum value of image widht (mdpi) that the image can have (without stretching)</param>
        /// <param name="heightConstraint">The maximum value of image height (mdpi) that the image can have (without stretching)</param>
        private void ExportResources(string sourcePath, double widthConstraint, double heightConstraint)
        {
            //save
            if (original.Checked)
            {
                //original
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable"), widthConstraint, heightConstraint, 0);
            }
            if (mdpi.Checked)
            {
                //mdpi
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable-mdpi"), widthConstraint, heightConstraint, 1);
            }
            if (hdpi.Checked)
            {
                //hdpi
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable-hdpi"), widthConstraint, heightConstraint, 1.5);
            }
            if (xhdpi.Checked)
            {
                //xhdpi
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable-xhdpi"), widthConstraint, heightConstraint, 2);
            }
            if (xxhdpi.Checked)
            {
                //xxhdpi
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable-xxhdpi"), widthConstraint, heightConstraint, 3);
            }
            if (xxxhdpi.Checked)
            {
                //xxxhdpi
                SaveResources(sourcePath, Path.Combine(OutputDialog.SelectedPath, "drawable-xxxhdpi"), widthConstraint, heightConstraint, 4);
            }
        }


        /// <summary>
        /// Scale (base on mdpi) the original resource to fit the desired resolution.
        /// When the scaleFactor is 0 the image will be copied
        /// </summary>
        /// <param name="sourcePath">Original resource path</param>
        /// <param name="outputPath">Resources output path</param>
        /// <param name="widthConstraint">The maximum value of image widht (mdpi) that the image can have (without stretching)</param>
        /// <param name="heightConstraint">The maximum value of image height (mdpi) that the image can have (without stretching)</param>
        /// <param name="scaleFactor">Scale factor (based on mdpi size)</param>
        public void SaveResources(string sourcePath, string outputPath, double widthConstraint, double heightConstraint, double scaleFactor)
        {
            string fileName = sourcePath.Substring(sourcePath.LastIndexOf('\\') + 1);
            Bitmap image = new Bitmap(sourcePath);
            int width = 0;
            int height = 0;

            string outputFilePath = Path.Combine(outputPath, fileName);
            Directory.CreateDirectory(outputPath);

            if (scaleFactor != 0)
            {
                if (checkBoxWidth.Checked && checkBoxHeight.Checked)
                {
                    width = (int)Math.Round(widthConstraint * scaleFactor);
                    height = (int)Math.Round(heightConstraint * scaleFactor);
                }
                else if (checkBoxWidth.Checked)
                {
                    width = (int)Math.Round(widthConstraint * scaleFactor);
                    height = (int)Math.Round(image.Height * (double)width / image.Width);
                }
                else if (checkBoxHeight.Checked)
                {
                    height = (int)Math.Round(heightConstraint * scaleFactor);
                    width = (int)Math.Round(image.Width * (double)height / image.Height);
                }
                else
                {
                    width = image.Width;
                    height = image.Height;
                }

                var Image = ResizeImage(image, width, height);
                Image.Save(outputFilePath, ImageFormat.Png);
                Image.Dispose();
            }
            else
            {
                image.Save(outputFilePath, ImageFormat.Png);
            }

            image.Dispose();
        }




        /// <summary>
        /// Create a new resized image
        /// </summary>
        /// <param name="image">Image to be resized</param>
        /// <param name="width">New image widht</param>
        /// <param name="height">New image height</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

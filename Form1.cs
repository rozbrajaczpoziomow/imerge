using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imerge
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string[] images = null;
        private int previewIdx = 0;
        public Form()
        {
            InitializeComponent();
            update();
        }

        // bullshit
        private void BgButton_Click(object sender, EventArgs e)
        {
            BgText.Text = pickImage();
            update();
        }
        private void OverlayButton_Click(object sender, EventArgs e)
        {
            OverlayText.Text = pickImage();
            update();
        }
        private void BaseButton_Click(object sender, EventArgs e)
        {
            BaseText.Text = pickFolder();
            images = getAllImages(BaseText.Text);
            update();
        }
        private void MergeButton_Click(object sender, EventArgs e)
        {
            doMerge();
        }
        private void PreviewCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(PreviewCheckbox.Checked)
            {
                Height += 256;
                PreviewImage.Visible = RerollButton.Visible = true;
                generatePreview();
            }
            else
            {
                Height -= 256;
                PreviewImage.Visible = RerollButton.Visible = false;
            }
        }
        private void RerollButton_Click(object sender, EventArgs e)
        {
            if(images != null)
                previewIdx = new Random().Next(images.Length);
            generatePreview();
        }

        // actual code
        private string pickImage()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Images (*.png, *.jpg)|*.png;*.jpg;*.jpeg",
                Title = "Choose image"
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : "";
        }

        private string pickFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.SelectedPath : "";
        }
        private void update()
        {
            string err = "";

            if(string.IsNullOrWhiteSpace(BgText.Text) && string.IsNullOrWhiteSpace(OverlayText.Text))
                err = "Either the background or the overlay needs to be selected\n";
            if(images == null || images.Length == 0)
                err += "The base image folder needs to be selected and non-empty\n";

            MergeButton.Enabled = err == "";
            ErrorCaption.Text = err;

            if (err != "")
                return;

            ErrorCaption.Text = images.Length + " images found";

            if (PreviewCheckbox.Checked)
                generatePreview();
        }
        private void generatePreview()
        {
            Image bg = getImage(BgText.Text);
            Image overlay = getImage(OverlayText.Text);

            if(images == null || images.Length < previewIdx || (bg == null && overlay == null))
                return; // just cowardly abort, doMerge may handle this if needed.

            Image image = Image.FromFile(images[previewIdx]);
            Bitmap merged = mergeSingle(bg, image, overlay);

            if(bg != null)
                bg.Dispose();
            image.Dispose();
            if(overlay != null)
                overlay.Dispose();

            if(PreviewImage.Image != null)
                PreviewImage.Image.Dispose();
            PreviewImage.Image = merged;
        }
        private void doMerge()
        {
            Image bg = getImage(BgText.Text);
            Image overlay = getImage(OverlayText.Text);

            if (bg == null && overlay == null)
            {
                MessageBox.Show("Could not load both the background and overlay images, this shouldn't happen!", "Uhhmm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //getAllImages(BaseText.Text);
            if(images == null || images.Length == 0) {
                MessageBox.Show("Could not load the base image folder, this shouldn't happen!", "Uhhmm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int count = 0;
            foreach (string imgpath in images)
            {
                Image image = Image.FromFile(imgpath);
                Bitmap bitmap = mergeSingle(bg, image, overlay);
                image.Dispose(); // free up the file to write to it.
                bitmap.Save(imgpath);
                ErrorCaption.Text = (images.Length - ++count).ToString() + " images left.";
                Update();
            }
            long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            // free em up
            bg.Dispose();
            overlay.Dispose();

            ErrorCaption.Text = images.Length + "images done in " + (end - start) + "ms.";
        }

        private Bitmap mergeSingle(Image bg, Image image, Image overlay)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            if (bg != null)
                graphics.DrawImage(bg, new Rectangle(0, 0, bg.Width, bg.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            if (overlay != null)
                graphics.DrawImage(overlay, new Rectangle(0, 0, overlay.Width, overlay.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            graphics.Save();
            return bitmap;
        }

        private Image getImage(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return null;

            try
            {
                return Image.FromFile(path);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string[] getAllImages(string path)
        {
            string[] sub = getSubentries(path);
            if (sub == null)
                return null;

            ArrayList list = new ArrayList(sub.Length);
            foreach(string s in sub)
            {
                if(Directory.Exists(s)) // if it is a directory, recurse into subdirectories
                {
                    Update();
                    string[] recur = getAllImages(s);
                    if (recur != null)
                        list.AddRange(recur);
                } else if(File.Exists(s)) // if it is a file, save it into the return value. can't do else in case it just doesn't exist
                {
                    list.Add(s);
                }
            }
            return list.OfType<string>().ToArray();
        }

        private string[] getSubentries(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return null;
            try
            {
                return Directory.GetFileSystemEntries(path);
            } catch(Exception)
            {
                return null;
            }
        }
    }
}

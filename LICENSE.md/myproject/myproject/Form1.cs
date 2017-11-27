using myproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Collage
{
    public partial class Form1 : Form
    {
        private readonly List<FileInfo> imagesList = new List<FileInfo>();
        private string outputDirectory = "";
        private CollageGenerator collage;

        public Form1()
        {
            InitializeComponent();
        }

        private void bntChooseDir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagesList.AddRange(openFileDialog1.FileNames.Select(name => new FileInfo(name)));
            ShowInformation(string.Format("Количество выбранных изображений: {0}.", imagesList.Count));
            btnCollage.Enabled = imagesList.Count > 0;
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.outputDirectory = folderBrowserDialog1.SelectedPath;
            ShowInformation(string.Format("Сохранить в: {0}.", this.outputDirectory));
        }

        private void btnCollage_Click(object sender, EventArgs e)
        {
            if (imagesList == null || imagesList.Count == 0)
            {
                ShowInformation("Изображения не выбраны");
                return;
            }

            ShowInformation("Создается коллаж...");
            DisableControls();

            var settings =
                new CollageSettings(
                    new CollageDimensionSettings
                    {
                        NumberOfColumns = Convert.ToInt32(nudColumns.Value),
                        NumberOfRows = Convert.ToInt32(nudRows.Value),
                        TileHeight = Convert.ToInt32(nudItemHeight.Value),
                        TileWidth = Convert.ToInt32(nudItemWidth.Value),
                        TileScalePercent = new Percentage(Convert.ToInt32(nudScalePercent.Value))
                    },                                        
                    imagesList,
                    new DirectoryInfo(folderBrowserDialog1.SelectedPath)
                    );

            CreateCollage(settings);
        }

        private void ShowInformation(string message)
        {
            listBox1.Items.Add(message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            collage.CancelAsync();
            EnableControls();
            progressBar1.Value = 0;
        }

        private void DisableControls()
        {
            btnChooseFiles.Enabled = false;
            btnSelectOutputDir.Enabled = false;
            btnCollage.Enabled = false;
            nudColumns.Enabled = false;
            nudItemHeight.Enabled = false;
            nudItemWidth.Enabled = false;
            nudRows.Enabled = false;
            nudScalePercent.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void EnableControls()
        {
            btnChooseFiles.Enabled = true;
            btnSelectOutputDir.Enabled = true;
            btnCollage.Enabled = true;
            nudColumns.Enabled = true;
            nudItemHeight.Enabled = true;
            nudItemWidth.Enabled = true;
            nudRows.Enabled = true;
            nudScalePercent.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void CreateCollage(CollageSettings settings)
        {
            this.collage = new CollageGenerator(settings);
            collage.CreateCompleted += this.collage_CreateCompleted;
            collage.CreateProgressChanged += this.collage_CreateProgressChanged;
            collage.CreateAsync();
        }

        void collage_CreateProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void collage_CreateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.ShowInformation(e.Cancelled ? "Отменено" : "Выполнено");

            if (e.UserState != null)
            {
                ShowInformation(e.UserState.ToString());
            }

            progressBar1.Value = 0;
            EnableControls();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudItemWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudItemHeight_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    internal class CollageSetting
    {
        private CollageDimensionSettings collageDimensionSettings;        
        private List<FileInfo> imagesList;
        private DirectoryInfo directoryInfo;

        public CollageSetting(CollageDimensionSettings collageDimensionSettings, List<FileInfo> imagesList, DirectoryInfo directoryInfo)
        {
            this.collageDimensionSettings = collageDimensionSettings;            
            this.imagesList = imagesList;
            this.directoryInfo = directoryInfo;
        }
    }
}


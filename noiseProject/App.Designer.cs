
using System;
using System.Drawing;
using System.Windows.Forms;

namespace noiseProject
{
    partial class App
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.aside = new System.Windows.Forms.Panel();
            this.asmOptionsPanel = new System.Windows.Forms.Panel();
            this.threadLabel = new System.Windows.Forms.Label();
            this.threadTrackBar = new System.Windows.Forms.TrackBar();
            this.useAsm = new System.Windows.Forms.CheckBox();
            this.timesPanel = new System.Windows.Forms.Panel();
            this.avgOperationTime = new System.Windows.Forms.Label();
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.operationTime = new System.Windows.Forms.Label();
            this.timeLabelDesc = new System.Windows.Forms.Label();
            this.importImageBtn = new System.Windows.Forms.Button();
            this.alogithmsSubmenu = new System.Windows.Forms.Panel();
            this.gaussianNoiseOptionBtn = new System.Windows.Forms.Button();
            this.noiseSaltAndPepperOptionBtn = new System.Windows.Forms.Button();
            this.uniformNoiseOptionBtn = new System.Windows.Forms.Button();
            this.toogleAlgorithmSubmenu = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleAppLabel = new System.Windows.Forms.Label();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.previewImageTitle = new System.Windows.Forms.Label();
            this.generatedImage = new System.Windows.Forms.PictureBox();
            this.generateImageTitle = new System.Windows.Forms.Label();
            this.genearteNosieOnImageBtn = new System.Windows.Forms.Button();
            this.welcomingText = new System.Windows.Forms.Label();
            this.addImageText = new System.Windows.Forms.Label();
            this.downloadGeneartedImg = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.aside.SuspendLayout();
            this.asmOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadTrackBar)).BeginInit();
            this.timesPanel.SuspendLayout();
            this.alogithmsSubmenu.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // aside
            // 
            this.aside.AutoScroll = true;
            this.aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.aside.Controls.Add(this.asmOptionsPanel);
            this.aside.Controls.Add(this.timesPanel);
            this.aside.Controls.Add(this.importImageBtn);
            this.aside.Controls.Add(this.alogithmsSubmenu);
            this.aside.Controls.Add(this.toogleAlgorithmSubmenu);
            this.aside.Controls.Add(this.titlePanel);
            this.aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.aside.Location = new System.Drawing.Point(0, 0);
            this.aside.Margin = new System.Windows.Forms.Padding(4);
            this.aside.Name = "aside";
            this.aside.Size = new System.Drawing.Size(224, 599);
            this.aside.TabIndex = 0;
            // 
            // asmOptionsPanel
            // 
            this.asmOptionsPanel.Controls.Add(this.threadLabel);
            this.asmOptionsPanel.Controls.Add(this.threadTrackBar);
            this.asmOptionsPanel.Controls.Add(this.useAsm);
            this.asmOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.asmOptionsPanel.Location = new System.Drawing.Point(0, 442);
            this.asmOptionsPanel.Name = "asmOptionsPanel";
            this.asmOptionsPanel.Size = new System.Drawing.Size(224, 145);
            this.asmOptionsPanel.TabIndex = 6;
            // 
            // threadLabel
            // 
            this.threadLabel.AutoSize = true;
            this.threadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadLabel.ForeColor = System.Drawing.Color.White;
            this.threadLabel.Location = new System.Drawing.Point(12, 51);
            this.threadLabel.Name = "threadLabel";
            this.threadLabel.Size = new System.Drawing.Size(76, 20);
            this.threadLabel.TabIndex = 1;
            this.threadLabel.Text = "Thread: 1\r\n";
            // 
            // threadTrackBar
            // 
            this.threadTrackBar.LargeChange = 1;
            this.threadTrackBar.Location = new System.Drawing.Point(12, 82);
            this.threadTrackBar.Maximum = 6;
            this.threadTrackBar.Name = "threadTrackBar";
            this.threadTrackBar.Size = new System.Drawing.Size(205, 45);
            this.threadTrackBar.TabIndex = 0;
            this.threadTrackBar.Scroll += new System.EventHandler(this.threadTrackBar_Scroll);
            // 
            // useAsm
            // 
            this.useAsm.AutoSize = true;
            this.useAsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useAsm.ForeColor = System.Drawing.Color.White;
            this.useAsm.Location = new System.Drawing.Point(16, 10);
            this.useAsm.Name = "useAsm";
            this.useAsm.Size = new System.Drawing.Size(91, 24);
            this.useAsm.TabIndex = 0;
            this.useAsm.Text = "Use asm";
            this.useAsm.UseVisualStyleBackColor = true;
            this.useAsm.CheckedChanged += new System.EventHandler(this.useAsm_CheckedChanged);
            // 
            // timesPanel
            // 
            this.timesPanel.Controls.Add(this.avgOperationTime);
            this.timesPanel.Controls.Add(this.avgTimeLabel);
            this.timesPanel.Controls.Add(this.operationTime);
            this.timesPanel.Controls.Add(this.timeLabelDesc);
            this.timesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timesPanel.Location = new System.Drawing.Point(0, 301);
            this.timesPanel.Name = "timesPanel";
            this.timesPanel.Size = new System.Drawing.Size(224, 141);
            this.timesPanel.TabIndex = 5;
            // 
            // avgOperationTime
            // 
            this.avgOperationTime.AutoSize = true;
            this.avgOperationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgOperationTime.ForeColor = System.Drawing.Color.White;
            this.avgOperationTime.Location = new System.Drawing.Point(149, 83);
            this.avgOperationTime.Name = "avgOperationTime";
            this.avgOperationTime.Size = new System.Drawing.Size(18, 20);
            this.avgOperationTime.TabIndex = 12;
            this.avgOperationTime.Text = "0";
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTimeLabel.ForeColor = System.Drawing.Color.White;
            this.avgTimeLabel.Location = new System.Drawing.Point(12, 83);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(120, 40);
            this.avgTimeLabel.TabIndex = 11;
            this.avgTimeLabel.Text = "Avarage time of\r\noperations\r\n";
            // 
            // operationTime
            // 
            this.operationTime.AutoSize = true;
            this.operationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationTime.ForeColor = System.Drawing.Color.White;
            this.operationTime.Location = new System.Drawing.Point(149, 19);
            this.operationTime.Name = "operationTime";
            this.operationTime.Size = new System.Drawing.Size(18, 20);
            this.operationTime.TabIndex = 10;
            this.operationTime.Text = "0";
            // 
            // timeLabelDesc
            // 
            this.timeLabelDesc.AutoSize = true;
            this.timeLabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabelDesc.ForeColor = System.Drawing.Color.White;
            this.timeLabelDesc.Location = new System.Drawing.Point(12, 19);
            this.timeLabelDesc.Name = "timeLabelDesc";
            this.timeLabelDesc.Size = new System.Drawing.Size(90, 40);
            this.timeLabelDesc.TabIndex = 9;
            this.timeLabelDesc.Text = "Time of last\r\noperation";
            // 
            // importImageBtn
            // 
            this.importImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.importImageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.importImageBtn.FlatAppearance.BorderSize = 0;
            this.importImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importImageBtn.ForeColor = System.Drawing.Color.White;
            this.importImageBtn.Location = new System.Drawing.Point(0, 261);
            this.importImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.importImageBtn.Name = "importImageBtn";
            this.importImageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.importImageBtn.Size = new System.Drawing.Size(224, 40);
            this.importImageBtn.TabIndex = 4;
            this.importImageBtn.Text = "Import Image";
            this.importImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importImageBtn.UseVisualStyleBackColor = false;
            this.importImageBtn.Click += new System.EventHandler(this.importImageBtn_Click);
            // 
            // alogithmsSubmenu
            // 
            this.alogithmsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.alogithmsSubmenu.Controls.Add(this.gaussianNoiseOptionBtn);
            this.alogithmsSubmenu.Controls.Add(this.noiseSaltAndPepperOptionBtn);
            this.alogithmsSubmenu.Controls.Add(this.uniformNoiseOptionBtn);
            this.alogithmsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.alogithmsSubmenu.Location = new System.Drawing.Point(0, 141);
            this.alogithmsSubmenu.Name = "alogithmsSubmenu";
            this.alogithmsSubmenu.Size = new System.Drawing.Size(224, 120);
            this.alogithmsSubmenu.TabIndex = 2;
            // 
            // gaussianNoiseOptionBtn
            // 
            this.gaussianNoiseOptionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.gaussianNoiseOptionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaussianNoiseOptionBtn.FlatAppearance.BorderSize = 0;
            this.gaussianNoiseOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaussianNoiseOptionBtn.ForeColor = System.Drawing.Color.White;
            this.gaussianNoiseOptionBtn.Location = new System.Drawing.Point(0, 80);
            this.gaussianNoiseOptionBtn.Name = "gaussianNoiseOptionBtn";
            this.gaussianNoiseOptionBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.gaussianNoiseOptionBtn.Size = new System.Drawing.Size(224, 40);
            this.gaussianNoiseOptionBtn.TabIndex = 2;
            this.gaussianNoiseOptionBtn.Text = "Gaussian noise";
            this.gaussianNoiseOptionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gaussianNoiseOptionBtn.UseVisualStyleBackColor = false;
            this.gaussianNoiseOptionBtn.Click += new System.EventHandler(this.algorithmSelection_Click);
            // 
            // noiseSaltAndPepperOptionBtn
            // 
            this.noiseSaltAndPepperOptionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.noiseSaltAndPepperOptionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.noiseSaltAndPepperOptionBtn.FlatAppearance.BorderSize = 0;
            this.noiseSaltAndPepperOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noiseSaltAndPepperOptionBtn.ForeColor = System.Drawing.Color.White;
            this.noiseSaltAndPepperOptionBtn.Location = new System.Drawing.Point(0, 40);
            this.noiseSaltAndPepperOptionBtn.Name = "noiseSaltAndPepperOptionBtn";
            this.noiseSaltAndPepperOptionBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.noiseSaltAndPepperOptionBtn.Size = new System.Drawing.Size(224, 40);
            this.noiseSaltAndPepperOptionBtn.TabIndex = 1;
            this.noiseSaltAndPepperOptionBtn.Text = "Noise salt and pepper";
            this.noiseSaltAndPepperOptionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noiseSaltAndPepperOptionBtn.UseVisualStyleBackColor = false;
            this.noiseSaltAndPepperOptionBtn.Click += new System.EventHandler(this.algorithmSelection_Click);
            // 
            // uniformNoiseOptionBtn
            // 
            this.uniformNoiseOptionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.uniformNoiseOptionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.uniformNoiseOptionBtn.FlatAppearance.BorderSize = 0;
            this.uniformNoiseOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniformNoiseOptionBtn.ForeColor = System.Drawing.Color.White;
            this.uniformNoiseOptionBtn.Location = new System.Drawing.Point(0, 0);
            this.uniformNoiseOptionBtn.Name = "uniformNoiseOptionBtn";
            this.uniformNoiseOptionBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.uniformNoiseOptionBtn.Size = new System.Drawing.Size(224, 40);
            this.uniformNoiseOptionBtn.TabIndex = 0;
            this.uniformNoiseOptionBtn.Text = "Uniform noise";
            this.uniformNoiseOptionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uniformNoiseOptionBtn.UseVisualStyleBackColor = false;
            this.uniformNoiseOptionBtn.Click += new System.EventHandler(this.algorithmSelection_Click);
            // 
            // toogleAlgorithmSubmenu
            // 
            this.toogleAlgorithmSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.toogleAlgorithmSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.toogleAlgorithmSubmenu.FlatAppearance.BorderSize = 0;
            this.toogleAlgorithmSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toogleAlgorithmSubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toogleAlgorithmSubmenu.ForeColor = System.Drawing.Color.White;
            this.toogleAlgorithmSubmenu.Location = new System.Drawing.Point(0, 101);
            this.toogleAlgorithmSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.toogleAlgorithmSubmenu.Name = "toogleAlgorithmSubmenu";
            this.toogleAlgorithmSubmenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toogleAlgorithmSubmenu.Size = new System.Drawing.Size(224, 40);
            this.toogleAlgorithmSubmenu.TabIndex = 1;
            this.toogleAlgorithmSubmenu.Text = "Choose algorithm";
            this.toogleAlgorithmSubmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toogleAlgorithmSubmenu.UseVisualStyleBackColor = false;
            this.toogleAlgorithmSubmenu.Click += new System.EventHandler(this.chooseAlgorithm_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleAppLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(224, 101);
            this.titlePanel.TabIndex = 0;
            // 
            // titleAppLabel
            // 
            this.titleAppLabel.AutoSize = true;
            this.titleAppLabel.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAppLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleAppLabel.Location = new System.Drawing.Point(24, 42);
            this.titleAppLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleAppLabel.Name = "titleAppLabel";
            this.titleAppLabel.Size = new System.Drawing.Size(109, 27);
            this.titleAppLabel.TabIndex = 0;
            this.titleAppLabel.Text = "NoiseGen";
            this.titleAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "imageFileDialog";
            // 
            // selectedImage
            // 
            this.selectedImage.Location = new System.Drawing.Point(258, 101);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(344, 375);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImage.TabIndex = 1;
            this.selectedImage.TabStop = false;
            // 
            // previewImageTitle
            // 
            this.previewImageTitle.AutoSize = true;
            this.previewImageTitle.BackColor = System.Drawing.Color.Transparent;
            this.previewImageTitle.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewImageTitle.ForeColor = System.Drawing.Color.White;
            this.previewImageTitle.Location = new System.Drawing.Point(301, 42);
            this.previewImageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewImageTitle.Name = "previewImageTitle";
            this.previewImageTitle.Size = new System.Drawing.Size(242, 27);
            this.previewImageTitle.TabIndex = 1;
            this.previewImageTitle.Text = "Selected image preview";
            this.previewImageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generatedImage
            // 
            this.generatedImage.Location = new System.Drawing.Point(737, 101);
            this.generatedImage.Name = "generatedImage";
            this.generatedImage.Size = new System.Drawing.Size(344, 375);
            this.generatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.generatedImage.TabIndex = 2;
            this.generatedImage.TabStop = false;
            // 
            // generateImageTitle
            // 
            this.generateImageTitle.AutoSize = true;
            this.generateImageTitle.BackColor = System.Drawing.Color.Transparent;
            this.generateImageTitle.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateImageTitle.ForeColor = System.Drawing.Color.White;
            this.generateImageTitle.Location = new System.Drawing.Point(822, 42);
            this.generateImageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generateImageTitle.Name = "generateImageTitle";
            this.generateImageTitle.Size = new System.Drawing.Size(178, 27);
            this.generateImageTitle.TabIndex = 3;
            this.generateImageTitle.Text = "Generated image";
            this.generateImageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genearteNosieOnImageBtn
            // 
            this.genearteNosieOnImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.genearteNosieOnImageBtn.FlatAppearance.BorderSize = 0;
            this.genearteNosieOnImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genearteNosieOnImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genearteNosieOnImageBtn.ForeColor = System.Drawing.Color.White;
            this.genearteNosieOnImageBtn.Location = new System.Drawing.Point(524, 546);
            this.genearteNosieOnImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.genearteNosieOnImageBtn.Name = "genearteNosieOnImageBtn";
            this.genearteNosieOnImageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.genearteNosieOnImageBtn.Size = new System.Drawing.Size(305, 40);
            this.genearteNosieOnImageBtn.TabIndex = 5;
            this.genearteNosieOnImageBtn.Text = "Please choose algortihm";
            this.genearteNosieOnImageBtn.UseVisualStyleBackColor = false;
            this.genearteNosieOnImageBtn.Click += new System.EventHandler(this.generateAlgorithmBtn_Click);
            // 
            // welcomingText
            // 
            this.welcomingText.AutoSize = true;
            this.welcomingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomingText.ForeColor = System.Drawing.Color.White;
            this.welcomingText.Location = new System.Drawing.Point(446, 251);
            this.welcomingText.Name = "welcomingText";
            this.welcomingText.Size = new System.Drawing.Size(450, 50);
            this.welcomingText.TabIndex = 6;
            this.welcomingText.Text = "Welcome in noise generator.\r\nPlease add an image and selectet algorithm :)\r\n";
            this.welcomingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addImageText
            // 
            this.addImageText.AutoSize = true;
            this.addImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageText.ForeColor = System.Drawing.Color.White;
            this.addImageText.Location = new System.Drawing.Point(557, 254);
            this.addImageText.Name = "addImageText";
            this.addImageText.Size = new System.Drawing.Size(233, 50);
            this.addImageText.TabIndex = 7;
            this.addImageText.Text = "Please add an image :)\r\n\r\n";
            this.addImageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadGeneartedImg
            // 
            this.downloadGeneartedImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.downloadGeneartedImg.FlatAppearance.BorderSize = 0;
            this.downloadGeneartedImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadGeneartedImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadGeneartedImg.ForeColor = System.Drawing.Color.White;
            this.downloadGeneartedImg.Location = new System.Drawing.Point(898, 483);
            this.downloadGeneartedImg.Margin = new System.Windows.Forms.Padding(4);
            this.downloadGeneartedImg.Name = "downloadGeneartedImg";
            this.downloadGeneartedImg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.downloadGeneartedImg.Size = new System.Drawing.Size(183, 40);
            this.downloadGeneartedImg.TabIndex = 8;
            this.downloadGeneartedImg.Text = "Download";
            this.downloadGeneartedImg.UseVisualStyleBackColor = false;
            this.downloadGeneartedImg.Click += new System.EventHandler(this.downloadGeneratedBtn_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1124, 599);
            this.Controls.Add(this.downloadGeneartedImg);
            this.Controls.Add(this.addImageText);
            this.Controls.Add(this.welcomingText);
            this.Controls.Add(this.genearteNosieOnImageBtn);
            this.Controls.Add(this.generateImageTitle);
            this.Controls.Add(this.generatedImage);
            this.Controls.Add(this.previewImageTitle);
            this.Controls.Add(this.selectedImage);
            this.Controls.Add(this.aside);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(925, 555);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.App_Load);
            this.aside.ResumeLayout(false);
            this.asmOptionsPanel.ResumeLayout(false);
            this.asmOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadTrackBar)).EndInit();
            this.timesPanel.ResumeLayout(false);
            this.timesPanel.PerformLayout();
            this.alogithmsSubmenu.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel aside;
        private Panel alogithmsSubmenu;
        private Button gaussianNoiseOptionBtn;
        private Button noiseSaltAndPepperOptionBtn;
        private Button uniformNoiseOptionBtn;
        private Button toogleAlgorithmSubmenu;
        private Panel titlePanel;
        private Label titleAppLabel;
        private Button importImageBtn;
        private OpenFileDialog imageFileDialog;
        private PictureBox selectedImage;
        private Label previewImageTitle;
        private PictureBox generatedImage;
        private Label generateImageTitle;
        private Button genearteNosieOnImageBtn;
        private Label welcomingText;
        private Label addImageText;
        private Panel timesPanel;
        private Label avgOperationTime;
        private Label avgTimeLabel;
        private Label operationTime;
        private Label timeLabelDesc;
        private Button downloadGeneartedImg;
        private SaveFileDialog saveFileDialog;
        private Panel asmOptionsPanel;
        private TrackBar threadTrackBar;
        private CheckBox useAsm;
        private Label threadLabel;
    }
}


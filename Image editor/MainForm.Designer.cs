﻿namespace Image_editor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMonochromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToLABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posterizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveStretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramTableGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.medianFiltrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.processToolStripMenuItem,
            this.analyzeToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toRGBToolStripMenuItem,
            this.toMonochromToolStripMenuItem,
            this.rGBToHSVToolStripMenuItem,
            this.rGBToLABToolStripMenuItem,
            this.splitChannelsToolStripMenuItem,
            this.stretchingToolStripMenuItem,
            this.equalizationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // toRGBToolStripMenuItem
            // 
            this.toRGBToolStripMenuItem.Name = "toRGBToolStripMenuItem";
            this.toRGBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toRGBToolStripMenuItem.Text = "To RGB";
            this.toRGBToolStripMenuItem.Click += new System.EventHandler(this.toRGBToolStripMenuItem_Click);
            // 
            // toMonochromToolStripMenuItem
            // 
            this.toMonochromToolStripMenuItem.Name = "toMonochromToolStripMenuItem";
            this.toMonochromToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toMonochromToolStripMenuItem.Text = "RGB to Gray";
            this.toMonochromToolStripMenuItem.Click += new System.EventHandler(this.toMonochromToolStripMenuItem_Click);
            // 
            // rGBToHSVToolStripMenuItem
            // 
            this.rGBToHSVToolStripMenuItem.Name = "rGBToHSVToolStripMenuItem";
            this.rGBToHSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBToHSVToolStripMenuItem.Text = "RGB to HSV";
            this.rGBToHSVToolStripMenuItem.Click += new System.EventHandler(this.rGBToHSVToolStripMenuItem_Click);
            // 
            // rGBToLABToolStripMenuItem
            // 
            this.rGBToLABToolStripMenuItem.Name = "rGBToLABToolStripMenuItem";
            this.rGBToLABToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBToLABToolStripMenuItem.Text = "RGB to LAB";
            this.rGBToLABToolStripMenuItem.Click += new System.EventHandler(this.rGBToLABToolStripMenuItem_Click);
            // 
            // splitChannelsToolStripMenuItem
            // 
            this.splitChannelsToolStripMenuItem.Name = "splitChannelsToolStripMenuItem";
            this.splitChannelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.splitChannelsToolStripMenuItem.Text = "Split channels";
            this.splitChannelsToolStripMenuItem.Click += new System.EventHandler(this.splitChannelsToolStripMenuItem_Click);
            // 
            // stretchingToolStripMenuItem
            // 
            this.stretchingToolStripMenuItem.Name = "stretchingToolStripMenuItem";
            this.stretchingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stretchingToolStripMenuItem.Text = "Stretching";
            this.stretchingToolStripMenuItem.Click += new System.EventHandler(this.stretchingToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negationToolStripMenuItem,
            this.posterizationToolStripMenuItem,
            this.selectiveStretchingToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.kernelToolStripMenuItem,
            this.medianFiltrToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // negationToolStripMenuItem
            // 
            this.negationToolStripMenuItem.Name = "negationToolStripMenuItem";
            this.negationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.negationToolStripMenuItem.Text = "Negation";
            this.negationToolStripMenuItem.Click += new System.EventHandler(this.negationToolStripMenuItem_Click);
            // 
            // posterizationToolStripMenuItem
            // 
            this.posterizationToolStripMenuItem.Name = "posterizationToolStripMenuItem";
            this.posterizationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.posterizationToolStripMenuItem.Text = "Posterization";
            this.posterizationToolStripMenuItem.Click += new System.EventHandler(this.posterizationToolStripMenuItem_Click);
            // 
            // selectiveStretchingToolStripMenuItem
            // 
            this.selectiveStretchingToolStripMenuItem.Name = "selectiveStretchingToolStripMenuItem";
            this.selectiveStretchingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.selectiveStretchingToolStripMenuItem.Text = "Selective stretching";
            this.selectiveStretchingToolStripMenuItem.Click += new System.EventHandler(this.selectiveStretchingToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem1,
            this.laplacianToolStripMenuItem,
            this.cannyToolStripMenuItem1});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge detection";
            // 
            // sobelToolStripMenuItem1
            // 
            this.sobelToolStripMenuItem1.Name = "sobelToolStripMenuItem1";
            this.sobelToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.sobelToolStripMenuItem1.Text = "Sobel";
            this.sobelToolStripMenuItem1.Click += new System.EventHandler(this.sobelToolStripMenuItem1_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem1
            // 
            this.cannyToolStripMenuItem1.Name = "cannyToolStripMenuItem1";
            this.cannyToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.cannyToolStripMenuItem1.Text = "Canny";
            this.cannyToolStripMenuItem1.Click += new System.EventHandler(this.cannyToolStripMenuItem1_Click);
            // 
            // kernelToolStripMenuItem
            // 
            this.kernelToolStripMenuItem.Name = "kernelToolStripMenuItem";
            this.kernelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kernelToolStripMenuItem.Text = "Kernel";
            this.kernelToolStripMenuItem.Click += new System.EventHandler(this.kernelToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramTableGrayToolStripMenuItem,
            this.tableLUTToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.histogramRGBToolStripMenuItem,
            this.plotProfileToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // histogramTableGrayToolStripMenuItem
            // 
            this.histogramTableGrayToolStripMenuItem.Name = "histogramTableGrayToolStripMenuItem";
            this.histogramTableGrayToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramTableGrayToolStripMenuItem.Text = "Histogram Table Gray";
            this.histogramTableGrayToolStripMenuItem.Click += new System.EventHandler(this.histogramTableGrayToolStripMenuItem_Click);
            // 
            // tableLUTToolStripMenuItem
            // 
            this.tableLUTToolStripMenuItem.Name = "tableLUTToolStripMenuItem";
            this.tableLUTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tableLUTToolStripMenuItem.Text = "Histogram Table RGB";
            this.tableLUTToolStripMenuItem.Click += new System.EventHandler(this.tableLUTToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramToolStripMenuItem.Text = "Histogram Gray";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // histogramRGBToolStripMenuItem
            // 
            this.histogramRGBToolStripMenuItem.Name = "histogramRGBToolStripMenuItem";
            this.histogramRGBToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramRGBToolStripMenuItem.Text = "Histogram RGB";
            this.histogramRGBToolStripMenuItem.Click += new System.EventHandler(this.histogramRGBToolStripMenuItem_Click);
            // 
            // plotProfileToolStripMenuItem
            // 
            this.plotProfileToolStripMenuItem.Name = "plotProfileToolStripMenuItem";
            this.plotProfileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.plotProfileToolStripMenuItem.Text = "Plot profile";
            this.plotProfileToolStripMenuItem.Click += new System.EventHandler(this.plotProfileToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif\"";
            // 
            // medianFiltrToolStripMenuItem
            // 
            this.medianFiltrToolStripMenuItem.Name = "medianFiltrToolStripMenuItem";
            this.medianFiltrToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.medianFiltrToolStripMenuItem.Text = "Median filter";
            this.medianFiltrToolStripMenuItem.Click += new System.EventHandler(this.medianFiltrToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(434, 52);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tableLUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMonochromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramTableGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToLABToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posterizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveStretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFiltrToolStripMenuItem;
    }
}


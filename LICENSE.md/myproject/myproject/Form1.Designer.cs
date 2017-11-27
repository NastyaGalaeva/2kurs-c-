namespace Collage

{
    partial class Form1
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
            this.btnChooseFiles = new System.Windows.Forms.Button();
            this.btnCollage = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudScalePercent = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudItemHeight = new System.Windows.Forms.NumericUpDown();
            this.nudItemWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudScalePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseFiles
            // 
            this.btnChooseFiles.AutoEllipsis = true;
            this.btnChooseFiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChooseFiles.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFiles.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnChooseFiles.Location = new System.Drawing.Point(4, 162);
            this.btnChooseFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseFiles.Name = "btnChooseFiles";
            this.btnChooseFiles.Size = new System.Drawing.Size(102, 29);
            this.btnChooseFiles.TabIndex = 0;
            this.btnChooseFiles.Text = "Добавить ...";
            this.btnChooseFiles.UseVisualStyleBackColor = true;
            this.btnChooseFiles.Click += new System.EventHandler(this.bntChooseDir_Click);
            // 
            // btnCollage
            // 
            this.btnCollage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollage.Enabled = false;
            this.btnCollage.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollage.Location = new System.Drawing.Point(228, 162);
            this.btnCollage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCollage.Name = "btnCollage";
            this.btnCollage.Size = new System.Drawing.Size(102, 29);
            this.btnCollage.TabIndex = 1;
            this.btnCollage.Text = "Создать ";
            this.btnCollage.UseVisualStyleBackColor = true;
            this.btnCollage.Click += new System.EventHandler(this.btnCollage_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 1);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 154);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Высота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Строки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Столбцы:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.jpg)|*jpg";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOutputDir.Location = new System.Drawing.Point(116, 162);
            this.btnSelectOutputDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(102, 29);
            this.btnSelectOutputDir.TabIndex = 15;
            this.btnSelectOutputDir.Text = "Сохранить в ...";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Масштаб:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "%";
            // 
            // nudScalePercent
            // 
            this.nudScalePercent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScalePercent.Location = new System.Drawing.Point(351, 26);
            this.nudScalePercent.Margin = new System.Windows.Forms.Padding(4);
            this.nudScalePercent.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudScalePercent.Name = "nudScalePercent";
            this.nudScalePercent.Size = new System.Drawing.Size(38, 23);
            this.nudScalePercent.TabIndex = 22;
            this.nudScalePercent.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(87, 51);
            this.nudColumns.Margin = new System.Windows.Forms.Padding(4);
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(52, 23);
            this.nudColumns.TabIndex = 10;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(87, 23);
            this.nudRows.Margin = new System.Windows.Forms.Padding(4);
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(52, 23);
            this.nudRows.TabIndex = 9;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // nudItemHeight
            // 
            this.nudItemHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudItemHeight.Location = new System.Drawing.Point(216, 51);
            this.nudItemHeight.Margin = new System.Windows.Forms.Padding(4);
            this.nudItemHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudItemHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemHeight.Name = "nudItemHeight";
            this.nudItemHeight.Size = new System.Drawing.Size(52, 23);
            this.nudItemHeight.TabIndex = 6;
            this.nudItemHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemHeight.ValueChanged += new System.EventHandler(this.nudItemHeight_ValueChanged);
            // 
            // nudItemWidth
            // 
            this.nudItemWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudItemWidth.Location = new System.Drawing.Point(216, 23);
            this.nudItemWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nudItemWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudItemWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemWidth.Name = "nudItemWidth";
            this.nudItemWidth.Size = new System.Drawing.Size(52, 23);
            this.nudItemWidth.TabIndex = 3;
            this.nudItemWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemWidth.ValueChanged += new System.EventHandler(this.nudItemWidth_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudItemWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudScalePercent);
            this.groupBox1.Controls.Add(this.nudItemHeight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRows);
            this.groupBox1.Controls.Add(this.nudColumns);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 89);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 294);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 22);
            this.progressBar1.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(339, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 29);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(426, 319);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectOutputDir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCollage);
            this.Controls.Add(this.btnChooseFiles);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Collage";
            ((System.ComponentModel.ISupportInitialize)(this.nudScalePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFiles;
        private System.Windows.Forms.Button btnCollage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nudItemWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudItemHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectOutputDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudScalePercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancel;
    }
}


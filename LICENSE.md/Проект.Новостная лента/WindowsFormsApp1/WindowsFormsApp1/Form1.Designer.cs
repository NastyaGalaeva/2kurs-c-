namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxFeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listViewEntries
            // 
            this.listViewEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderTitle,
            this.columnHeaderLink,
            this.columnHeaderAuthor});
            this.listViewEntries.Location = new System.Drawing.Point(12, 37);
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(558, 220);
            this.listViewEntries.TabIndex = 3;
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.SelectedIndexChanged += new System.EventHandler(this.listViewEntries_SelectedIndexChanged);
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата публикации";
            this.columnHeaderDate.Width = 110;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Заголовок";
            this.columnHeaderTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTitle.Width = 258;
            // 
            // columnHeaderLink
            // 
            this.columnHeaderLink.Text = "Ссылка";
            this.columnHeaderLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLink.Width = 95;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Автор";
            this.columnHeaderAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAuthor.Width = 95;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(551, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(21, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = ">";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxFeed
            // 
            this.textBoxFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFeed.Location = new System.Drawing.Point(84, 9);
            this.textBoxFeed.Name = "textBoxFeed";
            this.textBoxFeed.Size = new System.Drawing.Size(461, 20);
            this.textBoxFeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загружено:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxFeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лента новостей";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLink;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}


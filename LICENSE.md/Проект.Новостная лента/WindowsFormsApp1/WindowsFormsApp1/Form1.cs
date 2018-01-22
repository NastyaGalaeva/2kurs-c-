using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Feed _feed = new Feed();

        public Form1()
        {
            InitializeComponent();

            this.textBoxFeed.Text = @"https://ru.investing.com/rss/news.rss";
            LoadFeed(textBoxFeed.Text);
            timer1.Start();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadFeed(textBoxFeed.Text);
            timer1.Start();
        }

        private void LoadFeed(string url)
        {
            listViewEntries.Items.Clear();

            Channel channel = _feed.Read(url);

            this.Text = "Лента новостей - " + channel.Title;

            foreach (Item item in channel.Items)
            {
                ListViewItem listViewItem = new ListViewItem(item.PubDate.ToString());
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Link);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.Tag = item;
                listViewEntries.Items.Add(listViewItem);
            }
        }

        
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listViewEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadFeed(textBoxFeed.Text);
        }
    }
}

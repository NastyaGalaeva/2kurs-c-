using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    internal class Channel
    {
        public string Title { get; set; }
        public string Link { get; set; }               
        public List<Item> Items { get; set; }
    }
}
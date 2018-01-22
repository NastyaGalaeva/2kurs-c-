using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;

namespace Новостная_лента
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static string LoadPage()
        //{
        //    var result = "";
        //    var request = (HttpWebRequest)WebRequest.Create(@"https://ria.ru/lenta/");
        //    var response = (HttpWebResponse)request.GetResponse();

        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        var receiveStream = response.GetResponseStream();
        //        if (receiveStream != null)
        //        {
        //            StreamReader readStream;
        //            if (response.CharacterSet == null)
        //                readStream = new StreamReader(receiveStream);
        //            else
        //                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
        //            result = readStream.ReadToEnd();
        //            readStream.Close();
        //        }
        //        response.Close();
        //    }
        //    return result;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace vize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Altin();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Altin()
        {
            XmlDocument dosya = new XmlDocument();
            string link = "http://www.kulcealtin.com/altinxml/";
            dosya.Load(link);
            XmlNodeList tür = dosya.DocumentElement.SelectNodes("altin");
            foreach (XmlNode altin in tür)
            {
                if (!comboBox1.Items.Contains(altin.SelectSingleNode("adi").InnerText))
                {
                    comboBox1.Items.Add(altin.SelectSingleNode("adi").InnerText);
                }
            }
            comboBox1.Sorted = true;
            foreach (XmlNode item in tür)
            {
                string saflik = item.SelectSingleNode("adi").InnerText;
                if (saflik==comboBox1.Text)
                {
                    string altin_adi = item.SelectSingleNode("adi").InnerText;
                    string saf = item.SelectSingleNode("field").InnerText;
                    string alis = (item.SelectSingleNode("al").InnerText);
                    string satis = (item.SelectSingleNode("sat").InnerText);
                    text_adi.Text = altin_adi;
                    text_saflık.Text = saf;
                    text_alis.Text = alis.ToString();
                    text_satis.Text = satis.ToString();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Altin();
        }
    }
}

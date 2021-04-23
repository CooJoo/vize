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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Altin();
        }
    }
}

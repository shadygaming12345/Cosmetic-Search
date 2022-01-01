using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace FortniteCPGenerator
{
    public partial class Form1 : Form
    {
        public static WebClient wc =  new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parsed2 = wc.DownloadString("https://fortnite-api.com/v2/cosmetics/br/search?backendType=AthenaCharacter&matchMethod=contains&name=" + richTextBox1.Text);
            var Parsed = JObject.Parse(parsed2);
            var parsed1 = Parsed["data"]["images"];
            richTextBox2.Text = (string)Parsed["data"]["path"];
            pictureBox1.ImageLocation = (string)parsed1["icon"];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

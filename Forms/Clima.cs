using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMiLibrero.Forms
{
    public partial class tbUbicacion : Form
    {
        public tbUbicacion()
        {
            InitializeComponent();
        }

        private void Clima_Load(object sender, EventArgs e)
        {
            string urlXml = "https://api.weatherapi.com/v1/current.xml?key=992efa6760594af59d4165159222001&q=Mexico";
            string urlJson = "https://api.weatherapi.com/v1/current.json?key=992efa6760594af59d4165159222001&q=Mexico";
            //WebRequest request = WebRequest.Create(urlJson);
            //request.Method = "GET";
            //WebResponse response = request.GetResponse();
            
            var json = new WebClient().DownloadString(urlJson);
            dynamic m = JsonConvert.DeserializeObject(json);
            textBox1.Text = m.location.name;
            tbTC.Text = m.current.temp_c;
            tbTF.Text = m.current.temp_f;
            tbCondiciones.Text = m.current.condition.text;
            tbHumedad.Text = m.current.humidity;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

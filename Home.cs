using AppMiLibrero.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMiLibrero
{
    public partial class Home : Form
    {

        wsMiLibrero.WebService1SoapClient ws = new wsMiLibrero.WebService1SoapClient();

        public Home()
        {
            InitializeComponent();
            AbrirFormPanel(new tbUbicacion());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //wsMiLibrero.Consulta_Autores_Result[] results;
            //results = ws.Consulta_Autores("V");
            //ws.Alta_Autor("Fernando", "Mexico");
        }

        public void AbrirFormPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(this.PanelContenedor.Controls.Count - 1);
            Form form = FormHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(form);
            this.PanelContenedor.Tag = form;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Alta_Libro());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Consulta_Libro());
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new tbUbicacion());
        }
    }
}

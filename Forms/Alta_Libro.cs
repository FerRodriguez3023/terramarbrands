using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMiLibrero.Forms
{
    public partial class Alta_Libro : Form
    {
        wsMiLibrero.WebService1SoapClient ws = new wsMiLibrero.WebService1SoapClient();

        public Alta_Libro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsMiLibrero.Alta_Libro_Result results;
            bool correto = true;

            string ISBN = tbISBN.Text.ToString();
            string Titulo = tbTitulo.Text.ToString();

            if (ISBN == "" || Titulo == "" || tbAxo.Text.ToString() == "" || tbNoPaginas.Text.ToString() == "" ) 
            {
                MessageBox.Show("Se debe de llenar el formulario");
                return;
            }

            int Axo = Convert.ToInt32(tbAxo.Text.ToString());
            int NoPaginas = Convert.ToInt32(tbNoPaginas.Text.ToString());

            string result = ws.Alta_Libro(ISBN, Titulo, Axo, NoPaginas).OBSERVACIONES;

            MessageBox.Show(result);
        }

        private void tbAxo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNoPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Alta_Libro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNoPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAxo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

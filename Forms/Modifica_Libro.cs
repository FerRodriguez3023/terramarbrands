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
    public partial class Modifica_Libro : Form
    {
        wsMiLibrero.WebService1SoapClient ws = new wsMiLibrero.WebService1SoapClient();
        string IdLibro;
        string ISBN;
        public Modifica_Libro(string xIdLibro, string xISBN)
        {
            InitializeComponent();

            IdLibro = xIdLibro;
            ISBN = xISBN;

            //Buscamos los autores
            wsMiLibrero.Consulta_Autores_Result[] results;
            results = ws.Consulta_Autores("V");

            //Recorremos los autores
            int x = 0;
            foreach (wsMiLibrero.Consulta_Autores_Result item in results)
            {
                cbAutores.Items.Add(item.Nombre);
                cbIdAutor.Items.Add(item.IdAutor);
                x++;
            }

            //Obtenemos la informaión del libro
            wsMiLibrero.Consulta_Libro_Result[] resultsLibros;
            resultsLibros = ws.Consulta_Libro(ISBN, "", "", "");

            //Recorremos el libro
            int y = 0;
            foreach (wsMiLibrero.Consulta_Libro_Result item in resultsLibros)
            {
                tbISBN.Text = item.ISBN;
                tbTitulo.Text = item.Titulo;
                tbAxo.Text = item.Axo.ToString();
                tbNoPaginas.Text = item.NoPaginas.ToString();
                y++;
            }


        }

        private void Modifica_Libro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIdAutor.SelectedIndex = cbAutores.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsMiLibrero.Actualiza_Libro_Result results;
            bool correto = true;

            string IdAutor = cbIdAutor.SelectedItem.ToString();
            string ISBN = tbISBN.Text.ToString();
            string Titulo = tbTitulo.Text.ToString();

            if (ISBN == "" || Titulo == "" || tbAxo.Text.ToString() == "" || tbNoPaginas.Text.ToString() == "")
            {
                MessageBox.Show("Se debe de llenar el formulario");
                return;
            }

            int Axo = Convert.ToInt32(tbAxo.Text.ToString());
            int NoPaginas = Convert.ToInt32(tbNoPaginas.Text.ToString());
            results = ws.Actualiza_Libro(IdLibro, ISBN, Titulo, Axo, NoPaginas, IdAutor, "V");

            MessageBox.Show(results.OBSERVACIONES);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wsMiLibrero.Elimina_Libro_Result results;
            results = ws.Elimina_Libro(IdLibro);
            MessageBox.Show(results.OBSERVACIONES);
        }
    }
}

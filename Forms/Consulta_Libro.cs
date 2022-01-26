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
    public partial class Consulta_Libro : Form
    {

        wsMiLibrero.WebService1SoapClient ws = new wsMiLibrero.WebService1SoapClient();

        public Consulta_Libro()
        {
            InitializeComponent();
        }

        private void Consulta_Libro_Load(object sender, EventArgs e)
        {
            ActualizaGrid(ws.Consulta_Libro("", "", "", ""));
        }
        public void ActualizaGrid(wsMiLibrero.Consulta_Libro_Result[] results) 
        {
            dataGridView1.Rows.Clear();
            int x = 0;
            foreach (wsMiLibrero.Consulta_Libro_Result item in results)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[x].Cells[0].Value = item.IdLibro;
                dataGridView1.Rows[x].Cells[1].Value = item.ISBN;
                dataGridView1.Rows[x].Cells[2].Value = item.Titulo;
                dataGridView1.Rows[x].Cells[3].Value = item.Axo;
                dataGridView1.Rows[x].Cells[4].Value = item.NoPaginas;
                dataGridView1.Rows[x].Cells[5].Value = item.Estatus;
                dataGridView1.Rows[x].Cells[6].Value = item.FechaAlta;
                dataGridView1.Rows[x].Cells[7].Value = item.Autor;

                x++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ISBN = tbISBN.Text.ToString();
            string Titulo = tbTitulo.Text.ToString();
            string Autor = tbAutor.Text.ToString();
            ActualizaGrid(ws.Consulta_Libro(ISBN, Titulo, Autor, ""));
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdLibro = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ISBN = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Modifica_Libro formAltaAgentes = new Modifica_Libro(IdLibro, ISBN);
            formAltaAgentes.ShowDialog(this);
        }
    }
}

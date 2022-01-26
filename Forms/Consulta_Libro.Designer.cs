namespace AppMiLibrero.Forms
{
    partial class Consulta_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.ISBN,
            this.Titulo,
            this.Axo,
            this.NoPaginas,
            this.Estatus,
            this.FechaAlta,
            this.Autor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Axo
            // 
            this.Axo.HeaderText = "Año";
            this.Axo.Name = "Axo";
            // 
            // NoPaginas
            // 
            this.NoPaginas.HeaderText = "No. Paginas";
            this.NoPaginas.Name = "NoPaginas";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ISBN";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(87, 38);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(177, 20);
            this.tbTitulo.TabIndex = 16;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(87, 12);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(177, 20);
            this.tbISBN.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Autor";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(87, 64);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(177, 20);
            this.tbAutor.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Consulta_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 416);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta_Libro";
            this.Text = "Consulta_Libro";
            this.Load += new System.EventHandler(this.Consulta_Libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Button button3;
    }
}
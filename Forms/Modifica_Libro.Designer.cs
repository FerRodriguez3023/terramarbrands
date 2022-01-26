namespace AppMiLibrero.Forms
{
    partial class Modifica_Libro
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoPaginas = new System.Windows.Forms.TextBox();
            this.tbAxo = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.cbIdAutor = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "No. Paginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ISBN";
            // 
            // tbNoPaginas
            // 
            this.tbNoPaginas.Location = new System.Drawing.Point(146, 118);
            this.tbNoPaginas.Name = "tbNoPaginas";
            this.tbNoPaginas.Size = new System.Drawing.Size(177, 20);
            this.tbNoPaginas.TabIndex = 16;
            // 
            // tbAxo
            // 
            this.tbAxo.Location = new System.Drawing.Point(146, 92);
            this.tbAxo.Name = "tbAxo";
            this.tbAxo.Size = new System.Drawing.Size(177, 20);
            this.tbAxo.TabIndex = 15;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(146, 66);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(177, 20);
            this.tbTitulo.TabIndex = 14;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(146, 40);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(177, 20);
            this.tbISBN.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Autor";
            // 
            // cbAutores
            // 
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(146, 146);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(177, 21);
            this.cbAutores.TabIndex = 24;
            this.cbAutores.SelectedIndexChanged += new System.EventHandler(this.cbAutores_SelectedIndexChanged);
            // 
            // cbIdAutor
            // 
            this.cbIdAutor.FormattingEnabled = true;
            this.cbIdAutor.Location = new System.Drawing.Point(329, 146);
            this.cbIdAutor.Name = "cbIdAutor";
            this.cbIdAutor.Size = new System.Drawing.Size(177, 21);
            this.cbIdAutor.TabIndex = 25;
            this.cbIdAutor.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Modifica_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 416);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbIdAutor);
            this.Controls.Add(this.cbAutores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoPaginas);
            this.Controls.Add(this.tbAxo);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modifica_Libro";
            this.Text = "Modifica_Libro";
            this.Load += new System.EventHandler(this.Modifica_Libro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoPaginas;
        private System.Windows.Forms.TextBox tbAxo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.ComboBox cbIdAutor;
        private System.Windows.Forms.Button button3;
    }
}
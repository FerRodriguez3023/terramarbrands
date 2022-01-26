namespace AppMiLibrero.Forms
{
    partial class Alta_Libro
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
            this.components = new System.ComponentModel.Container();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAxo = new System.Windows.Forms.TextBox();
            this.tbNoPaginas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(135, 37);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(177, 20);
            this.tbISBN.TabIndex = 0;
            this.tbISBN.TextChanged += new System.EventHandler(this.tbISBN_TextChanged);
            this.tbISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbISBN_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(135, 63);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(177, 20);
            this.tbTitulo.TabIndex = 2;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbTitulo_TextChanged);
            // 
            // tbAxo
            // 
            this.tbAxo.Location = new System.Drawing.Point(135, 89);
            this.tbAxo.Name = "tbAxo";
            this.tbAxo.Size = new System.Drawing.Size(177, 20);
            this.tbAxo.TabIndex = 3;
            this.tbAxo.TextChanged += new System.EventHandler(this.tbAxo_TextChanged);
            this.tbAxo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAxo_KeyPress);
            // 
            // tbNoPaginas
            // 
            this.tbNoPaginas.Location = new System.Drawing.Point(135, 115);
            this.tbNoPaginas.Name = "tbNoPaginas";
            this.tbNoPaginas.Size = new System.Drawing.Size(177, 20);
            this.tbNoPaginas.TabIndex = 4;
            this.tbNoPaginas.TextChanged += new System.EventHandler(this.tbNoPaginas_TextChanged);
            this.tbNoPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoPaginas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. Paginas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alta_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 416);
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
            this.Name = "Alta_Libro";
            this.Text = "Alta_Libro";
            this.Load += new System.EventHandler(this.Alta_Libro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAxo;
        private System.Windows.Forms.TextBox tbNoPaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
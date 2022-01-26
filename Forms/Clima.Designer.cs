namespace AppMiLibrero.Forms
{
    partial class tbUbicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCondiciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHumedad = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura °C";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTC
            // 
            this.tbTC.Location = new System.Drawing.Point(272, 97);
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(100, 20);
            this.tbTC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura °F";
            // 
            // tbTF
            // 
            this.tbTF.Location = new System.Drawing.Point(272, 128);
            this.tbTF.Name = "tbTF";
            this.tbTF.Size = new System.Drawing.Size(100, 20);
            this.tbTF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Condiciónes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbCondiciones
            // 
            this.tbCondiciones.Location = new System.Drawing.Point(272, 163);
            this.tbCondiciones.Name = "tbCondiciones";
            this.tbCondiciones.Size = new System.Drawing.Size(100, 20);
            this.tbCondiciones.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Humedad";
            // 
            // tbHumedad
            // 
            this.tbHumedad.Location = new System.Drawing.Point(272, 192);
            this.tbHumedad.Name = "tbHumedad";
            this.tbHumedad.Size = new System.Drawing.Size(100, 20);
            this.tbHumedad.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // tbUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHumedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCondiciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tbUbicacion";
            this.Text = "Clima";
            this.Load += new System.EventHandler(this.Clima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCondiciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHumedad;
        private System.Windows.Forms.TextBox textBox1;
    }
}
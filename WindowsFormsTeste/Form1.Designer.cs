namespace WindowsFormsTeste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textn1 = new System.Windows.Forms.TextBox();
            this.textn2 = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.labelresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "número 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "número 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textn1
            // 
            this.textn1.Location = new System.Drawing.Point(173, 75);
            this.textn1.Name = "textn1";
            this.textn1.Size = new System.Drawing.Size(435, 20);
            this.textn1.TabIndex = 2;
            // 
            // textn2
            // 
            this.textn2.Location = new System.Drawing.Point(173, 134);
            this.textn2.Name = "textn2";
            this.textn2.Size = new System.Drawing.Size(435, 20);
            this.textn2.TabIndex = 3;
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(133, 259);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(106, 49);
            this.somar.TabIndex = 4;
            this.somar.Text = "somar";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(316, 259);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(118, 49);
            this.limpar.TabIndex = 5;
            this.limpar.Text = "limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(508, 259);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(122, 49);
            this.fechar.TabIndex = 6;
            this.fechar.Text = "fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // labelresultado
            // 
            this.labelresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.Location = new System.Drawing.Point(102, 379);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(100, 23);
            this.labelresultado.TabIndex = 7;
            this.labelresultado.Text = "resultado:";
            this.labelresultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.textn2);
            this.Controls.Add(this.textn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textn1;
        private System.Windows.Forms.TextBox textn2;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label labelresultado;
    }
}


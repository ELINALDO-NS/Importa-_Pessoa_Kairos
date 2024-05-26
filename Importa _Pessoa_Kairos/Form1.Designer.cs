namespace Importa__Pessoa_Kairos
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
            this.button1 = new System.Windows.Forms.Button();
            this.LocalDoArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Chave = new System.Windows.Forms.TextBox();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.LBL_Progresso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocalDoArquivo
            // 
            this.LocalDoArquivo.Location = new System.Drawing.Point(19, 40);
            this.LocalDoArquivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocalDoArquivo.Name = "LocalDoArquivo";
            this.LocalDoArquivo.ReadOnly = true;
            this.LocalDoArquivo.Size = new System.Drawing.Size(195, 21);
            this.LocalDoArquivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local do Arquivo";
            // 
            // CNPJ
            // 
            this.CNPJ.Location = new System.Drawing.Point(19, 91);
            this.CNPJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Size = new System.Drawing.Size(147, 21);
            this.CNPJ.TabIndex = 3;
            this.CNPJ.Text = "15.127.483/0014-81";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(19, 145);
            this.CPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(147, 21);
            this.CPF.TabIndex = 5;
            this.CPF.Text = "905.200.335-15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chave";
            // 
            // Chave
            // 
            this.Chave.Location = new System.Drawing.Point(19, 202);
            this.Chave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Chave.Name = "Chave";
            this.Chave.Size = new System.Drawing.Size(236, 21);
            this.Chave.TabIndex = 7;
            // 
            // btn_Importar
            // 
            this.btn_Importar.Location = new System.Drawing.Point(19, 238);
            this.btn_Importar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(195, 28);
            this.btn_Importar.TabIndex = 9;
            this.btn_Importar.Text = "Importar";
            this.btn_Importar.UseVisualStyleBackColor = true;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // LBL_Progresso
            // 
            this.LBL_Progresso.AutoSize = true;
            this.LBL_Progresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Progresso.Location = new System.Drawing.Point(222, 245);
            this.LBL_Progresso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Progresso.Name = "LBL_Progresso";
            this.LBL_Progresso.Size = new System.Drawing.Size(0, 15);
            this.LBL_Progresso.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 279);
            this.Controls.Add(this.LBL_Progresso);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Chave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalDoArquivo);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação_Kairos_Danco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LocalDoArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Chave;
        private System.Windows.Forms.Button btn_Importar;
        private System.Windows.Forms.Label LBL_Progresso;
    }
}


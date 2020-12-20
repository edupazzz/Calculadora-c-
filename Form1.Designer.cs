
namespace Calculadora_02
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
            this.tb_tela = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtrai = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_multp = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_ponto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_tela
            // 
            this.tb_tela.BackColor = System.Drawing.Color.DarkBlue;
            this.tb_tela.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tela.Location = new System.Drawing.Point(12, 12);
            this.tb_tela.Multiline = true;
            this.tb_tela.Name = "tb_tela";
            this.tb_tela.ReadOnly = true;
            this.tb_tela.Size = new System.Drawing.Size(307, 73);
            this.tb_tela.TabIndex = 0;
            this.tb_tela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 154);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(53, 37);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(71, 197);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(53, 37);
            this.btn_5.TabIndex = 2;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 197);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(53, 37);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 240);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(53, 37);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(71, 240);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(53, 37);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(71, 154);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(53, 37);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(130, 154);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(53, 37);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(130, 240);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(53, 37);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(130, 197);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(53, 37);
            this.btn_6.TabIndex = 15;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(12, 283);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(171, 37);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_igual.Location = new System.Drawing.Point(207, 261);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(112, 59);
            this.btn_igual.TabIndex = 17;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_soma.Location = new System.Drawing.Point(266, 172);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(53, 37);
            this.btn_soma.TabIndex = 18;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtrai
            // 
            this.btn_subtrai.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_subtrai.Location = new System.Drawing.Point(266, 218);
            this.btn_subtrai.Name = "btn_subtrai";
            this.btn_subtrai.Size = new System.Drawing.Size(53, 37);
            this.btn_subtrai.TabIndex = 19;
            this.btn_subtrai.Text = "-";
            this.btn_subtrai.UseVisualStyleBackColor = false;
            this.btn_subtrai.Click += new System.EventHandler(this.btn_subtrai_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_limpa.Location = new System.Drawing.Point(12, 91);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(53, 42);
            this.btn_limpa.TabIndex = 20;
            this.btn_limpa.Text = "C";
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_apagar.Location = new System.Drawing.Point(266, 91);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(53, 24);
            this.btn_apagar.TabIndex = 21;
            this.btn_apagar.Text = "<---";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_multp
            // 
            this.btn_multp.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_multp.Location = new System.Drawing.Point(207, 172);
            this.btn_multp.Name = "btn_multp";
            this.btn_multp.Size = new System.Drawing.Size(53, 37);
            this.btn_multp.TabIndex = 22;
            this.btn_multp.Text = "x";
            this.btn_multp.UseVisualStyleBackColor = false;
            this.btn_multp.Click += new System.EventHandler(this.btn_multp_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_divide.Location = new System.Drawing.Point(207, 218);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(53, 37);
            this.btn_divide.TabIndex = 23;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_ponto
            // 
            this.btn_ponto.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ponto.Location = new System.Drawing.Point(266, 129);
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Size = new System.Drawing.Size(53, 37);
            this.btn_ponto.TabIndex = 24;
            this.btn_ponto.Text = ".";
            this.btn_ponto.UseVisualStyleBackColor = false;
            this.btn_ponto.Click += new System.EventHandler(this.btn_ponto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(331, 353);
            this.Controls.Add(this.btn_ponto);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multp);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_subtrai);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.tb_tela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tela;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtrai;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_multp;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_ponto;
    }
}


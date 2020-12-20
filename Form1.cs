using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        
        private void btn_1_Click(object sender, EventArgs e)
        {
            //Num 1
            tb_tela.Text = tb_tela.Text + 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            //Num 2
            tb_tela.Text = tb_tela.Text + 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            //Num 3
            tb_tela.Text = tb_tela.Text + 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            //Num 4
            tb_tela.Text = tb_tela.Text + 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            //Num 5
            tb_tela.Text = tb_tela.Text + 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            //Num 6
            tb_tela.Text = tb_tela.Text + 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            //Num 7
            tb_tela.Text = tb_tela.Text + 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            //Num 8
            tb_tela.Text = tb_tela.Text + 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            //Num 9
            tb_tela.Text = tb_tela.Text + 9;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            //Num 0
            tb_tela.Text = tb_tela.Text + 0;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            //Botao de soma - Sum
            if (tb_tela.Text != "")
            {
                num1 = float.Parse(tb_tela.Text);
                tb_tela.Clear();
                tb_tela.Focus();
                count = 1;
            }
        }
         //##########     Buttons-Botoes     ##########
        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            //Botao de subtrai - Subtraction
            if (tb_tela.Text != "")
            {
                num1 = float.Parse(tb_tela.Text);
                tb_tela.Clear();
                tb_tela.Focus();
                count = 2;
            }
        }

        private void btn_multp_Click(object sender, EventArgs e)
        {
            //Botao Multiplica - Multiplication
            if (tb_tela.Text !="") 
            {
                num1 = float.Parse(tb_tela.Text);
                tb_tela.Clear();
                tb_tela.Focus();
                count = 3;
            };
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            //Botao divisao - Division
            if (tb_tela.Text != "")
            {
                num1 = float.Parse(tb_tela.Text);
                tb_tela.Clear();
                tb_tela.Focus();
                count = 4;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            //Botao mostrar resultado - Show results
            compute(count);
        }

      
        public void compute(int count)
        {
            switch(count)
            {
                case 1:
                    ans = num1 + float.Parse(tb_tela.Text);
                    tb_tela.Text = ans.ToString();
                    break;

                case 2:
                    ans = num1 - float.Parse(tb_tela.Text);
                    tb_tela.Text = ans.ToString();
                    break;

                case 3:
                    ans = num1 * float.Parse(tb_tela.Text);
                    tb_tela.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(tb_tela.Text);
                    tb_tela.Text = ans.ToString();
                    break;
            }
        }

        
        private void btn_limpa_Click(object sender, EventArgs e)
        {
            //Limpar tela
            tb_tela.Clear();
            count = 0;
        }

       
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //Botao Apagar
            int length = tb_tela.TextLength-1;
            string texto = tb_tela.Text;
            tb_tela.Clear();

            for (int i=0; i < length; i++)
            {
                tb_tela.Text = tb_tela.Text + texto[i];
            };
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            //Botao Ponto - Dot btn
            int tx_l = tb_tela.TextLength;
            int flag = 0;
            string tb_texto = tb_tela.Text;
            
            for (int i=0; i < tx_l; i++)
            { 
                if(tb_texto[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else { flag = 0; }

                if (flag==0)
                { tb_tela.Text = tb_tela.Text + "."; }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosDiversos.ProjetoBancoDeSangue.Main
{
    public partial class Form1 : Form
    {
        int ap = 30;
        int an = 20;
        int bp = 30;
        int bn = 10;
        int abp = 15;
        int abn = 20;
        int op = 20;
        int on = 30;
        int quantidadeRetirada;
        int estoqueTotal;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            quantidadeRetirada = Int32.Parse(txtQuantidade.Text);
            txtConsole.Clear();
            if (rbAp.Checked)
            {   
                ap -= Retirada(ap);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo A+ disponivel atualmente: {ap}";
            }
            else if (rbAn.Checked)
            {
                an -= Retirada(an);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo A- disponivel atualmente: {an}";
            }else if (rbBp.Checked)
            {
                bp -= Retirada(bp);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo B+ disponivel atualmente: {bp}";
            }
            else if (rbBn.Checked)
            {
                bn -= Retirada(bn);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo B- disponivel atualmente: {bn}";
            }
            else if (rbABp.Checked)
            {
                abp -= Retirada(abp);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo B+ disponivel atualmente: {abp}";
            }
            else if (rbABn.Checked)
            {
                abn -= Retirada(abn);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo B- disponivel atualmente: {abn}";
            }
            else if (rbOp.Checked)
            {
                op -= Retirada(op);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo O+ disponivel atualmente: {op}";
            }
            else if (rbOn.Checked)
            {
                on -= Retirada(on);
                txtConsole.Text += $"\r\nEstoque de sangue do tipo O- disponivel atualmente: {on}";
            }
        }
        private void btnDoar_Click(object sender, EventArgs e)
        {
            int idade = Int32.Parse(txtIdade.Text);
            estoqueTotal = ap + an + bp + bn + abp + abn + op + on;
            txtConsole.Clear();
            if (estoqueTotal > 199)
            {
                txtConsole.Text += "Estoque cheio";
            }
            else if (idade > 59 || idade < 18)
            {
                txtConsole.Text += "Doação indisponível, paciente fora da faixa de idade";
            }
            else
            {
                if (rbAp.Checked)
                {
                    ap += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo A+ disponivel atualmente: {ap}";
                }
                else if (rbAn.Checked)
                {
                    an += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo A- disponivel atualmente: {an}";
                }
                else if (rbBp.Checked)
                {
                    bp+=Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo B+ disponivel atualmente: {bp}";
                }
                else if (rbBn.Checked)
                {
                    bn += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo B- disponivel atualmente: {bn}";
                }
                else if (rbABp.Checked)
                {
                    abp += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo B+ disponivel atualmente: {abp}";
                }
                else if (rbABn.Checked)
                {
                    abn += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo B- disponivel atualmente: {abn}";
                }
                else if (rbOp.Checked)
                {
                    op =+ Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo O+ disponivel atualmente: {op}";
                }
                else if (rbOn.Checked)
                {
                    on += Doacao();
                    txtConsole.Text += $"\r\nEstoque de sangue do tipo O- disponivel atualmente: {on}";

                }
            }
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            estoqueTotal = ap + an + bp + bn + abp + abn + op + on;
            txtConsole.Clear();
            txtConsole.Text += "\r\nEstoque Atual";
            txtConsole.Text += $"\r\nEstoque Total: {estoqueTotal}";
            txtConsole.Text += $"\r\nA+: {ap}";
            txtConsole.Text += $"\r\nA-: {an}";
            txtConsole.Text += $"\r\nB+: {bp}";
            txtConsole.Text += $"\r\nB-: {bn}";
            txtConsole.Text += $"\r\nAB+: {abn}";
            txtConsole.Text += $"\r\nAB-: {abn}";
            txtConsole.Text += $"\r\nO+: {op}";
            txtConsole.Text += $"\r\nO-: {on}";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtQuantidade.Clear();
            txtConsole.Clear();
        }
        public int Retirada(int tipoSanguineo)
        {
            if (quantidadeRetirada <= tipoSanguineo)
            {
                txtConsole.Text += $"\r\n{txtNome.Text} retirou {quantidadeRetirada} bolsas de sangue";
                return quantidadeRetirada;
            }
            else
            {
               txtConsole.Text +="\r\nEstoque Abaixo da quantidade solicitada";
               return 0;
            }
        }
        public int Doacao()
        {
            txtConsole.Text += $"\r\n{txtNome.Text} doou 1 bolsa de sangue";
            return 1;   
        }
    }
}

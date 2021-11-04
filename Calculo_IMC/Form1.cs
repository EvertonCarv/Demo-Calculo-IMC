using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis
            //variável recebe conteúdo do textbox
            double peso, altura, imc;
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            imc = peso / (altura * altura);
            //textbox recebe conteúdo da variável imc  = resultado do cálculo
            //definição de utilização de 2 casas decimais
            txtimc.Text = imc.ToString("0.00");
            //Condiçoes de acordo com os resultados dos cálculos
            //Serão exibidas mensagens
            //Configuração das  messagebox, (mensagens, botões, ícones)
            //como são várias condições temos encadeamento de ifs
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com Peso dentro da Normalidade", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do Peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("SITUAÇÃO: Você está com Obesidade", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 39.99)
                MessageBox.Show("SITUAÇÃO: Você está com Obesidade de Grau II", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("SITUAÇÃO: Você está com Grau de Obesidade Grau III", "Cálculo de IMC",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtpeso.Text = "";
            txtaltura.Text = "";
            txtimc.Text = "";
            txtpeso.Focus();
        }
        private void KeyPress_Allow_Only_Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        }
}

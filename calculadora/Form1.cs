﻿namespace calculadora
{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
        public decimal valor2 { get; set; }
        public string sinal { get; set; }

        private Operacao operacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text += "9";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text == "")
            {
                resultadoTextBox.Text = "0,";
            }
            else if (!resultadoTextBox.Text.Contains(","))
            {
                resultadoTextBox.Text += ",";
            }
        }

        private void mais_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "+";
                operacaoSelecionada = Operacao.Adicao;
                valor += Convert.ToDecimal(resultadoTextBox.Text);
                valor2 = Convert.ToDecimal(resultadoTextBox.Text);
                resultadoTextBox.Text = "";
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "-";
                operacaoSelecionada = Operacao.Subtracao;
                valor += Convert.ToDecimal(resultadoTextBox.Text);
                valor2 = Convert.ToDecimal(resultadoTextBox.Text);
                resultadoTextBox.Text = "";
            }
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "X";
                operacaoSelecionada = Operacao.Multiplicacao;
                valor += Convert.ToDecimal(resultadoTextBox.Text);          
                valor2 = Convert.ToDecimal(resultadoTextBox.Text);
                resultadoTextBox.Text = "";
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "/";
                operacaoSelecionada = Operacao.Divisao;
                valor += Convert.ToDecimal(resultadoTextBox.Text);
                valor2 = Convert.ToDecimal(resultadoTextBox.Text);
                resultadoTextBox.Text = "";
            }
        }

        private void negativar_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                double numeroNegativo = Math.Pow(float.Parse(resultadoTextBox.Text), 1) * -1;
                resultadoTextBox.Text = numeroNegativo.ToString();
            }
        }

        private void delet1_Click(object sender, EventArgs e)
        {
            // Verifica se há texto na caixa de texto
            if (!string.IsNullOrEmpty(resultadoTextBox.Text))
            {
                // Obtém o texto atual
                string textoAtual = resultadoTextBox.Text;
                // Verifica se há caracteres para apagar
                if (textoAtual.Length > 0)
                {
                    // Remove o último caractere da caixa de texto
                    resultadoTextBox.Text = textoAtual.Substring(0, textoAtual.Length - 1);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text = "";
            valor = 0;
            valor2 = 0;
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            // Implemente a funcionalidade desejada para o botão de porcentagem, se necessário
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                switch (operacaoSelecionada)
                {
                    case Operacao.Adicao:
                        resultado = valor + Convert.ToDecimal(resultadoTextBox.Text);
                        break;
                    case Operacao.Subtracao:
                        resultado = valor - Convert.ToDecimal(resultadoTextBox.Text);
                        break;
                    case Operacao.Multiplicacao:
                        resultado = valor * Convert.ToDecimal(resultadoTextBox.Text);
                        break;
                    case Operacao.Divisao:
                        if (Convert.ToDecimal(resultadoTextBox.Text) != 0)
                        {
                            resultado = valor / Convert.ToDecimal(resultadoTextBox.Text);
                        }
                        else
                        {
                            resultadoTextBox.Text = "∞";
                        }
                        break;
                }

                if (operacaoSelecionada != Operacao.Divisao)
                {
                    resultadoTextBox.Text = Convert.ToString(resultado);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
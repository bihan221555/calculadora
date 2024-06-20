namespace calculadora
{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
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
            resultadoTextBox.Text += ",";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text.Length == 0)
            {
                operacaoSelecionada = Operacao.Adicao;
                valor = Convert.ToDecimal(resultadoTextBox.Text);
                resultadoTextBox.Text = "";
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToDecimal(resultadoTextBox.Text);
            resultadoTextBox.Text = "";
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(resultadoTextBox.Text);
            resultadoTextBox.Text = "";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(resultadoTextBox.Text);
            resultadoTextBox.Text = "";
        }

        private void negativar_Click(object sender, EventArgs e)
        {
            double numeroNegativo = Math.Pow(float.Parse(resultadoTextBox.Text), 1) * -1;
            resultadoTextBox.Text = numeroNegativo.ToString();
        }

        private void delet1_Click(object sender, EventArgs e)
        {
            // Verifica se h� texto na caixa de texto
            if (!string.IsNullOrEmpty(resultadoTextBox.Text))
            {
                // Obt�m o texto atual
                string textoAtual = resultadoTextBox.Text;

                // Verifica se h� caracteres para apagar
                if (textoAtual.Length > 0)
                {
                    // Remove o �ltimo caractere da caixa de texto
                    resultadoTextBox.Text = textoAtual.Substring(0, textoAtual.Length - 1);
                }
            }
        }

            private void clear_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text = "";
            valor = 0;
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            
        }

        private void igual_Click(object sender, EventArgs e)
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
                    resultado = valor / Convert.ToDecimal(resultadoTextBox.Text);
                    break;
            }
            resultadoTextBox.Text = Convert.ToString(resultado);
        }
    }
}
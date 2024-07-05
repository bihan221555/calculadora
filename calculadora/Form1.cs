using calculadoraimposto1;
using iText.Kernel.Colors;
using System;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public double resultado { get; set; }
        public double valor { get; set; }
        public bool valor2 { get; set; } = true;
        public string sinal { get; set; }

        private Operacao operacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Potencia,
            Raiz
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarDigito(string digito)
        {
            if (valor2 || resultadoTextBox.Text == "0")
            {
                resultadoTextBox.Text = digito;
                valor2 = false;
            }
            else
            {
                resultadoTextBox.Text += digito;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            AdicionarDigito("0");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            AdicionarDigito("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            AdicionarDigito("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            AdicionarDigito("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            AdicionarDigito("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            AdicionarDigito("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            AdicionarDigito("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            AdicionarDigito("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            AdicionarDigito("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            AdicionarDigito("9");
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
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " + ";
                valor2 = true;
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "-";
                operacaoSelecionada = Operacao.Subtracao;
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " - ";
                valor2 = true;
            }
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "X";
                operacaoSelecionada = Operacao.Multiplicacao;
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " x ";
                valor2 = true;
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "/";
                operacaoSelecionada = Operacao.Divisao;
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " ÷ ";
                valor2 = true;
            }
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "^";
                operacaoSelecionada = Operacao.Potencia;
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " ^ ";
                valor2 = true;
            }
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                sinal = "√";
                operacaoSelecionada = Operacao.Raiz;
                valor = Convert.ToDouble(resultadoTextBox.Text);
                historicoTemporareo.Text = Convert.ToString(valor) + " √ ";
                valor2 = true;
            }
        }

        private void negativar_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "0")
            {
                if (resultadoTextBox.Text != "")
                {
                    double numeroNegativo = Math.Pow(float.Parse(resultadoTextBox.Text), 1) * -1;
                    resultadoTextBox.Text = numeroNegativo.ToString();
                }
            }
        }

        private void delet1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultadoTextBox.Text))
            {

                string textoAtual = resultadoTextBox.Text;

                if (textoAtual.Length > 0)
                {

                    resultadoTextBox.Text = textoAtual.Substring(0, textoAtual.Length - 1);
                }
            }
            if (resultadoTextBox.Text == "")
            {
                resultadoTextBox.Text = "0";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text = "0";
            valor = 0;
            historicoTemporareo.Text = "";

        }
        private void Corrigir_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text = "0";
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                resultadoTextBox.Text = Convert.ToString(valor * (Convert.ToDouble(resultadoTextBox.Text) / 100));
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (resultadoTextBox.Text != "")
            {
                switch (operacaoSelecionada)
                {
                    case Operacao.Adicao:
                        resultado = valor + Convert.ToDouble(resultadoTextBox.Text);
                        historicoTemporareo.Text = Convert.ToString(valor) + " + " + resultadoTextBox.Text + " = ";
                        break;
                    case Operacao.Subtracao:
                        resultado = valor - Convert.ToDouble(resultadoTextBox.Text);
                        historicoTemporareo.Text = Convert.ToString(valor) + " - " + resultadoTextBox.Text + " = ";
                        break;
                    case Operacao.Multiplicacao:
                        resultado = valor * Convert.ToDouble(resultadoTextBox.Text);
                        historicoTemporareo.Text = Convert.ToString(valor) + " x " + resultadoTextBox.Text + " = ";
                        break;
                    case Operacao.Potencia:
                        resultado = Math.Pow(valor, Convert.ToDouble(resultadoTextBox.Text));
                        historicoTemporareo.Text = Convert.ToString(valor) + " ^ " + resultadoTextBox.Text + " = ";
                        break;
                    case Operacao.Raiz:
                        resultado = Math.Pow(valor, 1.0 / Convert.ToDouble(resultadoTextBox.Text));
                        historicoTemporareo.Text = Convert.ToString(valor) + " √ " + resultadoTextBox.Text + " = ";
                        break;
                    case Operacao.Divisao:
                        if (Convert.ToDouble(resultadoTextBox.Text) != 0)
                        {
                            resultado = valor / Convert.ToDouble(resultadoTextBox.Text);
                            historicoTemporareo.Text = Convert.ToString(valor) + " ÷ " + resultadoTextBox.Text + " = ";
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
                valor2 = true;
            }
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 35;
                hamburguer.BackColor = System.Drawing.Color.FromArgb(34, 30, 30);
                if (sidebar.Width <= 0)
                {

                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 35;
                hamburguer.BackColor = System.Drawing.Color.FromArgb(48, 44, 44);
                if (sidebar.Width >= 236)
                {

                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        bool sidebarExpand2 = false;
        private void sidebarTransition2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand2)
            {
                sidebar2.Width -= 35;
                hamburguer.BackColor = System.Drawing.Color.FromArgb(34, 30, 30);
                if (sidebar2.Width <= 0)
                {

                    sidebarExpand2 = false;
                    sidebarTransition2.Stop();
                }
            }
            else
            {
                sidebar2.Width += 35;
                hamburguer.BackColor = System.Drawing.Color.FromArgb(48, 44, 44);
                if (sidebar2.Width >= 236)
                {

                    sidebarExpand2 = true;
                    sidebarTransition2.Stop();
                }
            }
        }
        private void hamburguer_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            sidebarTransition2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultadoTextBox.Text = "0";
        }

        private void impostoRendaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
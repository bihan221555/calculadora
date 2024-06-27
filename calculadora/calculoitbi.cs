using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraimposto1
{
    public partial class calculoitbi : Form
    {
        public calculoitbi()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (valorvenalitbi.Text != "" && aliquotaitbi.Text != "")
            {
                double valorvenalitbiNumber = double.Parse(valorvenalitbi.Text);
                double aliquotaitbiNumber = double.Parse(aliquotaitbi.Text);
                double resultadoitbiNumber = valorvenalitbiNumber * (aliquotaitbiNumber * 0.01);
                resultadoitbi.Text = resultadoitbiNumber.ToString();
            }
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            impostomunicipal form = new impostomunicipal();
            form.Show();
            this.Hide();
        }
    }
}

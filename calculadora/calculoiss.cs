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
    public partial class calculoiss : Form
    {
        public calculoiss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorServico.Text != "" && aliquotaiss.Text != "")
            {
                float valorServicoNumber = float.Parse(valorServico.Text);
                float aliquotaissNumber = float.Parse(aliquotaiss.Text);
                float resultadoissNumber = (float)(valorServicoNumber * (aliquotaissNumber * 0.01));
                resultadoiss.Text = resultadoissNumber.ToString();
            }
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            impostomunicipal form = new impostomunicipal();
            form.Show();
            this.Hide();
        }

        private void calculoiss_Load(object sender, EventArgs e)
        {

        }
    }
}

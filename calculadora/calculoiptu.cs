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
    public partial class calculoiptu : Form
    {
        public calculoiptu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m2area_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void iptuResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float m2areaNumber = float.Parse(m2area.Text);
            float valorRegiaoNumber = float.Parse(valorRegiao.Text);
            float aliquotaNumber = float.Parse(aliquota.Text);
            float iptuResultadoNumber = (float) ((m2areaNumber * valorRegiaoNumber) * (aliquotaNumber * 0.01));
             iptuResultado.Text = iptuResultadoNumber.ToString();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            impostomunicipal form = new impostomunicipal();
            form.Show();
            this.Hide();
        }

        private void calculoiptu_Load(object sender, EventArgs e)
        {

        }
    }
}

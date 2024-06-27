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
    public partial class impostomunicipal : Form
    {
        public impostomunicipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            calculoiptu form = new calculoiptu();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            calculoiss form = new calculoiss();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            calculoitbi form = new calculoitbi();
            form.Show();
            this.Hide();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

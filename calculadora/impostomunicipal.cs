using calculadoraimposto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class impostomunicipal : Form
    {
        public impostomunicipal()
        {
            InitializeComponent();
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
        private void padraoButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
        private void impostoRendaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void iptuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculoiptu form3 = new calculoiptu();
            form3.Show();
        }

        private void issButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculoiss form4 = new calculoiss();
            form4.Show();
        }

        private void itbiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculoitbi form5 = new calculoitbi();
            form5.Show();
        }
    }
}

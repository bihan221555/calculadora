using calculadora;
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
            if ((m2area.Text != "" && valorRegiao.Text != "" && aliquota.Text != ""))
                {
                float m2areaNumber = float.Parse(m2area.Text);
                float valorRegiaoNumber = float.Parse(valorRegiao.Text);
                float aliquotaNumber = float.Parse(aliquota.Text);
                float iptuResultadoNumber = (float)((m2areaNumber * valorRegiaoNumber) * (aliquotaNumber * 0.01));
                iptuResultado.Text = iptuResultadoNumber.ToString();
                }
        }

        

        private void calculoiptu_Load(object sender, EventArgs e)
        {

        }
    }
}

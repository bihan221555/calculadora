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
    public partial class calculoiss : Form
    {
        public calculoiss()
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


        private void calculoiss_Load(object sender, EventArgs e)
        {

        }
    }
}

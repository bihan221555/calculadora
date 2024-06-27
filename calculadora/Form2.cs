namespace calculadoraimposto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            impostomunicipal form = new impostomunicipal();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            impostoestadual form = new impostoestadual();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            impostofederal form = new impostofederal();
            form.Show();
            this.Hide();
        }
    }
}
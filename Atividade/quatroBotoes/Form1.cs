namespace quatroBotoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLigar_Click(object sender, EventArgs e)
        {

            textBox1.Text = "O sistema foi ligado!";
        }

        private void buttonDesligar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "O sistema foi desligado!";
        }

        private void buttonErro_Click(object sender, EventArgs e)
        {
            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc= MessageBox.Show("Erro","Mensagem de Erro", bot, icon, bd);
        }

        private void t_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

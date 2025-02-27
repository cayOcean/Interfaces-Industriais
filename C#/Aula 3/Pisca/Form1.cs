namespace Pisca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Tag = "Verde"; // A tag indica o estado atual da imagem
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "Verde")
            {
                // Troca para a imagem vermelha
                pictureBox1.Image = Image.FromFile("C:\\Imagens\\Vermelho.bmp");
                pictureBox1.Tag = "Vermelho"; // Atualiza a tag para vermelho
            }
            else
            {
                // Troca para a imagem verde
                pictureBox1.Image = Image.FromFile("C:\\Imagens\\Verde.bmp");
                pictureBox1.Tag = "Verde"; // Atualiza a tag para verde
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Não está sendo usado nesse código, pode ser removido ou implementado conforme necessidade
        }
    }
}

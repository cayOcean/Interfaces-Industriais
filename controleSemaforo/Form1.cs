namespace controleSemaforo
{
    public partial class Form1 : Form
    {
        private int estadoRua = 0; // Indica o estado da rua (Vermelho, Amarelo, Verde)
        private int estadoAvenida = 0; // Indica o estado da avenida (Verde, Amarelo, Vermelho)
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        // Caminho das imagens
        private readonly string caminhoVermelho = @"C:\Imagens\Vermelho.Bmp";
        private readonly string caminhoAmarelo = @"C:\Imagens\Amarelo.Bmp";
        private readonly string caminhoVerde = @"C:\Imagens\Verde.Bmp";
        private readonly string caminhoApagado = @"C:\Imagens\apagado.Bmp";

        // Definindo os tempos de cada luz
        private readonly int tempoVermelhoRua = 2000; // 2 segundos para a rua
        private readonly int tempoAmareloRua = 1000;  // 1 segundo para a rua
        private readonly int tempoVerdeRua = 3000;    // 3 segundos para a rua

        private readonly int tempoVerdeAvenida = 3000; // 3 segundos para a avenida
        private readonly int tempoAmareloAvenida = 1000; // 1 segundo para a avenida
        private readonly int tempoVermelhoAvenida = 2000; // 2 segundos para a avenida

        public Form1()
        {
            InitializeComponent();

            // Configuração do Timer
            timer.Interval = 1000; // Intervalo do timer: 1 segundo (para trocar de estado)
            timer.Tick += Timer_Tick;

            // Configurar os botões
            button1.Click += ButtonLigar_Click;
            button2.Click += ButtonDesligar_Click;
            button3.Click += ButtonSair_Click;
            buttonEmergencia.Click += ButtonEmergencia_Click; // Adicionando evento do botão de emergência

            // Inicializa com luz apagada
            ResetarSemaforo();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AlternarSemaforo();
        }

        private void ButtonLigar_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ButtonDesligar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ResetarSemaforo();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlternarSemaforo()
        {
            try
            {
                // Reseta todas as imagens para a rua principal e avenida
                pictureBox1.Image = Image.FromFile(caminhoApagado); // Rua Vermelho
                pictureBox2.Image = Image.FromFile(caminhoApagado); // Rua Amarelo
                pictureBox3.Image = Image.FromFile(caminhoApagado); // Rua Verde
                pictureBox4.Image = Image.FromFile(caminhoApagado); // Avenida Verde
                pictureBox5.Image = Image.FromFile(caminhoApagado); // Avenida Amarelo
                pictureBox6.Image = Image.FromFile(caminhoApagado); // Avenida Vermelho

                // Alterna os estados do semáforo da rua principal
                if (estadoRua == 0) // Vermelho para a rua
                {
                    pictureBox1.Image = Image.FromFile(caminhoVermelho);
                    timer.Interval = tempoVermelhoRua; // 2 segundos de vermelho na rua
                }
                else if (estadoRua == 1) // Amarelo para a rua
                {
                    pictureBox2.Image = Image.FromFile(caminhoAmarelo);
                    timer.Interval = tempoAmareloRua; // 1 segundo de amarelo na rua
                }
                else // Verde para a rua
                {
                    pictureBox3.Image = Image.FromFile(caminhoVerde);
                    timer.Interval = tempoVerdeRua; // 3 segundos de verde na rua
                }

                // Alterna os estados do semáforo da avenida
                if (estadoAvenida == 0) // Verde para a avenida
                {
                    pictureBox4.Image = Image.FromFile(caminhoVerde);
                    timer.Interval = tempoVerdeAvenida; // 3 segundos de verde na avenida
                }
                else if (estadoAvenida == 1) // Amarelo para a avenida
                {
                    pictureBox5.Image = Image.FromFile(caminhoAmarelo);
                    timer.Interval = tempoAmareloAvenida; // 1 segundo de amarelo na avenida
                }
                else // Vermelho para a avenida
                {
                    pictureBox6.Image = Image.FromFile(caminhoVermelho);
                    timer.Interval = tempoVermelhoAvenida; // 2 segundos de vermelho na avenida
                }

                // Alterna entre os estados para a rua e avenida
                estadoRua = (estadoRua + 1) % 3; // Alterna entre 0, 1, 2 para a rua
                estadoAvenida = (estadoAvenida + 1) % 3; // Alterna entre 0, 1, 2 para a avenida
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as imagens: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetarSemaforo()
        {
            try
            {
                // Reseta todas as imagens da rua principal
                pictureBox1.Image = Image.FromFile(caminhoApagado);
                pictureBox2.Image = Image.FromFile(caminhoApagado);
                pictureBox3.Image = Image.FromFile(caminhoApagado);

                // Reseta todas as imagens da avenida
                pictureBox4.Image = Image.FromFile(caminhoApagado);
                pictureBox5.Image = Image.FromFile(caminhoApagado);
                pictureBox6.Image = Image.FromFile(caminhoApagado);

                estadoRua = 0;
                estadoAvenida = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao resetar as imagens: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Não está em uso neste código.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Não está em uso neste código.
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Não está em uso neste código.
        }

        private void buttonEmergencia_Click(object sender, EventArgs e)
        {
            // Mudar todas as imagens para o estado amarelo por 5 segundos
            pictureBox1.Image = Image.FromFile(caminhoAmarelo);
            pictureBox2.Image = Image.FromFile(caminhoAmarelo);
            pictureBox3.Image = Image.FromFile(caminhoAmarelo);
            pictureBox4.Image = Image.FromFile(caminhoAmarelo);
            pictureBox5.Image = Image.FromFile(caminhoAmarelo);
            pictureBox6.Image = Image.FromFile(caminhoAmarelo);

            // Esperar 5 segundos e depois resetar o semáforo
            timer.Stop(); // Parar o temporizador
            timer.Interval = 5000; // 5 segundos de emergência
            timer.Start();

            timer.Tick += (s, args) =>
            {
                // Após os 5 segundos, resetar as imagens e retomar a alternância do semáforo
                timer.Stop();
                ResetarSemaforo();
                timer.Interval = 1000; // Restaurar o intervalo normal do temporizador
                timer.Start();
            };
        }
    }
}

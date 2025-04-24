using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Temperatura_ArduinoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Desligado.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Imagens\\Icone.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Começo forms-------------------------------------------------------->
        private void Form1_Load(object sender, EventArgs e)
        {
            // Começa desconectado-->
            btConectar.Enabled = true;
            btDesconectar.Enabled = false;
            txPorta.Enabled = true;

            // Adiciona os baud rates ao ComboBox-->
            cbBaudRate.Items.Clear();
            cbBaudRate.Items.Add("9600");
            cbBaudRate.Items.Add("19200");
            cbBaudRate.Items.Add("38400");
            cbBaudRate.Items.Add("57600");
            cbBaudRate.Items.Add("115200");
            cbBaudRate.SelectedIndex = 0;
        }

        //Função para ler a temperatura------------------------------------------>
        private void lerTemperatura(object sender, EventArgs e)
        {
            
            string valor = serialPort1.ReadLine();                               // Lê uma linha completa da porta serial

            if (!string.IsNullOrWhiteSpace(valor))                               // Verifica se a linha não está vazia
            {
                try
                {
                    string[] dados = valor.Trim().Split(',');                    // Remove espaços extras e separa os dados usando vírgula

                    if (dados.Length == 2)                                       // Verifica se vieram os valores
                    {
                        int temperatura = Convert.ToInt32(dados[0]);             // Converte o primeiro valor para inteiro
                        
                        float potenciometro = float.Parse(dados[1], System.Globalization.CultureInfo.InvariantCulture);      // Converte o segundo valor para float (tensão do potenciômetro)

                        // Validação simples: temperatura deve estar entre 0 e 120 ºC
                        if (temperatura < 0 || temperatura > 120)
                        {
                            MessageBox.Show("Temperatura fora do intervalo: " + temperatura);
                            return;
                        }

                        // Atualiza os gauges com os valores recebidos
                        aGauge1.Value = temperatura;         // Temperatura no gauge circular
                        aGTemp.Value = potenciometro;        // Tensão no gauge de tensão

                        // Mostra os valores nas labels (com formatação)
                        lblTemperatura.Text = $"{temperatura} °C";
                        lblTensao.Text = $"{potenciometro:F2} V";

                        // Limpa os buffers de entrada e saída da porta serial
                        // (Evita dados repetidos ou enfileirados)
                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                    }
                }
                catch (Exception ex)
                {
                    // Mostra mensagem de erro caso ocorra falha ao processar os dados
                    MessageBox.Show("Erro ao processar dados: " + ex.Message);
                }
            }
        }

        //Função serialPort1------------------------------------------------------->
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (txPorta.Text != "")
            {
                serialPort1.PortName = txPorta.Text;
                serialPort1.BaudRate = int.Parse(cbBaudRate.SelectedItem.ToString());

                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        serialPort1.Write("L");

                        btConectar.Enabled = false;
                        btDesconectar.Enabled = true;
                        txPorta.Enabled = false;
                        cbBaudRate.Enabled = false;

                        pictureBox1.Image = Image.FromFile("C:\\Imagens\\Ligado.bmp");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar: " + ex.Message);
                    }
                }
            }
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("D");
                serialPort1.Close();
            }

            btConectar.Enabled = true;
            btDesconectar.Enabled = false;
            txPorta.Enabled = true;
            cbBaudRate.Enabled = true;

            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Desligado.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            Application.Exit();
        }

        private void aGTemp_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {
        }

        private void thermControl1_Load(object sender, EventArgs e)
        {
        }
    }
}

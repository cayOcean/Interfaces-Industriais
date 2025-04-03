using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Temp_Arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializa componentes do formulário
        }

        private void lerTemperatura(object sender, EventArgs e)
        {
            string valor = serialPort1.ReadExisting(); // Lê os dados disponíveis pela porta serial

            if (!string.IsNullOrEmpty(valor)) // Se recebeu dados
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor)); // Atualiza o controle de temperatura 

                // Limpa o Buffer da porta Serial
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));
        }

        private void btIndex_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txPorta.Text)) // Verifica se foi informada uma porta
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close(); // Fecha a porta se já estiver aberta
                    }

                    serialPort1.PortName = txPorta.Text; // Configura a porta serial
                    serialPort1.Open(); // Tenta abrir a conexão serial

                    MessageBox.Show($"Conectado à porta {txPorta.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe uma porta antes de conectar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso negado! A porta pode estar em uso por outro programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a porta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close(); // Fecha a conexão Serial
                }

                Application.Exit(); // Encerra a aplicação
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fechar a porta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

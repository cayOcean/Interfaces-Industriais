using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Temperatura_ArduinoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Começa desconectado
            btConectar.Enabled = true;
            btDesconectar.Enabled = false;
            txPorta.Enabled = true;
        }

        private void lerTemperatura(object sender, EventArgs e)
        {
            string valor = serialPort1.ReadLine(); // Lê uma linha inteira (até '\n')

            if (!string.IsNullOrWhiteSpace(valor))
            {
                try
                {
                    string[] dados = valor.Trim().Split(',');

                    if (dados.Length == 2)
                    {
                        int temperatura = Convert.ToInt32(dados[0]);
                        float potenciometro = float.Parse(dados[1], System.Globalization.CultureInfo.InvariantCulture);


                        // Verifica se a temperatura está dentro de um intervalo válido
                        if (temperatura < 0 || temperatura > 120)
                        {
                            MessageBox.Show("Temperatura fora do intervalo: " + temperatura);
                            return;
                        }

                        // Atualize os controles com os dados
                        aGauge1.Value = temperatura;
                        aGTemp.Value = potenciometro;
                        // Se tiver outro controle para o potenciômetro, atualize aqui também

                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao processar dados: " + ex.Message);
                }
            }
        }

        private void serialPort1_DataReceived (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (txPorta.Text != "")
            {
                serialPort1.PortName = txPorta.Text;

                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();

                        // Envia comando para acender o LED
                        serialPort1.Write("L");

                        // Atualiza estados dos botões
                        btConectar.Enabled = false;
                        btDesconectar.Enabled = true;
                        txPorta.Enabled = false;
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
                serialPort1.Write("D"); // Envia comando para desligar o LED
                serialPort1.Close();
            }

            btConectar.Enabled = true;
            btDesconectar.Enabled = false;
            txPorta.Enabled = true;
        }


        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
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

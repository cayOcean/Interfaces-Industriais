using System;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void ButtonLiga_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\Imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            
            textBox1.AppendText("Semáforo ligado (verde).\r\n");
        }

        
        private void buttonDesliga_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\Imagens\\Vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            
            textBox1.AppendText("Semáforo desligado (vermelho).\r\n");
        }

        
        private void ButtonSair_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                Application.Exit();
            }
            else
            {
                
                this.DialogResult = DialogResult.None;
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

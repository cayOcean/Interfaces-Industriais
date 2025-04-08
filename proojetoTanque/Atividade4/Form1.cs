using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\tanque_0%.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            MessageBoxIcon icone = MessageBoxIcon.Information;

            DialogResult resultado = MessageBox.Show("Início do abastecimento!", "Aviso", botoes, icone);

            timer_Encher.Interval = 2000;
            timer_Encher.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            MessageBoxIcon icone = MessageBoxIcon.Information;

            DialogResult resultado = MessageBox.Show("Início da retirada do fluido!", "Aviso", botoes, icone);


        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Encher_Tick(object sender, EventArgs e)
        {
            if (!timer_Encher.Enabled) return;



            pictureBox1.Image = Image.FromFile("C:\\Imagens\\tanque_25%.bmp");

            timer_Encher.Interval = 3000;
            timer_Encher.Start();

            timer_Encher.Stop();

            pictureBox1.Image = Image.FromFile("C:\\Imagens\\tanque_50%.bmp");

            timer_Encher.Interval = 3000;
            timer_Encher.Start();

            timer_Encher.Stop();

            pictureBox1.Image = Image.FromFile("C:\\Imagens\\tanque_75%.bmp");

            timer_Encher.Interval = 3000;
            timer_Encher.Start();

            timer_Encher.Stop();

            pictureBox1.Image = Image.FromFile("C:\\Imagens\\tanque_100%.bmp");

            timer_Encher.Interval = 3000;
            timer_Encher.Start();
        }
    }
}

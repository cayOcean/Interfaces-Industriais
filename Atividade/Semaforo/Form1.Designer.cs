namespace Semaforo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ButtonLiga = new Button();
            buttonDesliga = new Button();
            ButtonSair = new Button();
            toolTip1 = new ToolTip(components);
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonLiga
            // 
            ButtonLiga.Location = new Point(35, 211);
            ButtonLiga.Name = "ButtonLiga";
            ButtonLiga.Size = new Size(104, 47);
            ButtonLiga.TabIndex = 0;
            ButtonLiga.Text = "&Liga";
            ButtonLiga.UseVisualStyleBackColor = true;
            ButtonLiga.Click += ButtonLiga_Click;
            // 
            // buttonDesliga
            // 
            buttonDesliga.Location = new Point(193, 211);
            buttonDesliga.Name = "buttonDesliga";
            buttonDesliga.Size = new Size(104, 47);
            buttonDesliga.TabIndex = 1;
            buttonDesliga.Text = "&Desliga";
            buttonDesliga.UseVisualStyleBackColor = true;
            buttonDesliga.Click += buttonDesliga_Click;
            // 
            // ButtonSair
            // 
            ButtonSair.Location = new Point(349, 211);
            ButtonSair.Name = "ButtonSair";
            ButtonSair.Size = new Size(104, 47);
            ButtonSair.TabIndex = 2;
            ButtonSair.Text = "Sair";
            ButtonSair.UseVisualStyleBackColor = true;
            ButtonSair.Click += ButtonSair_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 153);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(104, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(197, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(511, 296);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(ButtonSair);
            Controls.Add(buttonDesliga);
            Controls.Add(ButtonLiga);
            Name = "Form1";
            Text = "Imagem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLiga;
        private Button buttonDesliga;
        private Button ButtonSair;
        private ToolTip toolTip1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}

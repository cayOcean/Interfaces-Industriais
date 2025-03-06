namespace quatroBotoes
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
            buttonLigar = new Button();
            buttonDesligar = new Button();
            buttonErro = new Button();
            t = new Button();
            toolTip1 = new ToolTip(components);
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLigar
            // 
            buttonLigar.Location = new Point(12, 27);
            buttonLigar.Name = "buttonLigar";
            buttonLigar.Size = new Size(93, 56);
            buttonLigar.TabIndex = 0;
            buttonLigar.Text = "&Ligar";
            buttonLigar.UseVisualStyleBackColor = true;
            buttonLigar.Click += buttonLigar_Click;
            // 
            // buttonDesligar
            // 
            buttonDesligar.Location = new Point(12, 106);
            buttonDesligar.Name = "buttonDesligar";
            buttonDesligar.Size = new Size(93, 56);
            buttonDesligar.TabIndex = 4;
            buttonDesligar.Text = "&Desligar";
            buttonDesligar.UseVisualStyleBackColor = true;
            buttonDesligar.Click += buttonDesligar_Click;
            // 
            // buttonErro
            // 
            buttonErro.Location = new Point(12, 184);
            buttonErro.Name = "buttonErro";
            buttonErro.Size = new Size(93, 56);
            buttonErro.TabIndex = 2;
            buttonErro.Text = "&Erro";
            buttonErro.UseVisualStyleBackColor = true;
            buttonErro.Click += buttonErro_Click;
            // 
            // t
            // 
            t.Location = new Point(12, 266);
            t.Name = "t";
            t.Size = new Size(93, 56);
            t.TabIndex = 1;
            t.Text = "&Sair";
            toolTip1.SetToolTip(t, "Encerra a aplicação");
            t.UseVisualStyleBackColor = true;
            t.Click += t_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 142);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            textBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 145);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Mensagem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 344);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(t);
            Controls.Add(buttonErro);
            Controls.Add(buttonDesligar);
            Controls.Add(buttonLigar);
            Name = "Form1";
            Text = "Quatro Botões";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLigar;
        private Button buttonDesligar;
        private Button buttonErro;
        private Button t;
        private ToolTip toolTip1;
        private TextBox textBox1;
        private Label label1;
    }
}

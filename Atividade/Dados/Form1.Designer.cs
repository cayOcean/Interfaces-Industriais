namespace monitoramentoTrafego
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
            toolTip1 = new ToolTip(components);
            buttonNome = new Button();
            buttonIdade = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonNome
            // 
            buttonNome.Location = new Point(42, 196);
            buttonNome.Name = "buttonNome";
            buttonNome.Size = new Size(118, 62);
            buttonNome.TabIndex = 1;
            buttonNome.Text = "&Nome";
            toolTip1.SetToolTip(buttonNome, "Encerra a aplicação");
            buttonNome.UseVisualStyleBackColor = true;
            buttonNome.Click += buttonNome_Click;
            // 
            // buttonIdade
            // 
            buttonIdade.Location = new Point(216, 194);
            buttonIdade.Name = "buttonIdade";
            buttonIdade.Size = new Size(118, 67);
            buttonIdade.TabIndex = 0;
            buttonIdade.Text = "&Idade";
            buttonIdade.UseVisualStyleBackColor = true;
            buttonIdade.Click += buttonIdade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 103);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Dados:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 100);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 307);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonIdade);
            Controls.Add(buttonNome);
            Name = "Form1";
            Text = "Nome e Idade";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Button buttonNome;
        private Button buttonIdade;
        private Label label1;
        private TextBox textBox1;
    }
}

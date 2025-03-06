namespace controleSemaforo
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
            label1 = new Label();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            Rua = new GroupBox();
            groupBox1 = new GroupBox();
            buttonEmergencia = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            Rua.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 37);
            label1.TabIndex = 0;
            label1.Text = "Rua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, 34);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 1;
            label2.Text = "Avenida";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(579, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 413);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(579, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            button1.Location = new Point(38, 349);
            button1.Name = "button1";
            button1.Size = new Size(112, 61);
            button1.TabIndex = 4;
            button1.Text = "Ligar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(207, 349);
            button2.Name = "button2";
            button2.Size = new Size(112, 61);
            button2.TabIndex = 5;
            button2.Text = "Desligar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(394, 349);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 6;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 66);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(20, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 66);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(20, 188);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 66);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(28, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 66);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(28, 101);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 66);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(28, 179);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 66);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // Rua
            // 
            Rua.BackColor = SystemColors.ActiveCaptionText;
            Rua.Controls.Add(pictureBox1);
            Rua.Controls.Add(pictureBox2);
            Rua.Controls.Add(pictureBox3);
            Rua.Location = new Point(38, 65);
            Rua.Name = "Rua";
            Rua.Size = new Size(112, 278);
            Rua.TabIndex = 13;
            Rua.TabStop = false;
            Rua.Text = "Rua";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Location = new Point(394, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 269);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Avenida";
            // 
            // buttonEmergencia
            // 
            buttonEmergencia.Location = new Point(207, 282);
            buttonEmergencia.Name = "buttonEmergencia";
            buttonEmergencia.Size = new Size(112, 61);
            buttonEmergencia.TabIndex = 5;
            buttonEmergencia.Text = "Emergência";
            buttonEmergencia.UseVisualStyleBackColor = true;
            buttonEmergencia.Click += buttonEmergencia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 435);
            Controls.Add(groupBox1);
            Controls.Add(Rua);
            Controls.Add(button3);
            Controls.Add(buttonEmergencia);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            Rua.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private GroupBox Rua;
        private GroupBox groupBox1;
        private Button buttonEmergencia;
    }
}

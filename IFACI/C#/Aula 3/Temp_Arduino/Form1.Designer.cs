namespace Temp_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btIndex = new System.Windows.Forms.Button();
            this.lbPorta = new System.Windows.Forms.Label();
            this.txPorta = new System.Windows.Forms.TextBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btIndex
            // 
            this.btIndex.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIndex.Location = new System.Drawing.Point(35, 496);
            this.btIndex.Name = "btIndex";
            this.btIndex.Size = new System.Drawing.Size(91, 65);
            this.btIndex.TabIndex = 1;
            this.btIndex.Text = "&Iniciar";
            this.btIndex.UseVisualStyleBackColor = false;
            this.btIndex.Click += new System.EventHandler(this.btIndex_Click);
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorta.Location = new System.Drawing.Point(31, 461);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(95, 21);
            this.lbPorta.TabIndex = 2;
            this.lbPorta.Text = "Porta COM";
            // 
            // txPorta
            // 
            this.txPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPorta.Location = new System.Drawing.Point(138, 461);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(100, 24);
            this.txPorta.TabIndex = 3;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFinalizar.Location = new System.Drawing.Point(147, 496);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(91, 65);
            this.btFinalizar.TabIndex = 2;
            this.btFinalizar.Text = "&Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(35, 12);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(180, 425);
            this.thermControl1.TabIndex = 5;
            this.thermControl1.Value = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(279, 604);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.lbPorta);
            this.Controls.Add(this.btIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Termômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIndex;
        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.TextBox txPorta;
        private System.Windows.Forms.Button btFinalizar;
        private ThermometerControl.ThermControl thermControl1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}


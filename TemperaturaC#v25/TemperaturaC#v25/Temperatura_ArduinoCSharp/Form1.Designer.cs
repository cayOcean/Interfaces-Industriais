namespace Temperatura_ArduinoCSharp
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel4 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel5 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel6 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange7 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange8 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange9 = new System.Windows.Forms.AGaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lbPorta = new System.Windows.Forms.Label();
            this.txPorta = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.aGTemp = new System.Windows.Forms.AGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblTensao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.Firebrick;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.White;
            this.btFinalizar.Location = new System.Drawing.Point(6, 19);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(121, 28);
            this.btFinalizar.TabIndex = 1;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.BackColor = System.Drawing.Color.Gray;
            this.lbPorta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorta.Location = new System.Drawing.Point(392, 24);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(86, 18);
            this.lbPorta.TabIndex = 2;
            this.lbPorta.Text = "Porta COM";
            // 
            // txPorta
            // 
            this.txPorta.Location = new System.Drawing.Point(484, 22);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(100, 20);
            this.txPorta.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // aGTemp
            // 
            this.aGTemp.BaseArcColor = System.Drawing.Color.Gray;
            this.aGTemp.BaseArcRadius = 80;
            this.aGTemp.BaseArcStart = 135;
            this.aGTemp.BaseArcSweep = 270;
            this.aGTemp.BaseArcWidth = 2;
            this.aGTemp.Center = new System.Drawing.Point(105, 105);
            aGaugeLabel1.Color = System.Drawing.Color.Black;
            aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(72, 180);
            aGaugeLabel1.Text = "Tensão (V)";
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel2.Name = "Gauge1V";
            aGaugeLabel2.Position = new System.Drawing.Point(11, 82);
            aGaugeLabel2.Text = "1";
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel3.Name = "Gauge2V";
            aGaugeLabel3.Position = new System.Drawing.Point(59, 16);
            aGaugeLabel3.Text = "2";
            aGaugeLabel4.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel4.Name = "Gauge3V";
            aGaugeLabel4.Position = new System.Drawing.Point(140, 16);
            aGaugeLabel4.Text = "3";
            aGaugeLabel5.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel5.Name = "Gauge4V";
            aGaugeLabel5.Position = new System.Drawing.Point(193, 82);
            aGaugeLabel5.Text = "4";
            this.aGTemp.GaugeLabels.Add(aGaugeLabel1);
            this.aGTemp.GaugeLabels.Add(aGaugeLabel2);
            this.aGTemp.GaugeLabels.Add(aGaugeLabel3);
            this.aGTemp.GaugeLabels.Add(aGaugeLabel4);
            this.aGTemp.GaugeLabels.Add(aGaugeLabel5);
            aGaugeRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            aGaugeRange1.EndValue = 1F;
            aGaugeRange1.InnerRadius = 50;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRangeNormal";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange2.EndValue = 2F;
            aGaugeRange2.InnerRadius = 50;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRangeAtencao";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 1F;
            aGaugeRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            aGaugeRange3.EndValue = 3F;
            aGaugeRange3.InnerRadius = 50;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRangeAlerta1";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 2F;
            aGaugeRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            aGaugeRange4.EndValue = 4F;
            aGaugeRange4.InnerRadius = 50;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRangeAlerta2";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 3F;
            aGaugeRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            aGaugeRange5.EndValue = 5F;
            aGaugeRange5.InnerRadius = 50;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange1";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 4F;
            this.aGTemp.GaugeRanges.Add(aGaugeRange1);
            this.aGTemp.GaugeRanges.Add(aGaugeRange2);
            this.aGTemp.GaugeRanges.Add(aGaugeRange3);
            this.aGTemp.GaugeRanges.Add(aGaugeRange4);
            this.aGTemp.GaugeRanges.Add(aGaugeRange5);
            this.aGTemp.Location = new System.Drawing.Point(480, 118);
            this.aGTemp.Margin = new System.Windows.Forms.Padding(2);
            this.aGTemp.MaxValue = 5F;
            this.aGTemp.MinValue = 0F;
            this.aGTemp.Name = "aGTemp";
            this.aGTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGTemp.NeedleRadius = 80;
            this.aGTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGTemp.NeedleWidth = 2;
            this.aGTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleLinesInterInnerRadius = 73;
            this.aGTemp.ScaleLinesInterOuterRadius = 80;
            this.aGTemp.ScaleLinesInterWidth = 1;
            this.aGTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleLinesMajorInnerRadius = 70;
            this.aGTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGTemp.ScaleLinesMajorStepValue = 5F;
            this.aGTemp.ScaleLinesMajorWidth = 2;
            this.aGTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGTemp.ScaleLinesMinorInnerRadius = 75;
            this.aGTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGTemp.ScaleLinesMinorTicks = 9;
            this.aGTemp.ScaleLinesMinorWidth = 1;
            this.aGTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleNumbersFormat = null;
            this.aGTemp.ScaleNumbersRadius = 95;
            this.aGTemp.ScaleNumbersRotation = 0;
            this.aGTemp.ScaleNumbersStartScaleLine = 0;
            this.aGTemp.ScaleNumbersStepScaleLines = 1;
            this.aGTemp.Size = new System.Drawing.Size(214, 205);
            this.aGTemp.TabIndex = 6;
            this.aGTemp.Text = "aGauge1";
            this.aGTemp.Value = 0F;
            this.aGTemp.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGTemp_ValueInRangeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.btDesconectar);
            this.groupBox1.Controls.Add(this.btConectar);
            this.groupBox1.Controls.Add(this.btFinalizar);
            this.groupBox1.Controls.Add(this.txPorta);
            this.groupBox1.Controls.Add(this.lbPorta);
            this.groupBox1.Location = new System.Drawing.Point(12, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Baud Rate";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(688, 22);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 6;
            // 
            // btDesconectar
            // 
            this.btDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDesconectar.Location = new System.Drawing.Point(133, 19);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(121, 28);
            this.btDesconectar.TabIndex = 5;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = false;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btConectar.Location = new System.Drawing.Point(260, 19);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(121, 28);
            this.btConectar.TabIndex = 4;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(105, 105);
            aGaugeLabel6.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel6.Name = "GaugeLabel1";
            aGaugeLabel6.Position = new System.Drawing.Point(53, 180);
            aGaugeLabel6.Text = "Temperatura (C°)";
            this.aGauge1.GaugeLabels.Add(aGaugeLabel6);
            aGaugeRange6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            aGaugeRange6.EndValue = 30F;
            aGaugeRange6.InnerRadius = 50;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRangeNormal";
            aGaugeRange6.OuterRadius = 80;
            aGaugeRange6.StartValue = 0F;
            aGaugeRange7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange7.EndValue = 60F;
            aGaugeRange7.InnerRadius = 50;
            aGaugeRange7.InRange = false;
            aGaugeRange7.Name = "GaugeRangeAtencao";
            aGaugeRange7.OuterRadius = 80;
            aGaugeRange7.StartValue = 30F;
            aGaugeRange8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            aGaugeRange8.EndValue = 90F;
            aGaugeRange8.InnerRadius = 50;
            aGaugeRange8.InRange = false;
            aGaugeRange8.Name = "GaugeRangeAlerta1";
            aGaugeRange8.OuterRadius = 80;
            aGaugeRange8.StartValue = 60F;
            aGaugeRange9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            aGaugeRange9.EndValue = 120F;
            aGaugeRange9.InnerRadius = 50;
            aGaugeRange9.InRange = false;
            aGaugeRange9.Name = "GaugeRangeAlerta2";
            aGaugeRange9.OuterRadius = 80;
            aGaugeRange9.StartValue = 90F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange6);
            this.aGauge1.GaugeRanges.Add(aGaugeRange7);
            this.aGauge1.GaugeRanges.Add(aGaugeRange8);
            this.aGauge1.GaugeRanges.Add(aGaugeRange9);
            this.aGauge1.Location = new System.Drawing.Point(155, 118);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(2);
            this.aGauge1.MaxValue = 120F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(214, 205);
            this.aGauge1.TabIndex = 8;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(768, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(225, 335);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 24);
            this.lblTemperatura.TabIndex = 10;
            // 
            // lblTensao
            // 
            this.lblTensao.AutoSize = true;
            this.lblTensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensao.Location = new System.Drawing.Point(552, 335);
            this.lblTensao.Name = "lblTensao";
            this.lblTensao.Size = new System.Drawing.Size(0, 24);
            this.lblTensao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "TempMLZ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Temperatura_ArduinoCSharp.Properties.Resources.Icone;
            this.pictureBox2.Location = new System.Drawing.Point(24, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 610);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTensao);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aGTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TempMLZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.TextBox txPorta;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.AGauge aGTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblTensao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


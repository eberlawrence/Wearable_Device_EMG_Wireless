namespace InterfaceEMG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cb_Port = new System.Windows.Forms.ComboBox();
            this.chartSinal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Port = new System.Windows.Forms.Label();
            this.gb_Port = new System.Windows.Forms.GroupBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Janela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ss_Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_Conecta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSinal)).BeginInit();
            this.gb_Port.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Port
            // 
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.Location = new System.Drawing.Point(52, 29);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(61, 21);
            this.cb_Port.TabIndex = 0;
            this.cb_Port.Text = "COM3";
            // 
            // chartSinal
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chartSinal.ChartAreas.Add(chartArea1);
            this.chartSinal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSinal.Legends.Add(legend1);
            this.chartSinal.Location = new System.Drawing.Point(0, 0);
            this.chartSinal.Name = "chartSinal";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Sinal Muscular";
            this.chartSinal.Series.Add(series1);
            this.chartSinal.Size = new System.Drawing.Size(565, 387);
            this.chartSinal.TabIndex = 1;
            this.chartSinal.Text = "chart1";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(6, 32);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(40, 13);
            this.lb_Port.TabIndex = 2;
            this.lb_Port.Text = "Portas:";
            // 
            // gb_Port
            // 
            this.gb_Port.Controls.Add(this.tb_Y);
            this.gb_Port.Controls.Add(this.tb_X);
            this.gb_Port.Controls.Add(this.tb_Janela);
            this.gb_Port.Controls.Add(this.label3);
            this.gb_Port.Controls.Add(this.label2);
            this.gb_Port.Controls.Add(this.label1);
            this.gb_Port.Controls.Add(this.bt_Start);
            this.gb_Port.Controls.Add(this.statusStrip1);
            this.gb_Port.Controls.Add(this.bt_Conecta);
            this.gb_Port.Controls.Add(this.lb_Port);
            this.gb_Port.Controls.Add(this.cb_Port);
            this.gb_Port.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_Port.Location = new System.Drawing.Point(0, 0);
            this.gb_Port.Name = "gb_Port";
            this.gb_Port.Size = new System.Drawing.Size(118, 387);
            this.gb_Port.TabIndex = 3;
            this.gb_Port.TabStop = false;
            this.gb_Port.Text = "Configurações";
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(67, 155);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(45, 20);
            this.tb_Y.TabIndex = 10;
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(67, 127);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(45, 20);
            this.tb_X.TabIndex = 9;
            // 
            // tb_Janela
            // 
            this.tb_Janela.Location = new System.Drawing.Point(52, 97);
            this.tb_Janela.Name = "tb_Janela";
            this.tb_Janela.Size = new System.Drawing.Size(60, 20);
            this.tb_Janela.TabIndex = 8;
            this.tb_Janela.TextChanged += new System.EventHandler(this.tb_Janela_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Escala - Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escala - X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Janela:";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(6, 181);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(107, 33);
            this.bt_Start.TabIndex = 4;
            this.bt_Start.Text = "Começar";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_Estado});
            this.statusStrip1.Location = new System.Drawing.Point(3, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(112, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ss_Estado
            // 
            this.ss_Estado.Name = "ss_Estado";
            this.ss_Estado.Size = new System.Drawing.Size(82, 17);
            this.ss_Estado.Text = "Desconectado";
            // 
            // bt_Conecta
            // 
            this.bt_Conecta.Location = new System.Drawing.Point(6, 56);
            this.bt_Conecta.Name = "bt_Conecta";
            this.bt_Conecta.Size = new System.Drawing.Size(107, 33);
            this.bt_Conecta.TabIndex = 3;
            this.bt_Conecta.Text = "Conectar";
            this.bt_Conecta.UseVisualStyleBackColor = true;
            this.bt_Conecta.Click += new System.EventHandler(this.bt_Conecta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartSinal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(118, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 387);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Port);
            this.Name = "Form1";
            this.Text = "EMG BioLab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSinal)).EndInit();
            this.gb_Port.ResumeLayout(false);
            this.gb_Port.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Port;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSinal;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.GroupBox gb_Port;
        private System.Windows.Forms.Button bt_Conecta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ss_Estado;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Janela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


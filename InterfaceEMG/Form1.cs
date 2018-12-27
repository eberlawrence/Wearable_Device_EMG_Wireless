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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace InterfaceEMG
{
    public partial class Form1: Form
    {

        Thread thread_Leitura;
        Thread thread_Plot;
        CircularBuffer<int> circularBuffer = new CircularBuffer<int>(10000);
        SerialPort Port;
        bool Loopear = false;


        double Fa = 50;
        double Tempo = 0;
        int T_Janela = 10;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Port = new SerialPort();
            Port.BaudRate = 115200;
            Port.PortName = "COM3";
            COM_ports();

            chartSinal.ChartAreas[0].AxisX.Maximum = T_Janela;

        }

        void COM_ports()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cb_Port.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cb_Port.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return; //retorna
            }

            //limpa comboBox
            cb_Port.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cb_Port.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cb_Port.SelectedIndex = 0;

        }

        private void bt_Conecta_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Loopear = false;
                thread_Leitura.Abort();
                thread_Plot.Abort();
                Port.Close();
                bt_Conecta.Text = "conectar";
                ss_Estado.Text = "Desconectado";

            }
            else
            {
                Port.PortName = cb_Port.SelectedItem.ToString();
                Port.Open();
                bt_Conecta.Text = "Desconectar";
                ss_Estado.Text = "Conectado";
            }
        }

        void Recebe_Dados(object status)
        {
            int BytesDisponiveis;
            byte MSB;
            byte LSB;
            byte[] Buff = new byte[2];
            while (Loopear)
            {
                BytesDisponiveis = Port.BytesToRead;
                if (BytesDisponiveis > 1)
                {
                        Port.Read(Buff, 0, 2);
                        LSB = Buff[0];
                        MSB = Buff[1];
                        int amostra = MSB << 8 | LSB;
                        circularBuffer.Enqueue(amostra);                
                }
            }
        }



        void Plot_Dados(object status)
        {
            while (Loopear)
            {
                if (!circularBuffer.IsEmpty)
                {
                    int N_amostras = circularBuffer.SamplesToRead;
                    
                    for (int i = 0; i < N_amostras; i++)
                    {
                        Tempo += (1 / Fa);
                        //Console.WriteLine(circularBuffer.Dequeue());
                        this.chartSinal.Invoke(new Action(() =>
                        {
                            chartSinal.Series[0].Points.AddXY(Tempo, circularBuffer.Dequeue());
                            if (Tempo > chartSinal.ChartAreas[0].AxisX.Maximum)
                            {
                                //chartSinal.Series[0].Points.RemoveAt(0);
                                //chartSinal.ChartAreas[0].AxisX.Maximum += (1 / Fa);

                                chartSinal.ChartAreas[0].AxisX.Minimum = chartSinal.ChartAreas[0].AxisX.Maximum;

                                chartSinal.ChartAreas[0].AxisX.Maximum += T_Janela;

                            }
                        }));
                    }
                }
            }           
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (Loopear == false && Port.IsOpen)
            {
                Port.Write(new byte[] { 1 }, 0, 1);
                thread_Leitura = new Thread(Recebe_Dados);
                thread_Plot = new Thread(Plot_Dados);
                //ThreadPool.QueueUserWorkItem(Recebe_Dados);
                //ThreadPool.QueueUserWorkItem(Plot_Dados);
                Loopear = true;
                thread_Leitura.Start();
                thread_Plot.Start();
            }
            else
            {
                Port.Write(new byte[] { 0 }, 0, 1);
                Loopear = false;
            }
        }

        private void tb_Janela_TextChanged(object sender, EventArgs e)
        {
            if (tb_Janela.Text == "")
            {
                T_Janela = 10;
            }
            else
            T_Janela = Convert.ToInt16(tb_Janela.Text);            
        }
    }
}

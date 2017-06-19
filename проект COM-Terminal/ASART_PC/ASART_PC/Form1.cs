using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;



namespace ASART_PC
{
    public partial class Form1 : Form
    {
        private delegate void setTextDeleg(string text);
        private int count_connect=0;
       
        public Form1()
        {
            InitializeComponent();


            this.MaximizeBox = false;

            this.Icon = Properties.Resources.иконка_главной_формы;

            string[] portNames = SerialPort.GetPortNames();

            foreach (string p in portNames)
            {
                comboBoxPORT.Items.Add(p);
            }
        }

        SerialPort _serialPorts = new SerialPort();
      

        private void button2_Click(object sender, EventArgs e)
        {
            count_connect++;

            if (count_connect % 2 != 0)
            {

                button2.Text = "Установлено соединение!";
                Connect_and_Seetins();

                _serialPorts.DataReceived += _serialPorts_DataReceived;

            }

            if(count_connect%2==0)
            {

                button2.Text = "Соединение разорвано!!";

                Port_disconnect();
            }


        }

        private void _serialPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50);
            string data = _serialPorts.ReadLine();
            BeginInvoke(new setTextDeleg(Receive_Data), new object[] { data });

        }
        private void Receive_Data(string Data)
        {
            richTextBox1.Text += "Прием :" + Data.Trim() + Environment.NewLine;
            richTextBox1.ScrollToCaret();
                   }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void Connect_and_Seetins()
        {

           

           

            bool error=false;

            if (comboBoxPORT.SelectedIndex!=-1 && comboBoxBit_paraty.SelectedIndex!=-1 && comboBoxBUAD_Speed.SelectedIndex!=-1 && comboBoxForm_Data.SelectedIndex!=-1 && comboBoxStop_Bits.SelectedIndex!=-1 )
            {
                _serialPorts.PortName = comboBoxPORT.Text;
                _serialPorts.BaudRate = int.Parse(comboBoxBUAD_Speed.Text);
                _serialPorts.Parity = (Parity)Enum.Parse(typeof(Parity),comboBoxBit_paraty.Text);
                _serialPorts.DataBits = int.Parse(comboBoxForm_Data.Text);
                _serialPorts.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStop_Bits.Text);
                //=====================================================================================

                //Блок проверки
                //===================================================================
                try
                {

                    _serialPorts.Open();
                }
                catch (UnauthorizedAccessException)
                {

                    error = true;

                }
                catch(System.IO.IOException)
                {
                    error = true;

                }

                catch(ArgumentException)
                {

                    error = true;

                }


                if(error)
                {
                    MessageBox.Show("Ошибка!! Проверте правильность ввода данных!");

                }
                else
                {
                    MessageBox.Show("Настройки приняты!!!Соединение с портом....");
                }




            }





        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=


        private void Port_disconnect()
        {
            MessageBox.Show("Закрытие соединения.......");
            _serialPorts.Close();

        }


        private void Transmit_Data()
        {
            try
            {
                string Text_Transmit;
                Text_Transmit = textBox1.Text;
                _serialPorts.WriteLine(String.Format("{0}", Text_Transmit));
                textBox1.Clear();
                richTextBox1.Text += "Передача :" + Text_Transmit+ Environment.NewLine;
                richTextBox1.ScrollToCaret();
              

            }

            catch(Exception ex)
            {
                MessageBox.Show("Ошибка :" + ex.Message);

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (count_connect % 2 != 0)
            {
                Transmit_Data();
              
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (count_connect % 2 != 0)
                {
                    Transmit_Data();

                }


            }
        }
    }
}

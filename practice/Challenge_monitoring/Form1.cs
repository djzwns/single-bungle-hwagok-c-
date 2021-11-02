using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_monitoring
{
    public partial class Form1 : Form
    {
        private byte[] rxBuf = new byte[255];
        private int rxLen = 0;
        private Regex regex = new Regex(@"([^\[\], ])+");
        private List<string> messageSubs = new List<string>();

        public Form1()
        {
            InitializeComponent();
            serialDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(SerialDataGet));
        }

        private void SerialDataGet(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            int bufferCount = serialDevice.BytesToRead;
            for (int i = 0; i < bufferCount; ++i)
            {
                byte data = (byte)serialDevice.ReadByte();
                if (ReceiveDataPacket(data))
                {
                    // checksum
                    if (Checksum(rxBuf))
                        DeviceProcess();

                }
            }
        }

        private bool Checksum(byte[] buf)
        {
            messageSubs.Clear();

            string msg = Encoding.Default.GetString(buf, 0, rxLen);
            MatchCollection mc = regex.Matches(msg);
            foreach (Match m in mc)
            {
                Console.WriteLine($"{m.Index}:{m.Value}");
                messageSubs.Add(m.Value);
            }

            Array.Clear(rxBuf, 0, rxLen);
            rxLen = 0;

            // 들어온 값이 8이 아니면 잘못된 패킷
            if (messageSubs.Count != 8)
                return false;

            // 첫 데이터가 0이 아니면 잘못된 패킷
            if (messageSubs[0] != "0")
                return false;

            return true;
        }

        private void DeviceProcess()
        {
            bool dev1 = messageSubs[1] == "1" ? true : false;
            bool dev2 = messageSubs[2] == "1" ? true : false;

            //if (cmd[3] == (byte)'1')
            //{
            //    btnSw1.Text = btnSw1.Text == "SW1 ON" ? "SW1 OFF" : "SW1 ON";
            //}
            //else if (cmd[4] == (byte)'1')
            //{
            //    btnSw2.Text = btnSw2.Text == "SW2 ON" ? "SW2 OFF" : "SW2 ON";
            //}
            //else
            //{
            //    btnLED1.Text = cmd[0] == (byte)'1' ? "LED1 OFF" : "LED1 ON";
            //    btnLED2.Text = cmd[1] == (byte)'1' ? "LED2 OFF" : "LED2 ON";
            //    btnLED3.Text = cmd[2] == (byte)'1' ? "LED3 OFF" : "LED3 ON";
            //}
            //btnSw1.Text = cmd[3] == (byte)'1' ? "SW1 OFF" : "SW1 ON";
            //btnSw2.Text = cmd[4] == (byte)'1' ? "SW2 OFF" : "SW2 ON";

            // 활용 한 데이터 초기화
        }

        private bool ReceiveDataPacket(byte data)
        {
            switch (rxLen)
            {
                case 0:
                    if (data == 0x5b) // 91 [
                    {
                        rxBuf[rxLen++] = data;
                    }
                    break;

                default:
                    rxBuf[rxLen++] = data;
                    if (data == 0x5d) // 93 ]
                        return true;
                    break;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialDevice.DataBits = 8;
            serialDevice.StopBits = StopBits.One;
            serialDevice.Parity = Parity.None;
            cbPort.DataSource = SerialPort.GetPortNames();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen)
            {
                serialDevice.Close();
                btnStart.Text = "실행하기";
            }
            else
            {
                serialDevice.PortName = cbPort.Text;
                serialDevice.BaudRate = Convert.ToInt32(cbBaud.Text);

                try
                {
                    serialDevice.Open();
                    btnStart.Text = "종료하기";
                }
                catch
                {
                    MessageBox.Show("serial open error");
                }
            }
        }
    }
}

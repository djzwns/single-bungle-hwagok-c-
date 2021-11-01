using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raspberry_led
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(SerialDataGet));
        }

        private byte[] rxBuf = new byte[255];
        int rxLen = 0;

        private void SerialDataGet(object sender, EventArgs e)
        {
            int bufferCount = serialDevice.BytesToRead;
            Console.WriteLine($"buffer count : {bufferCount}");
            for (int i = 0; i < bufferCount; ++i)
            {
                if (ReceiveDataPacket((byte)serialDevice.ReadByte()))
                {
                    // checksum
                    if (Checksum(rxBuf))
                        DeviceProcess();

                }
            }
        }

        private bool Checksum(byte[] rxBuf)
        {
            return rxBuf[0] == 0x5b && rxBuf[rxLen - 1] == 0x5d;
        }

        private void DeviceProcess()
        {
            //int sum = 0;
            List<byte> cmd = new List<byte>();

            // led 동작 코드
            for (int i = 1; i < rxLen - 1; ++i)
            {
                if (rxBuf[i] != 0x2c)
                {
                    cmd.Add(rxBuf[i]);
                    
                    Console.Write(rxBuf[i]);
                }
            }
            Console.WriteLine("");

            btnLED1.Text = cmd[0] == (byte)'1' ? "LED1 OFF" : "LED1 ON";
            btnLED2.Text = cmd[1] == (byte)'1' ? "LED2 OFF" : "LED2 ON";
            btnLED3.Text = cmd[2] == (byte)'1' ? "LED3 OFF" : "LED3 ON";
            //btnSw1.Text = cmd[3] == (byte)'1' ? "SW1 OFF" : "SW1 ON";
            //btnSw2.Text = cmd[4] == (byte)'1' ? "SW2 OFF" : "SW2 ON";

            //Console.WriteLine($"message sum: {sum}");

            // 활용 한 데이터 초기화
            Array.Clear(rxBuf, 0, rxLen);
            rxLen = 0;
        }


        private bool ReceiveDataPacket(byte rxDataByte)
        {
            switch(rxLen)
            {
                case 0:
                    if (rxDataByte == 0x5b) // 91 [
                    {
                        rxBuf[rxLen++] = rxDataByte;
                    }
                    break;

                default:
                    rxBuf[rxLen++] = rxDataByte;
                    if (rxDataByte == 0x5d) // 93 ]
                        return true;
                    break;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialDevice.BaudRate = 19200;
            serialDevice.DataBits = 8;
            serialDevice.StopBits = StopBits.One;
            serialDevice.Parity = Parity.None;
            //cbComPort.Items.AddRange(SerialPort.GetPortNames());
            cbComPort.DataSource = SerialPort.GetPortNames();
        }

        private void btnCmdSend_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            Console.WriteLine($"data send: {tbCommand.Text}");
            serialDevice.Write(tbCommand.Text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialDevice.PortName = cbComPort.Text;

            try
            {
                if (!serialDevice.IsOpen)
                    serialDevice.Open();
            }
            catch
            {
                MessageBox.Show("Serial Error");
            }
        }

        private void tbCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                serialDevice.Write(tbCommand.Text);
                tbCommand.Text = "[ ]";
                tbCommand.Focus();
                tbCommand.Select(1, 1);
            }
        }
    }
}

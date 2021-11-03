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
        private List<Label> controlLabels = new List<Label>();
        private List<PictureBox> controlImages = new List<PictureBox>();

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
            lbRecvPacket.Text = msg;
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
            string timestemp = DateTime.Now.ToString("mm:ss");

            // messageSubs[0] == start data
            float temp = Convert.ToSingle(messageSubs[6]);
            float humi = Convert.ToSingle(messageSubs[7]);

            chartTH.Series["Temperature"].Points.AddXY(timestemp, temp);
            chartTH.Series["Humidity"].Points.AddXY(timestemp, humi);
            if (chartTH.Series[0].Points.Count >= 50)
            {
                chartTH.Series["Temperature"].Points.RemoveAt(0);
                chartTH.Series["Humidity"].Points.RemoveAt(0);
            }

            for (int i = 0; i < 5; ++i)
            {
                bool enabled = messageSubs[i + 1] == "1";
                controlLabels[i].Text = enabled ? "ON" : "OFF";
                controlLabels[i].ForeColor = enabled ? Color.DarkGreen : Color.Red;
                controlImages[i].Image = imageList.Images[Convert.ToInt32(enabled)];
            }
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

            controlLabels.Add(lbDev1Stats);
            controlLabels.Add(lbDev2Stats);
            controlLabels.Add(lbDev3Stats);
            controlLabels.Add(lbSens1Stats);
            controlLabels.Add(lbSens2Stats);

            controlImages.Add(pbDev1);
            controlImages.Add(pbDev2);
            controlImages.Add(pbDev3);
            controlImages.Add(pbSensor1);
            controlImages.Add(pbSensor2);
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

        private void lbDevice1_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            serialDevice.Write("[1,0]");
        }

        private void lbDevice2_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            serialDevice.Write("[1,1]");
        }

        private void lbDevice3_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen == false)
                return;

            serialDevice.Write("[1,2]");
        }
    }
}

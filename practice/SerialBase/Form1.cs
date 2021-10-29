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

namespace SerialBase
{
    public partial class Form1 : Form
    {
        private static int messageCount = 0;

        private void ReceiveData(object sender, EventArgs e)
        {
            string displayMsg = messageCount.ToString("000#") + " R [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] : " + serialDevice.ReadExisting();

            lbMessageBox.Items.Add(displayMsg);
            ++messageCount;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            lbMessageBox.Items.Clear();

            cbComPort.Items.AddRange(SerialPort.GetPortNames());
            cbComPort.SelectedIndex = 0;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (serialDevice.IsOpen)
            {
                serialDevice.Close();
            }
            else
            {
                serialDevice.PortName = cbComPort.Text;
                serialDevice.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                try
                {
                    serialDevice.Open();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show(err.Message);
                }
            }

            btnConnection.Text = serialDevice.IsOpen ? "COM 포트 해제" : "COM 포트 연결";
            btnSend.Enabled = serialDevice.IsOpen;
        }

        private void SendMessage()
        {
            if (btnSend.Enabled == false)
                return;

            if (tbSendBox.Text == null)
                return;
            
            serialDevice.Write(tbSendBox.Text);

            string displayMsg = messageCount.ToString("000#") + " S [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] : " + tbSendBox.Text;
            lbMessageBox.Items.Add(displayMsg);
            tbSendBox.Text = "";
            ++messageCount;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void tbSendBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void serialDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Invoke(new EventHandler(ReceiveData));
                //Console.WriteLine(displayMsg);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lbMessageBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            lbMessageBox.DrawMode = DrawMode.OwnerDrawFixed;

            e.DrawBackground();

            Brush brush = Brushes.Black;

            string text = lbMessageBox.Items[e.Index].ToString();
            Console.WriteLine(text[5]);
            switch (text[5])
            {
                case 'R':
                    brush = Brushes.Blue;
                    break;
                case 'S':
                    brush = Brushes.Orange;
                    break;
            }

            e.Graphics.DrawString(lbMessageBox.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}

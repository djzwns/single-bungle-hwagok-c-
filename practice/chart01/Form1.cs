using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart01
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(ChartUpdate);
            timer1.Start();
        }

        private void ChartUpdate(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count >= 50)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }
            chart1.Series[0].Points.AddXY(DateTime.Now.ToString("mm:ss"), rand.Next(100));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count >= 10)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }
            chart1.Series[0].Points.AddXY(DateTime.Now.ToString("mm:ss"), rand.Next(100));
            //Console.WriteLine($"addxy result: {val}");
        }
    }
}

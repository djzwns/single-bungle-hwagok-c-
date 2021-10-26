using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenge01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScoreCalc_Click(object sender, EventArgs e)
        {
            float kor = Convert.ToSingle(tbKor.Text);
            float eng = Convert.ToSingle(tbEng.Text);
            float math = Convert.ToSingle(tbMath.Text);

            float total = kor + eng + math;
            float average = total / 3;
            string grade = "";

            if (average >= 90) grade = "A";
            else if (average >= 80) grade = "B";
            else if (average >= 70) grade = "C";
            else if (average >= 60) grade = "D";
            else grade = "F";

            labelTotal.Text = Convert.ToString(total);
            labelAverage.Text = Convert.ToString(average);
            labelGrade.Text = grade;
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            list99.Items.Clear();
            int dan = Convert.ToInt32(tbDan.Text);
            for (int i = 1; i < 10; ++i)
            {
                int value = i * dan;
                string strDisplay = "";
                strDisplay = $" {dan} * {i} = {value}";
                list99.Items.Add(strDisplay);
            }
            Random rand = new Random();
            list99.Items.Add(rand.Next(10).ToString());
        }
    }
}

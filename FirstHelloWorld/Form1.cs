using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string message = btnHello.Text == "Hello" ? "Hello World!!" : "Button Clicked!";
            MessageBox.Show(message, "Hello Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //    int[] arr = { 1, 2, 3, 4 };
            //    int[] initArr = { 6, 5, 4, 3, 2, 1 };
            //    Console.WriteLine(arr);
            //    Console.WriteLine("array 0 -> " + Convert.ToString(arr[0]));
            //    arr = new int[100];
            //    arr[0] = 0;
            //    arr[1] = 1;
            //    //Console.WriteLine("array 0 -> " + Convert.ToString(arr[0]));
            int a = 5;
            float b = 0;
            b = (float)a;
            Console.WriteLine(String.Format("b: {0}", b));
            btnHello.Text = btnHello.Text == "Hello" ? "Button" : "Hello";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);

            labelResult.Text = Convert.ToString(left + right);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);

            labelResult.Text = Convert.ToString(left - right);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);

            labelResult.Text = Convert.ToString(left * right);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);
            if (right == 0)
            {
                labelResult.Text = "오른쪽 값이 0이 되면 안됨니다";
                return;
            }

            labelResult.Text = Convert.ToString(left / right);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);

            labelResult.Text = Convert.ToString(left == right);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int left = Convert.ToInt32(tbLeft.Text);
            int right = Convert.ToInt32(tbRight.Text);
            if (left > right)
            {
                int t = left;
                left = right;
                right = t;
            }

            int sum = 0;
            for (int i = left; i <= right; ++i)
            {
                sum += i;
            }

            labelResult.Text = Convert.ToString(sum);
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int left = Convert.ToInt32(tbLeft.Text);
            int right = Convert.ToInt32(tbRight.Text);
            if (left > right)
            {
                int t = left;
                left = right;
                right = t;
            }


            if ((left & 1) == 1)
                left += 1;

                int sum = 0;
            for (int i = left; i <= right; i += 2)
            {
                sum += i;
            }

            labelResult.Text = Convert.ToString(sum);
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            float left = Convert.ToSingle(tbLeft.Text);
            float right = Convert.ToSingle(tbRight.Text);
            float result = 0;

            try
            {
                result = left / right;

            } catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
                labelResult.Text = error.Message;
            } finally
            {
                labelResult.Text = Convert.ToString(result);
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            float kor = Convert.ToSingle(tbKor.Text);
            float eng = Convert.ToSingle(tbEng.Text);
            float math = Convert.ToSingle(tbMath.Text);

            float total = kor + eng + math;
            float avg = total / 3;
            string grade = "";
            if (avg >= 90) grade = "A";
            else if (avg >= 80) grade = "B";
            else if (avg >= 70) grade = "C";
            else if (avg >= 60) grade = "D";
            else grade = "F";

            labelTotalTxt.Text = Convert.ToString(total);
            labelAverageTxt.Text = Convert.ToString(avg);
            labelGradeTxt.Text = grade;
        }
    }
}

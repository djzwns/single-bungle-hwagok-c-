using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseballgame
{
    public partial class Form1 : Form
    {
        private const int MAX_TIMES = 9;
        private const int MAX_COUNT = 3;
        private const int MAX_NUM = 10;
        private Random rand = new Random();
        private int[] computer = new int[MAX_COUNT];
        private char hide => cbHide.Checked ? '*' : '\0';
        private int timesCount;

        private int userScore = 0;
        private int computerScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitGame()
        {
            ComputerNumberSet();
            ComputerNumberHide(hide);
            timesCount = MAX_TIMES;
            labelTimesCount.Text = timesCount.ToString();
            labelComScore.Text = computerScore.ToString();
            labelUserScore.Text = userScore.ToString();
        }

        private void ComputerNumberHide(char _hide = '*')
        {
            tbComNum0.PasswordChar = _hide;
            tbComNum1.PasswordChar = _hide;
            tbComNum2.PasswordChar = _hide;
        }

        private void ComputerNumberSet()
        {
            for (int i = 0; i < MAX_COUNT; ++i)
            {
                computer[i] = rand.Next(MAX_NUM);

                for (int j = 0; j < i; ++j)
                {
                    if (computer[i] == computer[j])
                    {
                        computer[j--] = rand.Next(MAX_NUM);
                    }
                }
            }

            Console.WriteLine($"num0: {computer[0]}, num1: {computer[1]}, num2: {computer[2]}");
            tbComNum0.Text = computer[0].ToString();
            tbComNum1.Text = computer[1].ToString();
            tbComNum2.Text = computer[2].ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int[] user = { Convert.ToInt32(tbUserNum0.Text), Convert.ToInt32(tbUserNum1.Text), Convert.ToInt32(tbUserNum2.Text) };
            int s = 0;
            int b = 0;

            for (int i = 0; i < MAX_COUNT; ++i)
            {
                if (computer[i] == user[i])
                {
                    ++s;
                    continue;
                }
                for (int j = 0; j < MAX_COUNT; ++j)
                {
                    if (i == j) continue;

                    if (computer[i] == user[j])
                        ++b;
                }
            }

            listResult.Items.Add($"B: {b}, S: {s} - [ {user[0]} : {user[1]} : {user[2]} ]");
            listResult.SelectedIndex = listResult.Items.Count - 1;
            if (s == MAX_COUNT && timesCount != 0)
            {
                listResult.Items.Clear();
                listResult.Items.Add($"정답입니다~ - [ {user[0]} : {user[1]} : {user[2]} ]");
                ++userScore;
                InitGame();
                return;
            }
            --timesCount;
            labelTimesCount.Text = timesCount.ToString();
            if (timesCount == 0)
            {
                listResult.Items.Clear();
                listResult.Items.Add("실패~");
                ++computerScore;
                InitGame();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        private void cbHide_CheckedChanged(object sender, EventArgs e)
        {
            ComputerNumberHide(hide);
        }

        private void tbUserNum0_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbUserNum1.Focus();
                tbUserNum1.SelectAll();
            }
        }

        private void tbUserNum1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbUserNum2.Focus();
                tbUserNum2.SelectAll();
            }
        }

        private void tbUserNum2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);

                tbUserNum0.Focus();
                tbUserNum0.SelectAll();
            }
        }
    }
}

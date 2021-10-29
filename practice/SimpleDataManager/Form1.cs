using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataManager
{
    public partial class Form1 : Form
    {
        private List<int> dataList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            lbDataList.Items.Clear();
        }

        private void DataAdd()
        {
            if (tbData.Text == "" || tbData.Text == null)
                return;

            lbDataList.Items.Add(tbData.Text);
            dataList.Add(Convert.ToInt32(tbData.Text));
            tbData.Text = "";
        }

        private void tbData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                labelResult.Text = "데이터업슴";
                return;
            }

            int sum = dataList.Sum();
            labelResult.Text = sum.ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                labelResult.Text = "데이터업슴";
                return;
            }

            dataList.Sort();
            labelResult.Text = dataList[dataList.Count - 1].ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                labelResult.Text = "데이터업슴";
                return;
            }

            dataList.Sort();
            labelResult.Text = dataList[0].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataList.Clear();
            lbDataList.Items.Clear();
            labelResult.Text = "";
        }
    }
}

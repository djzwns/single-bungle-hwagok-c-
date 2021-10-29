using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvResult.Items)
            {
                int total = 0;
                float average = 0;
                foreach (ListViewItem sub in item.SubItems)
                {
                    total += Convert.ToInt32(sub.Text);
                }
                item.SubItems.Add(total.ToString());
                item.SubItems.Add(average.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void tbKor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbEng.Focus();
            }
        }

        private void tbEng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMath.Focus();
            }
        }

        private void tbMath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddData();
            }
        }

        private void AddData()
        {
            if (string.IsNullOrEmpty(tbKor.Text) || string.IsNullOrEmpty(tbEng.Text) || string.IsNullOrEmpty(tbMath.Text))
            {
                return;
            }

            ListViewItem item = new ListViewItem(tbKor.Text);
            item.SubItems.Add(tbEng.Text);
            item.SubItems.Add(tbMath.Text);
            lvResult.Items.Add(item);
            tbKor.Text = "";
            tbEng.Text = "";
            tbMath.Text = "";
            tbKor.Focus();
        }
    }
}

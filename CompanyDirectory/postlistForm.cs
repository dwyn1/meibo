using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDirectory
{
    public partial class postlistForm : Form
    {
        string s;
        string s1;
        string s2;
        string s3;
        int j = 0;  //前後ボタンクリック回数
        int k;  //ID番号
        int m;
        public postlistForm()
        {
            InitializeComponent();
            InitializeComponent();
            cmbSex.Items.Add("");
            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");
            m = 0;
            cmbSex.SelectedIndex = m;
        }

        private void buttonbefore_Click(object sender, EventArgs e)
        {
            j--;
            if (j == 0)
            {
                buttonbefore.Visible = false;
            }
            //DBに回数jを受け取ってもらう。
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttonbefore.Visible = true;
            j++;
            //DBに回数jを受け取ってもらう。
        }

        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            s = txtid.Text;
            k = int.Parse(s);
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvYakuin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonbefore.Visible = false;
        }
    }
}

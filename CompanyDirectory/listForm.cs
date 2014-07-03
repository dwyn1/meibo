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
    public partial class listForm : Form
    {
        string s;
        string s1;
        string s2;
        string s3;
        int j=0;  //前後ボタンクリック回数
        int k;  //ID番号
        int m;
        public listForm()
        {
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

        private void buttonsearch_Click(object sender, EventArgs e)  //検索 今回はjとkとm;
        {

        }

        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            s = txtid.Text;
            k = int.Parse(s);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            s1 = txtName.Text;
        }

        private void txtKana_TextChanged(object sender, EventArgs e)
        {
            s2 = txtKana.Text;
        }

        private void cmbBusho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYaku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbEnter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            s3 = txtMail.Text;
        }

        private void listForm_Load(object sender, EventArgs e)
        {
                buttonbefore.Visible = false;
        }
    }
}

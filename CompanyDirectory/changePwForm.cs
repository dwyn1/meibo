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
    public partial class changePwForm : Form
    {
        string s1;
        string s2;
        string s3;
        int y;
        public changePwForm(int x)
        {
            InitializeComponent();
            this.SendDataB = x;
        }

        private void txtNowPw_TextChanged(object sender, EventArgs e)
        {
            s1 = txtNowPw.Text;
        }

        private void txtNewPw_TextChanged(object sender, EventArgs e)
        {
            s2 = txtNewPw.Text;
        }

        private void txtCheckPw_TextChanged(object sender, EventArgs e)
        {
            s3 = txtCheckPw.Text;
        }

        private void buttonPwOK_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            y = this.SendDataB;
            if (pass.show(s1) == 0 & pass.show(s2) == 0&s1==y.ToString() &s2 == s3)
            {   //DBに更新後のPASSを渡す。
                this.Close();
            }
            else if (pass.show(s1) != 0 || pass.show(s2) != 0 || s2 != s3 || s1 != y.ToString())
            {
                txtNowPw.Text = "";
                txtNewPw.Text = "";
                txtCheckPw.Text = "";
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "入力形式にミスがあります";
            }
        }
        public int SendDataB
        {
            set
            {
                y = value;

            }
            get
            {
                return y;
            }
        }
    }
}

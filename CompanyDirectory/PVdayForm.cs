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
    public partial class PVdayForm : Form
    {
        int j = 0;  //前後ボタンクリック回数
        public PVdayForm(int i)
        {
            InitializeComponent();
            //labPVに直近の10日分表示
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttonbefore.Visible = true;
            j++;
            //DBに回数jを受け取ってもらう。
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

        private void PVdayForm_Load(object sender, EventArgs e)
        {
            buttonbefore.Visible = false;
        }
    }
}

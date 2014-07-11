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
    public partial class checkForm : Form
    {
        int x;
        public checkForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (SendData == 1)  //チェック文　消す
            {
                //xすなわちIDを元にDBが情報検索し削除する。
            }
            this.Close();
        }
        public int SendData
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class entryForm : Form
    {
        public entryForm(int i)
        {
            InitializeComponent();
            if (i == 0)
            {
                txtid.Text = "";
            }
            else
            {
                txtid.Text = i.ToString();
            }
        }

        private void txtid_MaskInputRejected(object sender, EventArgs e)
        {

        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class deleteForm : Form
    {
        int x;
        public deleteForm(int i)
        {
            InitializeComponent();
            labId.Text = i.ToString();
            this.SendData = i;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            checkForm chf = new checkForm();
            chf.SendData = this.SendData;
            chf.Show();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteForm_Load(object sender, EventArgs e)
        {

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
    }
}

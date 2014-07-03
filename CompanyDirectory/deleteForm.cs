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
        public deleteForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            deleteForm df = new deleteForm();
            df.Show();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

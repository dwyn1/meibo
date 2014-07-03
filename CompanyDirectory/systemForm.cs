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
    public partial class systemForm : Form
    {
        public systemForm()
        {
            InitializeComponent();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            changePwForm cpf = new changePwForm();
            cpf.Show();
        }

        private void buttonMast_Click(object sender, EventArgs e)
        {
            masterForm mf = new masterForm();
            mf.Show();
        }
    }
}

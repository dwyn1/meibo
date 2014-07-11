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
    public partial class entrymasterForm : Form
    {
        public entrymasterForm(int i)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //DBに情報を渡す
            this.Close();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

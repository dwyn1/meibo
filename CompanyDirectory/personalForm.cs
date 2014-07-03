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
    public partial class personalForm : Form
    {
        changePwForm cpf = new changePwForm();
        public personalForm(int i)
        {
            InitializeComponent();
            labId.Text = i.ToString();
            //label32～label16までＤＢに頼む
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            cpf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVdayForm pvdf = new PVdayForm();
            pvdf.Show();
        }
    }

}

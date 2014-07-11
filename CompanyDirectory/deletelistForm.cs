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
    public partial class deletelistForm : Form
    {
        int i;
        public deletelistForm()
        {
            InitializeComponent();
        }

        private void buttonReentry_Click(object sender, EventArgs e)
        {    
            //dvgdeleteにて選択されている者のIDをiとする。実験的にi=1
            i = 1;
            entryForm ef = new entryForm(i);
            ef.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //dvgdeleteにて選択されている者のIDをiとする。
            checkForm cf = new checkForm();
            cf.SendData = i;
            cf.Show();
        }
    }
}

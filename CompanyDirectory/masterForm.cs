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
    public partial class masterForm : Form
    {
        int i;
        public masterForm()
        {
            InitializeComponent();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /*if (dgvBusho.Rows[0].Selected == true)
            {
                entrymasterForm emf = new entrymasterForm(0);
                emf.Show();
            }
            else if (dgvBusho.Rows[1].Selected == true)
            {
                entrymasterForm emf = new entrymasterForm(1);
                emf.Show();
            }
            else if (dgvBusho.Rows[2].Selected == true)
            {
                entrymasterForm emf = new entrymasterForm(2);
                emf.Show();
            }*/
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            entrymasterForm emf = new entrymasterForm(1);// 訂正必要
            emf.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            entrymasterForm emf = new entrymasterForm(1);//訂正必要
            emf.Show();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

    }
}

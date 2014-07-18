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
    public partial class chooseForm : Form
    {
       
        postlistForm plf = new postlistForm();
        CheckID ci = new CheckID();
        
        int x;
        public chooseForm()
        {
            InitializeComponent();
        }

        private void buttonKojin_Click(object sender, EventArgs e)
        {
            int i;
            i = x;
            personalForm pf = new personalForm(i);
            pf.Show();
        }

        private void bottonMeibo_Click(object sender, EventArgs e)
        {
            // 畑中追加、すぐに消す

            if (SendData == 1)
            {
                plf.Show();
            }
            else if (SendData >= 101 && SendData<= 300)
            {
                
                listForm lf = new listForm();
                this.Visible = false;
                lf.ShowDialog(this);
                
            }
            else if (SendData == 3)
            {
                managelistForm mlf = new managelistForm();
                mlf.Show();
            }
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

        private void chooseForm_Load(object sender, EventArgs e)
        {

        }
        private void chooseForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

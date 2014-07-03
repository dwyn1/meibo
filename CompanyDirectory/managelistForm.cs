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
    public partial class managelistForm : Form
    {
        int i;
        public managelistForm()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            /*if(データ選択されていない場合)
             ERROR
              else
             {
              選択内容をentryFormに引き渡す。変数iにid番号が入力される。
              }
             */
            i = 1;                        //実験的にidは1とする。
            entryForm ef = new entryForm(i);
            ef.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            i = 0;                      //IDに0は存在しない。
            entryForm ef = new entryForm(i);
            ef.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

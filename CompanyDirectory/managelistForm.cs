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
        string s;
        string s1;
        string s2;
        string s3;
        int j = 0;  //前後ボタンクリック回数
        int k;  //ID番号
        int m;
        int x;
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
            i = 0;                      //IDに0は存在しない。実験
            entryForm ef = new entryForm(i);
            ef.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {   /*if(データ選択されていない場合)
             ERROR
              else
             {
              選択内容をdeleteFormに引き渡す。変数iにid番号が入力される。
              }
             */
            i = 1;                        //実験的にidは1とする。
            deleteForm df = new deleteForm(i);
            df.Show();
        }

        private void buttonPV_Click(object sender, EventArgs e)
        {
            i = 1;
            takePVForm tpf = new takePVForm(i);
            tpf.Show();
        }

        private void mainteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            systemForm sf = new systemForm();
            sf.Show();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbBirth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonbefore_Click(object sender, EventArgs e)
        {
            j--;
            if (j == 0)
            {
                buttonbefore.Visible = false;
            }
            //DBに回数jを受け取ってもらう。
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttonbefore.Visible = true;
            j++;
            //DBに回数jを受け取ってもらう。
        }

        private void managelistForm_Load(object sender, EventArgs e)
        {
            buttonbefore.Visible = false;
        }
    }
}

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
    public partial class entryForm : Form
    {
        int a;
        int b;
        int c;
        int countuse;
        int x;
        int yearcheck = 0;//yearcheckは0(今年)か-1(去年)しかとらない
        DateTime d;
        DateTime d1;
        public entryForm(int i)
        {
            InitializeComponent();
            d1 = DateTime.Now;
            a = d1.Year;
            b = d1.Month;
            c = d1.Day;
            if (i == 0)  //とりあえずチェック用にID=0ははじく
            {
                txtid.Text = "";
            }
            else
            {
                txtid.Text = i.ToString();
                Yukyuu yukyuu = new Yukyuu();
                //method-nyusya;ID(i)から入社年月日を返してもらうメソッドだが別のフォームで同内容のものがあればそれでOK
                DateTime dx = DateTime.Now; //試験的に入社年月日を現在の日付にし、それで動かす。
                txtAllPV.Text = yukyuu.show(dx, yearcheck).ToString();//全有給日数
                //method-i:IDから氏名を持ってくる。メソッド。labNameに入力
                txtName.Text = "畑中";
                //method-syouhi:IDから使用した有給日数(更新前)をカウントするメソッド。labTakePVに入力
                countuse = 0;
                txtTakePV.Text = countuse.ToString();
                //残り有給日数(labHavePV)については以上の情報から導出可能
                txtHavePV.Text = (yukyuu.show(dx, yearcheck) - countuse).ToString();
            }
            

        }

        private void txtid_MaskInputRejected(object sender, EventArgs e)
        {

        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //DBにデータ登録
            this.Close();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

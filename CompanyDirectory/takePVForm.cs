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
    public partial class takePVForm : Form
    {
        int a;
        int b;
        int c;
        int countuse;
        int x;
        int yearcheck = 0;//yearcheckは0(今年)か-1(去年)しかとらない
        DateTime d;
        DateTime d1;
        public takePVForm(int i)
        {
            InitializeComponent();
            d1 = DateTime.Now;
            a = d1.Year;
            b = d1.Month;
            c = d1.Day;
            label1.Text = a + "年" + b + "月" + c + "日";
            labId.Text = i.ToString();
            Yukyuu yukyuu = new Yukyuu();
            //method-nyusya;ID(i)から入社年月日を返してもらうメソッドだが別のフォームで同内容のものがあればそれでOK
            DateTime dx=DateTime.Now; //試験的に入社年月日を現在の日付にし、それで動かす。
            labAllPV.Text=yukyuu.show(dx,yearcheck).ToString();//全有給日数
            //method-i:IDから氏名を持ってくる。メソッド。labNameに入力
            labName.Text="畑中";
            //method-syouhi:IDから使用した有給日数(更新前)をカウントするメソッド。labTakePVに入力
            countuse=0;
            labTakePV.Text=countuse.ToString();
            //残り有給日数(labHavePV)については以上の情報から導出可能
            labHavePV.Text=(yukyuu.show(dx,yearcheck)-countuse).ToString();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            d = monthCalendar1.SelectionStart;
            a = d.Year;
            b = d.Month;
            c = d.Day;
            label1.Text = a + "年" + b + "月" + c + "日";
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //DB担当　DBへ有給使用日(a,b,c)を受け渡す
            this.Close();
        }

    }
    class Yukyuu
    {
        public double show(DateTime dx, int yearcheck)
        {

            int a, b, c;
            double d1;
            a = dx.Year;
            b = dx.Month;
            c = dx.Day;
            DateTime dt = new DateTime(a, b, c);
            DateTime dtYear0Month6 = dt.AddMonths(6);
            dt = dtYear0Month6;
            if (dt.Month < 11 && dt.Month >= 7)
            {
                Month11to7 month11to7 = new Month11to7();
                d1=month11to7.show(dt,yearcheck);
            }
            else if ((dt.Month == 11 && dt.Day > 1) || dt.Month > 11)
            {
                Monthmore11 monthmore11 = new Monthmore11();
                d1 = (monthmore11.show(dt, yearcheck));
            }
            else if (dt.Month <= 6)
            {
                Monthless6 monthless6 = new Monthless6();
                d1 = (monthless6.show(dt, yearcheck));
            }
            else
            {
                Month11day1 month11day1 = new Month11day1();
                d1 = (month11day1.show(dt, yearcheck));
            }
            return d1;
        }
    }
    class Hantei
    {
        public bool show(DateTime dt, DateTime dtToday)
        {
            bool b=false;
            if ((dtToday.Month < dt.Month) || (dtToday.Month == dt.Month && dt.Day > dtToday.Day))
            {
                b =false;
            }
            else if ((dtToday.Month > dt.Month) || (dtToday.Month == dt.Month && dt.Day < dtToday.Day))
            {
                b = true;
            }
            return b;
        }
    }
    class Month11to7
    {
        public double show(DateTime dt, int i)
        {
            double x;
            double d;
            DateTime dtToday = DateTime.Now;
            dtToday = dtToday.AddYears(i);
            Hantei hantei = new Hantei();
            if (dtToday.Year - dt.Year==-1 && hantei.show(dt, dtToday) == false)
            {
                x = 0;

            }
            else if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == true)
            {
                x = 0;

            }
            else if (dtToday.Year == dt.Year &&hantei.show(dt,dtToday)==false)
            {
                x = 0;

            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == true)
            {
                d = dtToday.Month - 11;
                x = 10 + Math.Floor(d * 11 / 12);

            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false) //2年次のみの月割り処理
            {
                d = dtToday.Month;
                x = 10 + Math.Floor((2 + d) * 11 / 12);

            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == true)
            {
                d = dt.Month;
                x = 11;

            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == false)
            {
                d = dt.Month;
                x = 11;

            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == true)
            {
                x = 12;

            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == false)
            {
                x = 12;

            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == true)
            {
                x = 14;

            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == false)
            {
                x = 14;

            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == true)
            {
                x = 16;

            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == false)
            {
                x = 16;

            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == true)
            {
                x = 18;

            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == false)
            {
                x = 18;

            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == true)
            {
                x = 20;

            }
            else if (dtToday.Year - dt.Year == 7 && hantei.show(dt, dtToday) == false)
            {
                x = 20;
            }
            else
            {
                x = 20;

            }
            return x;
        }
    }
    class Monthmore11
    {
        public double show(DateTime dt, int i)
        {
            double x;
            double d;
            DateTime dtToday = DateTime.Now;
            dtToday = dtToday.AddYears(i);
            Hantei hantei = new Hantei();

            if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == false)
            {
                x = 0;

            }
            else if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == true)
            {
                x = 0;

            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == false)
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == true)
            {
                d = dtToday.Month - 11;
                x = 10 + Math.Floor(d * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false)
            {
                d = dtToday.Month;
                x = 10 + Math.Floor((2 + d) * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == true)
            {
                d = dt.Month;
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == false)
            {
                d = dt.Month;
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == true)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == false)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == true)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == false)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == true)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt,dtToday)==false)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == true)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == false)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == true)
            {
                x = 20;
            }
            else
            {
                x = 20;
            }
            return x;

        }
    }
    class Monthless6
    {
        public double show(DateTime dt, int i)
        {
            double x;
            double d;
            DateTime dtToday = DateTime.Now;
            Hantei hantei = new Hantei();
            dtToday = dtToday.AddYears(i);
            if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == false)
            {
                x = 0;

            }
            else if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == true)
            {
                x = 0;

            }
            else if (dt.Year == dtToday.Year && hantei.show(dt, dtToday) == false)
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == true&&dtToday.Month<11)
            {
                x = 10;
            }
            else if (dtToday.Year==dt.Year && hantei.show(dt, dtToday) == true&&dtToday.Month>=11)
            {
                d = dtToday.Month;
                x = 10 + Math.Floor(d * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false)
            {
                d = dtToday.Month;
                x = 10 + Math.Floor((2 + d) * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == true)
            {
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == false)
            {
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == true)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == false)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == true)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == false)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == true)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == false)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == true)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == false)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == true)
            {
                x =20;
            }
            else
            {
                x = 20;
            }
            return x;
        }
    }
    class Month11day1
    {
        public double show(DateTime dt, int i)
        {
            double x;
            double d;
            DateTime dtToday = DateTime.Now;
            Hantei hantei = new Hantei();
            dtToday = dtToday.AddYears(i);
            if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == false)
            {
                x = 0;

            }
            else if (dtToday.Year - dt.Year == -1 && hantei.show(dt, dtToday) == true)
            {
                x = 0;

            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == false)
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == true)
            {
                d = dtToday.Month - 11;
                x = 10 + Math.Floor(d * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false)
            {
                d = dtToday.Month;
                x = Math.Floor((2 + d) * 11 / 12) + 10;
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == true)
            {
                d = dt.Month;
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == false)
            {
                d = dt.Month;
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && hantei.show(dt, dtToday) == true)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == false)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && hantei.show(dt, dtToday) == true)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == false)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && hantei.show(dt, dtToday) == true)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == false)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && hantei.show(dt, dtToday) == true)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == false)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && hantei.show(dt, dtToday) == true)
            {
                x = 20;
            }
            else if (dtToday.Year - dt.Year == 7 && hantei.show(dt, dtToday) == false)
            {
                x = 20;
            }
            else if (dtToday.Year - dt.Year == 7 && hantei.show(dt, dtToday) == true)
            {
                x = 20;
            }
            else
            {
                x = 20;
            }
            return x;
        }
    }
}




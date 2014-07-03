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
        int x;
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
            labAllPV.Text=yukyuu.zen(yukyuu.nen(i), 0).ToString();
            labTakePV.Text = yukyuu.syouhi(i).ToString();
            labHavePV.Text = (yukyuu.zen(yukyuu.nen(i), 0) - yukyuu.syouhi(i)).ToString();
            labName.Text = yukyuu.name(i);
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
        public DateTime nen (int i)
        {
            //DB処理　iつまりIDを元に入社年月日を呼び出す。
            DateTime d = DateTime.Now;
            return d;
        }
        public int syouhi(int i)
        {
            //DB処理 iを元に使用日から使用日数を計算する。
            return 0;
        }
        public string name(int i)
        {
            //DB処理 iを元に名前を呼び出す。
            return "畑中";
        }
        public double zen(DateTime y, int d)
        {
            
            int a, b, c;
            double x;
            a=y.Year;
            b = y.Month;
            c = y.Day;
            DateTime dt = new DateTime(a, b, c);
            DateTime dtYear0Month6 = dt.AddMonths(6);
            dt = dtYear0Month6;

            DateTime dtToday = DateTime.Now;
            DateTime dtToday1 = DateTime.Now;
            dtToday = dtToday.AddYears(d);
            
            if (dt.Month < 11 && dt.Month >= 7)
            {
                Month11to7 month11to7 = new Month11to7();
                x=month11to7.show(dt,dtToday);
            }
            else if ((dt.Month == 11 && dt.Day > 1) || dt.Month > 11)
            {
                Monthmore11 monthmore11 = new Monthmore11();
                x=monthmore11.show(dt,dtToday);
            }
            else if (dt.Month <= 6)
            {
                Monthless6 monthless6 = new Monthless6();
                x=monthless6.show(dt,dtToday);
            }
            else
            {
                Month11day1 month11day1 = new Month11day1();
                x=month11day1.show(dt,dtToday);
            }
            return x;
        }
    }
    class Hantei
    {
        public bool hmethod(DateTime now, DateTime sixmonth,int i)
        {
          bool b;
          b = true;
          if (now.Year - sixmonth.Year==i && (now.Month < sixmonth.Month) || (now.Month == sixmonth.Month && sixmonth.Day < now.Day))
          {
              b = true;
          }
          else if (now.Year - sixmonth.Year==i && (now.Month > sixmonth.Month) || (now.Month == sixmonth.Month && sixmonth.Day > now.Day))
          {
              b = false;
          }
          return b;
           
        }
    }
    class Month11to7
    {
        public double show(DateTime dt, DateTime dtToday)
        {
            double x;
            double d;
            Hantei hantei = new Hantei();

            if (hantei.hmethod(dtToday, dt, -1) == true)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, -1) == false)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday,dt,0)==true)
            {
                x = 0;

            }
            else if (hantei.hmethod(dtToday, dt, 0) == false)
            {
                if (dtToday.Month <= 10)
                {
                    d = 0;
                    x = 10;
                }
                else
                {
                    d = dtToday.Month - 10;
                    x = Math.Floor(d * 11 / 12);
                }                
            }
            else if (hantei.hmethod(dtToday, dt, 1) == true)
            {
                d = dtToday.Month;
                x = Math.Floor((2 + d) * 11 / 12);

            }
            else if (hantei.hmethod(dtToday, dt, 1) == false)
            {
                x = 11;

            }
            else if (hantei.hmethod(dtToday, dt, 2) == true)
            {
                x = 11;

            }
            else if (hantei.hmethod(dtToday, dt, 2) == false)
            {
                x = 12;

            }
            else if (hantei.hmethod(dtToday, dt, 3) == true)
            {
                x = 12;

            }
            else if (hantei.hmethod(dtToday, dt, 3) == false)
            {
                x = 14;

            }
            else if (hantei.hmethod(dtToday, dt, 4) == true)
            {
                x = 14;

            }
            else if (hantei.hmethod(dtToday, dt, 4) == false)
            {
                x = 16;

            }
            else if (hantei.hmethod(dtToday, dt, 5) == true)
            {
                x = 16;

            }
            else if (hantei.hmethod(dtToday, dt, 5) == false)
            {
                x = 18;

            }
            else if (hantei.hmethod(dtToday, dt, 6) == true)
            {
                x = 18;

            }
            else if (hantei.hmethod(dtToday, dt, 6) == false)
            {
                x = 20;

            }
            else if (hantei.hmethod(dtToday, dt, 7) == true)
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
        public double show(DateTime dt,DateTime dtToday)
        {
            double x;
            double d;
            Hantei hantei = new Hantei();

            if (hantei.hmethod(dtToday, dt, -1) == true)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, -1) == false)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, 0) == true)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, 0) == false)
            {
                x = 10;
            }
            else if (dtToday.Year - dt.Year == 1 && dtToday.Month < 11 && (dtToday.Month < dt.Month || (dtToday.Month == dt.Month && dtToday.Day < dt.Day)))
            {
                x = 10;
            }
            else if (dtToday.Year - dt.Year == 1 && (dtToday.Month == 11 && dtToday.Day == 1))
            {
                d = 1;
                x =  Math.Floor(d * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && dtToday.Month >= 11 && (dtToday.Month > dt.Month || (dtToday.Month == dt.Month && dtToday.Day >= dt.Day)))
            {
                x = 11;
            }
            else if (hantei.hmethod(dtToday, dt, 2) == true)
            {
                x = 11;
            }
            else if (hantei.hmethod(dtToday, dt, 2) == false)
            {
                x = 12;
            }
            else if (hantei.hmethod(dtToday, dt, 3) == true)
            {
                x = 12;
            }
            else if (hantei.hmethod(dtToday, dt, 3) == false)
            {
                x = 14;
            }
            else if (hantei.hmethod(dtToday, dt, 4) == true)
            {
                x = 14;
            }
            else if (hantei.hmethod(dtToday, dt, 4) == false)
            {
                x = 16;
            }
            else if (hantei.hmethod(dtToday, dt, 5) == true)
            {
                x = 16;
            }
            else if (hantei.hmethod(dtToday, dt, 5) == false)
            {
                x = 18;
            }
            else if (hantei.hmethod(dtToday, dt, 6) == true)
            {
                x = 18;
            }
            else if (hantei.hmethod(dtToday, dt, 6) == false)
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
        public double show(DateTime dt,DateTime dtToday)
        {
            double x;
            double d;
            Hantei hantei = new Hantei();
            if (hantei.hmethod(dtToday, dt, -1) == true)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, -1) == false)
            {
                x = 0;
            }
            else if ((hantei.hmethod(dtToday, dt, 0) == true))
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && (dtToday.Month < 11) && ((dtToday.Month == dt.Month && dtToday.Day >= dt.Day) || dt.Month < dtToday.Month))
            {
                x = 10;
            }
            else if (dtToday.Year == dt.Year && (dtToday.Month > 10))
            {
                d = dtToday.Month - 11;
                x =  Math.Floor(d * 11 / 12);
            }
            else if (hantei.hmethod(dtToday, dt, 1) == true)
            {
                d = dtToday.Month;
                x = Math.Floor((d + 2) * 11 / 12);
            }
            else if (hantei.hmethod(dtToday, dt, 1) == false)
            {
                d = dtToday.Month;
                x = 11;
            }
            else if (hantei.hmethod(dtToday, dt, 2) == true)
            {
                x = 12;
            }
            else if (hantei.hmethod(dtToday, dt, 2) == false)
            {
                x =  12;
            }
            else if (hantei.hmethod(dtToday, dt, 3) == true)
            {
                x = 14;
            }
            else if (hantei.hmethod(dtToday, dt, 3) == false)
            {
                x = 14;
            }
            else if (hantei.hmethod(dtToday, dt, 4) == true)
            {
                x = 16;
            }
            else if (hantei.hmethod(dtToday, dt, 4) == false)
            {
                x = 16;
            }
            else if (hantei.hmethod(dtToday, dt, 5) == true)
            {
                x = 18;
            }
            else if (hantei.hmethod(dtToday, dt, 5) == false)
            {
                x = 18;
            }
            else if (hantei.hmethod(dtToday, dt, 6) == true)
            {
                x = 20;
            }
            else if (hantei.hmethod(dtToday, dt, 6) == false)
            {
                x = 20;
            }
            else if (hantei.hmethod(dtToday, dt, 7) == true)
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
    class Month11day1
    {
        public double show(DateTime dt, DateTime dtToday)
        {
            double x;
            double d;
            Hantei hantei = new Hantei();
            if (hantei.hmethod(dtToday, dt, -1) == true)
            {
                x = 0;
            }
            else if (hantei.hmethod(dtToday, dt, -1) == false)
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && dtToday.Month < 11)
            {
                x = 0;
            }
            else if (dtToday.Year == dt.Year && dtToday.Month >= 11)
            {
                d = dtToday.Month - 11;
                x = Math.Floor(d * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && dtToday.Month < 11)
            {
                d = dtToday.Month;
                x = Math.Floor((2 + d) * 11 / 12);
            }
            else if (dtToday.Year - dt.Year == 1 && dtToday.Month >= 11)
            {
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && dtToday.Month < 11)
            {
                d = dt.Month;
                x = 11;
            }
            else if (dtToday.Year - dt.Year == 2 && dtToday.Month >= 11)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && dtToday.Month < 11)
            {
                x = 12;
            }
            else if (dtToday.Year - dt.Year == 3 && dtToday.Month >= 11)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && dtToday.Month < 11)
            {
                x = 14;
            }
            else if (dtToday.Year - dt.Year == 4 && dtToday.Month >= 11)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && dtToday.Month < 11)
            {
                x = 16;
            }
            else if (dtToday.Year - dt.Year == 5 && dtToday.Month >= 11)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && dtToday.Month < 11)
            {
                x = 18;
            }
            else if (dtToday.Year - dt.Year == 6 && dtToday.Month >= 11)
            {
                x = 20;
            }
            else if (dtToday.Year - dt.Year == 7 && dtToday.Month < 11)
            {
                x = 20;
            }
            else if (dtToday.Year - dt.Year == 7 && dtToday.Month >= 11)
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



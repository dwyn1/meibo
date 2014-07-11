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
        int x; int a;
        int b;
        int c;
        int countuse;
        int yearcheck0 = 0;//今年
        int yearcheck = -1;//去年
        int yearcheck1 = 1;//yearcheckは1(来年)
        DateTime d;
        DateTime d1;
        public personalForm(int i)
        {
            InitializeComponent();
            //label32～label16までＤＢに頼む
            //DB側にIDすなわちiから導き出される入社年月日を受け取る。そこからa,b,cを導出する。
            //。
            int x=2012;
            int y=1;
            int z=1;
            PVDay pvday = new PVDay();
            labPVday.Text = (pvday.show(x, y, z)).ToString();//有給増減日
            labCount.Text = (pvday.show(x, y, z) - DateTime.Now).ToString();//後何日
            d1 = DateTime.Now;
            a = d1.Year;
            b = d1.Month;
            c = d1.Day;
            label1.Text = a + "年" + b + "月" + c + "日";
            labId.Text = i.ToString();
            Yukyuu yukyuu = new Yukyuu();
            //method-nyusya;ID(i)から入社年月日を返してもらうメソッドだが別のフォームで同内容のものがあればそれでOK
            DateTime dx = new DateTime(2012, 1, 1); //ここでは入社年月日を2012年１月１日にし、それで動かす。
            labAddPV.Text = yukyuu.show(dx, yearcheck1).ToString();//来期付与有給日数
            //method-i:IDから氏名を持ってくる。メソッド。labNameに入力
            labName.Text = "畑中";
            //method-syouhi:IDから使用した有給日数(更新前)をカウントするメソッド。labTakePVに入力
            countuse = 0;//
            //残り有給日数(labHavePV)については以上の情報から導出可能
            labDelPV.Text = (yukyuu.show(dx, yearcheck) - countuse).ToString();
            labPaidVac.Text = (yukyuu.show(dx, yearcheck0) + yukyuu.show(dx, yearcheck) - countuse).ToString();

            this.SendDataA = i;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //SendDataAから、すなわちIDからPASSをもらう。ＤＢ
            changePwForm cpf = new changePwForm(2);//Passを２とする。
            cpf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVdayForm pvdf = new PVdayForm(this.SendDataA);
            pvdf.Show();
        }

        private void personalForm_Load(object sender, EventArgs e)
        {

        }
        public int SendDataA
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
    }
    
    class PVDay
    {
        public DateTime show(int a, int b, int c)   //staticの消し忘れに注意
        {
            DateTime dt = new DateTime(a, b, c);
            DateTime dtYear0Month6 = dt.AddMonths(6);
            dt = dtYear0Month6;
            Monthless11to1 m11to1 = new Monthless11to1();
            Monthmore11ex mm11 = new Monthmore11ex();
            Month11day1ex mm11d1 = new Month11day1ex();
            DateTime d1 = new DateTime();
            if (dt.Month >= 1 || dt.Month < 11)
            {
                d1 = m11to1.show(dt);
            }
            else if (dt.Month == 11 && dt.Day > 1 || dt.Month > 11)
            {
                d1 = mm11.show(dt);
            }
            else if (dt.Month == 11 && dt.Day == 1)
            {
                d1 = mm11d1.show(dt);
            }
            return d1;

        }
    }
    class Hantei1
    {
        public bool show(DateTime dt, DateTime dtToday)
        {
            bool b = false;
            if ((dtToday.Month < dt.Month) || (dtToday.Month == dt.Month && dt.Day > dtToday.Day))
            {
                b = false;
            }
            else if ((dtToday.Month > dt.Month) || (dtToday.Month == dt.Month && dt.Day < dtToday.Day))
            {
                b = true;
            }
            return b;
        }
    }
    class Monthless11to1
    {
        public DateTime show(DateTime dt)
        {
            DateTime d1 = new DateTime();                   //返す
            DateTime dtToday = DateTime.Now;
            Hantei1 hantei = new Hantei1();
            if (dtToday.Year == dt.Year)
            {
                if (hantei.show(dt, dtToday) == false)
                {
                    d1 = dt;
                }
                else if (hantei.show(dt, dtToday) == true && dtToday.Month < 11)
                {
                    int a, b, c;
                    a = dt.Year;
                    b = 11;
                    c = 1;
                    DateTime d = new DateTime(a, b, c);
                    d1 = d;

                }
                else if (hantei.show(dt, dtToday) == true && dtToday.Month > 11)
                {
                    d1 = dt.AddYears(1);
                }
            }
            else if (dtToday.Year > dt.Year && hantei.show(dt, dtToday) == false)
            {
                d1 = dt.AddYears(dtToday.Year - dt.Year);
            }
            else if (dtToday.Year > dt.Year && hantei.show(dt, dtToday) == true)
            {
                d1 = dt.AddYears(dtToday.Year - dt.Year + 1);
            }
            return d1;
        }
    }
    class Monthmore11ex
    {
        public DateTime show(DateTime dt)
        {
            DateTime d1 = new DateTime();                   //返す
            DateTime dtToday = DateTime.Now;
            Hantei1 hantei = new Hantei1();
            if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == false)
            {
                d1 = dt;
            }
            else if (dtToday.Year == dt.Year && hantei.show(dt, dtToday) == true)
            {
                int a, b, c;
                a = dtToday.Year + 1;
                b = 11;
                c = 1;
                DateTime d = new DateTime(a, b, c);
                d1 = d;
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false && dtToday.Month < 11)
            {
                int a, b, c;
                a = dtToday.Year + 1;
                b = 11;
                c = 1;
                DateTime d = new DateTime(a, b, c);
                d1 = d;
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == false && dtToday.Month >= 11)
            {
                d1 = dt.AddYears(1);
            }
            else if (dtToday.Year - dt.Year == 1 && hantei.show(dt, dtToday) == true)
            {
                d1 = dt.AddYears(2);
            }
            else if (dtToday.Year - dt.Year >= 2 && hantei.show(dt, dtToday) == false)
            {
                d1 = dt.AddYears(dtToday.Year - dt.Year);
            }
            else if (dtToday.Year - dt.Year >= 2 && hantei.show(dt, dtToday) == true)
            {
                d1 = dt.AddYears(dtToday.Year - dt.Year);
            }
            return d1;

        }
    }
    class Month11day1ex
    {
        public DateTime show(DateTime dt)
        {
            DateTime d1 = new DateTime();                   //返す
            DateTime dtToday = DateTime.Now;
            d1 = dt.AddYears(dtToday.Year - dt.Year);
            return d1;
        }
    }
}

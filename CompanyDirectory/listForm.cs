using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// 7月10日時点で最新

namespace CompanyDirectory
{
    public partial class listForm : Form
    {
        int j = 0;  //前後ボタンクリック回数
        int i = 0; //前後ボタンクリック回数その２
        int? k;  //ID番号
        int m;
        int? x;
        int y;
        string sid;
        string sx;

        int? i0;
        string s0 = "";
        string s1 = "";
        string s2;
        string s3;
        string s4;
        string s5, s5a, s5b, s5c;
        DateTime? dt;
        string s6;
        string s7 = "";
        public listForm()
        {
            InitializeComponent();
            int ret;
            string sex = "";
            string busho = "";
            string yaku = "";

            List<string> sexlist = new List<string>();
            ret = getSexList(ref sexlist);                //性別
            for (int i = 0; i < sexlist.Count; i++)
            {
                sex += sexlist[i];
                sex += "\n";
            }
            for (int i = 0; i < sexlist.Count; i++)
            {
                cmbSex.Items.Add(sexlist[i]);
            }
            List<string> busholist = new List<string>();
            ret = getBushoList(ref busholist);             //部署
            for (int i = 0; i < busholist.Count; i++)
            {
                busho += busholist[i];
                busho += "\n";
            }
            for (int i = 0; i < busholist.Count; i++)
            {
                cmbBusho.Items.Add(busholist[i]);
            }
            List<string> yakulist = new List<string>();
            ret = getYakuList(ref yakulist);             //役職
            for (int i = 0; i < yakulist.Count; i++)
            {
                yaku += yakulist[i];
                yaku += "\n";
            }
            for (int i = 0; i < yakulist.Count; i++)
            {
                cmbYaku.Items.Add(yakulist[i]);
            }
            cmbEnter.Items.Add("");                 //生年月日
            cmbEnter.Items.Add("同一");
            cmbEnter.Items.Add("前");
            cmbEnter.Items.Add("後");
        }
        private void buttonbefore_Click(object sender, EventArgs e)
        {
            j--;

            //if (j == 0)
            if (j == 0)
            {
                buttonbefore.Visible = false;
                buttonnext.Visible = true;
            }
            else
            {
                buttonbefore.Visible = true;
                buttonnext.Visible = true;
            }

            DataSet ds = this.maetugidata(i0, s0, s1, s2, s3, s4, dt, s6, s7, j);
            /*i0 = 0;
            s0 = "";
            s1 = "";*/
            this.Display(ds);
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttonbefore.Visible = true;

            j++;

            //DBに回数jを受け取ってもらう。

            DataSet ds = this.maetugidata(i0, s0, s1, s2, s3, s4, dt, s6, s7, j);
            this.Display(ds);
            //if (SendDataE - 10 * (j + 1) < 1)
            if (SendDataE - 10 * (j + 1) < 1)
            {
                buttonnext.Visible = false;
            }
            else
            {
                buttonbefore.Visible = true;
                buttonnext.Visible = true;
            }
            /*i0 = 0;
            s0 = "";
            s1 = "";*/
        }

        private void buttonsearch_Click(object sender, EventArgs e)  //検索 今回はjとkとm;
        {

            int count;
            j = 0;
            DataSet ds = this.getdata(i0, s0, s1, s2, s3, s4, dt, s6, s7, out count);//DBから受け取ったデータセット
            this.Display(ds);
            if (count <= 10)
            {
                buttonbefore.Visible = false;
                buttonnext.Visible = false;
            }
            else if (count > 10)
            {
                buttonnext.Visible = true;
                buttonbefore.Visible = false;
            }
            SendDataE = count;
            /*i0 = 0;
            s0 = "";
            s1 = "";*/


        }
        public DataGridView Display(DataSet ds)
        {
            dgvIppan.DataSource = ds;
            dgvIppan.DataMember = ds.Tables[0].TableName;
            int[] ippan_list_width = new int[] { 30, 78, 81, 81, 81, 45, 79, 200 }; //size720, 235
            for (int i = 0; ippan_list_width.Length > i; i++)
            {
                dgvIppan.Columns[i].Width = ippan_list_width[i];
            }

            //          表示データヘッダー部分の編集（不要かもしれません）
            string[] ippanlist = new string[] { "ID", "氏名", "かな氏名", "部署名", "役職名", "性別", "入社年月日", "メール" };
            for (int i = 0; ippanlist.Length > i; i++)
            {
                dgvIppan.Columns[i].HeaderText = ippanlist[i];
            }
            return dgvIppan;
        }
        public int getSexList(ref List<string> sexlist)
        {
            string sqlText = "";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";
            conn.Open();
            SqlCommand command = new SqlCommand();


            // SQL文を設定
            sqlText = " select * from ";
            sqlText += " (select ROW_NUMBER() OVER(ORDER BY sex_no) AS num, ";
            sqlText += "* from tbl_sex) ";
            sqlText += "as motodata where num between 1 and 10";

            command.CommandText = sqlText;
            command.Connection = conn;
            // SQL文を実行する

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                sexlist.Add((string)reader.GetValue(2));
            }

            conn.Close();

            return 0;
        }
        public int getBushoList(ref List<string> busholist)
        {
            string sqlText = "";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";
            conn.Open();
            SqlCommand command = new SqlCommand();


            // SQL文を設定
            sqlText = " select * from ";
            sqlText += " (select ROW_NUMBER() OVER(ORDER BY busho_no) AS num, ";
            sqlText += "* from tbl_busho) ";
            sqlText += "as motodata where num between 1 and 10";

            command.CommandText = sqlText;
            command.Connection = conn;
            // SQL文を実行する

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                busholist.Add((string)reader.GetValue(2));
            }

            conn.Close();

            return 0;
        }


        public int getYakuList(ref List<string> yakulist)
        {
            string sqlText = "";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";
            conn.Open();
            SqlCommand command = new SqlCommand();


            // SQL文を設定
            sqlText = " select * from ";
            sqlText += " (select ROW_NUMBER() OVER(ORDER BY yakushoku_no) AS num, ";
            sqlText += "* from tbl_yakushoku) ";
            sqlText += "as motodata where num between 1 and 10";

            command.CommandText = sqlText;
            command.Connection = conn;
            // SQL文を実行する

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                yakulist.Add((string)reader.GetValue(2));
            }

            conn.Close();

            return 0;
        }
        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            s0 = txtName.Text;
        }

        private void txtKana_TextChanged(object sender, EventArgs e)
        {
            s1 = txtKana.Text;
        }

        private void cmbBusho_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = cmbBusho.Text;
        }

        private void cmbYaku_SelectedIndexChanged(object sender, EventArgs e)
        {
            s3 = cmbYaku.Text;
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            s4 = cmbSex.Text;
        }

        private void txtEnterday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbEnter_SelectedIndexChanged(object sender, EventArgs e)
        {
            s6 = cmbEnter.Text;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            s7 = txtMail.Text;
        }

        private void listForm_Load(object sender, EventArgs e)
        {
            buttonbefore.Visible = false;
            buttonnext.Visible = false;
        }
        public int? SendDataC
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

        /************************************************
         * ＜SQL文発行＞
         * 検索データを受け取り、DB内のデータと照合して 
         * データを表示させる
         * ********************************************* */
        private DataSet getdata(int? i0, string s0, string s1, string s2, string s3, string s4, DateTime? dt, string s6, string s7, out int count)  //検索ボタンクリック時のDB用メソッド
        {
            count = 0;

            string sqlText;
            string s;
            // DataGrid dg = new DataGrid();
            sid = txtid.Text;
            if (txtid.Text == "")
            {
                k = null;
                s = null;
            }
            else
            {
                try
                {
                    k = int.Parse(sid);
                    s = sid;
                }
                catch
                {
                    k = 11111;
                    s = "11111";
                }

            }
            this.SendDataC = k;
            i0 = k;

            String shortDateString;
            s5 = txtEnterday.Text;
            s5a = s5.Substring(0, 4);
            s5b = s5.Substring(5, 2);
            s5c = s5.Substring(8, 2);
            string snn;
            string snn1;
            string snn2;
            string snn3;
            string snn4;
            if (s5 == "    年  月  日")
            {
                dt = null;
                shortDateString = "";
                snn = "and nyusya LIKE'%" + shortDateString + "' ";
            }
            else
            {
                try
                {
                    dt = new DateTime(int.Parse(s5a), int.Parse(s5b), int.Parse(s5c));


                    shortDateString = dt.Value.ToShortDateString();
                    MessageBox.Show(shortDateString);
                    if (s6 == "同一")
                    {
                        snn = "and nyusya ='" + shortDateString + "' ";
                    }
                    else if (s6 == "前")
                    {
                        snn = "and nyusya <'" + shortDateString + "' ";
                    }
                    else if (s6 == "後")
                    {
                        snn = "and nyusya >'" + shortDateString + "' ";
                    }
                    else
                    {
                        snn = "and nyusya ='" + shortDateString + "' ";
                    }

                }
                catch
                {
                    dt = null;
                    shortDateString = "0000/01/01";
                    snn = "and nyusya LIKE'%" + shortDateString + "' ";
                }
            }

            // if (s0 == null)
            if (s0.Length == 0)
            {
                snn1 = "and name LIKE '%" + s0 + "%' ";
            }
            else
            {
                snn1 = "and name LIKE '%" + s0 + "%' ";
            }
            //if (s1 == null)
            if (s1.Length == 0)
            {
                snn2 = "and name_kana LIKE '%" + s1 + "%' ";
            }
            else
            {
                snn2 = "and name_kana LIKE '%" + s1 + "%' ";
                // MessageBox.Show(s1.Length.ToString());
            }
            if (s7.Length == 0)
            {
                snn3 = "and mail LIKE '%" + s7 + "%' ";
            }
            else
            {
                snn3 = "and mail LIKE '%" + s7 + "%' ";
            }
            // MessageBox.Show(shortDateString);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";
            conn.Open();
            SqlCommand command = new SqlCommand();

            sqlText = "SELECT id, name, name_kana, bushomei, yakushokumei, sex, nyusya, mail FROM ";
            sqlText += "(SELECT ROW_NUMBER() OVER(ORDER BY id ) AS num, ";
            sqlText += "id, name, name_kana, bushomei, yakushokumei, sex, nyusya, mail FROM tbl_meibo ";
            sqlText += "LEFT OUTER JOIN tbl_busho ON tbl_meibo.busho_no = tbl_busho.busho_no ";
            sqlText += "LEFT OUTER JOIN tbl_yakushoku ON tbl_meibo.yakushoku_no = tbl_yakushoku.yakushoku_no ";
            sqlText += "LEFT OUTER JOIN tbl_sex ON tbl_meibo.sex_no = tbl_sex.sex_no ";
            sqlText += "WHERE flag_no = 0 ";

            sqlText += "and id LIKE '%" + s + "%' ";
            sqlText += snn1;
            sqlText += snn2;
            sqlText += "and bushomei LIKE '%" + s2 + "%' ";
            sqlText += "and yakushokumei LIKE '%" + s3 + "%' ";
            sqlText += "and sex LIKE '%" + s4 + "%' ";

            sqlText += snn;

            sqlText += snn3;

            sqlText += ") AS motodata WHERE num between " + (1 + (j * 10)) + "and " + (10 + (j * 10)) + ";";

            label1.Text = sqlText;

            string sqlText2;
            sqlText2 = "SELECT MAX(num) FROM ";
            sqlText2 += "(SELECT ROW_NUMBER() OVER(ORDER BY id ) AS num, ";
            sqlText2 += "id, name, name_kana, bushomei, yakushokumei, sex, nyusya, mail FROM tbl_meibo ";
            sqlText2 += "LEFT OUTER JOIN tbl_busho ON tbl_meibo.busho_no = tbl_busho.busho_no ";
            sqlText2 += "LEFT OUTER JOIN tbl_yakushoku ON tbl_meibo.yakushoku_no = tbl_yakushoku.yakushoku_no ";
            sqlText2 += "LEFT OUTER JOIN tbl_sex ON tbl_meibo.sex_no = tbl_sex.sex_no ";
            sqlText2 += "WHERE flag_no = 0 ";

            sqlText2 += "and id LIKE '%" + s + "%' ";

            sqlText2 += snn1;
            sqlText2 += snn2;
            sqlText2 += "and bushomei LIKE '%" + s2 + "%' ";
            sqlText2 += "and yakushokumei LIKE '%" + s3 + "%' ";
            sqlText2 += "and sex LIKE '%" + s4 + "%' ";

            sqlText2 += snn;

            sqlText2 += snn3;

            sqlText2 += ") AS motodata";
            command.CommandText = sqlText2;
            command.Connection = conn;
            object o = command.ExecuteScalar();
            try
            {
                count = int.Parse(o.ToString());
            }
            catch
            {
                count = 0;
            }

            // データベースアダプタオブジェクトを作る
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlText, conn);
            // datasetする
            DataSet ds = new DataSet();
            //dsにtbl_meiboのデータを流し込む
            dataadapter.Fill(ds, "tbl_meibo");
            // closeする
            conn.Close();
            MessageBox.Show(count.ToString());
            i0 = 0;
            s0 = "";
            s1 = "";
            s7 = "";
            j = 0;
            return ds;
        }
        private DataSet maetugidata(int? i0, string s0, string s1, string s2, string s3, string s4, DateTime? dt, string s6, string s7, int j)   //「前へ」「次へ」ボタンクリック時のDB用メソッド
        {


            string sqlText;
            string s;
            // DataGrid dg = new DataGrid();
            sid = txtid.Text;
            if (txtid.Text == "")
            {
                k = null;
                s = null;
            }
            else
            {
                try
                {
                    k = int.Parse(sid);
                    s = sid;
                }
                catch
                {
                    k = 11111;
                    s = "11111";
                }
            }
            this.SendDataC = k;
            i0 = k;

            String shortDateString;
            s5 = txtEnterday.Text;
            s5a = s5.Substring(0, 4);
            s5b = s5.Substring(5, 2);
            s5c = s5.Substring(8, 2);
            string snn;
            string snn1;
            string snn2;
            string snn3;
            try
            {
                dt = new DateTime(int.Parse(s5a), int.Parse(s5b), int.Parse(s5c));


                shortDateString = dt.Value.ToShortDateString();
                snn = "and nyusya ='" + shortDateString + "' ";
                if (s6 == "同一")
                {
                    snn = "and nyusya ='" + shortDateString + "' ";
                }
                else if (s6 == "前")
                {
                    snn = "and nyusya <'" + shortDateString + "' ";
                }
                else if (s6 == "後")
                {
                    snn = "and nyusya >'" + shortDateString + "' ";
                }
                else
                {
                    snn = "and nyusya ='" + shortDateString + "' ";
                }
            }
            catch
            {
                dt = null;
                shortDateString = "";
                snn = "and nyusya LIKE'%" + shortDateString + "' ";
            }
            if (s0.Length == 0)
            {
                snn1 = "and name LIKE '%" + s0 + "%' ";
            }
            else
            {
                snn1 = "and name LIKE '%" + s0 + "%' ";
            }
            if (s1.Length == 0)
            {
                snn2 = "and name_kana LIKE '%" + s1 + "%' ";
            }
            else
            {
                snn2 = "and name_kana LIKE '%" + s1 + "%' ";

            }
            if (s7.Length == 0)
            {
                snn3 = "and mail LIKE '%" + s7 + "%' ";
            }
            else
            {
                snn3 = "and mail LIKE '%" + s7 + "%' ";
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";
            conn.Open();
            SqlCommand command = new SqlCommand();

            sqlText = "SELECT id, name, name_kana, bushomei, yakushokumei, sex, nyusya, mail FROM ";
            sqlText += "(SELECT ROW_NUMBER() OVER(ORDER BY id ) AS num, ";
            sqlText += "id, name, name_kana, bushomei, yakushokumei, sex, nyusya, mail FROM tbl_meibo ";
            sqlText += "LEFT OUTER JOIN tbl_busho ON tbl_meibo.busho_no = tbl_busho.busho_no ";
            sqlText += "LEFT OUTER JOIN tbl_yakushoku ON tbl_meibo.yakushoku_no = tbl_yakushoku.yakushoku_no ";
            sqlText += "LEFT OUTER JOIN tbl_sex ON tbl_meibo.sex_no = tbl_sex.sex_no ";
            sqlText += "WHERE flag_no = 0 ";

            sqlText += "and id LIKE '%" + s + "%' ";

            sqlText += snn1;
            sqlText += snn2;
            sqlText += "and bushomei LIKE '%" + s2 + "%' ";
            sqlText += "and yakushokumei LIKE '%" + s3 + "%' ";
            sqlText += "and sex LIKE '%" + s4 + "%' ";

            sqlText += snn;

            sqlText += snn3;

            sqlText += ") AS motodata WHERE num between " + (1 + (j * 10)) + " and " + (10 + (j * 10)) + ";";

            label1.Text = sqlText;
            //sqlText2
            command.Connection = conn;


            // データベースアダプタオブジェクトを作る
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlText, conn);
            // datasetする
            DataSet ds = new DataSet();
            //dsにtbl_meiboのデータを流し込む
            dataadapter.Fill(ds, "tbl_meibo");
            // closeする
            conn.Close();
            i0 = 0;
            s0 = "";
            s1 = "";
            s7 = "";
            j = 0;
            return ds;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int SendDataE
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }

        private void cmbSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbYaku_TextUpdate(object sender, EventArgs e)
        {
            s3 = cmbYaku.Text;
        }

        private void cmbBusho_TextUpdate(object sender, EventArgs e)
        {
            s2 = cmbBusho.Text;
        }
        private void cmbEnter_TextUpdate(object sender, EventArgs e)
        {
            s6 = cmbEnter.Text;
        }

        private void cmbSex_TextUpdate(object sender, EventArgs e)
        {
            s4 = cmbSex.Text;
        }
    }
}

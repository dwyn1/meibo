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

namespace CompanyDirectory
{
    public partial class IdPwForm : Form
    {
        public string s11;
        string s2;
        public int i;
        public IdPwForm()
        {
            InitializeComponent();
        }
        int j = 0;
//        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
 //       {
 //       }
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            s11 = txtid.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s2 = textBox2.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            ID id = new ID();
            CheckID checkid = new CheckID();
            chooseForm cf = new chooseForm();
//            s11 = txtid.Text;//動作のため一時避難
            if (id.show(s11) == 0 & pass.show(s2) == 0)    //片側の結果で弾くのではなく両側で判定してほしいので&は一つ
            {
                try 
                {
                    i = int.Parse(s11);
                }
                catch(FormatException)
                {
                    label1.ForeColor = System.Drawing.Color.Red;
                    label1.Text = "入力形式にミスがあります";
                }
                LoginID db1 = new LoginID();
                if (db1.show(i,s2) == 1)
                {
                    label1.ForeColor = System.Drawing.Color.Red;
                    label1.Text = "入力形式にミスがあります";

                    if (db1.show(i, s2) == 0 && i!= 4)
                    {
                        cf.Show();     //後で消そう
                        checkid.show(i);
                    }
                    else if (db1.show(i, s2) == 0 && i == 4) //管理者IDを一時的に4とした。畑中さんと話し合う。
                    {
                        managelistForm mlf = new managelistForm();
                        mlf.Show();
                    }
                    else
                    {
                        txtid.Text = "";
                        textBox2.Text = "";
                    }
                    j++;
                }
                else if(db1.show(i, s2) == 0 && i!= 4)
                {
                    cf.Show();                           //後で消そう
                    checkid.show(i);
                }
                else if (db1.show(i, s2) == 0 && i == 4)
                {
                    managelistForm mlf = new managelistForm();
                    mlf.Show();
                }
            }
            else
            {
                txtid.Text = "";
                textBox2.Text = "";
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "入力形式にミスがあります";
            }
            if (j >=4)
            {
                MessageBox.Show("ALSOKに通報しました");
                this.Close();
            }
            DataSet ds = new DataSet();
            takePVForm tpv = new takePVForm(i);
            //personalForm pf = new personalForm(i);
            cf.SendData = i;
        }

    }
}
    class Pass                             //PASSが半角英数以外８文字以外なら1を返す。PASS変更でも使用。
    {
        public int show(string text2)
        {
            int x;
            System.Text.RegularExpressions.Regex r =
            new System.Text.RegularExpressions.Regex(@"[\u0030-\u0039,\u0041-\u005A,\u0061-\u007A]");
            try
            {
                if (r.IsMatch(text2) == true && text2.Length == 8)
                {
                    x = 0;
                }
                else
                {
                    x = 1;
                }
            }
            catch (ArgumentNullException)
            {
                x = 1;
            }
            
            return x;
        }
    }
    class LoginID
    {
        /****************************************************
        * IDとPwが正しいかor正しくないか判定するメソッド
        * 引数：string id, string pw
        * 戻り値：正しい場合＞0, 正しくない場合＞1
        * 引数のstring pwをそのまま持っていって下さい
        * ************************************************* */
        public int show(int id, string pw)
        {
            // データベース接続オブジェクトを作る
            SqlConnection conn = new SqlConnection(connectionString);
            conn.ConnectionString = @"Data Source=MER1103052\SQLEXPRESS;Initial Catalog=master;User Id=sa;Password=dowellsql;";

            SqlCommand cmd = new SqlCommand();

            conn.Open();
            // SQL文を準備する
            // flag_no = 0：在籍, flag_no = 1：離籍
            //cmd.CommandText = "SELECT COUNT(*) FROM tbl_meibo WHERE id =(SELECT id FROM tbl_meibo WHERE pw = (select pw from tbl_meibo Where flag_no = 0 and id =" + id + "and pw =" + pw + "))";
            cmd.CommandText = "SELECT COUNT(*) FROM tbl_meibo WHERE  flag_no = 0 and id =" + id + " and pw =" + pw;


            cmd.Connection = conn;
            int i = (int)cmd.ExecuteScalar();
            conn.Close();

            // ID・Pwが正しい場合
            if (i == 1)
            {
                return 0;
            }

            // ID・Pwが正しくない場合
            else
            {
                return 1;
            }
        }
        public string connectionString { get; set; }
    }
    class ID                      //IDが半角数字以外３文字以外ならエラーを返す。
    {
        public int show(string text1)
        {
            int x;
            System.Text.RegularExpressions.Regex r =
            new System.Text.RegularExpressions.Regex(@"[\u0030-\u0039]");
            try
            {
                if (r.IsMatch(text1) == true && text1.Length == 1||text1.Length==2||text1.Length==3)
                {
                    x = 0;
                }
                else
                {
                    x = 1;
                }
            }
            catch (ArgumentNullException)
            {
                x = 1;
            }
            
            return x;

        }
    }
    class CheckID
    {
        public void show(int i)
        {
            if (i == 0)
            {
                //～.Show();管理画面を開く   　　　あとで消去の可能性あり。
            }
            else if (i == 1)
            {
                //～.Show();役員用選択画面を開く
            }
            else if (i==2)
            {
                //～.Show();社員用選択画面を開く
            }
        }
    }


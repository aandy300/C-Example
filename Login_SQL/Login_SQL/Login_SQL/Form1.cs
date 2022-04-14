using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Login_SQL
{
    public partial class Form1 : Form
    {
        string DBName = "localhost";
        string Username = "root";
        string Password = "root";
        
        public string myConnection = "datasource=localhost:username=root:paswword=root";

        public Form1()
        {
            InitializeComponent();
        }


        private void Account_text1(object sender, EventArgs e)
        {

        }

        private void Password_text2(object sender, EventArgs e)
        {

        }

        private void textBox1_Account_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_button_Click(object sender, EventArgs e)
        {



            #region TEST1
            //using var con = new MySqlConnection(cs);
            //"datasource=localhost:username=root:paswword=root"
            //"datasource= localhost;port=3306;username=root;password=root";
            //string cs = @"server=localhost;userid=root;password=root;database=unity";
            //string cs = @"Server = localhost; Database = unity; Uid = root; Pwd = root";
            //MySqlConnection connection = new MySqlConnection(cs);
            //try { if (connection.State != ConnectionState.Open) 
            //{ connection.Open(); } MessageBox.Show("true"); } 
            //catch { MessageBox.Show("false"); }
            #endregion

            #region TEST2
            //bool result = false;
            //string conn = "database=localhost;dataSource=unity;port=3306;userId=root;password=root";
            //string connStr = "server=localhost;user=root;database=mysql;port=3306;password=root";
            //MySqlConnection connection = new MySqlConnection(connStr);

            //MySqlConnection conn = new MySqlConnection(connStr);
            //try
            //{
            //    Console.WriteLine("Connecting to MySQL...");
            //    conn.Open();

            //    //SQL Query to execute
            //    //selecting only first 10 rows for demo
            //    string sql = "select * from sakila.actor limit 0,10;";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    MySqlDataReader rdr = cmd.ExecuteReader();

            //    //read the data
            //    while (rdr.Read())
            //    {
            //        Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
            //    }
            //    rdr.Close();
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.ToString());
            //    //MessageBox.Show("fa");
            //}
            //conn.Open();
            //conn.Close();
            //Console.WriteLine("Connection Closed. Press any key to exit...");
            //Console.Read();
            //MessageBox.Show("fa");

            #endregion

            #region TEST3
            //MySqlConnection myConn = new MySqlConnection(myConnection);
            //MySqlCommand cmdDataBase = new MySqlCommand("*SELECT * FROM `users` where id='" + this.textBox_Account.Text + "'and Password='" + this.textBox_Password.Text + "';", myConn);
            //MySqlDataReader myReader;
            //myConn.Open();

            //myReader = cmdDataBase.ExecuteReader();
            //int count = 0;


            //while (myReader.Read()) {
            //    count = count + 1;                
            //}
            //if (count == 1) {
            //    MessageBox.Show("u are in");
            //}
            //else if (count > 1) {
            //    MessageBox.Show("No");
            //}
            //else {
            //    MessageBox.Show("ID OR PW 錯誤!");
            //}
            //myConn.Close();
            #endregion

            #region  test4
            //string dbHost = "資料庫位址";
            //string dbUser = "資料庫使用者名稱";
            //string dbPass = "資料庫使用者密碼";
            //string dbName = "資料庫名稱";

            //// 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci
            //string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            //MySqlConnection conn = new MySqlConnection(connStr);
            //// 連線到資料庫
            //try
            //{
            //    conn.Open();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    switch (ex.Number)
            //    {
            //        case 0:
            //            Console.WriteLine("無法連線到資料庫.");
            //            break;
            //        case 1045:
            //            Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
            //            break;
            //    }
            //}

            //// 進行select
            //string SQL = "select plain from yammer order by id desc limit 0,10 ";
            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand(SQL, conn);
            //    MySqlDataReader myData = cmd.ExecuteReader();

            //    if (!myData.HasRows)
            //    {
            //        // 如果沒有資料,顯示沒有資料的訊息
            //        Console.WriteLine("No data.");
            //    }
            //    else
            //    {
            //        // 讀取資料並且顯示出來
            //        while (myData.Read())
            //        {
            //            Console.WriteLine("Text={0}", myData.GetString(0));
            //        }
            //        myData.Close();
            //    }
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            //}
            #endregion

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

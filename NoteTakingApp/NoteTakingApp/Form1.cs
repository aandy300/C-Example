using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            //Columns = 列
            //追加列
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            
            //顯示資訊
            dataGridView1.DataSource = table;

            // 取消 Messages 的標題title
            dataGridView1.Columns["Messages"].Visible = false;
            // 更改 Title 標題 長度
            dataGridView1.Columns["Title"].Width = 230;
            //無效化 Sort 因 Sort會打亂 陣列順序導致讀取失敗
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bbtSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            //CurrentCell 取得或設定目前的現用儲存格
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                // 轉存 rows內容 目標 轉成string
                // title = 0  message = 1 欄位
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            //刪當前的
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

  
    }
}

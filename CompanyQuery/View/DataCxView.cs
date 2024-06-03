using CompanyQuery.View;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CompanyQuery
{
    public partial class DataCxView : Form
    {
        private string _querydata;
        // 保存选中行的数据
        private DataGridViewRow selectedRow;
        public DataCxView(string querydata)
        {
            InitializeComponent();
            _querydata = querydata;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 固定窗口大小，允许移动窗口
        }
        // 刷新 dataGridView 的方法
        public void Refresh()
        {
            MySqlDB mySql = new MySqlDB();
            dataGridView1.DataSource = null; // 清空原有数据源
            dataGridView1.DataSource = mySql.QueryData(_querydata); // 重新绑定数据源
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataCx_Load(object sender, EventArgs e)
        {
            MySqlDB mySql = new MySqlDB();

            dataGridView1.DataSource = mySql.QueryData(_querydata);
        }

        /// <summary>
        /// 详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // 获取所选行的数据
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                //string selectedData = selectedRow.Cells["CompanyName"].Value.ToString(); // 替换为实际的列名
                DataRowView dataRow = (DataRowView)selectedRow.DataBoundItem;

                // 创建第三个页面实例，并传递所选行的数据
                DetailedView detailed = new DetailedView(dataRow.Row);
                detailed.Show();
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddDataView add = new AddDataView(this);
            add.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //// 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 如果有选中的行，将删除按钮启用
                Deletebutton.Enabled = true;
                Updatabutton.Enabled = true;
                // 保存选中行的数据
                selectedRow = dataGridView1.SelectedRows[0];
            }
            else
            {
                // 如果没有选中的行，将删除按钮禁用
                Deletebutton.Enabled = false;
                Updatabutton.Enabled = false;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            // 确认用户是否要删除选定的行
            DialogResult result = MessageBox.Show("确定要删除选定的行吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MySqlDB mySql = new MySqlDB();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有发现选择行！");
                return;
            }
            if (result == DialogResult.Yes)
            {
                // 循环遍历所选行，并从数据库中删除对应的数据
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // 获取行的 ID 或主键值，假设 ID 存储在第一列
                    int id = Convert.ToInt32(row.Cells[0].Value); // 假设第一列是 ID 列

                    // 调用方法从数据库中删除数据
                    mySql.DeleteData(id);

                    // 从 DataGridView 中删除行
                    dataGridView1.Rows.Remove(row);
                }
            }
            // 提示删除成功
            MessageBox.Show("所选行已成功删除！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            //{
            //    // 获取所选行的数据
            //    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            //    //string selectedData = selectedRow.Cells["CompanyName"].Value.ToString(); // 替换为实际的列名
             DataRowView dataRow = (DataRowView)selectedRow.DataBoundItem;

            //    // 创建第三个页面实例，并传递所选行的数据
                UpdateData detailed = new UpdateData(dataRow.Row,this);
                detailed.Show();
            //}
        }
    }
}

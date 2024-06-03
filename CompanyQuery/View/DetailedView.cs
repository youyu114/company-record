using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyQuery
{
    public partial class DetailedView : Form
    {
        private DataRow _selectedRow;
        public DetailedView(DataRow selectedRow)
        {
            InitializeComponent();
            _selectedRow = selectedRow;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 固定窗口大小，允许移动窗口
        }
        private void OpenWebPage(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开浏览器：" + ex.Message);
            }
        }
        private void DetailedView_Load(object sender, EventArgs e)
        {
            CompanyNameLabel.Text = _selectedRow["CompanyName"].ToString();
            RegionLabel.Text = _selectedRow["Region"].ToString();
            InterviewLabel.Text = _selectedRow["Interview"].ToString() == "true" ? "是" : "否";
            RemarksTextBox.Text = _selectedRow["Remarks"].ToString();
        }

        private void CompanyNameLabel_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://www.baidu.com/s?wd=" + _selectedRow["CompanyName"].ToString());
        }



        private void CompanyNameLabel_MouseEnter_1(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Blue;
            toolTip1.SetToolTip(label, "查询公司其他信息");
        }

        private void CompanyNameLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Black;
            toolTip1.SetToolTip(label, ""); // 清除提示信息
        }
    }
}

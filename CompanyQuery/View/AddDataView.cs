using CompanyQuery.Mods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyQuery.View
{
    public partial class AddDataView : Form
    {
        private DataCxView _dataCx;
        public AddDataView(DataCxView dataCx)
        {
            InitializeComponent();
            _dataCx = dataCx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Interview = false;
            if (radioButton1.Checked) Interview = true;
            CompanyData data = new CompanyData();
            data.CompanyName = CompanyNameBox.Text;
            data.Province = ProvinceBox.Text;
            data.City = CityBox.Text;
            data.Province = ProvinceBox.Text;
            data.Region = RegionBox.Text;
            data.Remarks = RemarksBox.Text;
            data.Interview = Interview;
            // 构建 SQL INSERT INTO 命令
            //string insertCommand = "INSERT INTO company (CompanyName,Province,City,Region,Remarks,Interview) VALUES (@CompanyName,@Province,@City,@Region,@Remarks,@Interview)";
            //string sql = insertCommand.Replace("@CompanyName",CompanyNameBox.Text)
            //                          .Replace("@Province", ProvinceBox.Text)
            //                          .Replace("@City", CityBox.Text)
            //                          .Replace("@Province", ProvinceBox.Text)
            //                          .Replace("@Region", RegionBox.Text)
            //                          .Replace("@Remarks", RemarksBox.Text)
            //                          .Replace("@Interview", Interview.ToString())
            //                          ;
            MySqlDB mySql = new MySqlDB();
            var result = mySql.AddData(data);
            if (result != 0)
            {
                CompanyNameBox.Text = "";
                ProvinceBox.Text = "";
                CityBox.Text = "";
                RegionBox.Text = "";
                RemarksBox.Text = "";
                // Interview.Text = "";
            }
            _dataCx.Refresh();
        }
    }
}

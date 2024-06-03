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

namespace CompanyQuery
{
    public partial class UpdateData : Form
    {
        private DataRow _selectedRow;
        private DataCxView _dataCx;
        public UpdateData(DataRow selectedRow, DataCxView dataCx)
        {
            InitializeComponent();
            _selectedRow = selectedRow;
            _dataCx = dataCx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Interview = false;
            if (radioButton1.Checked) Interview = true;
            CompanyData data = new CompanyData();
            data.ID = int.Parse(_selectedRow["ID"].ToString());
            data.CompanyName = CompanyNameBox.Text;
            data.Province = ProvinceBox.Text;
            data.City = CityBox.Text;
            data.Province = ProvinceBox.Text;
            data.Region = RegionBox.Text;
            data.Remarks = RemarksBox.Text;
            data.Interview = Interview;

            MySqlDB mySql = new MySqlDB();
            mySql.UpdataData(data);
            _dataCx.Refresh();
        }

        private void UpdateData_Load(object sender, EventArgs e)
        {
            CompanyNameBox.Text = _selectedRow["CompanyName"].ToString();
            ProvinceBox.Text = _selectedRow["Province"].ToString();
            CityBox.Text = _selectedRow["City"].ToString();
            RegionBox.Text = _selectedRow["Region"].ToString();
            RemarksBox.Text = _selectedRow["Remarks"].ToString();
            if (_selectedRow["Interview"].ToString() == "true") {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void ProvinceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

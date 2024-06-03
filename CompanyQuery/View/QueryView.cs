using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CompanyQuery
{
    public partial class QueryView : Form
    {
        public QueryView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 固定窗口大小，允许移动窗口
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataCxView dataCx = new DataCxView(CompanyBox.Text);
            dataCx.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
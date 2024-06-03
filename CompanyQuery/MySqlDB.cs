using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using CompanyQuery.Mods;
using System.Data;

namespace CompanyQuery
{
    public class MySqlDB
    {
        string connectionString = "server=localhost;user id=root;password=123456;database=program";
      
        public DataTable QueryData(string Company)
        {
            string queryString = "SELECT * FROM company WHERE CompanyName LIKE @CompanyName";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@CompanyName", "%" + Company + "%");

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
        public int AddData(CompanyData data)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertCommand = "INSERT INTO company (CompanyName, Province, City, Region, Remarks, Interview) VALUES (@CompanyName, @Province, @City, @Region, @Remarks, @Interview)";
                
                    using (MySqlCommand command = new MySqlCommand(insertCommand, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@CompanyName", data.CompanyName);
                        command.Parameters.AddWithValue("@Province", data.Province);
                        command.Parameters.AddWithValue("@City", data.City);
                        command.Parameters.AddWithValue("@Region", data.Region);
                        command.Parameters.AddWithValue("@Remarks", data.Remarks);
                        command.Parameters.AddWithValue("@Interview", data.Interview ? 1 : 2);
                        // 执行 SQL 命令
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("数据已成功添加到数据库！");
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("未能添加数据到数据库。");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
                return 0;
            }

        }
        public int DeleteData(int id)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // 创建 SQL 命令，假设表名为 company，ID 列名为 id
                    string deleteCommand = "DELETE FROM company WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(deleteCommand, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@id", id);
                        // 执行 SQL 命令
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("数据已成功删除！");
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("未能删除数据。");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
                return 0;
            }
        }

        public int UpdataData(CompanyData data)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertCommand = "UPDATE company SET CompanyName=@CompanyName, Province=@Province, City=@City, Region=@Region, Remarks=@Remarks, Interview=@Interview WHERE ID=@ID";

                    using (MySqlCommand command = new MySqlCommand(insertCommand, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@ID", data.ID);
                        command.Parameters.AddWithValue("@CompanyName", data.CompanyName);
                        command.Parameters.AddWithValue("@Province", data.Province);
                        command.Parameters.AddWithValue("@City", data.City);
                        command.Parameters.AddWithValue("@Region", data.Region);
                        command.Parameters.AddWithValue("@Remarks", data.Remarks);
                        command.Parameters.AddWithValue("@Interview", data.Interview ? 1 : 2);
                        // 执行 SQL 命令
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("数据已成功修改！");
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("未能修改数据");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
                return 0;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GiaoDien_qlpks
{
    public partial class danhsachkhachhang : Form
    {
        public danhsachkhachhang()
        {
            InitializeComponent();
            loadkhachhanglist();
        }
        void loadkhachhanglist()
        {
            try
            {
                string connectionSTR = @"Data Source=LAPTOP-JKMABAVK\TESTSQL;Initial Catalog=QUANLYPHONGKHACHSAN;Integrated Security=True;TrustServerCertificate=true;";
                SqlConnection connection = new SqlConnection(connectionSTR);
                string query = "SELECT * FROM [dbo].[Table.KHACHHANG]";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

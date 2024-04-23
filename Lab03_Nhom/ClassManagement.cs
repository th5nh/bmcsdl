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

namespace Lab03_Nhom
{
    public partial class ClassManagement : Form
    {
        public string username { get; set; }
        public string password { get; set; }

        SqlConnection conn = new SqlConnection(@"Data Source=KIMHUYNH;Initial Catalog=QLSVNhom;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public ClassManagement()
        {
            InitializeComponent();
        }


        private void ClassManagement_Load(object sender, EventArgs e)
        {
            //label1.Text = username + " " + password;
            DisplayClassData();

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);


        }

        public void DisplayClassData()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM LOP ", conn);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ExitClassMana_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy giá trị của ô cell đầu tiên của dòng hiện tại
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem người dùng đã chọn một ô hợp lệ chưa
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string value = selectedRow.Cells[0].Value.ToString(); // Lấy giá trị của ô cell đầu tiên của dòng hiện tại (cột 0)

                txt_ClassId.Text = value;
            }
        }

        private void bnt_ViewStDetail_Click(object sender, EventArgs e)
        {
            if(txt_ClassId.Text.Length != 0) 
            {

                // chuyển qua màn hình quản lý sinh viên

                StudentDetails studentDetails = new StudentDetails();
                studentDetails.username = username;
                studentDetails.password = password;
                studentDetails.classID = txt_ClassId.Text;
                studentDetails.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã lớp học!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

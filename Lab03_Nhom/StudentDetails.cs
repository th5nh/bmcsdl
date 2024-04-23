using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Nhom
{


    public partial class StudentDetails : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string classID { get; set; }

        public string studentID;

        SqlConnection conn = new SqlConnection(@"Data Source=KIMHUYNH;Initial Catalog=QLSVNhom;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public StudentDetails()
        {
            InitializeComponent();
        }


        private void StudentDetails_Load(object sender, EventArgs e)
        {
            DisplayClassData();

            dtGriv_SinhvienDetail.CellClick += new DataGridViewCellEventHandler(dtGriv_SinhvienDetail_CellContentClick);
        }
        public void DisplayClassData()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT MASV,HOTEN,NGAYSINH,DIACHI,MALOP,TENDN FROM SINHVIEN WHERE MALOP = '" + classID + "'", conn);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtGriv_SinhvienDetail.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bnt_return_Click(object sender, EventArgs e)
        {

            // chuyển qua màn hình quản lý lớp học

            ClassManagement classManagement = new ClassManagement();
            classManagement.username = username;
            classManagement.password = password;
            classManagement.Show();
            this.Hide();
        }

        private void dtGriv_SinhvienDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy giá trị của ô cell đầu tiên của dòng hiện tại
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem người dùng đã chọn một ô hợp lệ chưa
            {
                DataGridViewRow selectedRow = dtGriv_SinhvienDetail.Rows[e.RowIndex];

                // gán studentID là dòng đang chọn
                studentID = selectedRow.Cells[0].Value.ToString();

                string fullname = selectedRow.Cells[1].Value.ToString(); // Lấy giá trị của họ tên

                string born = selectedRow.Cells[2].Value.ToString(); // Lấy giá trị của ngày sinh

                string address = selectedRow.Cells[3].Value.ToString(); // Lấy giá trị của địa chỉ

                string comp = selectedRow.Cells[5].Value.ToString(); // Lấy giá trị của tên doanh nghiệp

                txt_fullname.Text = fullname;
                txt_born.Text = born;
                txt_address.Text = address;
                txt_comp.Text = comp;



            }
        }

        private void bnt_change_Click(object sender, EventArgs e)
        {
            if (studentID.Length > 0)
            {
                // Kiểm tra sinh viên có thuộc lớp quản lý hay không
                conn.Open();
                SqlCommand checkClassCmd = new SqlCommand("SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @masv AND MALOP = (SELECT MALOP FROM LOP WHERE MALOP =@classID AND MANV = (SELECT MANV FROM NHANVIEN WHERE TENDN = @tendn) )", conn);
                checkClassCmd.Parameters.AddWithValue("@masv", studentID);
                checkClassCmd.Parameters.AddWithValue("@classID", classID);
                checkClassCmd.Parameters.AddWithValue("@tendn", username);
                int count = (int)checkClassCmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    DialogResult res;
                    res = MessageBox.Show("Do you want to change this student's information", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd = new SqlCommand("UPDATE SINHVIEN SET HOTEN = @hoten, NGAYSINH = @ngaysinh, DIACHI = @diachi, TENDN = @tendn WHERE MASV = @masv", conn);
                        cmd.Parameters.AddWithValue("@hoten", txt_fullname.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", txt_born.Text);
                        cmd.Parameters.AddWithValue("@diachi", txt_address.Text);
                        cmd.Parameters.AddWithValue("@tendn", txt_comp.Text);
                        cmd.Parameters.AddWithValue("@masv", studentID);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        // Xóa dữ liệu trong DataTable
                        dt.Clear();

                        // Làm mới DataGridView
                        DisplayClassData();
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ được chỉnh sửa thông tin sinh viên thuộc lớp quản lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bnt_InsertMark_Click(object sender, EventArgs e)
        {
            if (studentID != null )
            {


                // Kiểm tra sinh viên có thuộc lớp quản lý hay không
                conn.Open();
                SqlCommand checkClassCmd = new SqlCommand("SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @masv AND MALOP = (SELECT MALOP FROM LOP WHERE MALOP =@classID AND  MANV = (SELECT MANV FROM NHANVIEN WHERE TENDN = @tendn) )", conn);
                checkClassCmd.Parameters.AddWithValue("@masv", studentID);
                checkClassCmd.Parameters.AddWithValue("@classID", classID);
                checkClassCmd.Parameters.AddWithValue("@tendn", username);
                int count = (int)checkClassCmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    // chuyển qua màn hình nhập điểm

                    InsertMark insertMark = new InsertMark();
                    insertMark.username = username;
                    insertMark.password = password;
                    insertMark.masv = studentID;
                    insertMark.classID = classID;
                    insertMark.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Chỉ được nhập điểm của sinh viên thuộc lớp quản lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

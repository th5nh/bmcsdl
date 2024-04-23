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
    public partial class InsertMark : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string masv { get; set; }
        public string classID { get; set; }



        SqlConnection conn = new SqlConnection(@"Data Source=KIMHUYNH;Initial Catalog=QLSVNhom;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public InsertMark()
        {
            InitializeComponent();



        }


        private void InsertMark_Load(object sender, EventArgs e)
        {


            DisplayClassData();
            dtGriv_mark.CellClick += new DataGridViewCellEventHandler(dtGriv_mark_CellContentClick);


        }

        public void DisplayClassData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("EXEC SP_SEL_BANGDIEM @mk,@masv,@tendn", conn);
                cmd.Parameters.AddWithValue("@mk", password);
                cmd.Parameters.AddWithValue("@masv", masv);
                cmd.Parameters.AddWithValue("@tendn", username);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtGriv_mark.DataSource = dt;
                conn.Close();

                txt_StudentId.Text = masv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtGriv_mark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị của ô cell đầu tiên của dòng hiện tại
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem người dùng đã chọn một ô hợp lệ chưa
            {
                DataGridViewRow selectedRow = dtGriv_mark.Rows[e.RowIndex];

                string hp = selectedRow.Cells[1].Value.ToString();

                txt_HP.Text = hp;


            }
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
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

        private void bnt_Return_Click(object sender, EventArgs e)
        {
            // chuyển qua màn hình quản lý sinh viên

            StudentDetails studentDetails = new StudentDetails();
            studentDetails.username = username;
            studentDetails.password = password;
            studentDetails.classID = classID;
            studentDetails.Show();
            this.Hide();

        }

        private void bnt_InsertMark_Click(object sender, EventArgs e)
        {
            if (txt_HP.Text != null && txt_mark.Text != null)
            {
                try
                {
                    DialogResult res;

                    res = MessageBox.Show("Do you want to change add mark to this's student", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        conn.Open();
                        //ENCRYPTBYASYMKEY(AsymKey_Id(QUOTENAME(SELECT PUBKEY FROM NHANVIEN WHERE MANV = 'username')), '@diem')
                        cmd = new SqlCommand("EXEC SP_INS_PUBLIC_DIEMTHI @masv,@tendn,@mahp,@diem", conn);
                        
                        cmd.Parameters.AddWithValue("@masv", masv);
                        cmd.Parameters.AddWithValue("@tendn", username);
                        cmd.Parameters.AddWithValue("@mahp", txt_HP.Text);
                        cmd.Parameters.AddWithValue("@diem", txt_mark.Text);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        // Xóa dữ liệu trong DataTable
                        dt.Clear();

                        // Làm mới DataGridView
                        DisplayClassData();
                        txt_mark.Text = null;   

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã học phần và điểm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

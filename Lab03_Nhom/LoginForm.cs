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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=KIMHUYNH;Initial Catalog=QLSVNhom;Integrated Security=True;");
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void bnt_SignIn_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txt_Username.Text;
            password = txt_Password.Text;

            try
            {
                String querry = "SELECT * FROM NHANVIEN WHERE TENDN = '" + username + "' AND MATKHAU = HASHBYTES('SHA1','" + password + "')";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    password = txt_Password.Text;

                    MessageBox.Show("Đăng nhập thành công!");

                    // chuyển qua màn hình quản lý lớp học

                    ClassManagement classManagement = new ClassManagement();
                    classManagement.username = username;
                    classManagement.password = password;
                    classManagement.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Username.Clear();
                    txt_Password.Clear();

                    // to focus username
                    txt_Username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
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
    }
}

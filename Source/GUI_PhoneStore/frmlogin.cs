using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PhoneStore;
using DTO_PhoneStore;
using UTIL_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        BusNhanVien busNhanVien = new BusNhanVien();

        private void frmlogin_Load(object sender, EventArgs e)
        {
            // Thêm bất kỳ logic khởi tạo nào nếu cần
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Khi checkbox được tick, tắt PasswordChar để hiển thị mật khẩu
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Corrected instantiation of BusNhanVien and method call  
            NhanVien nv = busNhanVien.DangNhap(username, password);

            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đang tạm khóa, vui lòng liên hệ QTV!!!");
                    return;
                }
                AuthUtil.user = nv;

                mainform main = new mainform();
                main.Show();
                this.Hide();
            }
        }
    }
}
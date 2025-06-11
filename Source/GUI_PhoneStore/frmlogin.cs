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

        private void chkhienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkhienthimatkhau.Checked;
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
                    MessageBox.Show(this, "Tài khoản đang tạm khóa, vui lòng viên hệ QTV!!!");
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


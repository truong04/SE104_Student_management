using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GiaoDien;
namespace WindowsFormsApp2
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Matkhau1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Matkhau1.UseSystemPasswordChar = false;
            else
                Matkhau1.UseSystemPasswordChar = true;
        }

        private void Btn_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2.Checked)
                Matkhau2.UseSystemPasswordChar = false;
            else
                Matkhau2.UseSystemPasswordChar = true;
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkemail(string ac)
        {
            return Regex.IsMatch(ac, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
             
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        modify modify = new modify();
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string tentk = textBox_tentk.Text;
            string email = textbox_email.Text;
            string matkhau = Matkhau1.Text;
            string matkhauxacnhan = Matkhau2.Text;
            if(!checkAccount(tentk)) 
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản với 6-24 ký tự chữ và số");
                return;
            };
            if(!checkAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu với 6-24 ký tự chữ và số");
                return;
            };
            if(matkhauxacnhan!= matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu");
                return;
            };
            if(!checkemail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng dạng email");
                return;
            }
            if(modify.Taikhoans("Select * from Accounts where Email = '" + email+"' ").Count !=0)
            {
                MessageBox.Show("Email đã đuọc đăng kí vui lòng nhập Email khác");
                return;
            }
            if (modify.Taikhoans("Select * from Accounts where username = '" + tentk + "' ").Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí vui long nhập tên tài khoản khác");
                return;
            }
            try
            {
                string query = "Insert into Accounts values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    this.Hide();
                    dang_nhap f = new dang_nhap();
                    f.ShowDialog();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí vui lòng nhập tên tài khản khác");
            }
        }
    }
}

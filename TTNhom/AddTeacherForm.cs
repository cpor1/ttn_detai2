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

namespace TTNhom
{
    public partial class AddTeacherForm : Form
    {
        string ten, ngaySinh, diaChi, phone, email, mon, luong;
        int gioiTinh;
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        List<string> list = new List<string>();
        public AddTeacherForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ten = txtTen.Text.Trim();
            ngaySinh = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            diaChi = txtDiaChi.Text;
            phone = txtSDT.Text;
            email = txtEmail.Text;
            mon = txtMonHoc.Text;
            luong = txtLuong.Text;
            if (radioButtonNam.Checked == true)
            {
                gioiTinh = 1;
            }
            else
            {
                gioiTinh = 0;
            }
            try
            {
                if (ten.Equals("") || ngaySinh.Equals("") || diaChi.Equals("") || phone.Equals("") || email.Equals("") || gioiTinh.Equals("") || mon.Equals("") || luong.Equals(""))
                {
                    MessageBox.Show("Thieu Thong tin");

                }
                else
                {
                    conn.Open();
                    table = new DataTable();
                    string queryInsert = "INSERT dbo.teachers(teacher_name, sex, dob, address, phone_number, email, major, salary) VALUES" +
                        "(N'"+ten+"', '"+gioiTinh+"', '"+ngaySinh+"', N'"+diaChi+"', N'"+phone+"', N'"+email+"', N'"+mon+"', '"+luong+"')";
                    cmd = new SqlCommand(queryInsert, conn);
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Them Giao Vien Thanh Cong");
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai Định Dạng Ngày Tháng");
            }
        }
    }
}

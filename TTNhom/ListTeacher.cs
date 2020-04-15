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
    public partial class ListTeacher: Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        string ten, ngaySinh, diaChi, phone, email, monHoc, luong, gioiTinh;

        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            ten = txtTen.Text.Trim();
            ngaySinh = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            diaChi = txtDiaChi.Text;
            phone = txtSDT.Text;
            email = txtEmail.Text;
            monHoc = txtMonHoc.Text;
            luong = txtLuong.Text;
            if (radioButtonNam.Checked == true)
            {
                gioiTinh = "1";
            }
            else
            {
                gioiTinh = "0";
            }
            try
            {
                if (ten.Equals("") || ngaySinh.Equals("") || diaChi.Equals("") || phone.Equals("") || email.Equals("") || gioiTinh.Equals("") || monHoc.Equals("") || luong.Equals(""))
                {
                    MessageBox.Show("Thieu Thong tin");

                }
                else
                {
                    conn.Open();
                    table = new DataTable();
                    string queryInsert = "UPDATE dbo.teachers SET teacher_name = N'"+ten+"', sex = '"+gioiTinh+"', dob = '"+ngaySinh+"', address = N'"+diaChi+"', phone_number = N'"+phone+"'," +
                        " email = N'"+email+"', major = N'"+monHoc+"', salary = '"+luong+ "' WHERE id = '"+maGV+"'";
                    cmd = new SqlCommand(queryInsert, conn);
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Sửa Giao Vien Thanh Cong");
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai Định Dạng Ngày Tháng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maGV == -1)
            {
                MessageBox.Show("Chua Chon Giao Vien De XOA");
            }
            else
            {
                table = new DataTable();
                string query1 = "UPDATE dbo.time_table SET teacher_id = NULL WHERE teacher_id = '"+maGV+"'";
                string query2 = "UPDATE dbo.classes SET homeroom_teacher_id = NULL WHERE homeroom_teacher_id = '"+maGV+"'";
                string query3 = "DELETE FROM dbo.teachers WHERE id = '"+maGV+"'";
                GetData(query1, dataGridView1, table);
                GetData(query2, dataGridView1, table);
                GetData(query3, dataGridView1, table);
                GetData("SELECT * FROM dbo.teachers", dataGridView1, table);
                MessageBox.Show("Xóa Thành Công");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            ten = selectRow.Cells[1].Value.ToString();
            gioiTinh = selectRow.Cells[2].Value.ToString();
            ngaySinh = selectRow.Cells[3].Value.ToString();
            diaChi = selectRow.Cells[4].Value.ToString();
            phone = selectRow.Cells[5].Value.ToString();
            email = selectRow.Cells[6].Value.ToString();
            monHoc = selectRow.Cells[7].Value.ToString();
            luong = selectRow.Cells[8].Value.ToString();
            maGV = int.Parse(selectRow.Cells[0].Value.ToString());



            txtTen.Text = ten;
            txtDiaChi.Text = diaChi;
            txtEmail.Text = email;
            txtSDT.Text = phone;
            dateTimePicker1.Value = Convert.ToDateTime(ngaySinh);
            txtMonHoc.Text = monHoc;
            txtLuong.Text = luong;
            if (gioiTinh.Equals("True")) radioButtonNam.Checked = true;
            else radioButtonNu.Checked = true;
        }

        public static int maGV = -1;
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        public ListTeacher()
        {
            InitializeComponent();
        }
        private void PicSearch_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = txtKeySearch.Text.Trim();
            if (key.Equals(""))
            {
                string query = "SELECT * FROM dbo.teachers";
                GetData(query, dataGridView1, table);
            }
            else
            {
                int a;
                bool check = int.TryParse(key, out a);
                if (check == true)
                {
                    string query = "SELECT* FROM dbo.teachers WHERE salary = '"+key+"' OR id = '"+key+"' OR dob LIKE '%"+key+"%'";
                    GetData(query, dataGridView1, table);
                }
                else
                {
                    string query = "SELECT * FROM dbo.students WHERE student_name LIKE N'%" + key + "%' OR address LIKE N'%" + key + "%' " +
                    "OR parent_phone_number LIKE N'%" + key + "%' OR parent_email LIKE N'%" + key + "%'  ";
                    GetData(query, dataGridView1, table);
                }

            }
        }
    }
}

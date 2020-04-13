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
    public partial class ListStudentForm : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        string ten, ngaySinh, diaChi, phone, email, maLop;
        public static int maHS = -1;
        string gioiTinh;
        List<string> list = new List<string>();

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[index];
                ten = selectRow.Cells[1].Value.ToString();

                gioiTinh = (selectRow.Cells[2].Value.ToString());
                ngaySinh = selectRow.Cells[3].Value.ToString();
                diaChi = selectRow.Cells[4].Value.ToString();
                phone = selectRow.Cells[5].Value.ToString();
                email = selectRow.Cells[6].Value.ToString();
                maLop = selectRow.Cells[7].Value.ToString();
                maHS = int.Parse(selectRow.Cells[0].Value.ToString());

                string result = chuanHoaNgaySinh(ngaySinh);
                string[] data = result.Split('-');

                txtTen.Text = ten;
                txtDiaChi.Text = diaChi;
                txtEmail.Text = email;
                txtPhone.Text = phone;
                dateTimePicker1.Value = new DateTime(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]));

                if (gioiTinh.Equals("True")) radioButtonNam.Checked = true;
                else radioButtonNu.Checked = true;
                cbMaLop.SelectedIndex = cbMaLop.FindStringExact(maLop.ToString());
            }
            catch
            {

            }
            
        }

        private void BtnXemDiem_Click(object sender, EventArgs e)
        {
            if(maHS == -1)
            {
                MessageBox.Show("Chua Chon Hoc sinh de xem diem ");
            }
            else
            {
                FormDiem f = new FormDiem();
                f.Show();
            }
            

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(maHS == -1)
            {
                MessageBox.Show("Chua Chon hoc sinh de XOA");
            }
            else
            {
                table = new DataTable();
                string query = "delete students where id = '" + maHS + "'";
                GetData(query, dataGridView1, table);
                GetData("select * from students", dataGridView1, table);
                MessageBox.Show("Done");

            }
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            ten = txtTen.Text.Trim();
            ngaySinh = chuanHoaNgaySinh(dateTimePicker1.Value.ToShortDateString().ToString());
            diaChi = txtDiaChi.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            maLop = cbMaLop.Text.ToString();
            if (radioButtonNam.Checked == true)
            {
                gioiTinh = "1";
            }
            else
            {
                gioiTinh = "0";
            }

            if (ten.Equals("") || ngaySinh.Equals("") || diaChi.Equals("") || phone.Equals("") || email.Equals("") || gioiTinh.Equals(""))
            {
                MessageBox.Show("Thieu Thong tin");

            }
            else
            {
                string query = "UPDATE dbo.students SET " +
                    "name = N'"+ten+"' , sex = '"+int.Parse(gioiTinh)+"', dob = '"+ngaySinh+"', address = N'"+diaChi+"', parent_phone_number = N'"+phone+"', parent_email = N'"+email+"', class_id = '"+int.Parse(maLop)+"' " +
                    "WHERE id = '"+maHS+"'  ";
                GetData(query, dataGridView1, table);
                GetData("select * from Students", dataGridView1, table);
                MessageBox.Show("Done");
            }
        }

        private string chuanHoaNgaySinh(string ngaySinh)
        {
            string[] a = ngaySinh.Split(' ');
            string key = a[0];
            string[] b = key.Split('/');
            string result = b[2] + "-" + b[1] + "-" + b[0];
            return result;
        }

        
        public ListStudentForm()
        {
            InitializeComponent();
            addComboBox(conn, cmd, list, "id", "classes", cbMaLop);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            table = new DataTable();
            string query = "Select * From Students";
            GetData(query, dataGridView1, table);
        }
        private void addComboBox(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " FROM " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetInt32(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();

        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = txtKeySearch.Text.Trim();
            if (key.Equals(""))
            {
                string query = "Select * From Students";
                GetData(query, dataGridView1, table);
            }
            else
            {
                int a;
                bool check = int.TryParse(key, out a);
                if(check == true)
                {
                    string query = "SELECT * FROM dbo.students WHERE  sex = '"+key+"' OR dob LIKE '"+key+"'  OR class_id = '"+key+"' ";
                    GetData(query, dataGridView1, table);
                }
                else
                {
                    string query = "SELECT * FROM dbo.students WHERE name LIKE N'%" + key + "%' OR address LIKE N'%" + key + "%' " +
                    "OR parent_phone_number LIKE N'%" + key + "%' OR parent_email LIKE N'%" + key + "%'  ";
                    GetData(query, dataGridView1, table);
                }
                
            }
        }
    }
}

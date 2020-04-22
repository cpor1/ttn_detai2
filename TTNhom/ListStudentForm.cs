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
        string query;

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[index];
                ten = selectRow.Cells[1].Value.ToString();

                gioiTinh = selectRow.Cells[2].Value.ToString();
                ngaySinh = selectRow.Cells[3].Value.ToString();
                diaChi = selectRow.Cells[4].Value.ToString();
                phone = selectRow.Cells[5].Value.ToString();
                email = selectRow.Cells[6].Value.ToString();
                maLop = selectRow.Cells[7].Value.ToString();
                maHS = int.Parse(selectRow.Cells[0].Value.ToString());


                txtTen.Text = ten;
                txtDiaChi.Text = diaChi;
                txtEmail.Text = email;
                txtPhone.Text = phone;
                dateTimePicker1.Value = Convert.ToDateTime(ngaySinh);

                if (gioiTinh.Equals("True")) radioButtonNam.Checked = true;
                else radioButtonNu.Checked = true;
                cbMaLop.SelectedIndex = cbMaLop.FindStringExact(maLop.ToString());
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
                f.ShowDialog();
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
                string query1 = "DELETE dbo.student_subject_score WHERE student_id = '"+maHS+"'";
                string query2 = "DELETE dbo.students WHERE id = '" + maHS + "'";
                GetData(query1, dataGridView1, table);
                GetData(query2, dataGridView1, table);
                GetData("select * from students", dataGridView1, table);
                MessageBox.Show("Done");
            }
            
        }

        private void ListStudentForm_Load(object sender, EventArgs e)
        {
            comboBoxColumn.SelectedItem = comboBoxColumn.Items[0];
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            ten = txtTen.Text.Trim();
            ngaySinh = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
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
                    "student_name = N'"+ten+"' , sex = '"+int.Parse(gioiTinh)+"', dob = '"+ngaySinh+"', address = N'"+diaChi+"', parent_phone_number = N'"+phone+"', parent_email = N'"+email+"', class_id = '"+int.Parse(maLop)+"' " +
                    "WHERE id = '"+maHS+"'  ";
                GetData(query, dataGridView1, table);
                GetData("select * from Students", dataGridView1, table);
                MessageBox.Show("Done");
            }
        }
        
        public ListStudentForm()
        {
            InitializeComponent();
            addComboBox(conn, cmd, list, "id", "classes", cbMaLop);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            table = new DataTable();
            string query = "Select * From students";
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
            string keySearch = comboBoxColumn.Text;
            string keySearchCompare = txtKeySearch.Text;
            switch (keySearch)
            {
                case ("Mã Học Sinh"):
                    {
                        
                        GetData("select * from students where id like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Tên Học Sinh"):
                    {
                        GetData("select * from students where student_name like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Giới Tính"):
                    {
                        GetData("select * from students where sex like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Ngày Sinh"):
                    {
                        GetData("select * from students where dob like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Địa Chỉ"):
                    {
                        GetData("select * from students where address like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("SĐT Phụ Huynh"):
                    {
                        GetData("select * from students where parent_phone_number like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Email Phụ Huynh"):
                    {
                        GetData("select * from students where parent_email like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case ("Mã Lớp"):
                    {
                        GetData("select * from students where class_id like N'%" + keySearchCompare + "%' ", dataGridView1, table);
                        break;
                    }
                case (""):
                    {
                        GetData("select * from students ", dataGridView1, table);
                        break;
                    }
            }
        }
    }
}

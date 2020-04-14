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
    public partial class AddStudentForm : Form
    {
        string ten, ngaySinh, diaChi, phone, email, maLop;
        int gioiTinh;
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        List<string> list = new List<string>();
        public AddStudentForm()
        {
            InitializeComponent();
            addComboBox(conn, cmd, list, "id", "classes", cbMaLop);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
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


        private void BtnThem_Click(object sender, EventArgs e)
        {
            ten = txtTen.Text.Trim();
            ngaySinh = dateTimePicker1.Value.ToShortDateString().ToString();
            diaChi = txtDiaChi.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            maLop = cbMaLop.Text.ToString();

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
                if (ten.Equals("") || ngaySinh.Equals("") || diaChi.Equals("") || phone.Equals("") || email.Equals("") || gioiTinh.Equals(""))
                {
                    MessageBox.Show("Thieu Thong tin");

                }
                else
                {
                    conn.Open();
                    table = new DataTable();
                    string queryInsert = "INSERT dbo.students( student_name ,sex ,dob ,address ,parent_phone_number ,parent_email ,class_id)VALUES" +
                        "  ( N'" + ten + "' ,'" + gioiTinh + "' ,'" + ngaySinh + "' ,N'" + diaChi + "' ,N'" + phone + "' ,N'" + email + "' , '" + maLop + "'  )";
                    cmd = new SqlCommand(queryInsert, conn);
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Them Hoc Sinh Thanh Cong");
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

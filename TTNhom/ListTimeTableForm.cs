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
    public partial class ListTimeTableForm : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        List<string> list = new List<string>();
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();

        string teacher_id, subject_id, class_id, day_of_the_week, from_date, to_date;
        public static string id_TKB;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id_TKB == null)
            {
                MessageBox.Show("Vui lòng chọn 'id time_date' để thực hiện Xóa");
            }
            else
            {
                table = new DataTable();
                string queryDelete = "delete dbo.time_table where id = N'" + id_TKB + "' ";
                GetData(queryDelete, dataGridViewSchedule, table);
                GetData("select * from dbo.time_table", dataGridViewSchedule, table);
                MessageBox.Show("Done");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();

            teacher_id = cbID_teacher.Text.ToString();
            subject_id = cbID_subject.Text.ToString();
            class_id = cbID_class.Text.ToString();
            day_of_the_week = txtDayWeek.Text;
            from_date = dateTimePickerStart.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            to_date = dateTimePickerEnd.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");

            if (teacher_id.Equals("") || subject_id.Equals("") || class_id.Equals("") || day_of_the_week.Equals("") || from_date.Equals("") || to_date.Equals(""))
            {
                MessageBox.Show("Thiếu Thông tin !!!");

            }
            else if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                MessageBox.Show("Nhập sai 'Ngày kết thúc' \n Vui lòng nhập đúng yêu cầu : Ngày kết thúc muộn hơn Ngày bắt đầu.");
            }
            else
            {
                string query = "UPDATE dbo.time_table SET " +
                "teacher_id = N'" + teacher_id + "' , subject_id = '" + subject_id + "', class_id = '" + class_id + "', day_of_the_week = N'" + day_of_the_week + "', from_date = N'" + from_date + "', to_date = N'" + to_date + "' " +
                "WHERE id = '" + id_TKB + "'  ";
                GetData(query, dataGridViewSchedule, table);
                GetData("select * from dbo.time_table", dataGridViewSchedule, table);
                MessageBox.Show("Done");
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (id_TKB == null)
            {
                MessageBox.Show("Vui lòng chọn 'id time_date' để thực hiện xem Chi Tiết thông tin");
            }
            else
            {
                Form_ChiTiet_time_table f = new Form_ChiTiet_time_table();
                f.Show();
            }
        }

        private void DataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewSchedule.Rows[index];
            id_TKB = selectRow.Cells[0].Value.ToString();
            teacher_id = selectRow.Cells[1].Value.ToString();
            subject_id = selectRow.Cells[2].Value.ToString();
            class_id = selectRow.Cells[3].Value.ToString();
            day_of_the_week = selectRow.Cells[4].Value.ToString();
            from_date = selectRow.Cells[5].Value.ToString();
            to_date = selectRow.Cells[6].Value.ToString();
            //id_TKB = int.Parse(selectRow.Cells[0].Value.ToString());


            cbID_teacher.Text = teacher_id;
            cbID_subject.Text = subject_id;
            cbID_class.Text = class_id;
            txtDayWeek.Text = day_of_the_week;
            dateTimePickerStart.Value = Convert.ToDateTime(from_date);
            dateTimePickerEnd.Value = Convert.ToDateTime(to_date);

        }
        private void dataGridViewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public ListTimeTableForm()
        {
            InitializeComponent();
            table = new DataTable();
            string query = "Select * From time_table";
            GetData(query, dataGridViewSchedule, table);

            addComboBox(conn, cmd, list, "id", "teachers", cbID_teacher);
            addComboBox(conn, cmd, list1, "id", "subjects", cbID_subject);
            addComboBox(conn, cmd, list2, "id", "classes", cbID_class);
        }


        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void txtSearchTKB_TextChanged(object sender, EventArgs e)
        {
            /* Auto */
        }

        private void btnSearchTKB_Click(object sender, EventArgs e)
        {
            string key = txtSearchTKB.Text.Trim();
            if (key.Equals(""))
            {
                table = new DataTable();
                GetData("SELECT * FROM dbo.time_table", dataGridViewSchedule, table);
            }
            else
            {
                string query = "SELECT * FROM dbo.time_table WHERE id LIKE N'%" + key + "%' OR day_of_the_week LIKE N'%" + key + "%' ";
                table = new DataTable();
                GetData(query, dataGridViewSchedule, table);
            }
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
    }
}

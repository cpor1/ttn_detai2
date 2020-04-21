using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom {
    public partial class ListSubjectForm : Form {
        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        int maMon = -1;
        string tenMon;
        int soTiet;
        public ListSubjectForm() {
            InitializeComponent();
            addData();

        }
        private void addData() {
            table = new DataTable();
            GetData("select * from subjects" , tableMon , table);
        }
        private void GetData(string query , DataGridView grid , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void tableMon_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            DataGridViewRow selectRow = tableMon.Rows[index];
            maMon = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            tenMon = selectRow.Cells[1].Value.ToString().Trim();
            soTiet = int.Parse(selectRow.Cells[2].Value.ToString().Trim());
            txtTenMon.Text = tenMon;
            nudSoluongTiet.Value = soTiet;
        }
        private void btnXoaMon_Click(object sender , EventArgs e) {
            if(maMon == -1) {
                MessageBox.Show("Chưa chọn môn nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "DELETE dbo.subjects WHERE id = " + maMon;
                string query2 = "UPDATE dbo.student_subject_score SET subject_id = NULL WHERE subject_id = '" + maMon + "'";
                string query3 = "UPDATE dbo.time_table SET subject_id = NULL WHERE subject_id = '" + maMon + "'";
                GetData(query2 , tableMon , table);
                GetData(query3 , tableMon , table);
                GetData(query1 , tableMon , table);
                GetData("select * from subjects" , tableMon , table);
                MessageBox.Show("Done");

            }
        }
        private void btnSuaMon_Click(object sender , EventArgs e) {
            table = new DataTable();
            tenMon = txtTenMon.Text.Trim();
            soTiet = int.Parse(nudSoluongTiet.Value.ToString());
            if(tenMon.Equals("")) {
                MessageBox.Show("Thieu Thong tin");
            }
            else {
                string query = "UPDATE dbo.subjects SET " +
                    "subject_name = N'" + tenMon + "' , lesson_amount = " + soTiet + "WHERE id = " + maMon;
                GetData(query , tableMon , table);
                GetData("select * from subjects" , tableMon , table);
                MessageBox.Show("Done");
            }
        }

        private void button3_Click(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearch.Text;
            table = new DataTable();
            GetData("select * from subjects WHERE subject_name LIKE N'%" + keyword + "%' " +
                "OR lesson_amount LIKE N'%" + keyword + "%' "
                , tableMon , table);
        }
        private void textBoxSearch_TextChanged(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearch.Text;
            table = new DataTable();
            GetData("select * from subjects WHERE subject_name LIKE N'%" + keyword + "%' " +
                "OR lesson_amount LIKE N'%" + keyword + "%' "
                , tableMon , table);
        }
        private void ListSubjectForm_Load(object sender , EventArgs e) {

        }
    }
}






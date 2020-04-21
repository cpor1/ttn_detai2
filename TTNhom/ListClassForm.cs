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
    public partial class ListClassForm : Form {

        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        int maLop =-1;
        string tenLop;
        int soHS;
        int maGV;
        List<string> listGV = new List<string>();

        public ListClassForm() {
            InitializeComponent();
            addComboBox(conn , cmd , listGV , "id" , "teachers" , cbMaGV);
            addData();
        }
        private void GetData(string query , DataGridView grid , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void addComboBox(SqlConnection conn , SqlCommand cmd , List<string> list , string tenCot , string tenTable , ComboBox cb) {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " From " + tenTable , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                list.Add(dr.GetValue(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }
        private void addData() {
            table = new DataTable();
            GetData("select * from classes" , tableMain , table);
        }
        private void clear() {
            txtTenLop.Text = "";
            textBoxSearch.Text = "";
            nudSoluongHS.Value = 0;
            cbMaGV.Text = "";
        }
        private void tableMain_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            DataGridViewRow selectRow = tableMain.Rows[index];
            maLop = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            tenLop = selectRow.Cells[1].Value.ToString().Trim();
            soHS = int.Parse(selectRow.Cells[2].Value.ToString().Trim());
            maGV = int.Parse(selectRow.Cells[3].Value.ToString().Trim());

            txtTenLop.Text = tenLop;
            nudSoluongHS.Value = soHS;
            cbMaGV.SelectedIndex = cbMaGV.FindStringExact(maGV.ToString());
        }
        private void btnXoaLop_Click(object sender , EventArgs e) {
            if(maLop == -1) {
                MessageBox.Show("Chưa chọn lớp nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "DELETE dbo.classes WHERE id = " + maLop;
                string query2 = "UPDATE dbo.time_table SET class_id = NULL WHERE class_id = '" + maLop + "'";
                string query3 = "UPDATE dbo.students SET class_id = NULL WHERE class_id = '" + maLop + "'";

                GetData(query2 , tableMain , table);
                GetData(query3 , tableMain , table);
                GetData(query1 , tableMain , table);
                GetData("select * from classes" , tableMain , table);
                MessageBox.Show("Done");

            }
        }
        private void btnSuaLop_Click(object sender , EventArgs e) {
            table = new DataTable();
            tenLop = txtTenLop.Text.Trim();
            maGV = int.Parse(cbMaGV.Text.ToString());
            soHS = int.Parse(nudSoluongHS.Value.ToString());
            if(tenLop.Equals("")) {
                MessageBox.Show("Thieu Thong tin");
            }
            else {
                string query = "UPDATE dbo.classes SET " +
                    "class_name = N'" + tenLop + "' , student_amount = " + soHS  + ", homeroom_teacher_id = " + maGV  +"WHERE id = " + maLop ;
                GetData(query , tableMain , table);
                GetData("select * from classes" , tableMain , table);
                MessageBox.Show("Done");
            }
        }
        private void textBoxSearch_TextChanged(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearch.Text;
            table = new DataTable();
            GetData("select * from classes WHERE class_name LIKE N'%" + keyword + "%' " +
                "OR student_amount LIKE N'%" + keyword + "%' " +
                "OR homeroom_teacher_id LIKE N'%" + keyword + "%'"
                , tableMain , table);
        }
        private void button3_Click(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearch.Text;
            table = new DataTable();
            GetData("select * from classes WHERE class_name LIKE N'%" + keyword + "%' " +
                "OR student_amount LIKE N'%" + keyword + "%' " +
                "OR homeroom_teacher_id LIKE N'%" + keyword + "%'"
                , tableMain , table);
        }
    }
}

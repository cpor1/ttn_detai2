using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom {
    public partial class AddSubjectForm : Form {
        DBAccess access = new DBAccess();

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        string variable;
        public AddSubjectForm() {
            InitializeComponent();
        }
        private string queryID(SqlCommand sql , string colomn , string table , string dieuKien , string ndDieuKien) {
            conn.Open();
            cmd = new SqlCommand("SELECT " + colomn + " FROM " + table + " WHERE " + dieuKien + " = N'" + ndDieuKien + "'  " , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                variable = dr.GetInt32(0).ToString();
            }
            conn.Close();
            return variable;
        }

        private void buttonAddMon_Click(object sender , EventArgs e) {
            string tenMon, maMon;
            int soTiet;
            tenMon = txtTenMon.Text;
            soTiet = Convert.ToInt32(nudSoluongTiet.Value);
            maMon = queryID(cmd , "id" , "subjects" , "subject_name" , tenMon);
            if(tenMon.Equals("")) {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else if(maMon != null) {
                MessageBox.Show("Tên lớp đã tồn tại!");
            }
            else if(soTiet == 0) {
                MessageBox.Show("Số lượng tiết học phải lơn hơn 0!");
            }
            else {
                conn.Open();
                string queryInsert = "INSERT INTO dbo.subjects (subject_name , lesson_amount ) VALUES(N'" + tenMon + "'," + soTiet + ")";
                cmd = new SqlCommand(queryInsert , conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm môn học mới thành công");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    public partial class AddClassForm : Form
    {
        DBAccess access = new DBAccess();

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        string variable;
        public AddClassForm()
        {
            InitializeComponent();
            addData();
        }
        private void addComboBox(SqlConnection conn,SqlCommand cmd,List<string> list,string tenCot,string tenTable,ComboBox cb) {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " From " + tenTable , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                list.Add(dr.GetValue(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
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
        private void addData() {
            List<string> listGV= new List<string>();
            addComboBox(conn , cmd , listGV , "teacher_name" , "teachers" , comboBoxGVCN);
        }

        private void buttonAdd_Click(object sender , EventArgs e) {
            string tenLop, tenGVCN;
            int soHS;
            string maGVCN, maLop;
            tenLop = txtTenLop.Text;
            tenGVCN = comboBoxGVCN.Text;
            soHS = Convert.ToInt32(nudSoluongHS.Value);
            maLop = queryID(cmd,"id" , "classes" , "class_name" , tenLop);
            if(tenLop.Equals("")) {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else if(maLop!=null&&soHS<10) {
                MessageBox.Show("Tên lớp đã tồn tại hoặc số lượng học sinh nhỏ hơn 10!");
            }
            else {
            maGVCN = queryID(cmd , "id" , "teachers" , "teacher_name" , tenGVCN);
                conn.Open();
                string queryInsert = "INSERT INTO dbo.classes (class_name , student_amount , homeroom_teacher_id) VALUES(N'" +tenLop +"',"+ soHS+","+ maGVCN + ")";
                cmd = new SqlCommand(queryInsert , conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm lớp thành công");
            }
        }
    }
}

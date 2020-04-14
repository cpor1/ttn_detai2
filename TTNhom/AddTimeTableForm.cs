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
    public partial class AddTimeTableForm : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        string id_TKB, teacher_id, subject_id, class_id, day_of_the_week, from_date, to_date;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            teacher_id = txtTeacherID.Text.Trim();
            subject_id = txtSubjectID.Text;
            class_id = txtClassID.Text;
            day_of_the_week = txtDayWeek.Text;
            from_date = dateTimePickerStart.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            to_date = dateTimePickerEnd.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
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
                    conn.Open();
                    table = new DataTable();
                    string queryInsert = "INSERT dbo.time_table( teacher_id ,subject_id , class_id , day_of_the_week ,from_date , to_date )VALUES" +
                        "  ( N'" + teacher_id + "' ,'" + subject_id + "' ,'" + class_id + "' ,N'" + day_of_the_week + "' ,N'" + from_date + "' ,N'" + to_date + "' )";
                    cmd = new SqlCommand(queryInsert, conn);
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Thêm Thời Khóa Biểu Thành Công.");
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai Định Dạng Ngày Tháng !!!");
            }
        }

        public AddTimeTableForm()
        {
            InitializeComponent();
        }

        
    }
}

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
    public partial class FormDiem : Form
    {
        int maHS = ListStudentForm.maHS;
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        public FormDiem()
        {
            InitializeComponent();
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            string query = "SELECT sub.subject_name,sss.first_test_score,sss.middle_test_score,sss.final_test_score,sss.grade FROM dbo.student_subject_score AS sss, dbo.subjects AS sub , dbo.students AS stu" +
                " WHERE sss.student_id = stu.id AND sss.subject_id = sub.id AND stu.id = '"+maHS+"'";
            GetData(query, dataGridView1, table);
        }
    }
}

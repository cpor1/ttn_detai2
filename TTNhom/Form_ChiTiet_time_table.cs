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
    public partial class Form_ChiTiet_time_table : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        string id_TKB = ListTimeTableForm.id_TKB;
        public Form_ChiTiet_time_table()
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

        private void Form_ChiTiet_time_table_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id_TKB;
            table = new DataTable();
            string queryChiTiet = "SELECT tea.teacher_name AS Giao_Vien, sub.subject_name AS Mon_Hoc, cla.class_name AS Lop_Hoc, tt.day_of_the_week AS Lich_Hoc, tt.from_date AS Ngay_Bat_dau, tt.to_date AS Ngay_Ket_thuc FROM dbo.time_table AS tt, dbo.subjects AS sub, dbo.teachers AS tea, dbo.classes AS cla" +
                " WHERE tt.teacher_id = tea.id AND tt.subject_id = sub.id AND tt.class_id = cla.id AND tt.id = '" + id_TKB + "'";
            GetData(queryChiTiet, dataGridViewChiTietTKB, table);
        }
    }
}

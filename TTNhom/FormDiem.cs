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
        string queryMain;
        string first, mid, final, grade, subject_id;
        List<string> list = new List<string>();
        string id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            id = selectRow.Cells[0].Value.ToString();
            txtFirst.Text = selectRow.Cells[3].Value.ToString();
            txtMid.Text = selectRow.Cells[4].Value.ToString();
            txtFinal.Text = selectRow.Cells[5].Value.ToString();
            txtGrade.Text = selectRow.Cells[6].Value.ToString();
            comboBoxMaMon.SelectedIndex = comboBoxMaMon.FindStringExact(selectRow.Cells[2].Value.ToString());

        }

        public FormDiem()
        {
            InitializeComponent();
            txtMaHS.Text = maHS.ToString();
            addComboBox(conn, cmd, list, "id", "subjects", comboBoxMaMon);
        }

        private void BtnSửa_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            subject_id = comboBoxMaMon.Text;
            first = txtFirst.Text;
            mid = txtMid.Text;
            final = txtFinal.Text;
            grade = txtGrade.Text;
            if (first == "" || mid == "" || final == "" || grade == "")
            {
                MessageBox.Show("thieu thong tin");
            }
            else
            {

                string query = "UPDATE dbo.student_subject_score SET " +
                    "subject_id = '"+subject_id+"',first_test_score = '"+first+"',middle_test_score = '"+mid+"',final_test_score= '"+final+"',grade = '"+grade+"' WHERE id = '"+id+"'";
                GetData(query, dataGridView1, table);
                GetData(queryMain, dataGridView1, table);
                MessageBox.Show("done");

            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string query = "delete dbo.student_subject_score where id = '" + id + "'";
            GetData(query, dataGridView1, table);
            GetData(queryMain, dataGridView1, table);
            MessageBox.Show("done");
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

        private void FormDiem_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            queryMain = "SELECT * FROM dbo.student_subject_score WHERE student_id = '"+maHS+"'";
            GetData(queryMain, dataGridView1, table);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            subject_id = comboBoxMaMon.Text;
            first = txtFirst.Text;
            mid = txtMid.Text;
            final = txtFinal.Text;
            grade = txtGrade.Text;
            if (first == "" || mid == "" || final == "" || grade == "")
            {
                MessageBox.Show("thieu thong tin1111");
            }
            else
            {
                
                string query = "INSERT dbo.student_subject_score( student_id ,subject_id ,first_test_score ,middle_test_score ,final_test_score ,grade)" +
                    "VALUES  ( '" + maHS + "' ,'" + subject_id + "' ,'" + first + "' ,'" + mid + "' ,'" + final + "' ,N'" + grade + "')";
                GetData(query, dataGridView1, table);
                GetData(queryMain, dataGridView1, table);
                MessageBox.Show("done");

            }
        }
    }
}

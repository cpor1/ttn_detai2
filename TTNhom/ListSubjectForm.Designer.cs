namespace TTNhom
{
    partial class ListSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudSoluongTiet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableMon = new System.Windows.Forms.DataGridView();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMon)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSoluongTiet
            // 
            this.nudSoluongTiet.Location = new System.Drawing.Point(522, 357);
            this.nudSoluongTiet.Name = "nudSoluongTiet";
            this.nudSoluongTiet.Size = new System.Drawing.Size(45, 20);
            this.nudSoluongTiet.TabIndex = 164;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 163;
            this.label5.Text = "Số Lượng Tiết Học";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 158;
            this.button3.Text = "Tìm Kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(385, 110);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(149, 23);
            this.textBoxSearch.TabIndex = 157;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 17);
            this.label12.TabIndex = 156;
            this.label12.Text = "______________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 155;
            this.label3.Text = "Danh sách Môn Học ";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(121, 357);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(167, 20);
            this.txtTenMon.TabIndex = 152;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 151;
            this.label13.Text = "Tên Môn";
            // 
            // tableMon
            // 
            this.tableMon.BackgroundColor = System.Drawing.Color.White;
            this.tableMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMon.Location = new System.Drawing.Point(57, 153);
            this.tableMon.MultiSelect = false;
            this.tableMon.Name = "tableMon";
            this.tableMon.ReadOnly = true;
            this.tableMon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableMon.RowHeadersVisible = false;
            this.tableMon.RowHeadersWidth = 51;
            this.tableMon.Size = new System.Drawing.Size(565, 167);
            this.tableMon.TabIndex = 150;
            this.tableMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMon_CellClick);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoaMon.FlatAppearance.BorderSize = 0;
            this.btnXoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.Location = new System.Drawing.Point(410, 493);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(103, 41);
            this.btnXoaMon.TabIndex = 154;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(186)))), ((int)(((byte)(151)))));
            this.btnSuaMon.FlatAppearance.BorderSize = 0;
            this.btnSuaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.ForeColor = System.Drawing.Color.White;
            this.btnSuaMon.Location = new System.Drawing.Point(154, 493);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(103, 41);
            this.btnSuaMon.TabIndex = 153;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // ListSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 581);
            this.Controls.Add(this.nudSoluongTiet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tableMon);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnSuaMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListSubjectForm";
            this.Text = "ListSubjectForm";
            this.Load += new System.EventHandler(this.ListSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSoluongTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView tableMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
    }
}
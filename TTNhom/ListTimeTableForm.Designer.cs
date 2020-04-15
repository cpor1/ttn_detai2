namespace TTNhom
{
    partial class ListTimeTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTimeTableForm));
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.txtSearchTKB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDayWeek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSearchTKB = new System.Windows.Forms.Button();
            this.cbID_teacher = new System.Windows.Forms.ComboBox();
            this.cbID_class = new System.Windows.Forms.ComboBox();
            this.cbID_subject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 17);
            this.label12.TabIndex = 89;
            this.label12.Text = "______________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(49, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Danh sách Thời Khóa Biểu";
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(49, 125);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.Size = new System.Drawing.Size(565, 167);
            this.dataGridViewSchedule.TabIndex = 91;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellContentClick);
            // 
            // txtSearchTKB
            // 
            this.txtSearchTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTKB.Location = new System.Drawing.Point(398, 90);
            this.txtSearchTKB.Name = "txtSearchTKB";
            this.txtSearchTKB.Size = new System.Drawing.Size(172, 23);
            this.txtSearchTKB.TabIndex = 90;
            this.txtSearchTKB.TextChanged += new System.EventHandler(this.txtSearchTKB_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(27, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 24);
            this.label13.TabIndex = 94;
            this.label13.Text = "Thông tin : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(46, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 95;
            this.label1.Text = "Mã giáo viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(41, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Mã môn học : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(341, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Mã lớp học : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(341, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Lịch học : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(41, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Ngày bắt đầu : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(341, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Ngày kết thúc : ";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerStart.Location = new System.Drawing.Point(156, 442);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerStart.TabIndex = 102;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(454, 442);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerEnd.TabIndex = 103;
            // 
            // txtDayWeek
            // 
            this.txtDayWeek.Location = new System.Drawing.Point(454, 400);
            this.txtDayWeek.Name = "txtDayWeek";
            this.txtDayWeek.Size = new System.Drawing.Size(137, 20);
            this.txtDayWeek.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(616, 17);
            this.label8.TabIndex = 107;
            this.label8.Text = "____________________________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(616, 17);
            this.label9.TabIndex = 108;
            this.label9.Text = "____________________________________________________________________________";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(418, 513);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 41);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(186)))), ((int)(((byte)(151)))));
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(278, 513);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(103, 41);
            this.btnChiTiet.TabIndex = 109;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(186)))), ((int)(((byte)(151)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(137, 513);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 41);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSearchTKB
            // 
            this.btnSearchTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchTKB.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTKB.Image")));
            this.btnSearchTKB.Location = new System.Drawing.Point(576, 82);
            this.btnSearchTKB.Name = "btnSearchTKB";
            this.btnSearchTKB.Size = new System.Drawing.Size(38, 37);
            this.btnSearchTKB.TabIndex = 93;
            this.btnSearchTKB.UseVisualStyleBackColor = true;
            this.btnSearchTKB.Click += new System.EventHandler(this.btnSearchTKB_Click);
            // 
            // cbID_teacher
            // 
            this.cbID_teacher.FormattingEnabled = true;
            this.cbID_teacher.Location = new System.Drawing.Point(156, 356);
            this.cbID_teacher.Name = "cbID_teacher";
            this.cbID_teacher.Size = new System.Drawing.Size(121, 21);
            this.cbID_teacher.TabIndex = 112;
            // 
            // cbID_class
            // 
            this.cbID_class.FormattingEnabled = true;
            this.cbID_class.Location = new System.Drawing.Point(454, 356);
            this.cbID_class.Name = "cbID_class";
            this.cbID_class.Size = new System.Drawing.Size(121, 21);
            this.cbID_class.TabIndex = 113;
            // 
            // cbID_subject
            // 
            this.cbID_subject.FormattingEnabled = true;
            this.cbID_subject.Location = new System.Drawing.Point(156, 401);
            this.cbID_subject.Name = "cbID_subject";
            this.cbID_subject.Size = new System.Drawing.Size(121, 21);
            this.cbID_subject.TabIndex = 114;
            // 
            // ListTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 581);
            this.Controls.Add(this.cbID_subject);
            this.Controls.Add(this.cbID_class);
            this.Controls.Add(this.cbID_teacher);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDayWeek);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSearchTKB);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.txtSearchTKB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListTimeTableForm";
            this.Text = "ListTimeTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.TextBox txtSearchTKB;
        private System.Windows.Forms.Button btnSearchTKB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox txtDayWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbID_teacher;
        private System.Windows.Forms.ComboBox cbID_class;
        private System.Windows.Forms.ComboBox cbID_subject;
    }
}
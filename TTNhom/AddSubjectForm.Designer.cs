namespace TTNhom
{
    partial class AddSubjectForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddMon = new System.Windows.Forms.Button();
            this.nudSoluongTiet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "______________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Thêm mới môn học";
            // 
            // buttonAddMon
            // 
            this.buttonAddMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(186)))), ((int)(((byte)(151)))));
            this.buttonAddMon.FlatAppearance.BorderSize = 0;
            this.buttonAddMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMon.ForeColor = System.Drawing.Color.White;
            this.buttonAddMon.Location = new System.Drawing.Point(277, 414);
            this.buttonAddMon.Name = "buttonAddMon";
            this.buttonAddMon.Size = new System.Drawing.Size(120, 47);
            this.buttonAddMon.TabIndex = 105;
            this.buttonAddMon.Text = "Xác nhận";
            this.buttonAddMon.UseVisualStyleBackColor = false;
            this.buttonAddMon.Click += new System.EventHandler(this.buttonAddMon_Click);
            // 
            // nudSoluongTiet
            // 
            this.nudSoluongTiet.Location = new System.Drawing.Point(212, 271);
            this.nudSoluongTiet.Name = "nudSoluongTiet";
            this.nudSoluongTiet.Size = new System.Drawing.Size(43, 20);
            this.nudSoluongTiet.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Số Lượng Tiết Dạy";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(139, 197);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(474, 20);
            this.txtTenMon.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Tên Môn";
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 581);
            this.Controls.Add(this.nudSoluongTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddMon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Click += new System.EventHandler(this.buttonAddMon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluongTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddMon;
        private System.Windows.Forms.NumericUpDown nudSoluongTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
    }
}
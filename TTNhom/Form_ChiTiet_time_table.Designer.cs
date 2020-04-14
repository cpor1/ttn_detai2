namespace TTNhom
{
    partial class Form_ChiTiet_time_table
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
            this.dataGridViewChiTietTKB = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChiTietTKB
            // 
            this.dataGridViewChiTietTKB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTietTKB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewChiTietTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietTKB.Location = new System.Drawing.Point(33, 132);
            this.dataGridViewChiTietTKB.MultiSelect = false;
            this.dataGridViewChiTietTKB.Name = "dataGridViewChiTietTKB";
            this.dataGridViewChiTietTKB.ReadOnly = true;
            this.dataGridViewChiTietTKB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewChiTietTKB.RowHeadersVisible = false;
            this.dataGridViewChiTietTKB.Size = new System.Drawing.Size(644, 192);
            this.dataGridViewChiTietTKB.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "______________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 26);
            this.label3.TabIndex = 90;
            this.label3.Text = "Thông tin Chi Tiết Thời Khóa Biểu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 95;
            this.label13.Text = "Mã Time_Table : ";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(213, 82);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(37, 26);
            this.lbl_id.TabIndex = 96;
            this.lbl_id.Text = ". . .";
            // 
            // Form_ChiTiet_time_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChiTietTKB);
            this.Name = "Form_ChiTiet_time_table";
            this.Text = "Chi Tiết Time Table";
            this.Load += new System.EventHandler(this.Form_ChiTiet_time_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChiTietTKB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_id;
    }
}
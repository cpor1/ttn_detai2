namespace TTNhom
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelUsernameHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.buttonListTeacher = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonListStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.panelSubject = new System.Windows.Forms.Panel();
            this.buttonListSubject = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.panelClass = new System.Windows.Forms.Panel();
            this.buttonListClass = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.panelTimeTable = new System.Windows.Forms.Panel();
            this.buttonListTimeTable = new System.Windows.Forms.Button();
            this.buttonAddTimeTable = new System.Windows.Forms.Button();
            this.buttonTimeTable = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelSubject.SuspendLayout();
            this.panelClass.SuspendLayout();
            this.panelTimeTable.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsernameHeader
            // 
            this.labelUsernameHeader.AutoSize = true;
            this.labelUsernameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameHeader.Location = new System.Drawing.Point(497, 12);
            this.labelUsernameHeader.Name = "labelUsernameHeader";
            this.labelUsernameHeader.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelUsernameHeader.Size = new System.Drawing.Size(173, 27);
            this.labelUsernameHeader.TabIndex = 0;
            this.labelUsernameHeader.Text = "Hello, (Username) !";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.buttonUser);
            this.flowLayoutPanel1.Controls.Add(this.panelTeacher);
            this.flowLayoutPanel1.Controls.Add(this.panelStudent);
            this.flowLayoutPanel1.Controls.Add(this.panelSubject);
            this.flowLayoutPanel1.Controls.Add(this.panelClass);
            this.flowLayoutPanel1.Controls.Add(this.panelTimeTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 630);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Highschool Admin";
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUser.Image = global::TTNhom.Properties.Resources.user_white_medium;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.Location = new System.Drawing.Point(3, 44);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(197, 94);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "  (username)";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUser.UseVisualStyleBackColor = false;
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.buttonListTeacher);
            this.panelTeacher.Controls.Add(this.buttonAddTeacher);
            this.panelTeacher.Controls.Add(this.buttonTeacher);
            this.panelTeacher.Location = new System.Drawing.Point(3, 161);
            this.panelTeacher.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panelTeacher.MaximumSize = new System.Drawing.Size(194, 117);
            this.panelTeacher.MinimumSize = new System.Drawing.Size(194, 44);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(194, 44);
            this.panelTeacher.TabIndex = 2;
            // 
            // buttonListTeacher
            // 
            this.buttonListTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonListTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonListTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonListTeacher.Location = new System.Drawing.Point(0, 79);
            this.buttonListTeacher.Name = "buttonListTeacher";
            this.buttonListTeacher.Size = new System.Drawing.Size(194, 35);
            this.buttonListTeacher.TabIndex = 4;
            this.buttonListTeacher.Text = "Danh Sách";
            this.buttonListTeacher.UseVisualStyleBackColor = false;
            this.buttonListTeacher.Click += new System.EventHandler(this.buttonListTeacher_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonAddTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTeacher.Location = new System.Drawing.Point(0, 42);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(194, 37);
            this.buttonAddTeacher.TabIndex = 3;
            this.buttonAddTeacher.Text = "Thêm mới";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonTeacher.FlatAppearance.BorderSize = 0;
            this.buttonTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTeacher.Image = global::TTNhom.Properties.Resources.Expand_Arrow_20px;
            this.buttonTeacher.Location = new System.Drawing.Point(0, 0);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(194, 42);
            this.buttonTeacher.TabIndex = 2;
            this.buttonTeacher.Text = "Giáo Viên";
            this.buttonTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonTeacher.UseVisualStyleBackColor = false;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.buttonListStudent);
            this.panelStudent.Controls.Add(this.buttonAddStudent);
            this.panelStudent.Controls.Add(this.buttonStudent);
            this.panelStudent.Location = new System.Drawing.Point(3, 238);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panelStudent.MaximumSize = new System.Drawing.Size(194, 117);
            this.panelStudent.MinimumSize = new System.Drawing.Size(194, 44);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(194, 44);
            this.panelStudent.TabIndex = 3;
            // 
            // buttonListStudent
            // 
            this.buttonListStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonListStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonListStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonListStudent.Location = new System.Drawing.Point(0, 79);
            this.buttonListStudent.Name = "buttonListStudent";
            this.buttonListStudent.Size = new System.Drawing.Size(194, 35);
            this.buttonListStudent.TabIndex = 4;
            this.buttonListStudent.Text = "Danh Sách";
            this.buttonListStudent.UseVisualStyleBackColor = false;
            this.buttonListStudent.Click += new System.EventHandler(this.buttonListStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStudent.Location = new System.Drawing.Point(0, 42);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(194, 37);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Thêm mới";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStudent.Image = global::TTNhom.Properties.Resources.Expand_Arrow_20px;
            this.buttonStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(194, 42);
            this.buttonStudent.TabIndex = 2;
            this.buttonStudent.Text = "Học Sinh";
            this.buttonStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // panelSubject
            // 
            this.panelSubject.Controls.Add(this.buttonListSubject);
            this.panelSubject.Controls.Add(this.buttonAddSubject);
            this.panelSubject.Controls.Add(this.buttonSubject);
            this.panelSubject.Location = new System.Drawing.Point(3, 315);
            this.panelSubject.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panelSubject.MaximumSize = new System.Drawing.Size(194, 117);
            this.panelSubject.MinimumSize = new System.Drawing.Size(194, 44);
            this.panelSubject.Name = "panelSubject";
            this.panelSubject.Size = new System.Drawing.Size(194, 44);
            this.panelSubject.TabIndex = 4;
            // 
            // buttonListSubject
            // 
            this.buttonListSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonListSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonListSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonListSubject.Location = new System.Drawing.Point(0, 79);
            this.buttonListSubject.Name = "buttonListSubject";
            this.buttonListSubject.Size = new System.Drawing.Size(194, 35);
            this.buttonListSubject.TabIndex = 4;
            this.buttonListSubject.Text = "Danh Sách";
            this.buttonListSubject.UseVisualStyleBackColor = false;
            this.buttonListSubject.Click += new System.EventHandler(this.buttonListSubject_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonAddSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddSubject.Location = new System.Drawing.Point(0, 42);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(194, 37);
            this.buttonAddSubject.TabIndex = 3;
            this.buttonAddSubject.Text = "Thêm mới";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubject.FlatAppearance.BorderSize = 0;
            this.buttonSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubject.Image = global::TTNhom.Properties.Resources.Expand_Arrow_20px;
            this.buttonSubject.Location = new System.Drawing.Point(0, 0);
            this.buttonSubject.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(194, 42);
            this.buttonSubject.TabIndex = 2;
            this.buttonSubject.Text = "Môn học";
            this.buttonSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSubject.UseVisualStyleBackColor = false;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // panelClass
            // 
            this.panelClass.Controls.Add(this.buttonListClass);
            this.panelClass.Controls.Add(this.buttonAddClass);
            this.panelClass.Controls.Add(this.buttonClass);
            this.panelClass.Location = new System.Drawing.Point(3, 392);
            this.panelClass.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panelClass.MaximumSize = new System.Drawing.Size(194, 117);
            this.panelClass.MinimumSize = new System.Drawing.Size(194, 44);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(194, 44);
            this.panelClass.TabIndex = 5;
            // 
            // buttonListClass
            // 
            this.buttonListClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonListClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonListClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonListClass.Location = new System.Drawing.Point(0, 79);
            this.buttonListClass.Name = "buttonListClass";
            this.buttonListClass.Size = new System.Drawing.Size(194, 35);
            this.buttonListClass.TabIndex = 4;
            this.buttonListClass.Text = "Danh Sách";
            this.buttonListClass.UseVisualStyleBackColor = false;
            this.buttonListClass.Click += new System.EventHandler(this.buttonListClass_Click);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddClass.Location = new System.Drawing.Point(0, 42);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(194, 37);
            this.buttonAddClass.TabIndex = 3;
            this.buttonAddClass.Text = "Thêm mới";
            this.buttonAddClass.UseVisualStyleBackColor = false;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClass.FlatAppearance.BorderSize = 0;
            this.buttonClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClass.Image = global::TTNhom.Properties.Resources.Expand_Arrow_20px;
            this.buttonClass.Location = new System.Drawing.Point(0, 0);
            this.buttonClass.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(194, 42);
            this.buttonClass.TabIndex = 2;
            this.buttonClass.Text = "Lớp học";
            this.buttonClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClass.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonClass.UseVisualStyleBackColor = false;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // panelTimeTable
            // 
            this.panelTimeTable.Controls.Add(this.buttonListTimeTable);
            this.panelTimeTable.Controls.Add(this.buttonAddTimeTable);
            this.panelTimeTable.Controls.Add(this.buttonTimeTable);
            this.panelTimeTable.Location = new System.Drawing.Point(3, 469);
            this.panelTimeTable.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panelTimeTable.MaximumSize = new System.Drawing.Size(194, 117);
            this.panelTimeTable.MinimumSize = new System.Drawing.Size(194, 44);
            this.panelTimeTable.Name = "panelTimeTable";
            this.panelTimeTable.Size = new System.Drawing.Size(194, 44);
            this.panelTimeTable.TabIndex = 6;
            // 
            // buttonListTimeTable
            // 
            this.buttonListTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonListTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListTimeTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonListTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListTimeTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonListTimeTable.Location = new System.Drawing.Point(0, 79);
            this.buttonListTimeTable.Name = "buttonListTimeTable";
            this.buttonListTimeTable.Size = new System.Drawing.Size(194, 35);
            this.buttonListTimeTable.TabIndex = 4;
            this.buttonListTimeTable.Text = "Danh Sách";
            this.buttonListTimeTable.UseVisualStyleBackColor = false;
            this.buttonListTimeTable.Click += new System.EventHandler(this.buttonListTimeTable_Click);
            // 
            // buttonAddTimeTable
            // 
            this.buttonAddTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(131)))));
            this.buttonAddTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTimeTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.buttonAddTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTimeTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTimeTable.Location = new System.Drawing.Point(0, 42);
            this.buttonAddTimeTable.Name = "buttonAddTimeTable";
            this.buttonAddTimeTable.Size = new System.Drawing.Size(194, 37);
            this.buttonAddTimeTable.TabIndex = 3;
            this.buttonAddTimeTable.Text = "Thêm mới";
            this.buttonAddTimeTable.UseVisualStyleBackColor = false;
            this.buttonAddTimeTable.Click += new System.EventHandler(this.buttonAddTimeTable_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.buttonTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimeTable.FlatAppearance.BorderSize = 0;
            this.buttonTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTimeTable.Image = global::TTNhom.Properties.Resources.Expand_Arrow_20px;
            this.buttonTimeTable.Location = new System.Drawing.Point(0, 0);
            this.buttonTimeTable.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(194, 42);
            this.buttonTimeTable.TabIndex = 2;
            this.buttonTimeTable.Text = "Thời khóa biểu";
            this.buttonTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTimeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonTimeTable.UseVisualStyleBackColor = false;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.flowLayoutPanel2.Controls.Add(this.labelUsernameHeader);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(673, 49);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TTNhom.Properties.Resources.user_black_small;
            this.pictureBox2.Location = new System.Drawing.Point(465, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 581);
            this.panel1.TabIndex = 3;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMain.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(673, 581);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 15;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 15;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 15;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelSubject.ResumeLayout(false);
            this.panelClass.ResumeLayout(false);
            this.panelTimeTable.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsernameHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Button buttonListTeacher;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button buttonListStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelSubject;
        private System.Windows.Forms.Button buttonListSubject;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.Button buttonListClass;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panelTimeTable;
        private System.Windows.Forms.Button buttonListTimeTable;
        private System.Windows.Forms.Button buttonAddTimeTable;
        private System.Windows.Forms.Button buttonTimeTable;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.GroupBox groupBoxMain;
    }
}
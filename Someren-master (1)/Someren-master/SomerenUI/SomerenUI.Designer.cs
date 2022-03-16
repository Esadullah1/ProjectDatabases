namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.Students = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTeachers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTeach = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.superv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labteacher = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.TeacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelRooms = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.RoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Revenuepnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.panelTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRooms.SuspendLayout();
            this.Revenuepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(836, 0);
            this.imgDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(415, 332);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click_1);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(17, 32);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1200, 576);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(26, 25);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.Students);
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Location = new System.Drawing.Point(17, 32);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1200, 576);
            this.pnlStudents.TabIndex = 4;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(13, 13);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(141, 36);
            this.Students.TabIndex = 6;
            this.Students.Text = "Students";
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.DateOfBirth});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(20, 64);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(835, 385);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.TileSize = new System.Drawing.Size(1, 1);
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "Student id";
            this.studentID.Width = 150;
            // 
            // studentName
            // 
            this.studentName.Text = "Student name";
            this.studentName.Width = 150;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "Date of birth";
            this.DateOfBirth.Width = 150;
            // 
            // panelTeachers
            // 
            this.panelTeachers.Controls.Add(this.label1);
            this.panelTeachers.Controls.Add(this.listViewTeach);
            this.panelTeachers.Location = new System.Drawing.Point(17, 32);
            this.panelTeachers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelTeachers.Name = "panelTeachers";
            this.panelTeachers.Size = new System.Drawing.Size(1200, 576);
            this.panelTeachers.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teachers";
            // 
            // listViewTeach
            // 
            this.listViewTeach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fname,
            this.lname,
            this.superv});
            this.listViewTeach.GridLines = true;
            this.listViewTeach.HideSelection = false;
            this.listViewTeach.Location = new System.Drawing.Point(20, 64);
            this.listViewTeach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewTeach.Name = "listViewTeach";
            this.listViewTeach.Size = new System.Drawing.Size(835, 385);
            this.listViewTeach.TabIndex = 5;
            this.listViewTeach.TileSize = new System.Drawing.Size(1, 1);
            this.listViewTeach.UseCompatibleStateImageBehavior = false;
            this.listViewTeach.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "TeacherID";
            this.id.Width = 150;
            // 
            // fname
            // 
            this.fname.Text = "FirstName";
            this.fname.Width = 150;
            // 
            // lname
            // 
            this.lname.Text = "LastName";
            this.lname.Width = 150;
            // 
            // superv
            // 
            this.superv.Text = "Supervisor";
            this.superv.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.Location = new System.Drawing.Point(0, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(100, 23);
            this.lbl_Students.TabIndex = 0;
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.pictureBox2);
            this.pnlTeachers.Controls.Add(this.labteacher);
            this.pnlTeachers.Controls.Add(this.listViewTeachers);
            this.pnlTeachers.Location = new System.Drawing.Point(9, 31);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(1255, 482);
            this.pnlTeachers.TabIndex = 6;
            this.pnlTeachers.Tag = "TeacherID, FirstName, LastName";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(943, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 174);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labteacher
            // 
            this.labteacher.AutoSize = true;
            this.labteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.labteacher.Location = new System.Drawing.Point(19, 13);
            this.labteacher.Name = "labteacher";
            this.labteacher.Size = new System.Drawing.Size(137, 33);
            this.labteacher.TabIndex = 1;
            this.labteacher.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherID,
            this.FirstName,
            this.LastName,
            this.Supervisor});
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(50, 82);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(503, 354);
            this.listViewTeachers.TabIndex = 0;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // TeacherID
            // 
            this.TeacherID.Text = "teacherID";
            this.TeacherID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Firstname";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.Text = "Lastname";
            this.LastName.Width = 125;
            // 
            // Supervisor
            // 
            this.Supervisor.Text = "Supervisor";
            this.Supervisor.Width = 125;
            // 
            // panelRooms
            // 
            this.panelRooms.Controls.Add(this.label2);
            this.panelRooms.Controls.Add(this.listViewRooms);
            this.panelRooms.Location = new System.Drawing.Point(17, 32);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(1200, 576);
            this.panelRooms.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rooms";
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomID,
            this.Capacity,
            this.Type});
            this.listViewRooms.GridLines = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(20, 64);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(835, 385);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.TileSize = new System.Drawing.Size(1, 1);
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // RoomID
            // 
            this.RoomID.Text = "Room id";
            this.RoomID.Width = 150;
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            this.Capacity.Width = 150;
            // 
            // Type
            // 
            this.Type.Text = "Type (False = StudentRooms/True = TeacherRooms)";
            this.Type.Width = 150;
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // Revenuepnl
            // 
            this.Revenuepnl.Controls.Add(this.monthCalendar1);
            this.Revenuepnl.Controls.Add(this.label3);
            this.Revenuepnl.Location = new System.Drawing.Point(17, 31);
            this.Revenuepnl.Name = "Revenuepnl";
            this.Revenuepnl.Size = new System.Drawing.Size(1094, 500);
            this.Revenuepnl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Revenue";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.Revenuepnl);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelTeachers);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.panelTeachers.ResumeLayout(false);
            this.panelTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.Revenuepnl.ResumeLayout(false);
            this.Revenuepnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;

        private System.Windows.Forms.ColumnHeader studentDOB;      
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labteacher;
        private System.Windows.Forms.ColumnHeader TeacherID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Supervisor;


        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Panel panelTeachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTeach;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader superv;

        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader RoomID;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel Revenuepnl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
    }
}


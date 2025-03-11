namespace Quiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxAdvisor;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblAdvisorName;
        private System.Windows.Forms.TextBox txtAdvisorName;
        private System.Windows.Forms.Label lblAdvisorDepartment;
        private System.Windows.Forms.TextBox txtAdvisorDepartment;
        private System.Windows.Forms.Button btnAddAdvisor;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.TextBox txtStudentDepartment;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.Label lblStudentAdvisor;
        private System.Windows.Forms.TextBox txtStudentAdvisor;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblSearchAdvisor;
        private System.Windows.Forms.TextBox txtAdvisorSearch;
        private System.Windows.Forms.Button btnShowAdvisorStudents;
        private System.Windows.Forms.Button btnTopStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;

        private void InitializeComponent()
        {
            groupBoxAdvisor = new GroupBox();
            lblAdvisorName = new Label();
            txtAdvisorName = new TextBox();
            lblAdvisorDepartment = new Label();
            txtAdvisorDepartment = new TextBox();
            btnAddAdvisor = new Button();
            groupBoxStudent = new GroupBox();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblStudentDepartment = new Label();
            txtStudentDepartment = new TextBox();
            lblStudentGrade = new Label();
            txtStudentGrade = new TextBox();
            lblStudentAdvisor = new Label();
            txtStudentAdvisor = new TextBox();
            btnAddStudent = new Button();
            groupBoxSearch = new GroupBox();
            lblSearchAdvisor = new Label();
            txtAdvisorSearch = new TextBox();
            btnShowAdvisorStudents = new Button();
            btnTopStudent = new Button();
            dataGridViewStudents = new DataGridView();
            groupBoxAdvisor.SuspendLayout();
            groupBoxStudent.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAdvisor
            // 
            groupBoxAdvisor.Controls.Add(lblAdvisorName);
            groupBoxAdvisor.Controls.Add(txtAdvisorName);
            groupBoxAdvisor.Controls.Add(lblAdvisorDepartment);
            groupBoxAdvisor.Controls.Add(txtAdvisorDepartment);
            groupBoxAdvisor.Controls.Add(btnAddAdvisor);
            groupBoxAdvisor.Location = new Point(20, 20);
            groupBoxAdvisor.Name = "groupBoxAdvisor";
            groupBoxAdvisor.Size = new Size(350, 150);
            groupBoxAdvisor.TabIndex = 0;
            groupBoxAdvisor.TabStop = false;
            groupBoxAdvisor.Text = "เพิ่มอาจารย์ที่ปรึกษา";
            // 
            // lblAdvisorName
            // 
            lblAdvisorName.Location = new Point(10, 20);
            lblAdvisorName.Name = "lblAdvisorName";
            lblAdvisorName.Size = new Size(100, 23);
            lblAdvisorName.TabIndex = 0;
            lblAdvisorName.Text = "ชื่ออาจารย์";
            // 
            // txtAdvisorName
            // 
            txtAdvisorName.Location = new Point(120, 20);
            txtAdvisorName.Name = "txtAdvisorName";
            txtAdvisorName.Size = new Size(200, 23);
            txtAdvisorName.TabIndex = 1;
            // 
            // lblAdvisorDepartment
            // 
            lblAdvisorDepartment.Location = new Point(10, 50);
            lblAdvisorDepartment.Name = "lblAdvisorDepartment";
            lblAdvisorDepartment.Size = new Size(100, 23);
            lblAdvisorDepartment.TabIndex = 2;
            lblAdvisorDepartment.Text = "สาขา";
            // 
            // txtAdvisorDepartment
            // 
            txtAdvisorDepartment.Location = new Point(120, 50);
            txtAdvisorDepartment.Name = "txtAdvisorDepartment";
            txtAdvisorDepartment.Size = new Size(200, 23);
            txtAdvisorDepartment.TabIndex = 3;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(120, 80);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(75, 23);
            btnAddAdvisor.TabIndex = 4;
            btnAddAdvisor.Text = "เพิ่มอาจารย์";
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(lblStudentID);
            groupBoxStudent.Controls.Add(txtStudentID);
            groupBoxStudent.Controls.Add(lblStudentName);
            groupBoxStudent.Controls.Add(txtStudentName);
            groupBoxStudent.Controls.Add(lblStudentDepartment);
            groupBoxStudent.Controls.Add(txtStudentDepartment);
            groupBoxStudent.Controls.Add(lblStudentGrade);
            groupBoxStudent.Controls.Add(txtStudentGrade);
            groupBoxStudent.Controls.Add(lblStudentAdvisor);
            groupBoxStudent.Controls.Add(txtStudentAdvisor);
            groupBoxStudent.Controls.Add(btnAddStudent);
            groupBoxStudent.Location = new Point(20, 180);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Size = new Size(350, 250);
            groupBoxStudent.TabIndex = 1;
            groupBoxStudent.TabStop = false;
            groupBoxStudent.Text = "เพิ่มนักศึกษา";
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(10, 20);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(100, 23);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "รหัสนักศึกษา";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(120, 20);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(200, 23);
            txtStudentID.TabIndex = 1;
            // 
            // lblStudentName
            // 
            lblStudentName.Location = new Point(10, 50);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(100, 23);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "ชื่อนักศึกษา";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(120, 50);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(200, 23);
            txtStudentName.TabIndex = 3;
            // 
            // lblStudentDepartment
            // 
            lblStudentDepartment.Location = new Point(10, 80);
            lblStudentDepartment.Name = "lblStudentDepartment";
            lblStudentDepartment.Size = new Size(100, 23);
            lblStudentDepartment.TabIndex = 4;
            lblStudentDepartment.Text = "สาขา";
            // 
            // txtStudentDepartment
            // 
            txtStudentDepartment.Location = new Point(120, 80);
            txtStudentDepartment.Name = "txtStudentDepartment";
            txtStudentDepartment.Size = new Size(200, 23);
            txtStudentDepartment.TabIndex = 5;
            // 
            // lblStudentGrade
            // 
            lblStudentGrade.Location = new Point(10, 110);
            lblStudentGrade.Name = "lblStudentGrade";
            lblStudentGrade.Size = new Size(100, 23);
            lblStudentGrade.TabIndex = 6;
            lblStudentGrade.Text = "เกรด";
            // 
            // txtStudentGrade
            // 
            txtStudentGrade.Location = new Point(120, 110);
            txtStudentGrade.Name = "txtStudentGrade";
            txtStudentGrade.Size = new Size(200, 23);
            txtStudentGrade.TabIndex = 7;
            // 
            // lblStudentAdvisor
            // 
            lblStudentAdvisor.Location = new Point(10, 140);
            lblStudentAdvisor.Name = "lblStudentAdvisor";
            lblStudentAdvisor.Size = new Size(100, 23);
            lblStudentAdvisor.TabIndex = 8;
            lblStudentAdvisor.Text = "อาจารย์ที่ปรึกษา";
            // 
            // txtStudentAdvisor
            // 
            txtStudentAdvisor.Location = new Point(120, 140);
            txtStudentAdvisor.Name = "txtStudentAdvisor";
            txtStudentAdvisor.Size = new Size(200, 23);
            txtStudentAdvisor.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(120, 170);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(75, 23);
            btnAddStudent.TabIndex = 10;
            btnAddStudent.Text = "เพิ่มนักศึกษา";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(lblSearchAdvisor);
            groupBoxSearch.Controls.Add(txtAdvisorSearch);
            groupBoxSearch.Controls.Add(btnShowAdvisorStudents);
            groupBoxSearch.Controls.Add(btnTopStudent);
            groupBoxSearch.Location = new Point(20, 440);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(350, 120);
            groupBoxSearch.TabIndex = 2;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "ค้นหานักศึกษา";
            // 
            // lblSearchAdvisor
            // 
            lblSearchAdvisor.Location = new Point(10, 20);
            lblSearchAdvisor.Name = "lblSearchAdvisor";
            lblSearchAdvisor.Size = new Size(100, 23);
            lblSearchAdvisor.TabIndex = 0;
            lblSearchAdvisor.Text = "ชื่ออาจารย์";
            // 
            // txtAdvisorSearch
            // 
            txtAdvisorSearch.Location = new Point(120, 20);
            txtAdvisorSearch.Name = "txtAdvisorSearch";
            txtAdvisorSearch.Size = new Size(200, 23);
            txtAdvisorSearch.TabIndex = 1;
            // 
            // btnShowAdvisorStudents
            // 
            btnShowAdvisorStudents.Location = new Point(120, 50);
            btnShowAdvisorStudents.Name = "btnShowAdvisorStudents";
            btnShowAdvisorStudents.Size = new Size(107, 23);
            btnShowAdvisorStudents.TabIndex = 2;
            btnShowAdvisorStudents.Text = "แสดงนักศึกษา";
            btnShowAdvisorStudents.Click += btnShowAdvisorStudents_Click;
            // 
            // btnTopStudent
            // 
            btnTopStudent.Location = new Point(120, 80);
            btnTopStudent.Name = "btnTopStudent";
            btnTopStudent.Size = new Size(107, 23);
            btnTopStudent.TabIndex = 3;
            btnTopStudent.Text = "นักศึกษาที่ดีที่สุด";
            btnTopStudent.Click += btnTopStudent_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.Location = new Point(400, 20);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(372, 200);
            dataGridViewStudents.TabIndex = 3;
            // 
            // Form1
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBoxAdvisor);
            Controls.Add(groupBoxStudent);
            Controls.Add(groupBoxSearch);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ระบบบันทึกข้อมูลนักศึกษาและที่ปรึกษา";
            groupBoxAdvisor.ResumeLayout(false);
            groupBoxAdvisor.PerformLayout();
            groupBoxStudent.ResumeLayout(false);
            groupBoxStudent.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }
    }
}

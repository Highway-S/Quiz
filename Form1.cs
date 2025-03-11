using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string name = txtAdvisorName.Text;
            string department = txtAdvisorDepartment.Text;
            advisors.Add(new Advisor(name, department));
            MessageBox.Show("Added Advisor Successfully");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string name = txtStudentName.Text;
            string department = txtStudentDepartment.Text;
            double grade = double.Parse(txtStudentGrade.Text);
            string advisorName = txtStudentAdvisor.Text;

            // ค้นหาอาจารย์ที่ปรึกษาจากชื่อ
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);
            if (advisor == null)
            {
                MessageBox.Show("Advisor not found!");
                return;
            }

            // ตรวจสอบว่า นักศึกษาคนนี้ได้ถูกบันทึกในฐานข้อมูลแล้วหรือยัง
            if (students.Any(s => s.ID == id))
            {
                MessageBox.Show("This student is already added.");
                return;
            }

            // สร้างนักศึกษาใหม่ และเพิ่มนักศึกษาในอาจารย์ที่ปรึกษา
            Student student = new Student(id, name, department, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);  // เพิ่มนักศึกษาในที่ปรึกษา

            MessageBox.Show("Student Added Successfully");
            RefreshStudentGrid();
        }

        private void btnShowAdvisorStudents_Click(object sender, EventArgs e)
        {
            string advisorName = txtAdvisorSearch.Text;
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            if (advisor == null)
            {
                MessageBox.Show("Advisor not found!");
                return;
            }

            string studentList = string.Join("\n", advisor.GetStudentNames());
            MessageBox.Show(studentList != "" ? studentList : "No students assigned yet.");
        }

        private void btnTopStudent_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).First();
            MessageBox.Show($"Top Student: {topStudent.Name} - Grade: {topStudent.Grade}");
        }


        private void RefreshStudentGrid()
        {
            var studentData = students.Select(s => new
            {
                s.ID,
                s.Name,
                s.Department,
                s.Grade,
                AdvisorName = s.Advisor.Name // แสดงชื่ออาจารย์ที่ปรึกษา
            }).ToList();

            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = studentData;
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Person(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }

    public class Student : Person
    {
        public string ID { get; set; }
        public double Grade { get; set; }
        public Advisor Advisor { get; set; }

        public Student(string id, string name, string department, double grade, Advisor advisor) : base(name, department)
        {
            ID = id;
            Grade = grade;
            Advisor = advisor;
        }
    }

    public class Advisor : Person
    {
        private List<Student> advisees = new List<Student>();

        public Advisor(string name, string department) : base(name, department) { }

        public void AddStudent(Student student)
        {
            advisees.Add(student);
        }

        public List<string> GetStudentNames()
        {
            return advisees.Select(s => s.Name).ToList();
        }
    }
}

using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                panelTeachers.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                panelTeachers.Hide();

                // show students
                pnlStudents.Show();


                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    foreach (Student s in studentList)
                    {
                        string[] arr = new string[3];
                        arr[0] = s.studentID.ToString();
                        arr[1] = s.studentName;
                        //arr[2] = s.studentDOB.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Lecturers")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Show();
                
                panelTeachers.Show();

               
                try
                {

                   
                    // fill the students listview within the students panel with a list of students
                    TeacherService teachService = new TeacherService(); ;
                    List<Teacher> teacherList = teachService.GetTeachers(); ;
                   
                    
                    // clear the listview before filling it again
                    //listViewTeachers.Clear();

                   
                   
                    

                    foreach (Teacher t in teacherList)
                    {

                        ListViewItem li = new ListViewItem(t.Number.ToString());
                        listViewTeach.Items.Add(li);
                       

                        //ListViewItem li = new ListViewItem(t.Name);
                        //listViewTeachers.Items.Add(li);

                    }

                    foreach(Teacher t in teacherList)
                    {
                        ListViewItem li2 = new ListViewItem(t.FirstName.ToString());
                        listViewTeach.Items.Add(li2);
                       
                    }
                   
                   

                    foreach (Teacher t in teacherList)
                    {
                       
                        ListViewItem li3 = new ListViewItem(t.LastName.ToString());
                        listViewTeach.Items.Add(li3);
                    }

                   

                    foreach (Teacher t in teacherList)
                    {

                       ListViewItem li4 = new ListViewItem(t.Supervisor.ToString());
                       listViewTeach.Items.Add(li4);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
                }
            }
            
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }

    }
}

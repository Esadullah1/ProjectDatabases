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
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                Revenuepnl.Hide();

                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                listViewStudents.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                Revenuepnl.Hide();

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
                        arr[2] = s.DateOfBirth.ToString("dd/MM/yyyy");
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
                listViewTeach.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelRooms.Hide();
                Revenuepnl.Hide();

                panelTeachers.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    TeacherService teachService = new TeacherService(); ;
                    List<Teacher> teacherList = teachService.GetTeachers(); ;

                    foreach (Teacher t in teacherList)
                    {
                        string[] arr = new string[4];
                        arr[0] = t.Number.ToString();
                        arr[1] = t.TeacherFirstName;
                        arr[2] = t.TeacherLastName;
                        arr[3] = t.Supervisors.ToString();

                        ListViewItem li = new ListViewItem(arr);
                        listViewTeach.Items.Add(li);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
                }
            }
            else if (panelName == "Revenue")
            {
                listViewRooms.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();

                Revenuepnl.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    RevenueService revenueService = new RevenueService(); ;
                    List<Revenue> revenueList = revenueService.GetPrice();
                   

                    foreach (Revenue r in revenueList)
                    {
                        string[] arr = new string[2];
                        arr[0] = r.student.ToString();
                        arr[1] = r.drink.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        studentrevlist.Items.Add(li);
                    }

                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }




            }
            else if (panelName == "Rooms")
            {
                listViewRooms.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                Revenuepnl.Hide();

                panelRooms.Show();


                try
                {
                    // fill the students listview within the students panel with a list of students
                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms();

                    foreach (Room r in roomList)
                    {
                        string[] arr = new string[3];
                        arr[0] = r.RoomID.ToString();
                        arr[1] = r.Capacity.ToString();
                        arr[2] = r.Type.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        listViewRooms.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Rooms: " + e.Message);
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

        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            showPanel("Lecturers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            



        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String startdate = monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");
            String enddate = monthCalendar2.SelectionRange.Start.ToString("dd-MM-yyyy");

            

            

            
        }

        private void totalpricelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

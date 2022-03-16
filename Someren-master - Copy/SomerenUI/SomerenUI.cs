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
                panelCashRegister.Hide();

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
                panelCashRegister.Hide();

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
                panelCashRegister.Hide();

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
            else if (panelName == "Rooms")
            {
                listViewRooms.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelCashRegister.Hide();

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
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Cash register")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();

                panelCashRegister.Show();


                try
                {
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    foreach (Student s in studentList)
                    {
                        string studentName = s.studentName;
                        comboBox1.Items.Add(studentName);
                    }

                    DrinkService drinkService = new DrinkService(); ;
                    List<Drink> drinkList = drinkService.GetDrink(); ;

                    foreach (Drink d in drinkList)
                    {
                        //string[] arr = new string[1];
                        //string[] arr2 = new string[1];

                        //arr[0] = d.Price.ToString();
                        //arr2[0] = d.drinkName.ToString();
                        string drinkName = d.drinkName;
                        decimal price = d.Price;
                        comboBox2.Items.Add(drinkName);
                        comboBox3.Items.Add($"{price:0.00}");

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
                }
                
            }

        }
        void RemoveComboBox()
        {
            comboBox1.Items.RemoveAt(0);
            comboBox2.Items.RemoveAt(0);
            comboBox3.Items.RemoveAt(0);
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

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            showPanel("Cash register");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashRegisterService cashService = new CashRegisterService();
            MessageBox.Show($"Name of student: {comboBox1.SelectedItem}\nName of drink: {comboBox2.SelectedItem}\nPrice: {comboBox3.SelectedItem}\nDate of purchase: {monthCalendar1.SelectionStart.ToString("dd/MM/yyyy")}");
            cashService.AddCashRegister(comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), monthCalendar1.SelectionStart.ToString("dd/MM/yyyy"));
            
        }
    }
}

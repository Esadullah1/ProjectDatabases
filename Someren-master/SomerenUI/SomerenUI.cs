using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        Drinks deleteDrink;
        Drinks updateDrink;
        Drinks updateStock;

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
                panelDrink.Hide();
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
                panelDrink.Hide();
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
                panelDrink.Hide();
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
                panelDrink.Hide();
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
            else if (panelName == "Drinks")
            {
                listViewDrinks.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                panelDrink.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    DrinksService drinkService = new DrinksService();
                    List<Drinks> drinkList = drinkService.GetDrinks();

                    foreach (Drinks d in drinkList)
                    {


                        string[] arr = new string[6];
                        arr[0] = d.DrinkName;
                        arr[1] = d.Price.ToString("0.00");
                        arr[2] = d.Voucher.ToString();
                        arr[3] = d.Alcoholic.ToString();
                        arr[4] = d.Stock.ToString();
                        arr[5] = d.DrinkID.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        listViewDrinks.Items.Add(li);






                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
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



        private void drinksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void buttonDeleteDrink_Click(object sender, EventArgs e)
        {


            DrinksService drinksService = new DrinksService();
            drinksService.DeleteDrink(deleteDrink);
            showPanel("Drinks");


        }

        private void buttonUpdateDrink_Click(object sender, EventArgs e)
        {
            Drinks drinksUpdate = new Drinks();
            Drinks drinksStockUpdate = new Drinks();


            listViewDrinks.FocusedItem.SubItems[0].Text = txtUpdateDrink.Text;
            DrinksService drinksService = new DrinksService();
            drinksUpdate.DrinkName = listViewDrinks.FocusedItem.SubItems[0].Text;
            drinksUpdate.DrinkID = Convert.ToInt32(listViewDrinks.FocusedItem.SubItems[5].Text);

            listViewDrinks.FocusedItem.SubItems[4].Text = txtUpdateStockOfDrink.Text;
            
            drinksStockUpdate.Stock = Convert.ToInt32(listViewDrinks.FocusedItem.SubItems[4].Text);
            drinksStockUpdate.DrinkID = Convert.ToInt32(listViewDrinks.FocusedItem.SubItems[5].Text);


            this.updateDrink = drinksUpdate;
            this.updateStock = drinksStockUpdate;
            drinksService.UpdateDrink(updateDrink);
            drinksService.UpdateDrinkStock(drinksStockUpdate);
            txtUpdateDrink.Clear();
            txtUpdateStockOfDrink.Clear();
            showPanel("Drinks");
            



        }



        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drinks drinksDelete = new Drinks();
            drinksDelete.DrinkName = listViewDrinks.FocusedItem.SubItems[0].Text;
            txtUpdateDrink.Text = listViewDrinks.FocusedItem.SubItems[0].Text;
            txtUpdateStockOfDrink.Text = listViewDrinks.FocusedItem.SubItems[4].Text;
            this.deleteDrink = drinksDelete;



        }
    }
}

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

        Activity activityDelete;
        Activity activityidUpdate;
        Activity descriptionUpdate;



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
                Revenuepnl.Hide();
                panelCashRegister.Hide();
                pnlactivity.Hide();
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
                Revenuepnl.Hide();
                panelCashRegister.Hide();
                pnlactivity.Hide();
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
                panelDrink.Hide();
                Revenuepnl.Hide();
                pnlactivity.Hide();
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
                panelDrink.Hide();
                Revenuepnl.Hide();
                pnlactivity.Hide();
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
            else if (panelName == "Drinks")
            {
                listViewDrinks.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                Revenuepnl.Hide();
                panelRooms.Hide();
                panelCashRegister.Hide();
                pnlactivity.Hide();
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
                    MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
                }





            }
            else if (panelName == "Cash Register")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                panelDrink.Hide();
                Revenuepnl.Hide();
                pnlactivity.Hide();
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

                    DrinksService drinkService = new DrinksService(); ;
                    List<Drinks> drinkList = drinkService.GetDrinks();

                    foreach (Drinks d in drinkList)
                    {
                        //string[] arr = new string[1];
                        //string[] arr2 = new string[1];

                        //arr[0] = d.Price.ToString();
                        //arr2[0] = d.drinkName.ToString();
                        string drinkName = d.DrinkName;
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
            else if (panelName == "Revenue")
            {
                studentrevlist.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                panelCashRegister.Hide();
                panelDrink.Hide();
                pnlactivity.Hide();
                Revenuepnl.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    RevenueService revenueService = new RevenueService(); ;
                    List<Revenue> revenueList = revenueService.GetPrice();


                    foreach (Revenue r in revenueList)
                    {
                        string[] arr = new string[2];
                        arr[1] = r.student.ToString();
                        arr[0] = r.drink.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        studentrevlist.Items.Add(li);
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }

                try
                {
                    // fill the students listview within the students panel with a list of students
                    RevenueService revenueService = new RevenueService(); ;
                    List<studentrev> revenueList = revenueService.GetStudentNames();


                    foreach (studentrev r in revenueList)
                    {
                        string[] arr = new string[1];
                        arr[0] = r.student1.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        studentnameslist.Items.Add(li);
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }

                try
                {
                    // fill the students listview within the students panel with a list of students
                    RevenueService revenueService = new RevenueService(); ;
                    List<sumrev> revenueList = revenueService.GetSum();


                    foreach (sumrev r in revenueList)
                    {
                        string[] arr = new string[1];
                        arr[0] = r.price1.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        sumlist.Items.Add(li);
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }





            }
            else if (panelName == "Activity")
            {
                activitylist.Items.Clear();
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                panelTeachers.Hide();
                panelRooms.Hide();
                panelDrink.Hide();
                Revenuepnl.Hide();
                panelCashRegister.Hide();

                pnlactivity.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    ActivityService activityService = new ActivityService(); ;
                    List<Activity> ActivityList = activityService.GetActivity();


                    foreach (Activity r in ActivityList)
                    {
                        string[] arr = new string[5];
                        arr[0] = r.ActivityID.ToString();
                        arr[1] = r.Description.ToString();
                        arr[2] = r.StartDateTime.ToString();
                        arr[3] = r.EndDateTime.ToString();
                        arr[4] = r.ActivityNumber.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        activitylist.Items.Add(li);
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
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
            MessageBox.Show("Succesfully updated Drink Name and/or stock of drink");
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

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            showPanel("Cash Register");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveComboBox();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CashRegisterService cashService = new CashRegisterService();


            MessageBox.Show($"Name of student: {comboBox1.SelectedItem}\nName of drink: {comboBox2.SelectedItem}\nPrice: {comboBox3.SelectedItem}\nDate of purchase: {monthCalendar1.SelectionStart.ToString("dd/MM/yyyy")}");
            cashService.AddCashRegister(comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), monthCalendar1.SelectionStart.ToString("dd/MM/yyyy"));
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String startdate = monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");
            String enddate = monthCalendar2.SelectionRange.Start.ToString("dd-MM-yyyy");

            calanderlabel.Text = $"{startdate} -- {enddate}";


        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activity");
        }

        private void CreateActivity_Click(object sender, EventArgs e)
        {
            ActivityService activityservice = new ActivityService();


            MessageBox.Show($"ActivityID: {ActivityIDbox}\nDescription {DescriptionBox.Text}\nStartdate: {startdatecal.SelectionStart}\nEnddate: {enddatecal.SelectionEnd}\nActivityNumber: {ActivityNumberBox.Text.ToString()}");
            activityservice.AddActivities(ActivityIDbox.Text.ToString(), DescriptionBox.Text.ToString(), startdatecal.SelectionStart.ToString("dd/MM/yyyy"), enddatecal.SelectionEnd.ToString("dd/MM/yyyy"), ActivityNumberBox.Text.ToString());
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();

            showPanel("Activity");
        }

        private void enddatecal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void activitylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity deleteactivity = new Activity();
            deleteactivity.ActivityID = activitylist.FocusedItem.SubItems[0].Text;
            UpdateActivitybox.Text = activitylist.FocusedItem.SubItems[0].Text;
            updateDescriptionBox.Text = activitylist.FocusedItem.SubItems[1].Text;
            this.activityDelete = deleteactivity;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            activityService.DeleteActivity(activityDelete);

            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze activiteit wilt verwijderen?", "Weet u zeker dat u activiteit wilt verwijderen?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Activiteit verwijderd");
                ActivityService activityService1 = new ActivityService();
                activityService1.DeleteActivity(activityDelete);
                ActivityIDbox.Clear();
                DescriptionBox.Clear();
                ActivityNumberBox.Clear();
                UpdateActivitybox.Clear();
                updateDescriptionBox.Clear();
                showPanel("Activity");
            }
            else
            {
                MessageBox.Show("Activiteit niet verwijderd");
                showPanel("Activititeit Supervisors");
            }
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();        
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            showPanel("Activity");
        }

        private void UpdateActivity_Click(object sender, EventArgs e)
        {
            Activity activityidUpdate = new Activity();
            Activity descriptionUpdate = new Activity();


            activitylist.FocusedItem.SubItems[0].Text = UpdateActivitybox.Text;
            ActivityService activityService = new ActivityService();
            activityidUpdate.ActivityID = activitylist.FocusedItem.SubItems[0].Text;
            activityidUpdate.ActivityNumber = Convert.ToInt32(activitylist.FocusedItem.SubItems[4].Text);

            activitylist.FocusedItem.SubItems[1].Text = updateDescriptionBox.Text;

            descriptionUpdate.Description = (activitylist.FocusedItem.SubItems[1].Text);
            descriptionUpdate.ActivityNumber = Convert.ToInt32(activitylist.FocusedItem.SubItems[4].Text);


            this.activityidUpdate = activityidUpdate;
            this.descriptionUpdate = descriptionUpdate;
            activityService.UpdateActivityID(activityidUpdate);
            activityService.UpdateDescription(descriptionUpdate);
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();
            MessageBox.Show("Succesfully updated ActivityID and/or Description");
            showPanel("Activity");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}

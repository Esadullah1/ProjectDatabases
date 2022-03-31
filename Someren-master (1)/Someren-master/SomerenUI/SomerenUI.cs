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

        ActivityAdd selectActivityName;

        ActivityAdd activityDelete;
        ActivityAdd activityidUpdate;
        ActivityAdd descriptionUpdate;

        Activity updateActivity;
        Activity deleteSupervisor;
        Activity insertActivity;

        private bool guestAcces;
        private bool LoggedIn;

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            panelNames(LoginPanel);
        }
        private void buttonAsGuest_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
            guestAcces = true;
            LoggedIn = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            LoginService loginService = new LoginService(); ;
            List<Login> loginList = loginService.GetAllPasswords();
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            textBoxPassword.Text = pwHasher.ToString();
            if (textBoxUsername.Text == loginList[0].userName && pwHasher.ToString() == loginList[0].passWord)
            {
                showPanel("Dashboard");
                guestAcces = true;
                LoggedIn = true;
            }
            else if (textBoxUsername.Text == loginList[4].userName && pwHasher.ToString() == loginList[4].passWord)
            {
                showPanel("Dashboard");
                LoggedIn = true;
            }
            else
            {
                MessageBox.Show("Username or password is incorrect. please try again.");
                SomerenUI_Load(sender, e);
            }

        }
        private void panelNames(Panel panel)
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            panelRooms.Hide();
            panelCashRegister.Hide();
            panelDrink.Hide();
            Revenuepnl.Hide();
            panelParticipants.Hide();
            pnlactivity.Hide();
            pnlSupervisors.Hide();
            LoginPanel.Hide();
            panelTeachers.Hide();
            registerpanel.Hide();
            panel.Show();
        }
        
            private void showPanel(string panelName)
            {
            if (panelName == "Dashboard")
            {
                panelNames(pnlDashboard);

                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                panelNames(pnlStudents);
                listViewStudents.Items.Clear();

                try
                {
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    foreach (Student s in studentList)
                    {
                        string[] arr = new string[3];
                        arr[0] = s.studentID.ToString();
                        arr[1] = s.studentName;
                        arr[2] = s.DateOfBirth.ToString("dd/MM/yyyy");
                        listViewStudents.Items.Add(new ListViewItem(arr));

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Lecturers")
            {
                panelNames(panelTeachers);
                listViewTeach.Items.Clear();

                try
                {
                    TeacherService teachService = new TeacherService();
                    List<Teacher> teacherList = teachService.GetTeachers();

                    foreach (Teacher t in teacherList)
                    {
                        string[] arr = new string[4];
                        arr[0] = t.Number.ToString();
                        arr[1] = t.TeacherFirstName;
                        arr[2] = t.TeacherLastName;
                        arr[3] = t.Supervisors.ToString();
                        listViewTeach.Items.Add(new ListViewItem(arr));
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                panelNames(panelRooms);
                listViewRooms.Items.Clear();


                try
                {
                    RoomService roomService = new RoomService();
                    List<Room> roomList = roomService.GetRooms();

                    foreach (Room r in roomList)
                    {
                        string[] arr = new string[3];
                        arr[0] = r.RoomID.ToString();
                        arr[1] = r.Capacity.ToString();
                        arr[2] = r.Type.ToString();
                        listViewRooms.Items.Add(new ListViewItem(arr));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Rooms: " + e.Message);
                }
            }
            else if (panelName == "Drinks")
            {
                panelNames(panelDrink);
                listViewDrinks.Items.Clear();

                try
                {
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
                        listViewDrinks.Items.Add(new ListViewItem(arr));


                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
                }

            }
            else if (panelName == "Cash Register")
            {
                panelNames(panelCashRegister);
                listView2.Items.Clear();
                listView4.Items.Clear();

                try
                {
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    foreach (Student s in studentList)
                    {
                        listView2.Items.Add(new ListViewItem(s.studentName));
                    }

                    DrinksService drinkService = new DrinksService(); ;
                    List<Drinks> drinkList = drinkService.GetDrinks();

                    foreach (Drinks d in drinkList)
                    {
                        string[] arr = new string[2];
                        arr[0] = d.DrinkName;
                        arr[1] = $"{d.Price:0.00}";


                        listView4.Items.Add(new ListViewItem(arr));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
                }

            }
            else if (panelName == "Revenue")
            {
                panelNames(Revenuepnl);
                listViewRooms.Items.Clear();

                try
                {
                    RevenueService revenueService = new RevenueService();
                    List<Revenue> revenueList = revenueService.GetPrice();


                    foreach (Revenue r in revenueList)
                    {
                        string[] arr = new string[2];
                        arr[1] = r.student.ToString();
                        arr[0] = r.drink.ToString();
                        studentrevlist.Items.Add(new ListViewItem(arr));
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }

                try
                {
                    RevenueService revenueService = new RevenueService();
                    List<studentrev> revenueList = revenueService.GetStudentNames();


                    foreach (studentrev r in revenueList)
                    {
                        studentnameslist.Items.Add(new ListViewItem(r.student1.ToString()));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }

                try
                {
                    RevenueService revenueService = new RevenueService(); ;
                    List<sumrev> revenueList = revenueService.GetSum();


                    foreach (sumrev r in revenueList)
                    {
                        sumlist.Items.Add(new ListViewItem(r.price1.ToString()));
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }
            }
            else if (panelName == "Participants")
            {
                panelNames(panelParticipants);
                listViewParticipants.Items.Clear();
                listView1.Items.Clear();
                listViewParticipants3.Items.Clear();

                try
                {
                    ActivityAddService activity = new ActivityAddService();
                    List<ActivityAdd> activityList = activity.GetActivity();
                    
                    foreach (ActivityAdd d in activityList)
                    {
                        listViewParticipants.Items.Add(new ListViewItem(d.ActiviyID));
                    }
                    
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Participants: " + e.Message);
                }

            }
            else if (panelName == "Activity")
            {
                panelNames(pnlactivity);
                activitylist.Items.Clear();

                try
                {
                    
                    ActivityAddService activityService = new ActivityAddService(); ;
                    List<ActivityAdd> ActivityList = activityService.GetActivity();


                    foreach (ActivityAdd r in ActivityList)
                    {
                        string[] arr = new string[5];
                        arr[0] = r.ActiviyID.ToString();
                        arr[1] = r.Description.ToString();
                        arr[2] = r.StartDateTime.ToString();
                        arr[3] = r.EndDateTime.ToString();
                        arr[4] = r.ActivityNumber.ToString();

                        activitylist.Items.Add(new ListViewItem(arr));
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Revenue: " + e.Message);
                }
            }
            else if (panelName == "Activity Supervisors")
            {
                panelNames(pnlSupervisors);
                comboBoxActivityList.Items.Clear();
                listViewSupervisors.Items.Clear();
                listViewActivites.Items.Clear();
                txtNaamSupervisor.Clear();


                try
                {

                    ActivityService activityService = new ActivityService(); ;
                    List<Activity> activitiesList = activityService.GetActivitiesSupervisors();

                    foreach (Activity a in activitiesList)
                    {
                        string[] arr = new string[3];
                        arr[0] = a.SupervisorName;
                        arr[1] = a.ActivityName;
                        arr[2] = a.ActivityNumber.ToString();
                        ListViewItem li = new ListViewItem(arr);
                        listViewActivites.Items.Add(li);

                    }

                    TeacherService teachService = new TeacherService(); ;
                    List<Teacher> teacherList = teachService.GetTeachers(); ;

                    foreach (Teacher t in teacherList)
                    {
                        listViewSupervisors.Items.Add(t.TeacherFirstName);
                    }


                    List<Activity> activities = activityService.GetAllActivities();

                    foreach (Activity a in activities)
                    {
                        comboBoxActivityList.Items.Add(a.ActivityName.ToString());

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Lecturers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Rooms");
        }

        private void drinksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Drinks");
        }
        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Cash Register");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Revenue");
        }
        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Participants");
        }
        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!LoggedIn)
            {
                return;
            }

            showPanel("Activity");
        }
        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                return;
            }

            showPanel("Activity Supervisors");
        }

        private void buttonDeleteDrink_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            DrinksService drinksService = new DrinksService();
            drinksService.DeleteDrink(deleteDrink);
            showPanel("Drinks");
        }

        private void buttonUpdateDrink_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            CashRegisterService cashService = new CashRegisterService();
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("You did not select a student");
               
            }
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("You did not select a drink");

            }
            else if (listView2.SelectedItems.Count != 0 && listView4.SelectedItems.Count != 0)
            {
                MessageBox.Show($"Name of student: {listView2.SelectedItems[0].Text}\nName of drink: {listView4.SelectedItems[0].Text}\nPrice: {listView4.FocusedItem.SubItems[1].Text}\nDate of purchase: {DateTime.Today.ToString("dd/MM/yyyy")}");
                cashService.AddCashRegister(listView4.SelectedItems[0].Text.ToString(), listView2.SelectedItems[0].Text.ToString(), listView4.FocusedItem.SubItems[1].Text.ToString(), DateTime.Today.ToString("dd/MM/yyyy"));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            String startdate = DateTime.Today.ToString("dd-MM-yyyy");
            String enddate = monthCalendar2.SelectionRange.Start.ToString("dd-MM-yyyy");

            calanderlabel.Text = $"{startdate} -- {enddate}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewParticipants.SelectedItems.Count != 0)
            {
                listView1.Items.Clear();
                listViewParticipants3.Items.Clear();

                ActivityAdd selectActivityName = new ActivityAdd();
                selectActivityName.ActiviyID = listViewParticipants.SelectedItems[0].Text;

                this.selectActivityName = selectActivityName;

                ActivityStudentService st = new ActivityStudentService();
                st.SelectActivities(selectActivityName);

                ActivityService activity = new ActivityService();
                List<Activity> activityList = activity.GetAllActivities();

                for (int i = 0; i < activityList.Count; i++)
                {

                    if (listViewParticipants.FocusedItem.SubItems[0].Text == activityList[i].ActiviyID.ToString())
                    {
                        ActivityStudentService actStudService = new ActivityStudentService();
                        List<ActivityStudents> acitvityStudentList = actStudService.SelectActivities(selectActivityName);


                        foreach (ActivityStudents a in acitvityStudentList)
                        {
                            listView1.Items.Add(new ListViewItem(a.StudentID.ToString()));
                        }

                        ParticipatingService partService = new ParticipatingService();
                        List<Participating> partList = partService.GetAllParticipaters();

                        foreach (Participating p in partList)
                        {
                            listViewParticipants3.Items.Add(new ListViewItem(p.NotParticipatingStudents.ToString()));

                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not select an acitvity");
            }
        }

        private void ButtonAddParticipant_Click_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            if (listViewParticipants3.SelectedItems.Count != 0)
            {
                Activity selectActivityName = new Activity();
                selectActivityName.ActiviyID = listViewParticipants.SelectedItems[0].Text;

                ActivityStudents selectStudent = new ActivityStudents();
                selectStudent.StudentID = int.Parse(listViewParticipants3.FocusedItem.SubItems[0].Text);

                ParticipatingService participatingService = new ParticipatingService();
                participatingService.AddParticipant(selectStudent.StudentID, selectActivityName.ActiviyID);
                MessageBox.Show($"student {selectStudent.StudentID} added to {selectActivityName.ActiviyID}");
            }
            else
            {
                MessageBox.Show("You did not select a not participating student");
            }
        }

        private void ButtonRemoveParticipants_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            if (listView1.SelectedItems.Count != 0)
            {
                Activity selectActivityName = new Activity();
                selectActivityName.ActiviyID = listViewParticipants.SelectedItems[0].Text;

                ActivityStudents selectStudent = new ActivityStudents();
                selectStudent.StudentID = int.Parse(listView1.SelectedItems[0].Text);

                DialogResult dialogResult = MessageBox.Show($"Are you sure that you wish to remove student {selectStudent.StudentID}", "", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    ParticipatingService participatingService = new ParticipatingService();
                    participatingService.RemoveParticipant(selectStudent.StudentID, selectActivityName.ActiviyID);
                    MessageBox.Show($"student {selectStudent.StudentID} removed");
                }
                else if(dialogResult == DialogResult.No)
                {
                    MessageBox.Show($"Removing student canceled");
                }

            }
            else
            {
                MessageBox.Show("You did not select a participating student");
            }
        }

        private void CreateActivity_Click_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            ActivityAddService activityservice = new ActivityAddService();

            MessageBox.Show($"ActivityID: {ActivityIDbox}\nDescription {DescriptionBox.Text}\nStartdate: {startdatecal.SelectionStart}\nEnddate: {enddatecal.SelectionEnd}\nActivityNumber: {ActivityNumberBox.Text.ToString()}");
            activityservice.AddActivities(ActivityIDbox.Text.ToString(), DescriptionBox.Text.ToString(), startdatecal.SelectionStart.ToString("dd/MM/yyyy"), enddatecal.SelectionEnd.ToString("dd/MM/yyyy"), ActivityNumberBox.Text.ToString());
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();

            showPanel("Activity");
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            ActivityAddService activityService = new ActivityAddService();
            activityService.DeleteActivity(activityDelete);

            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze activiteit wilt verwijderen?", "Weet u zeker dat u activiteit wilt verwijderen?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Activiteit verwijderd");
                activityService.DeleteActivity(activityDelete);
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
                showPanel("Activity");
            }
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            showPanel("Activity");
        }

        private void UpdateActivity_Click_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            ActivityAdd activityidUpdate = new ActivityAdd();
            ActivityAdd descriptionUpdate = new ActivityAdd();


            activitylist.FocusedItem.SubItems[0].Text = UpdateActivitybox.Text;
            ActivityAddService activityAddService = new ActivityAddService();
            activityidUpdate.ActiviyID = activitylist.FocusedItem.SubItems[0].Text;
            activityidUpdate.ActivityNumber = Convert.ToInt32(activitylist.FocusedItem.SubItems[4].Text);

            activitylist.FocusedItem.SubItems[1].Text = updateDescriptionBox.Text;

            descriptionUpdate.Description = (activitylist.FocusedItem.SubItems[1].Text);
            descriptionUpdate.ActivityNumber = Convert.ToInt32(activitylist.FocusedItem.SubItems[4].Text);


            this.activityidUpdate = activityidUpdate;
            this.descriptionUpdate = descriptionUpdate;
            activityAddService.UpdateActivityID(activityidUpdate);
            activityAddService.UpdateDescription(descriptionUpdate);
            UpdateActivitybox.Clear();
            updateDescriptionBox.Clear();
            ActivityIDbox.Clear();
            DescriptionBox.Clear();
            ActivityNumberBox.Clear();
            MessageBox.Show("Succesfully updated ActivityID and/or Description");
            showPanel("Activity");
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            Activity activityUpdate = new Activity();

            try
            {
                ActivityService activityService = new ActivityService();
                listViewActivites.FocusedItem.SubItems[0].Text = listViewSupervisors.FocusedItem.SubItems[0].Text;
                activityUpdate.SupervisorName = listViewActivites.FocusedItem.SubItems[0].Text;
                activityUpdate.ActivityNumber = listViewActivites.FocusedItem.SubItems[2].Text;


                this.updateActivity = activityUpdate;

                activityService.AddSupervisor(activityUpdate);
                MessageBox.Show("Supervisor succesvol toegevoegd!");
                showPanel("Activity Supervisors");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to add an supervisor" + ex.Message);
            }

        }

        private void btnDeleteSupervisor_Click(object sender, EventArgs e)
        {
            if(guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze supervisor wilt verwijderen?", "Weet u zeker dat u deze supervisor wilt verwijderen?", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Supervisor verwijderd");
                ActivityService activityService = new ActivityService();
                activityService.DeleteSupervisor(deleteSupervisor);
                showPanel("Activity Supervisors");
            }
            else
            {
                MessageBox.Show("Supervisor niet verwijderd");
                showPanel("Activity Supervisors");
            }
        }
        

        private void listViewActivites_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Activity activityDelete = new Activity();
            activityDelete.SupervisorName = listViewActivites.FocusedItem.SubItems[0].Text;
            activityDelete.ActivityNumber = listViewActivites.FocusedItem.SubItems[2].Text;
            txtNaamSupervisor.Text = listViewActivites.FocusedItem.SubItems[0].Text;
            this.deleteSupervisor = activityDelete;
        }

        private void activitylist_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            ActivityAdd deleteactivity = new ActivityAdd();
            deleteactivity.ActiviyID = activitylist.FocusedItem.SubItems[0].Text;
            UpdateActivitybox.Text = activitylist.FocusedItem.SubItems[0].Text;
            updateDescriptionBox.Text = activitylist.FocusedItem.SubItems[1].Text;
            this.activityDelete = deleteactivity;
        }

        private void comboBoxActivityList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            Activity activityInsert = new Activity();

            activityInsert.ActivityName = comboBoxActivityList.SelectedItem.ToString();

            this.insertActivity = activityInsert;
        }

        private void btnAddActivity_Click_1(object sender, EventArgs e)
        {
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }

            ActivityService activityService = new ActivityService();
            activityService.InsertIntoActivity(insertActivity);
            showPanel("Activity Supervisors");
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            panelNames(registerpanel);

        }

        private void registrerenknop_Click(object sender, EventArgs e)
        {
            string code = codebox.Text;
            
            if (guestAcces)
            {
                MessageBox.Show("Sorry... You dont have acces to add, change or delete data from this page.");
                return;
            }
            switch (code)
            {
                case "XsZAb-tgz3PsD-qYh69un-WQCEx":
                    PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                    passwordbox.Text = pwHasher.ToString();
                    registerenService registrerenservice = new registerenService();
                        MessageBox.Show($"u succesfully made an account with this username: {usernamebox}");
                        registrerenservice.Addregistreren(usernamebox.Text.ToString(), pwHasher.ToString());
                        panelNames(LoginPanel);                    
                    break;

                default:
                    MessageBox.Show("Please verify the code and try again");
                    break;
                    

                
                    

                    
            }
           

        }
    }
}

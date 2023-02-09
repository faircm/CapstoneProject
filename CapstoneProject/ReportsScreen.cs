using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class ReportsScreen : Form
    {
        private MySqlDataReader reader;
        private MySqlCommand userCmd = new MySqlCommand($"SELECT userName, userId FROM user", DatabaseConnection.connection);

        private byte selectedReport = 0;
        private List<Appointment> userAppts = new List<Appointment>();
        private List<Appointment> custAppts = new List<Appointment>();

        // Create a dictionary to hold user IDs and easily readable usernames.
        private Dictionary<int, string> userDict = new Dictionary<int, string>();

        // Create a dictionary to hold customer IDs and easily readable customer names
        private Dictionary<int, string> custDict = new Dictionary<int, string>();

        private List<string> apptList = new List<string>();


        public ReportsScreen()
        {
            InitializeComponent();
            monthSelectBox.Text = "Select month";
            userSelectBox.Text = "Select user";
            custSelectBox.Text = "Select customer";

            // BEGIN: User combobox data source creation

            reader = userCmd.ExecuteReader();

            // Populate dictionary with usernames
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int userId = (int)reader.GetValue(reader.GetOrdinal("userId"));
                    string userName = (string)reader.GetValue(reader.GetOrdinal("userName"));
                    if (!userDict.ContainsKey(userId))
                    {
                        userDict.Add(userId, userName);
                    }
                }
            }
            reader.Close();
            foreach (string value in userDict.Values)
            {
                userSelectBox.Items.Add(value);
            }
            // END: User combobox data source creation

            // BEGIN: Customer combobox data source creation

            foreach (Customer cust in Customer.custList)
            {
                if (!custDict.ContainsKey(cust.Id))
                {
                    custDict.Add(cust.Id, cust.customerName);
                }
            }
            foreach (string value in custDict.Values)
            {
                custSelectBox.Items.Add(value);
            }
            // END: Customer combobox data source creation
        }

        private void apptTypeReportBtn_Click(object sender, EventArgs e)
        {
            selectedReport = 1;

            int numPresentation = 0;
            int numScrum = 0;
            int numCodeRev = 0;
            int numSprintPlan = 0;
            int numSprintRev = 0;
            int numBacklog = 0;
            int numRetrospective = 0;
            int numReleasePlan = 0;
            int numOneOnOne = 0;
            int numTeamBuilding = 0;
            int numQuarterlyRev = 0;
            int numAllHands = 0;
            int numOther = 0;
            int numTest = 0;

            List<Appointment> appointments = Appointment.apptList;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < appointments.Count; i++)
            {
                if (DateTime.Parse(appointments[i].start).Month == monthSelectBox.SelectedIndex + 1)
                {
                    switch (appointments[i].type)
                    {
                        case "Presentation":
                            numPresentation++;
                            break;

                        case "Scrum":
                            numScrum++;
                            break;

                        case "Code Review":
                            numCodeRev++;
                            break;

                        case "Sprint Planning":
                            numSprintPlan++;
                            break;

                        case "Sprint Review":
                            numSprintRev++;
                            break;

                        case "Backlog Refinement":
                            numBacklog++;
                            break;

                        case "Retrospective":
                            numRetrospective++;
                            break;

                        case "Release Planning":
                            numReleasePlan++;
                            break;

                        case "One-on-one":
                            numOneOnOne++;
                            break;

                        case "Team Building":
                            numTeamBuilding++;
                            break;

                        case "Quarterly review":
                            numQuarterlyRev++;
                            break;

                        case "All-hands":
                            numAllHands++;
                            break;

                        case "Other":
                            numOther++;
                            break;

                        case "test":
                            numTest++;
                            break;

                        default:
                            numOther++;
                            break;
                    }
                }
            }
            apptList.Add(monthSelectBox.SelectedItem.ToString());
            apptList.Add($"Number of Presentation meetings: {numPresentation}");
            apptList.Add($"Number of Scrum meetings: {numScrum}");
            apptList.Add($"Number of Code Review meetings: {numCodeRev}");
            apptList.Add($"Number of Sprint Planning meetings: {numSprintPlan}");
            apptList.Add($"Number of Sprint Review meetings: {numSprintRev}");
            apptList.Add($"Number of Backlog Refinement meetings: {numBacklog}");
            apptList.Add($"Number of Retrospective meetings: {numRetrospective}");
            apptList.Add($"Number of Release Planning meetings: {numReleasePlan}");
            apptList.Add($"Number of One-on-one meetings: {numOneOnOne}");
            apptList.Add($"Number of Team Building meetings: {numTeamBuilding}");
            apptList.Add($"Number of Quarterly review meetings: {numQuarterlyRev}");
            apptList.Add($"Number of All-hands meetings: {numAllHands}");
            apptList.Add($"Number of Other meetings: {numOther}");
            apptList.Add($"Number of test meetings: {numTest}");

            foreach (string appt in apptList)
            {
                apptCountBox.Text += appt + "\n\n";
            }
            
            apptCountBox.Visible = true;
        }

        private void userSchedBtn_Click(object sender, EventArgs e)
        {
            selectedReport = 2;
            int userId = userSelectBox.SelectedIndex + 1;
            userAppts = Appointment.getCurrentUserAppts(userId);
            ReportViewer.DataSource = userAppts;
            apptCountBox.Visible = false;
        }

        private void custSchedBtn_Click(object sender, EventArgs e)
        {
            selectedReport = 3;
            int custId = custSelectBox.SelectedIndex + 1;
            custAppts = Appointment.getCustAppts(custId);
            ReportViewer.DataSource = custAppts;
            apptCountBox.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 7 FEB 2023 - Added download report functionality
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if(selectedReport == 1)
            {
                StreamWriter writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "appointmentList.csv"));

                foreach (string appt in apptList)
                {
                    writer.Write(appt + "\n");
                    writer.Flush();
                }
                MessageBox.Show("Meeting report downloaded to My Documents folder", "Success", MessageBoxButtons.OK);
                writer.Close();
            } else if(selectedReport == 2)
            {
                StreamWriter writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userAppointments.csv"));
                foreach (Appointment appt in userAppts)
                {
                    
                    writer.Write(appt.toString());
                }
                MessageBox.Show("User schedule downloaded to My Documents folder", "Success", MessageBoxButtons.OK);
                writer.Close();
            } else if(selectedReport == 3)
            {
                StreamWriter writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "customerAppointments.csv"));
                
                foreach (Appointment appt in custAppts)
                {
                    writer.Write(appt.toString());
                }
                MessageBox.Show("Customer schedule downloaded to My Documents folder", "Success", MessageBoxButtons.OK);
                writer.Close();
            }
        }
    }
}
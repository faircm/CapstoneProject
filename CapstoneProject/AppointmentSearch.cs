using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AppointmentSearch : Form
    {
        string searchStr = "SELECT * FROM appointment WHERE";
        string savedSearchStr = "";
        public AppointmentSearch()
        {
            InitializeComponent();
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Set flag to determine if query has multiple parameters
            bool flag = false;
            DateTime startDateTime = startDatePicker.Value;
            DateTime endDateTime = endDatePicker.Value;
            string startDateTimeStr = startDateTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string endDateTimeStr = endDateTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (idBox.Text.Length > 0)
            {
                searchStr += $" appointmentId = {idBox.Text}";
                flag = true;
            }

            if (nameBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND customerId = {Customer.getIdByName(nameBox.Text)}";
            }
            else if (nameBox.Text.Length > 0 && !flag)
            {
                searchStr += $" customerId = {Customer.getIdByName(nameBox.Text)}";
                flag = true;
            }


            if (titleBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND title = \'{titleBox.Text}\'";
            }
            else if (titleBox.Text.Length > 0 && !flag)
            {
                searchStr += $" title = \'{titleBox.Text}\'";
                flag = true;
            }

            if (locationBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND location = \'{locationBox.Text}\'";
            }
            else if (locationBox.Text.Length > 0 && !flag)
            {
                searchStr += $" location = \'{locationBox.Text}\'";
                flag = true;
            }
            if (typeBox.SelectedItem != null && typeBox.SelectedItem.ToString().Length > 0 && flag)
            {
                searchStr += $" AND type = \'{typeBox.SelectedItem.ToString()}\'";
            }
            else if (typeBox.SelectedItem != null && typeBox.SelectedItem.ToString().Length > 0 && !flag)
            {
                searchStr += $" type = \'{typeBox.SelectedItem.ToString()}\'";
                flag = true;
            }
            if (startDatePicker.Value > endDatePicker.Value)
            {
                MessageBox.Show("Start time must occur before end time.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchStr = "SELECT * FROM appointment WHERE";
                return;
            }
            else
            {
                if (flag)
                {
                    searchStr += $" AND start >= \'{startDateTimeStr}\' AND end <= \'{endDateTimeStr}\'";
                }
                else
                {
                    searchStr += $" start >= \'{startDateTimeStr}\' AND end <= \'{endDateTimeStr}\'";
                }
            }
            if (searchStr == "SELECT * FROM appointment WHERE")
            {
                return;
            }

            searchStr += ";";
            apptList.DataSource = Appointment.getAppts(searchStr);
            savedSearchStr = searchStr;
            searchStr = "SELECT * FROM appointment WHERE";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modApptBtn_Click(object sender, EventArgs e)
        {
            bool isNull = (apptList.CurrentRow == null) ? true : false;
            if (isNull)
            {
                return;
            }
            ModifyAppointmentScreen modifyAppointmentScreen = new ModifyAppointmentScreen(apptList.CurrentRow);
            modifyAppointmentScreen.Show();
            modifyAppointmentScreen.Focus();
        }

        private void delApptBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            if (apptList.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewSelectedRowCollection deleteRows = apptList.SelectedRows;
            Appointment delAppt = (Appointment)deleteRows[0].DataBoundItem;
            MySqlCommand delCmd = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = {delAppt.Id}", DatabaseConnection.connection);
            reader = delCmd.ExecuteReader();
            reader.Close();
            apptList.DataSource = Appointment.getAppts(savedSearchStr);
        }

        private void refreshList(object sender, EventArgs e)
        {
            apptList.DataSource = null;
            apptList.DataSource = Appointment.getAppts(savedSearchStr);
        }
    }
}

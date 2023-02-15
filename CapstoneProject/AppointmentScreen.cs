using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AppointmentScreen : Form
    {
        private AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen();

        public AppointmentScreen()
        {
            InitializeComponent();
            appointmentList.DataSource = Appointment.apptList;
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen(); ;
            addAppointmentScreen.Show();
            addAppointmentScreen.Focus();
        }

        private void modApptBtn_Click(object sender, EventArgs e)
        {
            ModifyAppointmentScreen modifyAppointmentScreen = new ModifyAppointmentScreen(appointmentList.CurrentRow);
            modifyAppointmentScreen.Show();
            modifyAppointmentScreen.Focus();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            appointmentList.DataSource = null;
            appointmentList.DataSource = Appointment.apptList;
        }

        private void delApptBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = appointmentList.SelectedRows;

            foreach (DataGridViewRow row in deleteRows)
            {
                Appointment newAppt = (Appointment)row.DataBoundItem;
                MySqlCommand command = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = {newAppt.Id}", DatabaseConnection.connection);
                reader = command.ExecuteReader();
                reader.Close();

                Appointment.apptList.Remove(newAppt);
            }
        }

        private void AppointmentScreen_Enter(object sender, EventArgs e)
        {
            appointmentList.DataSource = null;
            appointmentList.DataSource = Appointment.apptList;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen(this);
            searchScreen.Show();
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AppointmentScreen : Form
    {

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
            bool isNull = (appointmentList.CurrentRow == null) ? true : false;
            if (isNull)
            {
                return;
            }
            ModifyAppointmentScreen modifyAppointmentScreen = new ModifyAppointmentScreen(appointmentList.CurrentRow);
            modifyAppointmentScreen.Show();
            modifyAppointmentScreen.Focus();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            appointmentList.DataSource = null;
            Appointment.apptList = Appointment.getAppts();
            appointmentList.DataSource = Appointment.apptList;
        }

        private void delApptBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            if (appointmentList.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewSelectedRowCollection deleteRows = appointmentList.SelectedRows;
            foreach (DataGridViewRow row in deleteRows)
            {
                Appointment newAppt = (Appointment)row.DataBoundItem;
                MySqlCommand command = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = {newAppt.Id}", DatabaseConnection.connection);
                reader = command.ExecuteReader();
                reader.Close();

                Appointment.apptList.Remove(newAppt);
            }

            refreshBtn_Click(null, null);

            /*            appointmentList.DataSource = null;
                        Appointment.apptList = Appointment.getAppts();
                        appointmentList.DataSource = Appointment.apptList;*/

        }

        private void AppointmentScreen_Enter(object sender, EventArgs e)
        {
            appointmentList.DataSource = null;
            appointmentList.DataSource = Appointment.apptList;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //IMPLEMENT
            AppointmentSearch appointmentSearch = new AppointmentSearch();
            appointmentSearch.Show();
            appointmentSearch.Focus();
        }
    }
}
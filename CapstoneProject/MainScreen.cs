using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            userApptList.DataSource = Appointment.getCurrentUserAppts(userContext.getUserId());
            Appointment.appointmentReminder();
            apptCalendar.AddBoldedDate(DateTime.Now);
            apptCalendar.SelectionStart = DateTime.Now;
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            AppointmentScreen appointmentScreen = new AppointmentScreen();
            appointmentScreen.Show();
        }

        private void closeBtn_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            userApptList.DataSource = null;
            userApptList.DataSource = Appointment.getCurrentUserAppts(userContext.getUserId());
            defaultViewBtn.Checked = true;
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsScreen reportsScreen = new ReportsScreen();
            reportsScreen.Show();
            reportsScreen.Focus();
        }

        private void addressBtn_Click(object sender, EventArgs e)
        {
            AddressScreen addressScreen = new AddressScreen();
            addressScreen.Show();
            addressScreen.Focus();
        }

        private void dayViewBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dayViewBtn.Checked)
            {
                // Ensure selection range consists of solely the selected date.
                apptCalendar.SelectionEnd = apptCalendar.SelectionStart;

                // Return all appointments that start on the user-provided date.
                userApptList.DataSource = Appointment.findUserApptByDate(userContext.getUserId(), apptCalendar.SelectionStart, apptCalendar.SelectionEnd);
            }
        }

        private void weekViewBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (weekViewBtn.Checked)
            {
                // Retrieve an integer representation of the day of the week
                int dayOfWeekAdjustment = (int)apptCalendar.SelectionStart.DayOfWeek + 1;
                // Remove value of current day of the week in order to calculate the actual start of the week.
                DateTime adjustedStart = apptCalendar.SelectionStart - TimeSpan.FromDays(dayOfWeekAdjustment);
                // Assign the previously calculated DateTime as the start of the selection.
                apptCalendar.SelectionStart = adjustedStart;
                // Add 7 days to the selection start in order to select end of the week as the end of the selection.
                apptCalendar.SelectionEnd = apptCalendar.SelectionStart.AddDays(7);

                // Return all appointments with a start date in the provided range
                userApptList.DataSource = Appointment.findUserApptByDate(userContext.getUserId(), apptCalendar.SelectionStart, apptCalendar.SelectionEnd);
            }
        }

        private void monthViewBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (monthViewBtn.Checked)
            {
                // Determine month and year of selected date
                int selectedMonth = apptCalendar.SelectionStart.Month;
                int selectedYear = apptCalendar.SelectionStart.Year;

                // Create new DateTime object to reflect selected month and year
                string convertToDT = $"{selectedMonth}/1/{selectedYear}";
                DateTime convertedDate = DateTime.Parse(convertToDT);

                // Return all appointments with a matching month and year.
                userApptList.DataSource = Appointment.findUserApptByDate(userContext.getUserId(), convertedDate);
            }
        }

        private void defaultViewBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultViewBtn.Checked)
            {
                userApptList.DataSource = Appointment.getCurrentUserAppts(userContext.getUserId());
            }
        }
    }
}
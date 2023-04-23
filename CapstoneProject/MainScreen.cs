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

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (dayViewBtn.Checked)
            {
                apptCalendar.SelectionStart = apptCalendar.SelectionEnd;
                userApptList.DataSource = Appointment.findUserApptByDate(
                    userContext.getUserId(),
                    apptCalendar.SelectionStart,
                    "day"
                );
            }
            else if (weekViewBtn.Checked)
            {
                int dayOfWeek = (int)apptCalendar.SelectionStart.DayOfWeek + 1;
                DateTime newStart = apptCalendar.SelectionStart.AddDays((-dayOfWeek));
                apptCalendar.SelectionStart = newStart.AddHours(11).AddMinutes(59).AddSeconds(59);
                apptCalendar.SelectionEnd = apptCalendar.SelectionStart
                    .AddDays(7)
                    .AddHours(11)
                    .AddMinutes(59)
                    .AddSeconds(59);
                userApptList.DataSource = Appointment.findUserApptByDate(
                    userContext.getUserId(),
                    apptCalendar.SelectionStart,
                    apptCalendar.SelectionEnd
                );
            }
            else if (monthViewBtn.Checked)
            {
                int selectedMonth = apptCalendar.SelectionStart.Month;
                int selectedYear = apptCalendar.SelectionStart.Year;
                string convertToDT = $"{selectedMonth}/1/{selectedYear}";
                DateTime convertedDate = DateTime.Parse(convertToDT);
                userApptList.DataSource = Appointment.findUserApptByDate(
                    userContext.getUserId(),
                    convertedDate,
                    "month"
                );
            }
            else
            {
                userApptList.DataSource = Appointment.getCurrentUserAppts(userContext.getUserId());
            }
        }
    }
}

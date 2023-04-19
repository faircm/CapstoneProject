using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AddAppointmentScreen : Form
    {
        public AddAppointmentScreen()
        {
            InitializeComponent();
            if (Appointment.apptList.Count == 0)
            {
                apptIdBox.Text = "1";
            }
            else
            {
                apptIdBox.Text = (Appointment.apptList[Appointment.apptList.Count - 1].Id + 1).ToString();
            }

            userIdBox.Text = userContext.getUserId().ToString();
            lastUpdatePicker.Value = DateTime.Now;
            createDatePicker.Value = DateTime.Now;

            createdByBox.Text = userContext.getUsername();
            lastUpdateByBox.Text = userContext.getUsername();

            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool custExists = false;
            try
            {
                if (startTimePicker.Value.Hour < 9 || (startTimePicker.Value.Hour == 17 && (startTimePicker.Value.Minute > 0 || startTimePicker.Value.Second > 0)) || (endTimePicker.Value.Hour < 9 || (endTimePicker.Value.Hour == 17 && (endTimePicker.Value.Minute > 0 || endTimePicker.Value.Second > 0))))
                {
                    throw new BusinessHoursException();
                }

                foreach (Appointment appt in Appointment.apptList)
                {
                    // Cycle through all appointments to check for time conflicts. This includes a nested check to ensure the appointment won't cause a scheduling issue for any users or customers.
                    if (appt.Id == Int32.Parse(apptIdBox.Text))
                    {
                        continue;
                    }
                    else
                    {
                        if ((startTimePicker.Value < DateTime.Parse(appt.end) && endTimePicker.Value > DateTime.Parse(appt.start)))
                        {
                            if (Int32.Parse(userIdBox.Text) == appt.userId || Int32.Parse(custIdBox.Text) == appt.customerId)
                            {
                                throw new ScheduleConflictException();
                            }
                        }
                    }
                }

                foreach (Customer cust in Customer.custList)
                {
                    if (Int32.Parse(custIdBox.Text) == cust.Id)
                    {
                        custExists = true;
                    }
                }
                if (!custExists)
                {
                    MessageBox.Show("There is no customer with that ID.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Appointment newAppt = new Appointment(Int32.Parse(apptIdBox.Text), Int32.Parse(custIdBox.Text), Int32.Parse(userIdBox.Text), titleBox.Text, descBox.Text, locationBox.Text, contactBox.Text, typeBox.Text, urlBox.Text, startTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), endTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text);

                Appointment.addToDb(newAppt);

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BusinessHoursException)
            {
                MessageBox.Show("Please choose a time between 9:00 AM and 5:00 PM", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ScheduleConflictException)
            {
                MessageBox.Show("Your chosen time conflicts with a previously scheduled appointment.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
﻿using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class ModifyAppointmentScreen : Form
    {
        public ModifyAppointmentScreen(DataGridViewRow appt)
        {
            InitializeComponent();
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currentTimeUTC = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Value = DateTime.Now;
            Appointment selectedAppt = (Appointment)appt.DataBoundItem;

            apptIdBox.Text = selectedAppt.Id.ToString();
            custIdBox.Text = selectedAppt.customerId.ToString();
            userIdBox.Text = selectedAppt.userId.ToString();
            titleBox.Text = selectedAppt.title;
            descBox.Text = selectedAppt.description;
            locationBox.Text = selectedAppt.location;
            contactBox.Text = selectedAppt.contact;
            typeBox.Text = selectedAppt.type;
            urlBox.Text = selectedAppt.url;
            startTimePicker.Value = DateTime.Parse(
                selectedAppt.start.TrimStart('\'').TrimEnd('\'')
            );
            endTimePicker.Value = DateTime.Parse(selectedAppt.end.TrimStart('\'').TrimEnd('\''));
            createDatePicker.Value = DateTime.Parse(selectedAppt.createDate);
            createdByBox.Text = selectedAppt.createdBy;
            lastUpdateByBox.Text = userContext.getUsername();
        }

        private void submitBtn_Click(object sender, System.EventArgs e)
        {
            DateTime startTime = startTimePicker.Value;
            DateTime endTime = endTimePicker.Value;

            try
            {
                if (!typeBox.Items.Contains(typeBox.Text))
                {
                    MessageBox.Show(
                        "For appointment type, please choose a value from the drop-down menu.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (startTime > endTime)
                {
                    MessageBox.Show(
                        "Start time must occur before end time.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                foreach (Appointment appt in Appointment.apptList)
                {
                    if (appt.Id == Int32.Parse(apptIdBox.Text))
                    {
                        continue;
                    }
                    else
                    {
                        if (
                            (
                                startTimePicker.Value < DateTime.Parse(appt.end)
                                && endTimePicker.Value > DateTime.Parse(appt.start)
                            )
                        )
                        {
                            if (
                                Int32.Parse(userIdBox.Text) == appt.userId
                                || Int32.Parse(custIdBox.Text) == appt.customerId
                            )
                            {
                                throw new ScheduleConflictException();
                            }
                        }
                    }
                }

                if ((startTime.Hour < 9 || endTime.Hour > 17))
                {
                    throw new BusinessHoursException();
                }
                else if (startTime.Hour > 17)
                {
                    throw new BusinessHoursException();
                }
                else if (endTime.Hour == 17 && (endTime.Minute > 0 || endTime.Second > 0))
                {
                    throw new BusinessHoursException();
                }

                Appointment newAppt = new Appointment(
                    Int32.Parse(apptIdBox.Text),
                    Int32.Parse(custIdBox.Text),
                    Int32.Parse(userIdBox.Text),
                    titleBox.Text,
                    descBox.Text,
                    locationBox.Text,
                    contactBox.Text,
                    typeBox.Text,
                    urlBox.Text,
                    startTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    endTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    createdByBox.Text,
                    lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    lastUpdateByBox.Text
                );

                Appointment.modifyDb(newAppt);

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "All fields must be filled out correctly before continuing.",
                    "Error adding appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (BusinessHoursException)
            {
                MessageBox.Show(
                    "Please choose a time between 9:00 AM and 5:00 PM",
                    "Error adding appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (ScheduleConflictException)
            {
                MessageBox.Show(
                    "Your chosen time conflicts with a previously scheduled appointment.",
                    "Error adding appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show(
                    "All fields must be filled out correctly before continuing.",
                    "Error adding appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

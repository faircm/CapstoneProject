using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C969Assessment
{
    public class Appointment : Record
    {
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string start { get; set; }
        public string end { get; set; }

        private static MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
            "SELECT * FROM appointment",
            DatabaseConnection.connection
        );

        public static List<Appointment> apptList;

        public Appointment() { }

        public Appointment(
            int appointmentId,
            int customerId,
            int userId,
            string title,
            string description,
            string location,
            string contact,
            string type,
            string url,
            string start,
            string end,
            string createDate,
            string createdBy,
            string lastUpdate,
            string lastUpdateBy
        )
        {
            this.Id = appointmentId;
            this.customerId = customerId;
            this.userId = userId;
            this.title = $"'{title}'";
            this.description = $"'{description}'";
            this.location = $"'{location}'";
            this.contact = $"'{contact}'";
            this.type = $"'{type}'";
            this.url = $"'{url}'";
            this.start = $"'{start}'";
            this.end = $"'{end}'";
            this.createDate = $"'{createDate}'";
            this.createdBy = $"'{createdBy}'";
            this.lastUpdate = $"'{lastUpdate}'";
            this.lastUpdateBy = $"'{lastUpdateBy}'";

            apptList.Add(this);
        }

        public static List<Appointment> getAppts()
        {
            List<Appointment> appointments = new List<Appointment>();
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.Id = reader.GetInt32("appointmentId");
                appointment.customerId = reader.GetInt32("customerId");
                appointment.userId = reader.GetInt32("userId");
                appointment.title = reader.GetString("title");
                appointment.description = reader.GetString("description");
                appointment.location = reader.GetString("location");
                appointment.contact = reader.GetString("contact");
                appointment.type = reader.GetString("type");
                appointment.url = reader.GetString("url");
                appointment.start = reader.GetDateTime("start").ToLocalTime().ToString();
                appointment.end = reader.GetDateTime("end").ToLocalTime().ToString();
                appointment.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                appointment.createdBy = reader.GetString("createdBy");
                int columnNum = reader.GetOrdinal("lastUpdate");
                object dataType = reader.GetValue(columnNum);
                string lastUpdateStr = reader.GetValue(columnNum).ToString();
                appointment.lastUpdate = DateTime.Parse(lastUpdateStr).ToLocalTime().ToString();
                appointment.lastUpdateBy = reader.GetString("lastUpdateBy");

                appointments.Add(appointment);
            }
            reader.Close();

            return appointments;
        }

        public static List<Appointment> getAppts(string searchStr)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                searchStr,
                DatabaseConnection.connection
            );

            List<Appointment> appointments = new List<Appointment>();

            if (searchStr.Length == 0)
            {
                return appointments;
            }
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.Id = reader.GetInt32("appointmentId");
                appointment.customerId = reader.GetInt32("customerId");
                appointment.userId = reader.GetInt32("userId");
                appointment.title = reader.GetString("title");
                appointment.description = reader.GetString("description");
                appointment.location = reader.GetString("location");
                appointment.contact = reader.GetString("contact");
                appointment.type = reader.GetString("type");
                appointment.url = reader.GetString("url");
                appointment.start = reader.GetDateTime("start").ToLocalTime().ToString();
                appointment.end = reader.GetDateTime("end").ToLocalTime().ToString();
                appointment.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                appointment.createdBy = reader.GetString("createdBy");
                int columnNum = reader.GetOrdinal("lastUpdate");
                object dataType = reader.GetValue(columnNum);
                string lastUpdateStr = reader.GetValue(columnNum).ToString();
                appointment.lastUpdate = DateTime.Parse(lastUpdateStr).ToLocalTime().ToString();
                appointment.lastUpdateBy = reader.GetString("lastUpdateBy");

                appointments.Add(appointment);
            }
            reader.Close();

            return appointments;
        }

        public static List<Appointment> getCurrentUserAppts(int userId)
        {
            List<Appointment> userAppts = new List<Appointment>();
            foreach (Appointment appt in Appointment.apptList)
            {
                if (appt.userId == userId)
                {
                    userAppts.Add(appt);
                }
            }
            return userAppts;
        }

        public static List<Appointment> getCustAppts(int custId)
        {
            List<Appointment> custAppts = new List<Appointment>();
            foreach (Appointment appt in Appointment.apptList)
            {
                if (appt.customerId == custId)
                {
                    custAppts.Add(appt);
                }
            }
            return custAppts;
        }

        public static void appointmentReminder()
        {
            foreach (Appointment appt in apptList)
            {
                if (appt.userId == userContext.getUserId())
                {
                    if (
                        (DateTime.Parse(appt.start) - DateTime.Now).TotalMinutes <= 15
                        && (DateTime.Parse(appt.start) - DateTime.Now).TotalMinutes > 0
                    )
                    {
                        MessageBox.Show(
                            "Upcoming apppointment",
                            $"Your next appointment begins at {DateTime.Parse(appt.start)}",
                            MessageBoxButtons.OK
                        );
                    }
                }
            }
        }

        public static List<Appointment> findUserApptByDate(
            int userId,
            DateTime date,
            string timeSpan
        )
        {
            List<Appointment> returnList = new List<Appointment>();

            foreach (Appointment appt in apptList)
            {
                if (timeSpan == "day")
                {
                    if (
                        (
                            DateTime.Parse(appt.start).DayOfYear == date.DayOfYear
                            || DateTime.Parse(appt.end).DayOfYear == date.DayOfYear
                        )
                        && DateTime.Parse(appt.start).Year == date.Year
                    )
                    {
                        returnList.Add(appt);
                    }
                }
                else
                {
                    if (
                        (
                            DateTime.Parse(appt.start).Month == date.Month
                            || DateTime.Parse(appt.end).Month == date.Month
                        )
                        && DateTime.Parse(appt.start).Year == date.Year
                    )
                    {
                        returnList.Add(appt);
                    }
                }
            }
            return returnList;
        }

        public static List<Appointment> findUserApptByDate(
            int userId,
            DateTime dateStart,
            DateTime dateEnd
        )
        {
            List<Appointment> returnList = new List<Appointment>();

            foreach (Appointment appt in apptList)
            {
                if (
                    DateTime.Parse(appt.start) >= dateStart && DateTime.Parse(appt.start) <= dateEnd
                )
                {
                    returnList.Add(appt);
                }
            }
            return returnList;
        }

        public static void addToDb(Appointment appointment)
        {
            MySqlCommand addCmd = new MySqlCommand(
                "INSERT INTO appointment(appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES("
                    + appointment.Id
                    + ","
                    + appointment.customerId
                    + ","
                    + appointment.userId
                    + ","
                    + appointment.title
                    + ","
                    + appointment.description
                    + ","
                    + appointment.location
                    + ","
                    + appointment.contact
                    + ","
                    + appointment.type
                    + ","
                    + appointment.url
                    + ","
                    + appointment.start
                    + ","
                    + appointment.end
                    + ","
                    + appointment.createDate
                    + ","
                    + appointment.createdBy
                    + ","
                    + appointment.lastUpdate
                    + ","
                    + appointment.lastUpdateBy
                    + ");",
                DatabaseConnection.connection
            );
            addCmd.ExecuteNonQuery();
            apptList = getAppts();
        }

        public static void modifyDb(Appointment appointment)
        {
            MySqlCommand updateCmd = new MySqlCommand(
                "UPDATE appointment SET customerId = "
                    + appointment.customerId
                    + ", "
                    + "userId = "
                    + appointment.userId
                    + ", "
                    + "title = "
                    + appointment.title
                    + ", "
                    + "description = "
                    + appointment.description
                    + ", "
                    + "location = "
                    + appointment.location
                    + ", "
                    + "contact = "
                    + appointment.contact
                    + ", "
                    + "type = "
                    + appointment.type
                    + ", "
                    + "url = "
                    + appointment.url
                    + ", "
                    + "start = "
                    + appointment.start
                    + ", "
                    + "end = "
                    + appointment.end
                    + ", "
                    + "lastUpdate = "
                    + appointment.lastUpdate
                    + ", "
                    + "lastUpdateBy = "
                    + appointment.lastUpdateBy
                    + "WHERE appointmentId = "
                    + appointment.Id
                    + ";",
                DatabaseConnection.connection
            );
            updateCmd.ExecuteNonQuery();

            apptList = getAppts();
        }

        public string toString()
        {
            return $"User: {this.userId}"
                + $",Customer: {this.customerId}"
                + $",Title: {this.title}"
                + $",Type: {this.type}"
                + $",Description: {this.description}"
                + $",Contact: {this.contact}"
                + $",Location: {this.location}"
                + $",URL: {this.url}"
                + $",Start Time: {this.start}"
                + $",End Time: {this.end}\n";
        }
    }
}

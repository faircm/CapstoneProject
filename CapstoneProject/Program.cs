using System;
using System.Windows.Forms;

namespace C969Assessment
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseConnection.openConnection();
            Application.Run(new LoginPage());
            DatabaseConnection.closeConnection();

            // LOGIN PAGE COMPLETE
            // LOCALIZATION COMPLETE
            // LOGFILE COMPLETE


            // Minimum data for input on customer creation should be Name, Address, Phone Number, City Name and Country Name. Country name/city name CANNOT be a drop down.
            // Appointments must link to a customer ID. Minimum input - Type, Customer, Scheduled Time and User ID. Consider putting user IDs in a combobox.
            // Calendar DOESN'T HAVE TO BE THE CLASSIC GRID, GRAPHICAL CALENDAR. NO. Just do a list of appointments, datagridview list. Implement views: ALL APPOINTMENTS, CURRENT WEEK APPOINTMENTS, CURRENT MONTH APPOINTMENTS
            // Provide ability to automatically adjust appt times based on user time zones and DST. When you put datetimes in your DB, make sure you convert them to UTC, and make sure that the time zone is set to default to client system. USE DATETIMES, NOT STRINGS,
            // Exceptions: Scheduling an appt outside of business hours, scheduling overlapping appts (on ONE user's schedule), entering nonexistent or invalid customer data (check for blank text, no need to do regex), entering an incorrect username/password. TWO METHODS TO CONTROL FOR EXCEPTIONS. Use if statements and try/catch blocks
            // Include 2 or more lambda expressions to improve efficiency, BUT JUSTIFY AND EXPLAIN WITH AN INLINE COMMENT
            // Alert user if there is an appointment within 15 minutes of that user's login. ONLY happens after a successful logins. Don't use the databases current time, use the system's current time. 
            // Display number of appt types by month; given a type and a month, how many appointments match? COUNT, NO LIST.
            // Allow users to select other users to display their appointments. NOT customers. 
            // One additional report of your choice (any number or list)
            // Recommended classes to use: MySqlConnection, MySqlCommand, MySqlDataAdapter, DataTable, @param to inject values // DateTime // FileStream // CultureInfo

            // Plan your GUI first - map it out. Make it user friendly
            // Plan your object model, think of using joins for your customer data
            // Organize your code so it's easy to navigate
        }
    }
}

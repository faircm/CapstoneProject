using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class SearchScreen : Form
    {
        //14 FEB 2023 created search form, controls generated based on where the search command is called from.
        private static string formType = "";
        public SearchScreen(Form form)
        {
            InitializeComponent();
            formType = form.Name;
            defineLabels(getSearchType());
        }
        private static string getSearchType()
        {
            switch (formType)
            {
                case "AddressScreen":
                    return "Address Search";
                case "AppointmentScreen":
                    return "Appointment Search";
                case "CustomerScreen":
                    return "Customer Search";
                default:
                    return "Search";
            }
        }

        // 15 FEB 2023, changes labels to match search type
        private void defineLabels(string searchType)
        {
            searchLabel.Text = searchType;
            if (searchType == "Address Search")
            {
                label2.Text = "Address";
                label3.Text = "City";
                label4.Text = "Phone Number";
                label5.Text = "Created By";
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
            else if(searchType == "Appointment Search")
            {
                label2.Text = "Title";
                label3.Text = "Participant";
                label4.Text = "Type";
                label5.Text = "Location";
                label6.Text = "Date";
                label7.Text = "Created By";
                label8.Visible = false;
                label9.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
            else if(searchType == "Customer Search")
            {
                label2.Text = "Name";
                label3.Text = "Is Active";
                label4.Text = "Address";
                label5.Text = "Created By";
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultsBox.DataSource = null;
        }
    }
}
